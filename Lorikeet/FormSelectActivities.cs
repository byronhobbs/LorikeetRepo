using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lorikeet
{
    public partial class FormSelectActivities : Form
    {
        public List<string> selectedActivities = new List<string>();

        public FormSelectActivities()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            foreach (object item in checkedListBoxControl1.CheckedItems)
            {
                DataRowView row = item as DataRowView;
                selectedActivities.Add(row["DisplayName"].ToString());
            }

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FormSelectActivities_Load(object sender, EventArgs e)
        {
            this.labelsTableAdapter.Fill(this.lorikeetAppDataSet.Labels);
        }
    }
}
