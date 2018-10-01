using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using Lorikeet.Data;

namespace Lorikeet
{
    public partial class FormAddEditContacts : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private int memberID = -1;
        private int staffID = -1;
        private int idSelected = -1;
        public FormAddEditContacts(int memberID, int staffID)
        {
            InitializeComponent();

            this.memberID = memberID;
            this.staffID = staffID;

            contactTableAdapter.ClearBeforeFill = true;

            RefreshContactTable();
        }

        private void RefreshContactTable()
        {
            this.contactTableAdapter.FillByMemberID(this.lorikeetAppDataSet.Contact, memberID);
        }

        private void gridViewContactDetails_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));
                if (hitInfo.HitTest == GridHitTest.RowCell)
                {
                    idSelected = int.Parse(view.GetRowCellDisplayText(hitInfo.RowHandle, colContactID).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
            }

            try
            {
                using (var context = new LorikeetAppEntities())
                {
                    var contact = (from c in context.Contacts
                                   where c.ContactID == idSelected
                                   select c).DefaultIfEmpty().First();

                    if (contact != null)
                    {
                        textBoxAddress.Text = contact.ContactAddress;
                        textBoxType.Text = contact.ContactType;
                        textBoxName.Text = contact.ContactName;
                        textBoxPhone.Text = contact.ContactPhone;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearTextBoxes()
        {
            textBoxAddress.Text = "";
            textBoxPhone.Text = "";
            textBoxType.Text = "";
            textBoxName.Text = "";
        }

        private void buttonClearTextBoxes_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbiAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textBoxType.Text != "" && textBoxName.Text != "" && textBoxAddress.Text != "" && textBoxPhone.Text != "")
            {
                try
                {
                    using (var context = new LorikeetAppEntities())
                    {
                        Contact contactToAdd = new Contact();
                        contactToAdd.ContactAddress = textBoxAddress.Text;
                        contactToAdd.ContactName = textBoxName.Text;
                        contactToAdd.ContactPhone = textBoxPhone.Text;
                        contactToAdd.ContactType = textBoxType.Text;
                        contactToAdd.MemberID = memberID;

                        context.Contacts.Add(contactToAdd);
                        context.SaveChanges();
                    }

                    Logging.AddLogEntry(staffID, Logging.ErrorCodes.Broadcast, Logging.RefreshCodes.Contact, "Contact - " + textBoxName.Text + " was added", false);
                }
                catch (Exception ex)
                {
                    Logging.AddLogEntry(staffID, Logging.ErrorCodes.Error, Logging.RefreshCodes.None, "Error in adding a contact - " + ex.Message, false);
                    MessageBox.Show(ex.Message);
                }

                ClearTextBoxes();
                RefreshContactTable();
            }
        }

        private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textBoxType.Text != "" && textBoxName.Text != "" && textBoxAddress.Text != "" && textBoxPhone.Text != "" && idSelected != -1)
            {
                try
                {
                    using (var context = new LorikeetAppEntities())
                    {
                        Contact contactToAdd = new Contact();
                        contactToAdd = (from c in context.Contacts
                                        where c.ContactID == idSelected
                                        select c).DefaultIfEmpty().First();

                        if (contactToAdd != null)
                        {
                            contactToAdd.ContactAddress = textBoxAddress.Text;
                            contactToAdd.ContactName = textBoxName.Text;
                            contactToAdd.ContactPhone = textBoxPhone.Text;
                            contactToAdd.ContactType = textBoxType.Text;

                            context.SaveChanges();
                        }
                        Logging.AddLogEntry(staffID, Logging.ErrorCodes.Broadcast, Logging.RefreshCodes.Contact, "Contact - " + textBoxName.Text + " was edited", false);
                    }
                }
                catch (Exception ex)
                {
                    Logging.AddLogEntry(staffID, Logging.ErrorCodes.Error, Logging.RefreshCodes.None, "Error in editing a contact - " + ex.Message, false);
                    MessageBox.Show(ex.Message);
                }

                ClearTextBoxes();
                RefreshContactTable();
            }
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (idSelected != -1)
                {
                    using (var context = new LorikeetAppEntities())
                    {
                        var contactToDelete = (from c in context.Contacts
                                               where c.ContactID == idSelected
                                               select c).DefaultIfEmpty().First();

                        context.Contacts.Remove(contactToDelete);
                        context.SaveChanges();
                    }

                    Logging.AddLogEntry(staffID, Logging.ErrorCodes.Broadcast, Logging.RefreshCodes.Contact, "Contact - " + textBoxName.Text + " was deleted", false);

                    RefreshContactTable();
                    ClearTextBoxes();
                }
            }
            catch (Exception ex)
            {
                Logging.AddLogEntry(staffID, Logging.ErrorCodes.Error, Logging.RefreshCodes.None, "Error in deleting a contact - " + ex.Message, false);
                MessageBox.Show(ex.Message);
            }
        }

        private void FormAddEditContacts_Load(object sender, EventArgs e)
        {
            RefreshContactTable();
        }
    }
}