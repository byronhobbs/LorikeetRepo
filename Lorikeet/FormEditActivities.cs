using System;
using System.Windows.Forms;

namespace Lorikeet
{
    public partial class FormEditActivities : Form
    {
        private int rowSelected = -1;
        public FormEditActivities()
        {
            InitializeComponent();
        }

        private void gridView1_RowUpdated_1(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                labelsTableAdapter.Update(lorikeetAppDataSet);
                lorikeetAppDataSet.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                labelsTableAdapter.InsertQuery(0, "Change Me", "Change Me", "CM");
                lorikeetAppDataSet.AcceptChanges();
                labelsTableAdapter.Fill(lorikeetAppDataSet.Labels);
            }
            catch (Exception ex)
            {
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (rowSelected != -1)
                {
                    labelsTableAdapter.DeleteQuery(rowSelected);
                    lorikeetAppDataSet.AcceptChanges();
                    labelsTableAdapter.Fill(lorikeetAppDataSet.Labels);
                }

                rowSelected = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            try
            {
                rowSelected = (int)gridView1.GetFocusedRowCellValue("LabelID");
            }
            catch (Exception ex)
            {
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
        }

        private void FormEditActivities_Load(object sender, EventArgs e)
        {
            try
            {
                this.labelsTableAdapter.Fill(this.lorikeetAppDataSet.Labels);
            }
            catch (Exception ex)
            {
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
            }
        }
    }
}
