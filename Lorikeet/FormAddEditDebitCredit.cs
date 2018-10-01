using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraBars;
using Lorikeet.Data;

namespace Lorikeet
{
    public partial class FormAddEditDebitCredit : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private int memberID = -1;
        private int staffID = -1;
        private int debitIDSelected = -1;
        private int rowSelected = -1;
        private bool fixable = false;
        private bool debitSel = false;
        private PopupMenu menu = null;

        public FormAddEditDebitCredit(int memberID, int staffID)
        {
            InitializeComponent();

            this.memberID = memberID;
            this.staffID = staffID;

            bbiFixMistake.Enabled = false;
            SetupPopupMenu();

            this.debitSystemTableAdapter.FillByMemberID(this.lorikeetAppDataSet.DebitSystem, memberID);
        }

        private void SetupPopupMenu()
        {
            barManager1.ForceInitialize();

            menu = new PopupMenu();
            menu.Manager = barManager1;
            barManager1.Images = imageCollection1;
            BarButtonItem itemInsertAbove = new BarButtonItem(barManager1, "Insert Row Above", 0);
            BarButtonItem itemInsertBelow = new BarButtonItem(barManager1, "Insert Row Below", 1);
            BarButtonItem itemDeleteRow = new BarButtonItem(barManager1, "Delete Row", 2);
            BarButtonItem itemFixMistake = new BarButtonItem(barManager1, "Fix Mistake", 3);
            menu.AddItems(new BarItem[] { itemInsertAbove, itemInsertBelow, itemDeleteRow, itemFixMistake });
            itemFixMistake.Links[0].BeginGroup = true;

            barManager1.ItemClick += BarManager1_ItemClick;
        }

        private void BarManager1_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (debitIDSelected != -1)
            {
                try
                {
                    if(e.Item.Caption.Equals("Insert Row Above"))
                    {
                        using (var context = new LorikeetAppEntities())
                        {
                            var checkDateTime = (from c in context.DebitSystems
                                                    where c.DebitID == debitIDSelected
                                                    select c).FirstOrDefault();

                            if (checkDateTime != null)
                            {
                                DateTime date = checkDateTime.Date.AddSeconds(-1);

                                var addDebitCreditRow = new DebitSystem();
                                addDebitCreditRow.Credit = 0;
                                addDebitCreditRow.Date = date;
                                addDebitCreditRow.Debit = 0;
                                addDebitCreditRow.Details = "";
                                addDebitCreditRow.MemberID = this.memberID;
                                addDebitCreditRow.RunningTotal = 0;
                                addDebitCreditRow.StaffID = this.staffID;

                                context.DebitSystems.Add(addDebitCreditRow);
                                context.SaveChanges();

                                UpdateRunningTotal();
                            }
                        }
                    }
                    else if (e.Item.Caption.Equals("Insert Row Below"))
                    {
                        using (var context = new LorikeetAppEntities())
                        {
                            var checkDateTime = (from c in context.DebitSystems
                                                 where c.DebitID == debitIDSelected
                                                 select c).FirstOrDefault();

                            if (checkDateTime != null)
                            {
                                DateTime date = checkDateTime.Date.AddSeconds(1);

                                var addDebitCreditRow = new DebitSystem();
                                addDebitCreditRow.Credit = 0;
                                addDebitCreditRow.Date = date;
                                addDebitCreditRow.Debit = 0;
                                addDebitCreditRow.Details = "";
                                addDebitCreditRow.MemberID = this.memberID;
                                addDebitCreditRow.RunningTotal = 0;
                                addDebitCreditRow.StaffID = this.staffID;

                                context.DebitSystems.Add(addDebitCreditRow);
                                context.SaveChanges();

                                UpdateRunningTotal();
                            }
                        }
                    }
                    else if (e.Item.Caption.Equals("Delete Row"))
                    {
                        DialogResult dr = new DialogResult();
                        dr = MessageBox.Show("Are you sure you want to remove row?", "Warning", MessageBoxButtons.YesNo);
                        if (dr == DialogResult.Yes)
                        {
                            using (var context = new LorikeetAppEntities())
                            {
                                var debitCreditToRemove = (from d in context.DebitSystems
                                                           where d.DebitID == debitIDSelected
                                                           select d).FirstOrDefault();

                                if (debitCreditToRemove != null)
                                {
                                    context.DebitSystems.Remove(debitCreditToRemove);
                                    context.SaveChanges();

                                    UpdateRunningTotal();                    
                                }
                            }
                        }
                    }
                    else if (e.Item.Caption.Equals("Fix Mistake"))
                    {
                        if (fixable)
                            FixMistake();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(MiscStuff.GetAllMessages(ex));
                }
            }
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void FormAddEditDebitCredit_Load(object sender, EventArgs e)
        {
            
        }

        private void textBoxDebit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
                e.Handled = true;
        }

