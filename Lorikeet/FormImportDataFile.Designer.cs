namespace Lorikeet
{
    partial class FormImportDataFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImportDataFile));
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbiConvert = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraOpenFileDialog = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            this.listViewImport = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.spellChecker1 = new DevExpress.XtraSpellChecker.SpellChecker(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            this.SuspendLayout();
            // 
            // mainRibbonControl
            // 
            this.mainRibbonControl.ExpandCollapseItem.Id = 0;
            this.mainRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbonControl.ExpandCollapseItem,
            this.bbiSave,
            this.bbiClose,
            this.bbiConvert});
            this.mainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonControl.MaxItemId = 11;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.Size = new System.Drawing.Size(585, 143);
            this.mainRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "Import File";
            this.bbiSave.Id = 2;
            this.bbiSave.ImageOptions.ImageUri.Uri = "Save";
            this.bbiSave.Name = "bbiSave";
            this.bbiSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSave_ItemClick);
            // 
            // bbiClose
            // 
            this.bbiClose.Caption = "Close";
            this.bbiClose.Id = 7;
            this.bbiClose.ImageOptions.ImageUri.Uri = "Close";
            this.bbiClose.Name = "bbiClose";
            this.bbiClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiClose_ItemClick);
            // 
            // bbiConvert
            // 
            this.bbiConvert.Caption = "Convert";
            this.bbiConvert.Id = 10;
            this.bbiConvert.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiConvert.ImageOptions.Image")));
            this.bbiConvert.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiConvert.ImageOptions.LargeImage")));
            this.bbiConvert.Name = "bbiConvert";
            this.bbiConvert.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiConvert_ItemClick);
            // 
            // mainRibbonPage
            // 
            this.mainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.mainRibbonPageGroup});
            this.mainRibbonPage.MergeOrder = 0;
            this.mainRibbonPage.Name = "mainRibbonPage";
            this.mainRibbonPage.Text = "Home";
            // 
            // mainRibbonPageGroup
            // 
            this.mainRibbonPageGroup.AllowTextClipping = false;
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiClose);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiSave);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiConvert);
            this.mainRibbonPageGroup.Name = "mainRibbonPageGroup";
            this.mainRibbonPageGroup.ShowCaptionButton = false;
            this.mainRibbonPageGroup.Text = "Tasks";
            // 
            // xtraOpenFileDialog
            // 
            this.xtraOpenFileDialog.FileName = null;
            // 
            // listViewImport
            // 
            this.listViewImport.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewImport.LargeImageList = this.imageList1;
            this.listViewImport.Location = new System.Drawing.Point(0, 143);
            this.listViewImport.Name = "listViewImport";
            this.listViewImport.Size = new System.Drawing.Size(585, 446);
            this.listViewImport.SmallImageList = this.imageList1;
            this.listViewImport.TabIndex = 1;
            this.listViewImport.UseCompatibleStateImageBehavior = false;
            this.listViewImport.View = System.Windows.Forms.View.List;
            this.listViewImport.SelectedIndexChanged += new System.EventHandler(this.listViewImport_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 547;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "checkmark.png");
            this.imageList1.Images.SetKeyName(1, "failed.jpg");
            this.imageList1.Images.SetKeyName(2, "warning.jpg");
            // 
            // spellChecker1
            // 
            this.spellChecker1.Culture = new System.Globalization.CultureInfo("en-AU");
            this.spellChecker1.ParentContainer = null;
            // 
            // FormImportDataFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(585, 589);
            this.Controls.Add(this.listViewImport);
            this.Controls.Add(this.mainRibbonControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormImportDataFile";
            this.Ribbon = this.mainRibbonControl;
            this.Text = "Import Data File";
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl mainRibbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage mainRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup mainRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarButtonItem bbiClose;
        private DevExpress.XtraBars.BarButtonItem bbiConvert;
        private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog;
        private System.Windows.Forms.ListView listViewImport;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private DevExpress.XtraSpellChecker.SpellChecker spellChecker1;
    }
}