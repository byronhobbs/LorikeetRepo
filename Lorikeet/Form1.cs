using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraSplashScreen;
using Lorikeet.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Lorikeet
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private BarManager barManager;
        private int memberIDSelected = -1;
        private int staffID = -1;
        private int lastLogID = -1;
        private object _locker = 0;
        private bool _threadBroadcast = true;
        private Queue<string> broadCastQueue = new Queue<string>();

        private BackgroundWorker bw = new BackgroundWorker();

        public Form1(int staffID)
        {
            InitializeComponent();

            barManager = barManager1;
            barManager.ItemClick += new ItemClickEventHandler(barManager_ItemClick);

            radialMenu1 = new RadialMenu(barManager);
            radialMenu1.AddItems(GetRadialMenuItems(barManager));

            RefreshDataGrid();

            lastLogID = Logging.GetLastLogID();
            this.staffID = staffID;

            buttonRefresh.Enabled = false;

            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);

            if (bw.IsBusy != true)
            {
                bw.RunWorkerAsync();
            }
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            while (true)
            {
                if (worker != null && worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    System.Threading.Thread.Sleep(1000);
                    int getLogID = Logging.GetLastLogID();
                    if (getLogID != lastLogID)
                    {
                        lock (_locker)
                        {
                            List<Log> tempLogList = Logging.GetAllBroadcastLogsFromID(lastLogID);
                            lastLogID = getLogID;

                            foreach (var tll in tempLogList)
                            {
                                broadCastQueue.Enqueue(tll.DateTime + ": Staff Name - " + MiscStuff.GetStaffName(tll.StaffID) + ": " + tll.Message);
                                if (tll.RefreshCode >= 3)
                                {
                                    buttonRefresh.Invoke((MethodInvoker)delegate { buttonRefresh.Enabled = true; });
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread broadcastThread = new Thread(() =>
            {
                Thread.Sleep(2500);
                while (_threadBroadcast)
                {
                    lock (_locker)
                    {
                        if (broadCastQueue.Count != 0)
                        {
                            textBoxBroadcast.Invoke((MethodInvoker)delegate { textBoxBroadcast.Text = broadCastQueue.Dequeue(); });
                        }
                    }
                    Thread.Sleep(2500);
                }
            });

            broadcastThread.Start();

            var access = MiscStuff.GetAccessLevel(staffID);
            SetAccessLevels(access);
        }

        private void SetAccessLevels(int access)
        {
            if (access <= 8)
            {
                barButtonItemImportDatabase.Enabled = false;
                bbiImportSpreadsheet.Enabled = false;
            }
            if (access <= 6)
            {
                bbiUsers.Enabled = false;
                barButtonItemEditMedsDiagnosis.Enabled = false;
                barButtonItem3.Enabled = false;
                barButtonItemEditActivityNumbers.Enabled = false;
            }
        }

        BarItem[] GetRadialMenuItems(BarManager barManager)
        {
            BarItem btnNew = new BarButtonItem(barManager, "New Member");
            btnNew.ImageOptions.ImageUri.Uri = "New;Size16x16";

            BarItem btnEdit = new BarButtonItem(barManager, "Edit");
            btnEdit.ImageOptions.ImageUri.Uri = "Edit;Size16x16";

            return new BarItem[] { btnNew, btnEdit };
        }

        void barManager_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (e.Item.Caption.Equals("New Member"))
                {
                    radialMenu1.Collapse(true);

                    var form = new FormNewMemberWizard(staffID);
                    form.ShowDialog();

                    RefreshDataGrid();
                }
                else if (e.Item.Caption.Equals("Edit"))
                {
                    radialMenu1.Collapse(true);

                    if (gridControl1.FocusedView.ViewCaption.ToString().Equals(""))
                    {
                        if (memberIDSelected != -1)
                        {
                            var form = new FormEditMember(memberIDSelected, staffID);
                            form.ShowDialog();

                            this.memberTableAdapter.Fill(this.lorikeetAppDataSet.Member);
                        }
                    }

                    else if (gridControl1.FocusedView.ViewCaption.ToString().Equals("Contact"))
                    {
                        if (memberIDSelected != -1)
                        {
                            var form = new FormAddEditContacts(memberIDSelected, staffID);
                            form.ShowDialog();

                            this.contactTableAdapter.Fill(this.lorikeetAppDataSet.Contact);
                        }
                    }
                    else if (gridControl1.FocusedView.ViewCaption.ToString().Equals("Credits / Debits"))
                    {
                        if (memberIDSelected != -1)
                        {
                            var form = new FormAddEditDebitCredit(memberIDSelected, staffID);
                            form.ShowDialog();

                            this.debitSystemTableAdapter.Fill(this.lorikeetAppDataSet.DebitSystem);
                        }
                    }
                    else if (gridControl1.FocusedView.ViewCaption.ToString().Equals("Medication"))
                    {
                        if (memberIDSelected != -1)
                        {
                            var form = new FormAddEditMedication(memberIDSelected, staffID);
                            form.ShowDialog();

                            this.medicationTableAdapter.Fill(this.lorikeetAppDataSet.Medication);
                        }
                    }
                    else if (gridControl1.FocusedView.ViewCaption.ToString().Equals("Diagnosis"))
                    {
                        if (memberIDSelected != -1)
                        {
                            var form = new FormAddEditDiagnosis(memberIDSelected, staffID);
                            form.ShowDialog();

                            this.diagnosisTableAdapter.Fill(this.lorikeetAppDataSet.Diagnosis);
                        }
                    }
                    else if (gridControl1.FocusedView.ViewCaption.ToString().Equals("Notes"))
                    {
                        if (memberIDSelected != -1)
                        {
                            var form = new FormAddEditNotes(memberIDSelected, staffID);
                            form.ShowDialog();

                            this.noteTableAdapter.Fill(this.lorikeetAppDataSet.Note);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
            }
        }

        private void RefreshDataGrid()
        {
            try
            {
                this.memberTableAdapter.Fill(this.lorikeetAppDataSet.Member);
                this.diagnosisTableAdapter.Fill(this.lorikeetAppDataSet.Diagnosis);
                this.medicationTableAdapter.Fill(this.lorikeetAppDataSet.Medication);
                this.debitSystemTableAdapter.Fill(this.lorikeetAppDataSet.DebitSystem);
                this.contactTableAdapter.Fill(this.lorikeetAppDataSet.Contact);
                this.noteTableAdapter.Fill(this.lorikeetAppDataSet.Note);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonReportItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);

            var form = new FormReports();

            SplashScreenManager.CloseForm(false);

            form.ShowDialog();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);

            var form = new FormSchedule(staffID);

            SplashScreenManager.CloseForm(false);

            form.ShowDialog();

            RefreshDataGrid();
        }

        private void barButtonItemMember_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new FormNewMemberWizard(staffID);
            form.ShowDialog();

            RefreshDataGrid();
        }

        private void barButtonItemContact_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (memberIDSelected != -1)
            {
                var addContactForm = new FormAddEditContacts(memberIDSelected, staffID);
                addContactForm.ShowDialog();

                this.contactTableAdapter.Fill(this.lorikeetAppDataSet.Contact);
            }
        }

        private void barButtonItemDiagnosis_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (memberIDSelected != -1)
            {
                var form = new FormAddEditDiagnosis(memberIDSelected, staffID);
                form.ShowDialog();

                this.diagnosisTableAdapter.Fill(this.lorikeetAppDataSet.Diagnosis);
            }
        }

        private void barButtonItemMedication_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (memberIDSelected != -1)
            {
                var form = new FormAddEditMedication(memberIDSelected, staffID);
                form.ShowDialog();

                this.medicationTableAdapter.Fill(this.lorikeetAppDataSet.Medication);
            }
        }

        private void barButtonItemNote_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (memberIDSelected != -1)
            {
                var form = new FormAddEditNotes(memberIDSelected, staffID);
                form.ShowDialog();

                this.noteTableAdapter.Fill(this.lorikeetAppDataSet.Note);
            }
        }

        private void barButtonItemEditMedsDiagnosis_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new FormAddEditDeleteDiagnosisMedication(staffID);
            form.ShowDialog();

            RefreshDataGrid();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));
            if (hitInfo.HitTest == GridHitTest.RowCell)
            {
                memberIDSelected = int.Parse(view.GetRowCellDisplayText(hitInfo.RowHandle, colMemberID).ToString());
            }

            var form = new FormEditMember(memberIDSelected, staffID);
            form.ShowDialog();

            RefreshDataGrid();
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));
            if (hitInfo.HitTest == GridHitTest.RowCell)
            {
                memberIDSelected = int.Parse(view.GetRowCellDisplayText(hitInfo.RowHandle, colMemberIDContact).ToString());            }

            if (memberIDSelected != -1)
            {
                var addContactForm = new FormAddEditContacts(memberIDSelected, staffID);
                addContactForm.ShowDialog();

                this.contactTableAdapter.Fill(this.lorikeetAppDataSet.Contact);
            }
        }

        private void gridView3_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));
            if (hitInfo.HitTest == GridHitTest.RowCell)
            {
                memberIDSelected = int.Parse(view.GetRowCellDisplayText(hitInfo.RowHandle, colMemberIDDebitCredit).ToString());
            }

            if (memberIDSelected != -1)
            {
                var editDebitCreditForm = new FormAddEditDebitCredit(memberIDSelected, staffID);
                editDebitCreditForm.ShowDialog();

                this.debitSystemTableAdapter.Fill(this.lorikeetAppDataSet.DebitSystem);
            }
        }

        private void gridView4_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));
            if (hitInfo.HitTest == GridHitTest.RowCell)
            {
                memberIDSelected = int.Parse(view.GetRowCellDisplayText(hitInfo.RowHandle, colMemberIDMedication).ToString());
            }

            if (memberIDSelected != -1)
            {
                var form = new FormAddEditMedication(memberIDSelected, staffID);
                form.ShowDialog();

                this.medicationTableAdapter.Fill(this.lorikeetAppDataSet.Medication);
            }
        }

        private void gridView5_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));
            if (hitInfo.HitTest == GridHitTest.RowCell)
            {
                memberIDSelected = int.Parse(view.GetRowCellDisplayText(hitInfo.RowHandle, colMemberIDDiagnosis).ToString());
            }

            if (memberIDSelected != -1)
            {
                var form = new FormAddEditDiagnosis(memberIDSelected, staffID);
                form.ShowDialog();

                this.diagnosisTableAdapter.Fill(this.lorikeetAppDataSet.Diagnosis);
            }
        }

        private void gridView6_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));
            if (hitInfo.HitTest == GridHitTest.RowCell)
            {
                memberIDSelected = int.Parse(view.GetRowCellDisplayText(hitInfo.RowHandle, colMemberIDNotes).ToString());
            }

            if (memberIDSelected != -1)
            {
                var form = new FormAddEditNotes(memberIDSelected, staffID);
                form.ShowDialog();

                this.noteTableAdapter.Fill(this.lorikeetAppDataSet.Note);
            }
        }

        private void gridView1_MouseDown(object sender, MouseEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));
            if (hitInfo.HitTest == GridHitTest.RowCell)
            {
                memberIDSelected = int.Parse(view.GetRowCellDisplayText(hitInfo.RowHandle, colMemberIDContact).ToString());
            }
        }

        private void gridView2_MouseDown(object sender, MouseEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));
            if (hitInfo.HitTest == GridHitTest.RowCell)
            {
                memberIDSelected = int.Parse(view.GetRowCellDisplayText(hitInfo.RowHandle, colMemberIDContact).ToString());
            }
        }

        private void gridView3_MouseDown(object sender, MouseEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));
            if (hitInfo.HitTest == GridHitTest.RowCell)
            {
                memberIDSelected = int.Parse(view.GetRowCellDisplayText(hitInfo.RowHandle, colMemberIDDebitCredit).ToString());
            }
        }

        private void gridView4_MouseDown(object sender, MouseEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));
            if (hitInfo.HitTest == GridHitTest.RowCell)
            {
                memberIDSelected = int.Parse(view.GetRowCellDisplayText(hitInfo.RowHandle, colMemberIDMedication).ToString());
            }
        }

        private void gridView5_MouseDown(object sender, MouseEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));
            if (hitInfo.HitTest == GridHitTest.RowCell)
            {
                memberIDSelected = int.Parse(view.GetRowCellDisplayText(hitInfo.RowHandle, colMemberIDDiagnosis).ToString());
            }
        }

        private void gridView6_MouseDown(object sender, MouseEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));
            if (hitInfo.HitTest == GridHitTest.RowCell)
            {
                memberIDSelected = int.Parse(view.GetRowCellDisplayText(hitInfo.RowHandle, colMemberIDNotes).ToString());
            }
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new FormEditAttendanceNumbers(staffID);
            form.ShowDialog();
        }

        private void barButtonItemDebitCredit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (memberIDSelected != -1)
            {
                var addContactForm = new FormAddEditDebitCredit(memberIDSelected, staffID);
                addContactForm.ShowDialog();

                this.debitSystemTableAdapter.Fill(this.lorikeetAppDataSet.DebitSystem);
            } 
        }

        private void Form1_Resize(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _threadBroadcast = false;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid();
            buttonRefresh.Enabled = false;
        }

        private void barButtonItemImportDatabase_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new FormImportDataFile();
            form.ShowDialog();

            RefreshDataGrid();
        }

        private void gridView1_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                bool archived = (bool)View.GetRowCellValue(e.RowHandle, View.Columns["Archived"]);
                bool agency = (bool)View.GetRowCellValue(e.RowHandle, View.Columns["Agency"]);

                if (agency)
                {
                    e.Appearance.BackColor = Color.FromArgb(150, Color.LightGray);
                    e.Appearance.BackColor2 = Color.White;
                }
                if (archived)
                {
                    e.Appearance.BackColor = Color.FromArgb(150, Color.Black);
                    e.Appearance.BackColor2 = Color.White;
                }
            }
        }

        private void gridView3_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            GridView View = sender as GridView;

            if (e.Column.FieldName != "Credit" && e.Column.FieldName != "Debit" && e.Column.FieldName != "RunningTotal") return;
            if (e.Column.FieldName == "Credit")
            {
                double credits = Convert.ToDouble(View.GetRowCellValue(e.RowHandle, View.Columns["Credit"]));
                if (credits == 0)
                {
                    e.Appearance.BackColor = Color.White;
                    e.Appearance.BackColor2 = Color.White;
                }
                else
                {
                    e.Appearance.BackColor = Color.White;
                    e.Appearance.BackColor2 = Color.FromArgb(150, Color.Green);
                }
            }
            else if (e.Column.FieldName == "Debit")
            {
                double debits = Convert.ToDouble(View.GetRowCellValue(e.RowHandle, View.Columns["Debit"]));
                if (debits == 0)
                {
                    e.Appearance.BackColor = Color.White;
                    e.Appearance.BackColor2 = Color.White;
                }
                else
                {
                    e.Appearance.BackColor2 = Color.White;
                    e.Appearance.BackColor = Color.FromArgb(150, Color.Red);
                }
            }
            else if (e.Column.FieldName == "RunningTotal")
            {
                double runTotal = Convert.ToDouble(View.GetRowCellValue(e.RowHandle, View.Columns["RunningTotal"]));
                if (runTotal == 0)
                {
                    e.Appearance.BackColor = Color.White;
                    e.Appearance.BackColor2 = Color.White;
                }
                else if (runTotal > 0)
                {
                    e.Appearance.BackColor = Color.White;
                    e.Appearance.BackColor2 = Color.FromArgb(150, Color.Green);
                }
                else if (runTotal < 0)
                {
                    e.Appearance.BackColor2 = Color.White;
                    e.Appearance.BackColor = Color.FromArgb(150, Color.Red);
                }
            }
        }

        private void gridControl1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            if (radialMenu1 == null) return;
            Point pt = this.Location;
            pt.Offset(this.Width / 2, this.Height / 2);
            radialMenu1.AutoExpand = true;
            radialMenu1.ShowPopup(pt);
        }

        private void barButtonItemEditActivityNumbers_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new FormEditAppointmentNumbers(staffID);
            form.ShowDialog();
        }

        private void bbiImportSpreadsheet_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new FormImportActivities();
            form.ShowDialog();
        }

        private void bbiDocuments_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            var form = new FormMDIDocumentViewer(staffID);

            SplashScreenManager.CloseForm();
            form.ShowDialog(this);
            form = null;
            System.GC.Collect(3);
            System.GC.WaitForPendingFinalizers();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void bbiWeather_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new FormShowWeather();
            form.ShowDialog();
        }

        private void gridControl1_Load(object sender, EventArgs e)
        {

        }

        private void bbiUsers_ItemClick(object sender, ItemClickEventArgs e)
        {
            var formUsers = new FormAddEditLogin(staffID);
            formUsers.ShowDialog();
        }

        private void gridControl1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
