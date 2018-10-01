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
    public partial class FormCheckDates : Form
    {
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }

        public FormCheckDates()
        {
            InitializeComponent();
        }

        private void FormCheckDates_Load(object sender, EventArgs e)
        {
            dateEditEnd.DateTime = DateTime.Today;
            dateEditStart.DateTime = DateTime.Today;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            startDate = dateEditStart.DateTime.Date;
            endDate = dateEditEnd.DateTime.Date;

            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
