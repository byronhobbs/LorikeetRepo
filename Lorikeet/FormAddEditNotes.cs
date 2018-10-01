using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using Lorikeet.Data;

namespace Lorikeet
{
    public partial class FormAddEditNotes : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private int memberID = -1;
        private int noteID = -1;
        private int staffID = -1;
        private bool editable = false;

        public FormAddEditNotes(int memberID, int staffID)
        {
            InitializeComponent();

            this.memberID = memberID;
            this.staffID = staffID;

            bbiAdd.Enabled = false;
            bbiEdit.Enabled = false;
            bbiDelete.Enabled = false;
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBoxAddNote.Text.Equals(""))
            {
                bbiAdd.Enabled = false;
            }
            else
            {
                bbiAdd.Enabled = true;
            }
        }

        private void RefreshNotesGrid()
        {
            try
            {
                this.noteTableAdapter.FillByMemberID(this.lorikeetAppDataSet.Note, memberID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
            }
        }

        private void FormAddEditNotes_Load(object sender, EventArgs e)
        {
            dateEditNote.DateTime = DateTime.Now;

            RefreshNotesGrid();
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (editable && noteID != -1)
            {
                try
                {
                    using (var context = new LorikeetAppEntities())
                    {
                        var noteToDelete = (from n in context.Notes
                                            where n.NotesID == noteID
                                            orderby n.Date
                                            select n).DefaultIfEmpty().First();

                        if (noteToDelete != null)
                        {
                            context.Notes.Remove(noteToDelete);
                            context.SaveChanges();
                        }
                    }
                    Logging.AddLogEntry(staffID, Logging.ErrorCodes.Broadcast, Logging.RefreshCodes.Notes, "Notes on " + MiscStuff.GetMemberName(memberID) + " have been deleted", false);
                }
                catch (Exception ex)
                {
                    Logging.AddLogEntry(staffID, Logging.ErrorCodes.Error, Logging.RefreshCodes.None, "Notes on " + MiscStuff.GetMemberName(memberID) + " has not been deleted - Error - " + ex.Message, false);
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Note is not directly Editable");
            }

            RefreshNotesGrid();

            bbiAdd.Enabled = false;
            bbiEdit.Enabled = false;
            bbiDelete.Enabled = false;
        }

        private void bbiAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textBoxAddNote.Text != "")
            {
                try
                {
                    using (var context = new LorikeetAppEntities())
                    {
                        var noteToAdd = new Note();
                        noteToAdd.Date = dateEditNote.DateTime;
                        noteToAdd.Editable = true;
                        noteToAdd.MemberID = memberID;
                        noteToAdd.Notes = textBoxAddNote.Text;
                        noteToAdd.StaffID = this.staffID;

                        context.Notes.Add(noteToAdd);
                        context.SaveChanges();
                    }

                    Logging.AddLogEntry(staffID, Logging.ErrorCodes.Broadcast, Logging.RefreshCodes.Notes, "Notes on " + MiscStuff.GetMemberName(memberID) + " has been added" , false);
                }
                catch (Exception ex)
                {
                    Logging.AddLogEntry(staffID, Logging.ErrorCodes.Error, Logging.RefreshCodes.None, "Notes on " + MiscStuff.GetMemberName(memberID) + " has not been added - Error - " + ex.Message, false);
                    MessageBox.Show(ex.Message);
                }

                RefreshNotesGrid();

                textBoxAddNote.Text = "";
                bbiAdd.Enabled = false;
                bbiEdit.Enabled = false;
                bbiDelete.Enabled = false;
            }
        }

        private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textBoxAddNote.Text != "")
            {
                try
                {
                    using (var context = new LorikeetAppEntities())
                    {
                        var noteToEdit = (from n in context.Notes
                                          where n.NotesID == noteID
                                          select n).DefaultIfEmpty().First();

                        if (noteToEdit != null)
                        {
                            noteToEdit.Notes = textBoxAddNote.Text;
                            noteToEdit.Date = dateEditNote.DateTime;
                            context.SaveChanges();
                        }
                    }

                    Logging.AddLogEntry(staffID, Logging.ErrorCodes.Broadcast, Logging.RefreshCodes.Notes, "Notes on " + MiscStuff.GetMemberName(memberID) + " has been edited", false);
                }
                catch (Exception ex)
                {
                    Logging.AddLogEntry(staffID, Logging.ErrorCodes.Error, Logging.RefreshCodes.None, "Notes on " + MiscStuff.GetMemberName(memberID) + " has not been edited - Error - " + ex.Message, false);
                    MessageBox.Show(ex.Message);
                }

                RefreshNotesGrid();

                textBoxAddNote.Text = "";

                bbiAdd.Enabled = false;
                bbiEdit.Enabled = false;
                bbiDelete.Enabled = false;
            }
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));
                if (hitInfo.HitTest == GridHitTest.RowCell)
                {
                    DateTime tempDate;
                    if (DateTime.TryParse(view.GetRowCellDisplayText(hitInfo.RowHandle, colDate), out tempDate))
                    {
                        dateEditNote.DateTime = tempDate;
                        this.noteID = int.Parse(view.GetRowCellDisplayText(hitInfo.RowHandle, colNotesID));
                        textBoxAddNote.Text = view.GetRowCellDisplayText(hitInfo.RowHandle, colNotes);
                        var checkedUnchecked = view.GetRowCellDisplayText(hitInfo.RowHandle, colEditable);
                        if (checkedUnchecked.Equals("Checked"))
                        {
                            editable = true;
                            bbiAdd.Enabled = true;
                            bbiEdit.Enabled = true;
                            bbiDelete.Enabled = true;
                        }
                        else
                        {
                            editable = false;
                            bbiAdd.Enabled = false;
                            bbiEdit.Enabled = false;
                            bbiDelete.Enabled = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxAddNote.Text = "";
            bbiAdd.Enabled = false;
        }
    }
}