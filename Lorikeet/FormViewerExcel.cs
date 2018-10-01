using DevExpress.Skins;
using DevExpress.Skins.XtraForm;
using DevExpress.Spreadsheet;
using DevExpress.XtraBars.Ribbon;
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
    public partial class FormViewerExcel : Form, IViewingForm
    {
        private string fileName = "";

        public bool saved { get; private set; }

        public FormViewerExcel(string fileName)
        {
            InitializeComponent();

            this.ControlBox = false;

            this.fileName = fileName;

            try
            {
                spreadsheetControl1.LoadDocument(fileName);
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
                spreadsheetControl1.SaveDocument(fileName);
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
                dr = MessageBox.Show("Do you want to save the Excel File before you quit", "Warning", MessageBoxButtons.YesNoCancel);

                if (dr == DialogResult.Yes)
                {
                    spreadsheetControl1.SaveDocument(fileName, DocumentFormat.OpenXml);
                    saved = true;
                    this.Close();
                }
                else if (dr == DialogResult.No)
                {
                    saved = true;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                saved = false;
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
            }
        }

        private void FormViewerExcel_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
