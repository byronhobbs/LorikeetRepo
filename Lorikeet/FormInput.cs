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
    public partial class FormInput : Form
    {
        public string inputText { get; set; }
        private bool onlyNumbers = false;

        public FormInput()
        {
            InitializeComponent();
        }

        public FormInput(string label, string buttonName, bool onlyNumbers = false, bool passwordChar = false)
        {
            InitializeComponent();

            this.buttonMerge.Text = buttonName;
            this.label1.Text = label;
            if (passwordChar)
            {
                textBoxMerge.PasswordChar = '*';
            }

            this.onlyNumbers = onlyNumbers;
        }

        private void buttonMerge_Click(object sender, EventArgs e)
        {
            if (textBoxMerge.Text.Equals(""))
            {
                MessageBox.Show("You must enter a Description");
                return;
            }
            else
            {
                inputText = textBoxMerge.Text;
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FormInput_Load(object sender, EventArgs e)
        {

        }

        private void textBoxMerge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!onlyNumbers)
                return;

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
                e.Handled = true;
        }
    }
}
