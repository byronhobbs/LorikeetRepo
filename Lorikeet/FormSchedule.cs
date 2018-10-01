using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Drawing;
using Lorikeet.Data;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lorikeet
{
    public partial class FormSchedule : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private DevExpress.XtraScheduler.Appointment copiedAppointment = null;
        private BarManager barManager;
        private DateTime selectedDate;
        private bool dateSelected = false;
        private int staffID = -1;

        private BackgroundWorker bw = new BackgroundWorker();

        public FormSchedule(int staffID)
        {
            InitializeComponent();
            UpdateListBox();

            labelControl1.Text = "Nothing Selected";
            labelControl2.Text = "";

            this.staffID = staffID;

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
                    UpdateListBox();
                }
            }
        }

        private void FormSchedule_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lorikeetAppDataSet.Labels' table. You can move, or remove it, as needed.
            this.labelsTableAdapter.Fill(this.lorikeetAppDataSet.Labels);
            this.resourcesTableAdapter.Fill(this.lorikeetAppDataSet.Resources);
            this.appointmentsTableAdapter.Fill(this.lorikeetAppDataSet.Appointments);

            schedulerControl1.Start = DateTime.Today;
            schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Month;
            schedulerControl1.DayView.TopRowTime = new TimeSpan(10, 0, 0);
            schedulerControl1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource;
            schedulerControl1.DayView.ResourcesPerPage = 1;
            schedulerControl1.DayView.TimeIndicatorDisplayOptions.ShowOverAppointment = false;
            schedulerControl1.Start = DateTime.Now.Date;
            schedulerControl1.DateNavigationBar.Visible = false;
            schedulerControl1.ActiveView.NavigationButtonVisibility = NavigationButtonVisibility.Never;
            schedulerControl1.OptionsCustomization.AllowDisplayAppointmentFlyout = true;

            this.schedulerStorage1.AppointmentsChanged += OnAppointmentChangedInsertedDeleted;
            this.schedulerStorage1.AppointmentsInserted += OnAppointmentChangedInsertedDeleted;
            this.schedulerStorage1.AppointmentsDeleted += OnAppointmentChangedInsertedDeleted;

            InitializeLabels();

            barManager = barManager1;
            barManager.ItemClick += new ItemClickEventHandler(barManager_ItemClick);

            radialMenu1 = new RadialMenu(barManager);
            radialMenu1.AddItems(GetRadialMenuItems(barManager));
        }

        BarItem[] GetRadialMenuItems(BarManager barManager)
        {
            BarItem btnNew = new BarButtonItem(barManager, "New");
            btnNew.ImageOptions.ImageUri.Uri = "New;Size16x16";

            BarSubItem btnMenuEditors = new BarSubItem(barManager, "Edit");
            BarCheckItem btnEditAppointment = new BarCheckItem(barManager, false);
            btnEditAppointment.Caption = "Appointment";
            btnEditAppointment.ImageOptions.ImageUri.Uri = "Edit;Size16x16";

            BarCheckItem btnEditMembers = new BarCheckItem(barManager, true);
            btnEditMembers.Caption = "Members";
            btnEditMembers.ImageOptions.ImageUri.Uri = "Edit;Size16x16";

            BarCheckItem btnEditAttendance = new BarCheckItem(barManager, true);
            btnEditAttendance.Caption = "Attendance";
            btnEditAttendance.ImageOptions.ImageUri.Uri = "Edit;Size16x16";

            BarItem[] subMenuItems = new BarItem[] { btnEditAttendance, btnEditAppointment, btnEditMembers };
            btnMenuEditors.AddItems(subMenuItems);

            BarItem btnCopy = new BarButtonItem(barManager, "Copy");
            btnCopy.ImageOptions.ImageUri.Uri = "Copy;Size16x16";

            BarItem btnDelete = new BarButtonItem(barManager, "Delete");
            btnDelete.ImageOptions.ImageUri.Uri = "Delete;Size16x16";

            BarItem btnPaste = new BarButtonItem(barManager, "Paste");
            btnPaste.ImageOptions.ImageUri.Uri = "Paste;Size16x16";

            return new BarItem[] { btnNew, btnMenuEditors, btnCopy, btnPaste, btnDelete };
        }

        void barManager_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (e.Item.Caption.Equals("Copy"))
                {
                    radialMenu1.Collapse(true);

                    DevExpress.XtraScheduler.Appointment apt = schedulerControl1.SelectedAppointments[0];
                    copiedAppointment = apt.Copy();
                }
                else if (e.Item.Caption.Equals("Paste"))
                {
                    if (copiedAppointment != null && dateSelected)
                    {
                        radialMenu1.Collapse(true);

                        copiedAppointment.Start = selectedDate;
                        schedulerStorage1.Appointments.Add(copiedAppointment);
                    }
                }
                else if (e.Item.Caption.Equals("Delete"))
                {
                    radialMenu1.Collapse(true);
                    var apptTemp = this.schedulerControl1.SelectedAppointments[0];

                    
                    using (var context = new LorikeetAppEntities())
                    {
                        var apptID = (from a in context.Appointments
                                        where a.Subject == apptTemp.Subject && DbFunctions.TruncateTime(a.StartDate) == DbFunctions.TruncateTime(apptTemp.Start)
                                        select a).DefaultIfEmpty().First();


                        var appointmentsToRemove = (from atr in context.AppointmentMembers
                                                    where atr.AppointmentsID == apptID.UniqueID
                                                    select atr).ToList();

                        foreach (var a in appointmentsToRemove)
                        {
                            context.AppointmentMembers.Remove(a);
                            context.SaveChanges();
                        }

                        var notesToRemove = (from ntr in context.Notes
                                                where DbFunctions.TruncateTime(ntr.Date) == DbFunctions.TruncateTime(apptID.StartDate) && ntr.Notes == "Member attended " + apptTemp.Subject + " group"
                                                select ntr).ToList();

                        foreach (var ntr in notesToRemove)
                        {
                            context.Notes.Remove(ntr);
                            context.SaveChanges();
                        }
                    }

                    schedulerStorage1.Appointments.Remove(apptTemp);
                    appointmentsTableAdapter.Update(lorikeetAppDataSet);
                    lorikeetAppDataSet.AcceptChanges();
                }
                else if (e.Item.Caption.Equals("New"))
                {
                    radialMenu1.Collapse(true);
                    DevExpress.XtraScheduler.Appointment appointmentNew = schedulerStorage1.CreateAppointment(AppointmentType.Normal);
                    appointmentNew.Start = schedulerControl1.SelectedInterval.Start;
                    appointmentNew.End = schedulerControl1.SelectedInterval.End;

                    var form = new OutlookAppointmentForm(schedulerControl1, appointmentNew, false);
                    form.ShowDialog(this);
                }
                else if (e.Item.Caption.Equals("Appointment"))
                {
                    radialMenu1.Collapse(true);
                    DevExpress.XtraScheduler.Appointment apt = schedulerControl1.SelectedAppointments[0];

                    var form = new OutlookAppointmentForm(schedulerControl1, apt, false);
                    form.ShowDialog(this);
                }
                else if (e.Item.Caption.Equals("Members"))
                {
                    radialMenu1.Collapse(true);

                    DevExpress.XtraScheduler.Appointment apt = schedulerControl1.SelectedAppointments[0];

                    var form = new FormEditAppointmentMembers(apt, staffID);
                    form.ShowDialog(this);
                }
                else if (e.Item.Caption.Equals("Attendance"))
                {
                    if (schedulerControl1.SelectedAppointments.Count < 1)
                    {
                        DateTime date = schedulerControl1.SelectedInterval.Start;
                        radialMenu1.Collapse(true);

                        var form = new FormEditAttendance(date, staffID);
                        form.ShowDialog(this);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
            }
        }

        private void InitializeLabels()
        {
            try
            {
                this.labelsTableAdapter.Fill(this.lorikeetAppDataSet.Labels);

                DataTable labels = this.lorikeetAppDataSet.Labels;

                if (labels.Rows.Count == 0)
                {
                    return;
                }

                schedulerControl1.Storage.Appointments.Labels.Clear();

                schedulerControl1.Storage.Appointments.Labels.BeginUpdate();
                for (int i = 0; i < labels.Rows.Count; i++)
                {
                    Color color = Color.FromArgb(Int32.Parse(labels.Rows[i].ItemArray[1].ToString()));
                    string displayName = labels.Rows[i].ItemArray[2].ToString();
                    string menuCaption = labels.Rows[i].ItemArray[3].ToString();
                    AppointmentLabel aptLabel = schedulerControl1.Storage.Appointments.Labels.CreateNewLabel(labels.Rows[i].ItemArray[0], displayName, menuCaption, color);
                    schedulerControl1.Storage.Appointments.Labels.Add(aptLabel);
                }

                schedulerControl1.Storage.Appointments.Labels.EndUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
            }
        }

        private void OnAppointmentChangedInsertedDeleted(object sender, PersistentObjectsEventArgs e)
        {
            appointmentsTableAdapter.Update(lorikeetAppDataSet);
            lorikeetAppDataSet.AcceptChanges();
        }

        private void schedulerControl1_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new FormEditActivities();
            form.ShowDialog(this);

            InitializeLabels();
        }

        private void schedulerControl1_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            e.Menu.Items.Clear();

            if (radialMenu1 == null) return;
            Point pt = this.Location;
            pt.Offset(this.Width / 2, this.Height / 2);
            radialMenu1.AutoExpand = true;
            radialMenu1.ShowPopup(pt);
        }

        private void schedulerControl1_SelectionChanged(object sender, EventArgs e)
        {
            TimeInterval visibleIntervals = (sender as DevExpress.XtraScheduler.SchedulerControl).SelectedInterval;
            selectedDate = visibleIntervals.Start;
            dateSelected = true;
        }

        private void schedulerControl1_Click(object sender, EventArgs e)
        {
            TimeInterval visibleIntervals = (sender as DevExpress.XtraScheduler.SchedulerControl).SelectedInterval;
            selectedDate = visibleIntervals.Start;
            dateSelected = true;
        }

        private void schedulerControl1_CustomizeAppointmentFlyout(object sender, CustomizeAppointmentFlyoutEventArgs e)
        {
            e.ShowSubject = true;
            e.Subject = String.Format("{0}", e.Subject);
            e.SubjectAppearance.Font = new Font("Segoe UI", 10f);
            e.ShowReminder = false;
            e.ShowLocation = false;
            e.ShowEndDate = false;
            e.ShowStartDate = true;
            e.ShowStatus = true;
            e.Appearance.BackColor = Color.Gray;

            var appointEvnt = e.Appointment as DevExpress.XtraScheduler.Appointment;
        }

        private void schedulerControl1_AppointmentFlyoutShowing(object sender, AppointmentFlyoutShowingEventArgs e)
        {

        }

        enum Selection
        {
            Appointment,
            Date,
            Nothing
        };

        private DateTime dateSel = DateTime.Now;
        private DevExpress.XtraScheduler.Appointment apptSelected;
        Selection whatsSelected = Selection.Nothing;

        private void schedulerControl1_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                Point pos = new Point(e.X, e.Y);
                SchedulerViewInfoBase viewInfo = schedulerControl1.ActiveView.ViewInfo;
                SchedulerHitInfo hitInfo = viewInfo.CalcHitInfo(pos, false);

                if (hitInfo.HitTest == SchedulerHitTest.AppointmentContent)
                {
                    apptSelected = ((AppointmentViewInfo)hitInfo.ViewInfo).Appointment;
                    whatsSelected = Selection.Appointment;
                }
                else if (schedulerControl1.ActiveView.Type == SchedulerViewType.Month && hitInfo.HitTest == SchedulerHitTest.Cell)
                {
                    int diff = pos.Y - ((SelectableIntervalViewInfo)hitInfo.ViewInfo).Bounds.Y;
                    long ticksPerPixel = ((SelectableIntervalViewInfo)hitInfo.ViewInfo).Interval.Duration.Ticks /
                        ((SelectableIntervalViewInfo)hitInfo.ViewInfo).Bounds.Height;
                    long ticksCount = (long)ticksPerPixel * diff;
                    dateSel = ((SelectableIntervalViewInfo)hitInfo.ViewInfo).Interval.Start.AddTicks(ticksCount);
                    whatsSelected = Selection.Date;
                }
                else if (hitInfo.HitTest == SchedulerHitTest.None)
                {
                    whatsSelected = Selection.Nothing;
                }
                else whatsSelected = Selection.Nothing;
            }
            catch (Exception ex)
            {
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
            }
        }

        private void UpdateListBox()
        {
            try
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate
                    {

                        using (var context = new LorikeetAppEntities())
                        {
                            if (whatsSelected == Selection.Nothing)
                            {
                                labelControl1.Text = "Nothing Selected";
                                labelControl2.Text = "";
                                listBoxControl1.Items.Clear();
                            }
                            else if (whatsSelected == Selection.Appointment)
                            {
                                var subject = apptSelected.Subject;
                                var startDate = apptSelected.Start;


                                Data.Appointment apptID = (from a in context.Appointments
                                                                    where a.Subject == subject && startDate == DbFunctions.TruncateTime(a.StartDate)
                                                                    select a).FirstOrDefault();

                                var id = apptID.UniqueID;

                                var membersInList = (from m in context.AppointmentMembers
                                                     join r in context.Members on m.MemberID equals r.MemberID
                                                     where m.AppointmentsID == id
                                                     select r).ToList();

                                labelControl1.Text = "Appointment: " + apptSelected.Subject;
                                labelControl2.Text = "Date: " + apptSelected.Start.ToLongDateString();

                                listBoxControl1.Items.Clear();

                                foreach (var mil in membersInList)
                                {
                                    listBoxControl1.Items.Add(mil.FirstName + " " + mil.Surname);
                                }
                            }
                            else if (whatsSelected == Selection.Date)
                            {
                                var startDate = dateSel;

                                var membersInList = (from a in context.Attendances
                                                     join m in context.Members on a.MemberID equals m.MemberID
                                                     where DbFunctions.TruncateTime(a.Date) == DbFunctions.TruncateTime(startDate)
                                                     select m).ToList();

                                labelControl1.Text = "Attendance - Count: " + membersInList.Count;
                                labelControl2.Text = "Date: " + dateSel.ToLongDateString();

                                listBoxControl1.Items.Clear();

                                foreach (var mil in membersInList)
                                {
                                    listBoxControl1.Items.Add(mil.FirstName + " " + mil.Surname);
                                }
                            }
                        }
                    }));
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            InitializeLabels();
        }

        private void schedulerControl1_EditAppointmentFormShowing_1(object sender, AppointmentFormEventArgs e)
        {
            try
            { 
                DevExpress.XtraScheduler.SchedulerControl scheduler = ((DevExpress.XtraScheduler.SchedulerControl)(sender));
                var form = new OutlookAppointmentForm(scheduler, e.Appointment, e.OpenRecurrenceForm);
                e.DialogResult = form.ShowDialog();
                e.Handled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
            }
        }
    }
}