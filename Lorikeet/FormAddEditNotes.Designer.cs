namespace Lorikeet
{
    partial class FormAddEditNotes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddEditNotes));
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbiAdd = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.textBoxAddNote = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNotesID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMemberID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEditable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStaffName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.noteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lorikeetAppDataSet = new Lorikeet.LorikeetAppDataSet();
            this.noteTableAdapter = new Lorikeet.LorikeetAppDataSetTableAdapters.NoteTableAdapter();
            this.dateEditNote = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lorikeetAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNote.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNote.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mainRibbonControl
            // 
            this.mainRibbonControl.ExpandCollapseItem.Id = 0;
            this.mainRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbonControl.ExpandCollapseItem,
            this.bbiClose,
            this.bbiAdd,
            this.bbiEdit,
            this.bbiDelete});
            this.mainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonControl.MaxItemId = 13;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.Size = new System.Drawing.Size(790, 143);
            this.mainRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiClose
            // 
            this.bbiClose.Caption = "Close";
            this.bbiClose.Id = 7;
            this.bbiClose.ImageOptions.ImageUri.Uri = "Close";
            this.bbiClose.Name = "bbiClose";
            this.bbiClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiClose_ItemClick);
            // 
            // bbiAdd
            // 
            this.bbiAdd.Caption = "Add";
            this.bbiAdd.Id = 10;
            this.bbiAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiAdd.ImageOptions.Image")));
            this.bbiAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiAdd.ImageOptions.LargeImage")));
            this.bbiAdd.Name = "bbiAdd";
            this.bbiAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAdd_ItemClick);
            // 
            // bbiEdit
            // 
            this.bbiEdit.Caption = "Edit";
            this.bbiEdit.Id = 11;
            this.bbiEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiEdit.ImageOptions.Image")));
            this.bbiEdit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiEdit.ImageOptions.LargeImage")));
            this.bbiEdit.Name = "bbiEdit";
            this.bbiEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEdit_ItemClick);
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Delete";
            this.bbiDelete.Id = 12;
            this.bbiDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiDelete.ImageOptions.Image")));
            this.bbiDelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiDelete.ImageOptions.LargeImage")));
            this.bbiDelete.Name = "bbiDelete";
            this.bbiDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDelete_ItemClick);
            // 
            // mainRibbonPage
            // 
            this.mainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.mainRibbonPageGroup,
            this.ribbonPageGroup1});
            this.mainRibbonPage.MergeOrder = 0;
            this.mainRibbonPage.Name = "mainRibbonPage";
            this.mainRibbonPage.Text = "Home";
            // 
            // mainRibbonPageGroup
            // 
            this.mainRibbonPageGroup.AllowTextClipping = false;
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiClose);
            this.mainRibbonPageGroup.Name = "mainRibbonPageGroup";
            this.mainRibbonPageGroup.ShowCaptionButton = false;
            this.mainRibbonPageGroup.Text = "Tasks";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiAdd);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiDelete);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Add / Edit / Delete";
            // 
            // textBoxAddNote
            // 
            this.textBoxAddNote.Location = new System.Drawing.Point(110, 148);
            this.textBoxAddNote.Name = "textBoxAddNote";
            this.textBoxAddNote.Size = new System.Drawing.Size(587, 21);
            this.textBoxAddNote.TabIndex = 4;
            this.textBoxAddNote.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(703, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNotesID,
            this.colMemberID,
            this.colDate,
            this.colNotes,
            this.colEditable,
            this.colStaffName});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // colNotesID
            // 
            this.colNotesID.FieldName = "NotesID";
            this.colNotesID.Name = "colNotesID";
            // 
            // colMemberID
            // 
            this.colMemberID.FieldName = "MemberID";
            this.colMemberID.Name = "colMemberID";
            // 
            // colDate
            // 
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 0;
            this.colDate.Width = 91;
            // 
            // colNotes
            // 
            this.colNotes.FieldName = "Notes";
            this.colNotes.Name = "colNotes";
            this.colNotes.Visible = true;
            this.colNotes.VisibleIndex = 1;
            this.colNotes.Width = 497;
            // 
            // colEditable
            // 
            this.colEditable.FieldName = "Editable";
            this.colEditable.Name = "colEditable";
            this.colEditable.Visible = true;
            this.colEditable.VisibleIndex = 2;
            this.colEditable.Width = 47;
            // 
            // colStaffName
            // 
            this.colStaffName.FieldName = "StaffName";
            this.colStaffName.Name = "colStaffName";
            this.colStaffName.Visible = true;
            this.colStaffName.VisibleIndex = 3;
            this.colStaffName.Width = 113;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.noteBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 176);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.mainRibbonControl;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(766, 407);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // noteBindingSource
            // 
            this.noteBindingSource.DataMember = "Note";
            this.noteBindingSource.DataSource = this.lorikeetAppDataSet;
            // 
            // lorikeetAppDataSet
            // 
            this.lorikeetAppDataSet.DataSetName = "LorikeetAppDataSet";
            this.lorikeetAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // noteTableAdapter
            // 
            this.noteTableAdapter.ClearBeforeFill = true;
            // 
            // dateEditNote
            // 
            this.dateEditNote.EditValue = null;
            this.dateEditNote.Location = new System.Drawing.Point(12, 148);
            this.dateEditNote.MenuManager = this.mainRibbonControl;
            this.dateEditNote.Name = "dateEditNote";
            this.dateEditNote.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditNote.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditNote.Size = new System.Drawing.Size(92, 20);
            this.dateEditNote.TabIndex = 9;
            // 
            // FormAddEditNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(790, 595);
            this.Controls.Add(this.dateEditNote);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.textBoxAddNote);
            this.Controls.Add(this.mainRibbonControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAddEditNotes";
            this.Ribbon = this.mainRibbonControl;
            this.Text = "Notes";
            this.Load += new System.EventHandler(this.FormAddEditNotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lorikeetAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNote.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNote.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl mainRibbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage mainRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup mainRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem bbiClose;
        private DevExpress.XtraBars.BarButtonItem bbiAdd;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private System.Windows.Forms.TextBox textBoxAddNote;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colNotesID;
        private DevExpress.XtraGrid.Columns.GridColumn colMemberID;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colNotes;
        private DevExpress.XtraGrid.Columns.GridColumn colEditable;
        private DevExpress.XtraGrid.Columns.GridColumn colStaffName;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private LorikeetAppDataSet lorikeetAppDataSet;
        private System.Windows.Forms.BindingSource noteBindingSource;
        private LorikeetAppDataSetTableAdapters.NoteTableAdapter noteTableAdapter;
        private DevExpress.XtraEditors.DateEdit dateEditNote;
    }
}