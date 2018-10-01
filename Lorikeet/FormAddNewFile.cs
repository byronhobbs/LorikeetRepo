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
    public partial class FormAddNewFile : Form
    {
        public string fileName { get; private set; }

        public FormAddNewFile()
        {
            InitializeComponent();

            comboBoxExtension.SelectedIndex = 0;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (textBoxFileName.Text.Contains("."))
            {
                MessageBox.Show("File Name cannot contain the file extension");
                return;
            }
            else if (textBoxFileName.Text.Equals(""))
            {
                MessageBox.Show("File Name cannot be empty");
                return;
            }
            else if (comboBoxExtension.Text.Equals(".docx") || comboBoxExtension.Text.Equals(".xlsx"))
            {
                DialogResult = DialogResult.OK;
                fileName = textBoxFileName.Text + comboBoxExtension.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("File extension must be one of the set choices");
                return;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
