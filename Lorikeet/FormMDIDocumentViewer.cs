using DevExpress.XtraBars;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraRichEdit;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraSpreadsheet;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Lorikeet
{
    public partial class FormMDIDocumentViewer : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private string rootPath;
        private List<FormsToDisplay> formsList;
        private PopupMenu popupMenuFolder = new PopupMenu();
        private PopupMenu popupMenuFile = new PopupMenu();
        private string directoryName = "";
        private string fileName = "";
        private string staffName = "";
        private List<string> staffDirectories = new List<string>();

        public FormMDIDocumentViewer(int staffID)
        {
            InitializeComponent();

            formsList = new List<FormsToDisplay>();
            InitData();

            try
            {
                staffName = MiscStuff.GetStaffName(staffID);

                SetupPopupMenus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
            }
        }

        private void SetupPopupMenus()
        {
            barManagerFolder.ForceInitialize();
            popupMenuFolder.Manager = barManagerFolder;
            BarButtonItem itemNewFolder = new BarButtonItem(barManagerFolder, "Create Folder", 0);
            BarButtonItem itemDeleteFolder = new BarButtonItem(barManagerFolder, "Delete Folder", 1);
            BarButtonItem itemImportFile = new BarButtonItem(barManagerFolder, "Import File(s)", 2);
            BarButtonItem itemNewFile = new BarButtonItem(barManagerFolder, "New File", 3);
            popupMenuFolder.AddItems(new BarItem[] { itemNewFolder, itemDeleteFolder, itemImportFile, itemNewFile });

            barManagerFile.ForceInitialize();
            popupMenuFile.Manager = barManagerFile;
            BarButtonItem itemOpenFileInApp = new BarButtonItem(barManagerFile, "Open In LorikeetApp", 0);
            BarButtonItem itemOpenFileOutApp = new BarButtonItem(barManagerFile, "Open in outside Program", 1);
            BarButtonItem itemDeleteFile = new BarButtonItem(barManagerFile, "Delete File", 2);
            BarButtonItem itemRenameFile = new BarButtonItem(barManagerFile, "Rename File", 3);
            popupMenuFile.AddItems(new BarItem[] { itemOpenFileInApp, itemOpenFileOutApp, itemDeleteFile, itemRenameFile });
        }

        private void InitData()
        {
            staffDirectories.Clear();
            rootPath = Application.StartupPath + "\\Documents\\";
            InitFolders(rootPath, null);
        }

        private void InitFolders(string path, TreeListNode pNode)
        {
            treeList1.BeginUnboundLoad();
            TreeListNode node;
            DirectoryInfo di;
            try
            {
                string[] root = Directory.GetDirectories(path);
                foreach (string s in root)
                {
                    try
                    {
                        di = new DirectoryInfo(s);
                        node = treeList1.AppendNode(new object[] { s, di.Name, "Folder", null, di }, pNode);
                        node.StateImageIndex = 0;
                        node.HasChildren = HasFiles(s);
                        if (node.Level == 0)
                            staffDirectories.Add(di.Name);
                        if (node.HasChildren)
                            node.Tag = true;
                    }
                    catch { }
                }
            }
            catch { }
            InitFiles(path, pNode);
            treeList1.EndUnboundLoad();
        }

        private void InitFiles(string path, TreeListNode pNode)
        {
            TreeListNode node;
            FileInfo fi;
            try
            {
                string[] root = Directory.GetFiles(path);
                foreach (string s in root)
                {
                    fi = new FileInfo(s);
                    node = treeList1.AppendNode(new object[] { s, fi.Name, "File", fi.Length, fi }, pNode);

                    node.StateImageIndex = 0;

                    if (fi.Name.Contains(".pdf"))
                    {
                        node.StateImageIndex = 4;
                    }
                    else if (fi.Name.Contains(".docx"))
                    {
                        node.StateImageIndex = 3;
                    }
                    else if (fi.Name.Contains(".xlsx"))
                    {
                        node.StateImageIndex = 2;
                    }
                    else
                    {
                        node.StateImageIndex = 1;
                    }

                    node.HasChildren = false;
                }
            }
            catch { }
        }

        private bool HasFiles(string path)
        {
            string[] root = Directory.GetFiles(path);
            if (root.Length > 0) return true;
            root = Directory.GetDirectories(path);
            if (root.Length > 0) return true;
            return false;
        }

        private void treeList1_BeforeExpand(object sender, BeforeExpandEventArgs e)
        {
            if (e.Node.Tag != null)
            {
                Cursor currentCursor = Cursor.Current;
                Cursor.Current = Cursors.WaitCursor;
                InitFolders(e.Node.GetDisplayText("FullName"), e.Node);
                e.Node.Tag = null;
                Cursor.Current = currentCursor;
            }
        }

        private void treeList1_AfterExpand(object sender, NodeEventArgs e)
        {
            if (e.Node.StateImageIndex != 1) e.Node.StateImageIndex = 5;
        }

        private void treeList1_AfterCollapse(object sender, NodeEventArgs e)
        {
            if (e.Node.StateImageIndex != 1) e.Node.StateImageIndex = 0;
        }

        private void treeList1_CalcNodeDragImageIndex(object sender, CalcNodeDragImageIndexEventArgs e)
        {
            try
            {
                if (e.Node[treeListColumn3].ToString() == "Folder")
                {
                    e.ImageIndex = 0;
                }
                if (e.Node[treeListColumn3].ToString() == "File")
                {
                    if (e.Node.ParentNode == treeList1.FocusedNode.ParentNode)
                    {
                        e.ImageIndex = -1;
                        return;
                    }
                    if (e.ImageIndex == 0)
                        if (e.Node.Id > treeList1.FocusedNode.Id)
                            e.ImageIndex = 2;
                        else
                            e.ImageIndex = 1;
                }
            }
            catch { }
        }

        private void treeList1_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                TreeListNode draggedNode = e.Data.GetData(typeof(TreeListNode)) as TreeListNode;
                TreeListNode tagretNode = treeList1.ViewInfo.GetHitTest(treeList1.PointToClient(new Point(e.X, e.Y))).Node;
                DirectoryInfo dr = new DirectoryInfo(draggedNode[treeListColumn1].ToString());

                if (draggedNode[treeListColumn1].ToString().Contains(staffName) && checkDirectoryRoot(dr.Name))
                {
                    if (tagretNode == null || draggedNode == null) return;
                    if (tagretNode[treeListColumn3].ToString() == "File")
                    {
                        if (tagretNode.ParentNode != draggedNode.ParentNode)
                            MoveInFolder(draggedNode, tagretNode.ParentNode);
                    }
                    else
                    {
                        MoveInFolder(draggedNode, tagretNode);
                    }
                    e.Effect = DragDropEffects.None;

                    treeList1.ClearNodes();
                    InitData();
                }
                else MessageBox.Show("You can't move a file or folder to another staff Members Directory or the Shared Directory");
            }
            catch { }
        }

        void MoveInFolder(TreeListNode sourceNode, TreeListNode destNode)
        {
            treeList1.MoveNode(sourceNode, destNode);
            if (sourceNode == null) return;
            FileSystemInfo sourceInfo = sourceNode[treeListColumn5] as FileSystemInfo;
            string sourcePath = sourceInfo.FullName;

            string destPath;
            if (destNode == null)
                destPath = rootPath + sourceInfo.Name;
            else
            {
                DirectoryInfo destInfo = destNode[treeListColumn5] as DirectoryInfo;
                destPath = destInfo.FullName + "\\" + sourceInfo.Name;
            }
            if (sourceInfo is DirectoryInfo)
            {
                if (!Directory.Exists(destPath))
                    Directory.Move(sourcePath, destPath);
            }
            else
            {
                if (!File.Exists(destPath))
                    File.Move(sourcePath, destPath);
            }
            sourceNode[treeListColumn5] = new DirectoryInfo(destPath);
        }

        private FileType GetFileType(string fileName)
        {
            if (fileName.Contains(".pdf"))
                return FileType.PDF;
            else if (fileName.Contains(".doc") || fileName.Contains(".docx"))
                return FileType.Word;
            else if (fileName.Contains(".xls") || fileName.Contains(".xlsx"))
                return FileType.Excel;
            else
                return FileType.Unknown;
        }

        private void OpenFile(string filePathName)
        {
            string fileName = Path.GetFileName(filePathName);
            FileType fileType = GetFileType(fileName);

            if (fileType == FileType.PDF)
            {
                SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
                var formPDF = new FormViewerPDF(filePathName);
                if (AddFormToList(formPDF, (int)FileType.PDF, fileName))
                {
                    formPDF.FormBorderStyle = FormBorderStyle.None;
                    formPDF.Dock = DockStyle.Fill;
                    formPDF.MdiParent = this;
                    formPDF.Show();
                }
                SplashScreenManager.CloseForm();
            }
            else if (fileType == FileType.Excel)
            {
                SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
                var formExcel = new FormViewerExcel(filePathName);
                if (AddFormToList(formExcel, (int)FileType.Excel, fileName))
                {
                    formExcel.FormBorderStyle = FormBorderStyle.None;
                    formExcel.Dock = DockStyle.Fill;
                    formExcel.MdiParent = this;
                    formExcel.Show();
                }
                SplashScreenManager.CloseForm();
            }
            else if (fileType == FileType.Word)
            {
                SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
                var formWord = new FormViewerWord(filePathName);
                if (AddFormToList(formWord, (int)FileType.Word, fileName))
                {
                    formWord.FormBorderStyle = FormBorderStyle.None;
                    formWord.Dock = DockStyle.Fill;
                    formWord.MdiParent = this;
                    formWord.Show();
                }
                SplashScreenManager.CloseForm();
            }
            else if (fileType == FileType.Unknown)
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("This file can not be opened in the Lorikeet App\nDo you want to open an external viewer for this File?", "Question", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    Process.Start(filePathName, null);
                }
            }
        }

        private void treeList1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if ((sender as TreeList).FocusedNode[treeListColumn3].ToString().Equals("Folder")) return;
                string filepathName = (sender as TreeList).FocusedNode[treeListColumn1].ToString();

                OpenFile(filepathName);
            }
            catch { }
        }

        private void treeList1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                (sender as TreeList).FocusedNode = treeList1.CalcHitInfo(e.Location).Node;
                if (e.Button == MouseButtons.Right)
                {
                    if ((sender as TreeList).FocusedNode[treeListColumn3].ToString() == "Folder")
                    {
                        popupMenuFolder.ShowPopup(Cursor.Position);
                        directoryName = (sender as TreeList).FocusedNode[treeListColumn1].ToString();
                        fileName = "";
                    }
                    else if ((sender as TreeList).FocusedNode[treeListColumn3].ToString() == "File")
                    {
                        popupMenuFile.ShowPopup(Cursor.Position);
                        directoryName = "";
                        fileName = (sender as TreeList).FocusedNode[treeListColumn1].ToString();
                    }
                }
                else if (e.Button == MouseButtons.Left)
                {
                    if ((sender as TreeList).FocusedNode[treeListColumn3].ToString() == "Folder")
                    {
                        directoryName = (sender as TreeList).FocusedNode[treeListColumn1].ToString();
                        fileName = "";
                    }
                    else if ((sender as TreeList).FocusedNode[treeListColumn3].ToString() == "File")
                    {
                        directoryName = "";
                        fileName = (sender as TreeList).FocusedNode[treeListColumn1].ToString();
                    }
                }
            }
            catch { }
        }

        private void RemoveDirectory(string fullDirectory)
        {
            try
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Do you really want to Remove the Directory", "Warning", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    Directory.Delete(fullDirectory);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
            }
        }

        private void MakeDirectory(string fullDirectory)
        {
            try
            {
                DialogResult dr = new DialogResult();
                var form = new FormInput("Enter New Directory to Create", "Create");
                dr = form.ShowDialog();
                if (dr == DialogResult.OK)
                    Directory.CreateDirectory(fullDirectory + "\\" + form.inputText + "\\");
            }
            catch (Exception ex)
            {
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
            }
        }

        private void DeleteFile(string fullDirectory)
        {
            try
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Do you really want to Remove the File", "Warning", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    File.Delete(fullDirectory);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
            }
        }

        private void RenameFile(string fullName)
        {
            try
            {
                DialogResult dr = new DialogResult();
                var form = new FormInput("Enter New File Name to Rename", "Rename");
                dr = form.ShowDialog();

                if (dr == DialogResult.OK && form.inputText != "")
                {
                    File.Move(fullName, Path.GetDirectoryName(fullName) + "\\" + form.inputText);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
            }
        }

        private void ImportFile(string fullDirectory)
        {
            try
            {
                var importFileDialog = new OpenFileDialog();
                importFileDialog.InitialDirectory = @"C:\";
                importFileDialog.Title = "Import Files";
                importFileDialog.CheckFileExists = true;
                importFileDialog.CheckPathExists = true;
                importFileDialog.Filter = "Word Documents (*.docx)|*.docx|Excel Documents (*.xlsx)|*.xlsx|PDF Documents (*.pdf)|*.pdf|All Files (*.*)|*.*";
                importFileDialog.FilterIndex = 4;
                importFileDialog.Multiselect = true;

                DialogResult dr = new DialogResult();
                dr = importFileDialog.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    foreach (String file in importFileDialog.FileNames)
                    {
                        File.Copy(file, fullDirectory + "\\" + Path.GetFileName(file));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
            }
        }

        private void barManagerFolder_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item.Caption.Equals("Create Folder"))
            {
                if (directoryName.Contains(staffName) || directoryName.Contains("Shared"))
                {
                    if (directoryName != "")
                    {
                        MakeDirectory(directoryName);
                        treeList1.ClearNodes();
                        InitData();
                    }
                }
                else MessageBox.Show("Sorry, Cant Create folder in other staff members Folders");
            }
            else if (e.Item.Caption.Equals("Delete Folder"))
            {
                DirectoryInfo di = new DirectoryInfo(directoryName);

                if (!checkDirectoryRoot(di.Name) && directoryName.Contains(staffName))
                {
                    if (directoryName != "")
                    {
                        RemoveDirectory(directoryName);
                        treeList1.ClearNodes();
                        InitData();
                    }
                }
                else MessageBox.Show("Sorry, you can't remove folders of other staff members or the root Directory");
            }
            else if (e.Item.Caption.Equals("Import File(s)"))
            {
                if (directoryName.Contains(staffName) || directoryName.Contains("Shared"))
                {
                    ImportFile(directoryName);
                    treeList1.ClearNodes();
                    InitData();
                }
            }
            else if (e.Item.Caption.Equals("New File"))
            {
                if (directoryName.Contains(staffName) || directoryName.Contains("Shared"))
                {
                    DialogResult dr = new DialogResult();
                    var formAddNewFile = new FormAddNewFile();
                    dr = formAddNewFile.ShowDialog();

                    if (dr == DialogResult.OK)
                    {
                        if (formAddNewFile.fileName.Contains(".docx"))
                        {
                            try
                            {
                                using (var richeditControl = new RichEditControl())
                                {
                                    richeditControl.CreateNewDocument(false);
                                    richeditControl.SaveDocument(directoryName + "\\" + formAddNewFile.fileName, DocumentFormat.OpenXml);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(MiscStuff.GetAllMessages(ex));
                            }
                        }
                        else if (formAddNewFile.fileName.Contains(".xlsx"))
                        {
                            try
                            {
                                using (var spreadsheetControl = new SpreadsheetControl())
                                {
                                    spreadsheetControl.CreateNewDocument();
                                    spreadsheetControl.SaveDocument(directoryName + "\\" + formAddNewFile.fileName, DevExpress.Spreadsheet.DocumentFormat.OpenXml);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(MiscStuff.GetAllMessages(ex));
                            }
                        }
                    }
                    treeList1.ClearNodes();
                    InitData();
                }
            }
        }

        private void barManagerFile_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item.Caption.Equals("Open In LorikeetApp"))
            {
                string filepathName = (sender as TreeList).FocusedNode[treeListColumn1].ToString();
                OpenFile(filepathName);
            }
            else if (e.Item.Caption.Equals("Open in outside Program"))
            {
                Process.Start(((sender as TreeList).FocusedNode[treeListColumn5] as FileSystemInfo).FullName, null);
            }
            else if (e.Item.Caption.Equals("Delete File") && fileName != null)
            {
                DeleteFile(fileName);
                treeList1.ClearNodes();
                InitData();
            }
            else if (e.Item.Caption.Equals("Rename File") && fileName != null)
            {
                RenameFile(fileName);
                treeList1.ClearNodes();
                InitData();
            }
        }

        private bool checkDirectoryRoot(string dirName)
        {
            foreach (var d in staffDirectories)
            {
                if (d.Equals(dirName))
                    return true;
            }
            return false;
        }        

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void bbiSaveClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void FormMDIDocumentViewer_Load(object sender, EventArgs e)
        {

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
                            tempForm = null;
                            System.GC.Collect(3);
                            System.GC.WaitForPendingFinalizers();
                        }
                        else if (name.Contains(".docx"))
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
                            tempForm = null;
                            System.GC.Collect(3);
                            System.GC.WaitForPendingFinalizers();
                        }
                        else if (name.Contains(".xlsx"))
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
                            tempForm = null;
                            System.GC.Collect(3);
                            System.GC.WaitForPendingFinalizers();
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
                        else if (name.Contains(".docx"))
                        {
                            var tempForm = getForm.form as FormViewerWord;
                            tempForm.SaveForm();
                        }
                        else if (name.Contains(".xlsx"))
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
    }

    public class FormsToDisplay
    {
        public int type { get; set; }
        public string name { get; set; }
        public Form form { get; set; }
    }
}
