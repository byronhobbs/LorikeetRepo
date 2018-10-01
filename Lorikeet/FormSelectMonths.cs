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
    public partial class FormSelectMonths : Form
    {
        public int birthdayMonth1 = 0;
        public int birthdayMonth2 = 0;
        public FormSelectMonths()
        {
            InitializeComponent();
        }

        private void FormSelectMonths_Load(object sender, EventArgs e)
        {
            radioGroupMonths.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioGroupMonths.SelectedIndex == 0)
            {
                birthdayMonth1 = 1;
                birthdayMonth2 = 2;
            }
            else if (radioGroupMonths.SelectedIndex == 1)
            {
                birthdayMonth1 = 3;
                birthdayMonth2 = 4;
            }
            else if (radioGroupMonths.SelectedIndex == 2)
            {
                birthdayMonth1 = 5;
                birthdayMonth2 = 6;
            }
            else if (radioGroupMonths.SelectedIndex == 3)
            {
                birthdayMonth1 = 7;
                birthdayMonth2 = 8;
            }
            else if (radioGroupMonths.SelectedIndex == 4)
            {
                birthdayMonth1 = 9;
                birthdayMonth2 = 10;
            }
            else if (radioGroupMonths.SelectedIndex == 5)
            {
                birthdayMonth1 = 11;
                birthdayMonth2 = 12;
            }

            DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
