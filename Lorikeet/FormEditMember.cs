using System;
using System.Windows.Forms;

namespace Lorikeet
{
    public partial class FormEditMember : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private int memberID = -1;
        private int staffID = -1;
        private bool allControlsAreValid = true;
        public FormEditMember(int memberID, int staffID)
        {
            InitializeComponent();

            this.memberID = memberID;
            this.staffID = staffID;
        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (allControlsAreValid)
            {
                try
                {
                    this.Validate();
                    this.memberBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.lorikeetAppDataSet);

                    Logging.AddLogEntry(staffID, Logging.ErrorCodes.Broadcast, Logging.RefreshCodes.Member, "Member " + firstNameTextEdit.Text + " " + surnameTextEdit.Text + " has been updated", false);
                }
                catch (Exception ex)
                {
                    Logging.AddLogEntry(staffID, Logging.ErrorCodes.Error, Logging.RefreshCodes.Member, "Member " + firstNameTextEdit.Text + " " + surnameTextEdit.Text + " was tried to update but failed - Error - " + ex.Message, false);
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Not all Entries are valid.");
                return;
            }

            this.Close();
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbiReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.memberTableAdapter.FillByMemberID(this.lorikeetAppDataSet.Member, memberID);
        }

        private void FormEditMember_Load(object sender, EventArgs e)
        {
            this.memberTableAdapter.FillByMemberID(this.lorikeetAppDataSet.Member, memberID);
        }

        private void bbiEditMemberID_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new FormEditMemberID(memberID, staffID);
            form.ShowDialog();
            if (form.newMemberID != -1)
            {
                this.memberTableAdapter.FillByMemberID(this.lorikeetAppDataSet.Member, form.newMemberID);
            }
        }

        private void simpleButtonMap_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            var mapForm = new FormCountryOfOrigin();
            dr = mapForm.ShowDialog();

            if (dr == DialogResult.OK)
            {
                countryOfOriginTextEdit.Text = mapForm.getCountryName;
            }
        }

        private void sexCheckEdit_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}