        private void textBoxCredit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
                e.Handled = true;
        }

        private void textBoxDebit_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDebit.Text == "")
            {
                textBoxCredit.Enabled = true;
            }
            else
            {
                textBoxCredit.Enabled = false;
            }
        }

        private void textBoxCredit_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCredit.Text == "")
            {
                textBoxDebit.Enabled = true;
            }
            else
            {
                textBoxDebit.Enabled = false;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new LorikeetAppEntities())
                {
                    decimal number;

                    if (textBoxDebit.Text == "" && decimal.TryParse(textBoxCredit.Text, out number))
                    {
                        var creditToAdd = new DebitSystem();
                        creditToAdd.StaffID = this.staffID;
                        creditToAdd.MemberID = this.memberID;
                        creditToAdd.Credit = number;
                        creditToAdd.Debit = 0;
                        creditToAdd.Details = textBoxDetails.Text;
                        creditToAdd.Date = DateTime.Now;

                        decimal? runTotal = 0m;

                        var runningTotal = (from dc in context.DebitSystems
                                            where dc.MemberID == this.memberID
                                            select dc).ToList();

                        if (runningTotal.Any())
                        {

                            runTotal = runningTotal.Last().RunningTotal + number;
                        }
                        else
                        {
                            runTotal = number;
                        }

                        creditToAdd.RunningTotal = runTotal;

                        context.DebitSystems.Add(creditToAdd);
                        context.SaveChanges();

                        Logging.AddLogEntry(staffID, Logging.ErrorCodes.Broadcast, Logging.RefreshCodes.DebitCredit, "Credit for member - " + MiscStuff.GetMemberName(memberID) + " of $" + number + " Added", false);
                    }
                    else if (textBoxCredit.Text == "" && decimal.TryParse(textBoxDebit.Text, out number))
                    {
                        var debitToAdd = new DebitSystem();
                        debitToAdd.StaffID = this.staffID;
                        debitToAdd.MemberID = this.memberID;
                        debitToAdd.Credit = 0;
                        debitToAdd.Debit = number;
                        debitToAdd.Details = textBoxDetails.Text;
                        debitToAdd.Date = DateTime.Now;

                        decimal? runTotal = 0m;

                        var runningTotal = (from dc in context.DebitSystems
                                            where dc.MemberID == this.memberID
                                            select dc).ToList();

                        if (runningTotal.Any())
                        {
                            runTotal = runningTotal.Last().RunningTotal - number; 
                        }
                        else
                        {
                            runTotal = 0 - number;
                        }

                        debitToAdd.RunningTotal = runTotal;

                        context.DebitSystems.Add(debitToAdd);
                        context.SaveChanges();

                        Logging.AddLogEntry(staffID, Logging.ErrorCodes.Broadcast, Logging.RefreshCodes.DebitCredit, "Debit for member - " + MiscStuff.GetMemberName(memberID) + " of $" + number + " Added", false);
                    }
                }
            }
            catch (Exception ex)
            {
                Logging.AddLogEntry(staffID, Logging.ErrorCodes.Error, Logging.RefreshCodes.None, "Debit / Credit not added - " + ex.Message, false);
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
            }

            textBoxCredit.Text = "";
            textBoxDebit.Text = "";
            textBoxDetails.Text = "";

            this.debitSystemTableAdapter.FillByMemberID(this.lorikeetAppDataSet.DebitSystem, memberID);
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
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

        private void bbiFixMistake_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FixMistake();
        }

        private void FixMistake()
        {
            DialogResult dr = new DialogResult();

            if (debitIDSelected != -1)
            {
                FormInput form = null;

                if (debitSel)
                {
                    form = new FormInput("Enter Debit Amount to Change", "OK", true);
                    dr = form.ShowDialog();
                }
                else
                {
                    form = new FormInput("Enter Credit Amount to Change", "OK", true);
                    dr = form.ShowDialog();
                }

                if (dr == DialogResult.OK)
                {
                    try
                    {
                        using (var context = new LorikeetAppEntities())
                        {
                            var debitcreditToUpdate = (from d in context.DebitSystems
                                                       where d.DebitID == debitIDSelected
                                                       select d).FirstOrDefault();

                            if (debitcreditToUpdate != null)
                            {
                                decimal debitCredit;
                                if (decimal.TryParse(form.inputText, out debitCredit))
                                {
                                    if (debitSel)
                                    {
                                        debitcreditToUpdate.Debit = debitCredit;
                                        debitcreditToUpdate.Credit = 0;
                                    }
                                    else
                                    {
                                        debitcreditToUpdate.Credit = debitCredit;
                                        debitcreditToUpdate.Debit = 0;
                                    }
                                    context.SaveChanges();
                                    UpdateRunningTotal();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(MiscStuff.GetAllMessages(ex));
                    }
                    this.debitSystemTableAdapter.FillByMemberID(this.lorikeetAppDataSet.DebitSystem, memberID);
                }
            }
        }

        private void UpdateRunningTotal()
        {
            try
            {
                using (var context = new LorikeetAppEntities())
                {
                    if (memberID != -1)
                    {
                        var changeRunningTotal = (from d in context.DebitSystems
                                                   where d.MemberID == memberID
                                                   orderby d.Date
                                                   select d).ToList();
                        if (changeRunningTotal.Count > 0)
                        {
                            decimal? runningTotal = 0;
                            foreach (var change in changeRunningTotal)
                            {
                                if (change.Debit > 0)
                                {
                                    runningTotal = runningTotal - change.Debit;
                                    change.RunningTotal = runningTotal;
                                }
                                else
                                {
                                    runningTotal = runningTotal + change.Credit;
                                    change.RunningTotal = runningTotal;
                                }
                                context.SaveChanges();
                            }
                        }
                        this.debitSystemTableAdapter.FillByMemberID(this.lorikeetAppDataSet.DebitSystem, memberID);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            
        }

        private void gridView1_MouseUp(object sender, MouseEventArgs e)
        {
            GridView view = (GridView)sender;
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                try
                {
                    GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(MousePosition));
                    if (hitInfo.HitTest == GridHitTest.RowCell)
                    {
                        debitIDSelected = int.Parse(view.GetRowCellDisplayText(hitInfo.RowHandle, colDebitID).ToString());
                        rowSelected = view.GetSelectedRows()[0];
                    }

                    var columnName = view.FocusedColumn;
                    if (columnName.GetCaption().Equals("Credit"))
                    {
                        fixable = true;
                        bbiFixMistake.Enabled = true;
                        debitSel = false;
                    }
                    else if (columnName.GetCaption().Equals("Debit"))
                    {
                        fixable = true;
                        bbiFixMistake.Enabled = true;
                        debitSel = true;
                    }
                    else
                    {
                        fixable = false;
                        bbiFixMistake.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(MiscStuff.GetAllMessages(ex));
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                
                rowSelected = view.GetSelectedRows()[0];
                menu.ShowPopup(Control.MousePosition);
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var view = (GridView)sender;

            GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(MousePosition));
            if (hitInfo.HitTest == GridHitTest.RowCell)
            {
                debitIDSelected = int.Parse(view.GetRowCellDisplayText(hitInfo.RowHandle, colDebitID).ToString());
                rowSelected = view.GetSelectedRows()[0];
            }

            var columnName = view.FocusedColumn;
            if (columnName.GetCaption().Equals("Details"))
            {
                DialogResult dr = new DialogResult();
                var form = new FormInput("Enter in the Details", "OK");
                dr = form.ShowDialog();

                try
                {
                    using (var context = new LorikeetAppEntities())
                    {
                        if (dr == DialogResult.OK)
                        {
                            var debitCreditChangeText = (from d in context.DebitSystems
                                                         where d.DebitID == debitIDSelected
                                                         select d).FirstOrDefault();

                            if (debitCreditChangeText != null)
                            {
                                debitCreditChangeText.Details = form.inputText;
                                context.SaveChanges();
                            }
                            this.debitSystemTableAdapter.FillByMemberID(this.lorikeetAppDataSet.DebitSystem, memberID);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(MiscStuff.GetAllMessages(ex));
                }
                fixable = false;
                bbiFixMistake.Enabled = false;
                debitSel = false;
            }
            else if (columnName.GetCaption().Equals("Debit") || columnName.GetCaption().Equals("Credit"))
            {
                FixMistake();
            }
        }
    }
}