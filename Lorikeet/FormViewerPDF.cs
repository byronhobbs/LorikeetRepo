using Lorikeet.Interfaces;
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
    public partial class FormViewerPDF : Form, IViewingForm
    {
        private string fileName = "";

        public bool saved { get; private set; }

        public FormViewerPDF(string fileName)
        {
            InitializeComponent();

            this.ControlBox = false;

            this.fileName = fileName;

            try
            {
                pdfViewer1.LoadDocument(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
            }
        }

        public bool SaveForm()
        {
            try
            {
                pdfViewer1.SaveDocument(fileName);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void CloseForm()
        {
            saved = true;
            this.Close();
        }

        private void FormViewerPDF_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
