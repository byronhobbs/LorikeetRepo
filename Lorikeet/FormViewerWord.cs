using DevExpress.XtraRichEdit;
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
    public partial class FormViewerWord : Form, IViewingForm
    {
        private string fileName = "";

        public bool saved { get; private set; }

        public FormViewerWord(string fileName)
        {
            InitializeComponent();

            this.ControlBox = false;

            this.fileName = fileName;
            try
            {
                recWord.LoadDocument(fileName);
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
                recWord.SaveDocument(fileName, DocumentFormat.OpenXml);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void CloseForm()
        {
            try
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Do you want to save the Word File before you quit", "Warning", MessageBoxButtons.YesNoCancel);

                if (dr == DialogResult.Yes)
                {
                    recWord.SaveDocument(fileName, DocumentFormat.OpenXml);
                    saved = true;
                    this.Close();
                }
                else if (dr == DialogResult.No)
                {
                    saved = true;
                    this.Close();
                }          
                else
                {
                    saved = false;
                }
            }
            catch (Exception ex)
            {
                saved = false;
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
            }
        }

        private void FormViewerWord_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
