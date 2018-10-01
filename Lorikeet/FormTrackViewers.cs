using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
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
    public partial class FormTrackViewers : Form
    {
        private List<FormsToDisplay> formsList;
        private bool flagMouseMove = false;

        public FormTrackViewers()
        {
            InitializeComponent();

            formsList = new List<FormsToDisplay>();
        }

        public bool AddFormToList(Form addForm, int type, string fileName)
        {
            try
            {
                var formCheckExists = (from f in formsList
                                       where f.name == fileName
                                       select f).DefaultIfEmpty().First();

                if (formCheckExists == null)
                {
                    FormsToDisplay formToAdd = new FormsToDisplay();
                    formToAdd.type = type;
                    formToAdd.name = fileName;
                    formToAdd.form = addForm;

                    formsList.Add(formToAdd);

                    RefreshTable();

                    return true;
                }
                else
                {
                    MessageBox.Show("File is already open");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
                return false;
            }
        }

        private void RefreshTable()
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Type");
                dt.Columns.Add("FileName");

                foreach (var f in formsList)
                {
                    dt.Rows.Add(f.type, f.name);
                }

                gridControl1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
            }
        }

        protected Point GetCellPoint(object cellInfo, Point point)
        {
            GridCellInfo cell = cellInfo as GridCellInfo;
            if (cell != null) point.Offset(-cell.CellValueRect.X, -cell.CellValueRect.Y);
            return point;
        }

        private void FormTrackViewers_Load(object sender, EventArgs e)
        {

        }

        private void onFormClosing(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTrackViewers_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                if (e.Column == gridColumnFormName)
                {
                    string name = gridView1.GetRowCellDisplayText(gridView1.FocusedRowHandle, "FileName");
                    var formToChoose = (from f in formsList
                                        where f.name == name
                                        select f).DefaultIfEmpty().First();

                    if (formToChoose != null)
                    {
                        formToChoose.form.BringToFront();
                    }
                }
                else if (e.Column == gridColumnCommands)
                {
                    GridViewInfo viewInfo = gridView1.GetViewInfo() as GridViewInfo;
                    GridHitInfo hitInfo = gridView1.CalcHitInfo(e.Location);
                    GridCellInfo cell = viewInfo.GetGridCellInfo(hitInfo);
                    if (cell == null || cell.Column == null || cell.Column.View == null) return;
                    Point hitPoint = GetCellPoint(cell, e.Location);
                    ButtonEditViewInfo buttonEditViewInfo = cell.ViewInfo as ButtonEditViewInfo;
                    DevExpress.XtraEditors.Drawing.EditorButtonObjectInfoArgs buttonInfoByPoint = buttonEditViewInfo.ButtonInfoByPoint(hitPoint);
                    if (buttonInfoByPoint != null)
                        repositoryItemButtonEdit1_ButtonClick(null, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(buttonInfoByPoint.Button));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
            }
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (e.Button.Tag != null && e.Button.Tag.ToString() == "Close")
                {
                    string name = gridView1.GetRowCellDisplayText(gridView1.FocusedRowHandle, "FileName");

                    var getForm = (from f in formsList
                                   where f.name == name
                                   select f).DefaultIfEmpty().First();

                    if (getForm != null)
                    {
                        if (name.Contains(".pdf"))
                        {
                            var tempForm = getForm.form as FormViewerPDF;
                            tempForm.CloseForm();
                            if (tempForm.saved)
                            {
                                formsList.Remove(getForm);
                                gridView1.DeleteRow(gridView1.FocusedRowHandle);

                                var maximizeForm = (from f in formsList
                                                    select f).DefaultIfEmpty().First();
                                if (maximizeForm != null)
                                {
                                    maximizeForm.form.WindowState = FormWindowState.Maximized;
                                }
                            }
                        }
                        else if (name.Contains(".docx") || name.Contains(".doc"))
                        {
                            var tempForm = getForm.form as FormViewerWord;
                            tempForm.CloseForm();
                            if (tempForm.saved)
                            {
                                formsList.Remove(getForm);
                                gridView1.DeleteRow(gridView1.FocusedRowHandle);

                                var maximizeForm = (from f in formsList
                                                    select f).DefaultIfEmpty().First();
                                if (maximizeForm != null)
                                {
                                    maximizeForm.form.WindowState = FormWindowState.Maximized;
                                }
                            }
                        }
                        else if (name.Contains(".xlsx") || name.Contains(".xls"))
                        {
                            var tempForm = getForm.form as FormViewerExcel;
                            tempForm.CloseForm();
                            if (tempForm.saved)
                            {
                                formsList.Remove(getForm);
                                gridView1.DeleteRow(gridView1.FocusedRowHandle);

                                var maximizeForm = (from f in formsList
                                                    select f).DefaultIfEmpty().First();
                                if (maximizeForm != null)
                                {
                                    maximizeForm.form.WindowState = FormWindowState.Maximized;
                                }
                            }
                        }
                    }
                }
                if (e.Button.Tag != null && e.Button.Tag.ToString() == "Save")
                {
                    string name = gridView1.GetRowCellDisplayText(gridView1.FocusedRowHandle, "FileName");

                    var getForm = (from f in formsList
                                   where f.name == name
                                   select f).DefaultIfEmpty().First();

                    if (getForm != null)
                    {
                        if (name.Contains(".pdf"))
                        {
                            var tempForm = getForm.form as FormViewerPDF;
                            tempForm.SaveForm();
                        }
                        else if (name.Contains(".docx") || name.Contains(".doc"))
                        {
                            var tempForm = getForm.form as FormViewerWord;
                            tempForm.SaveForm();
                        }
                        else if (name.Contains(".xlsx") || name.Contains(".xls"))
                        {
                            var tempForm = getForm.form as FormViewerExcel;
                            tempForm.SaveForm();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void FormTrackViewers_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void FormTrackViewers_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void FormTrackViewers_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void gridControl1_MouseDown(object sender, MouseEventArgs e)
        {
            flagMouseMove = true;
        }

        private void gridControl1_MouseUp(object sender, MouseEventArgs e)
        {
            flagMouseMove = false;
        }

        private void gridControl1_MouseMove(object sender, MouseEventArgs e)
        {
            if (flagMouseMove == true)
            {
                this.Location = Cursor.Position;
            }
        }
    }

    public class FormsToDisplay
    {
        public int type { get; set; }
        public string name { get; set; }
        public Form form { get; set; }
    }
}
