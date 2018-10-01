using DevExpress.Charts.Native;
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
    public partial class FormAddActivity : Form
    {
        public string activity { get; private set; }
        public string shortcut { get; private set; }

        public FormAddActivity(string shortcut)
        {
            InitializeComponent();

            textBoxOShortcut.Text = shortcut;
        }

        private void FormAddActivity_Load(object sender, EventArgs e)
        {

        }

        private void buttonChangeShortcut_Click(object sender, EventArgs e)
        {
            this.shortcut = textBoxCShortcut.Text;
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonAddShortcut_Click(object sender, EventArgs e)
        {
            this.activity = textBoxAddActivity.Text;
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
