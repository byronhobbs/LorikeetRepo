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
    public partial class FormPassword : Form
    {
        public string password { get; set; }

        public FormPassword(string fileName)
        {
            InitializeComponent();

            this.labelPassword.Text = "Enter Password "; 
        }

        private void FormPassword_Load(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text != "")
            {
                password = textBoxPassword.Text;
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
