namespace Lorikeet
{
    partial class FormEditMemberID
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditMemberID));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxOriginalID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNewID = new System.Windows.Forms.TextBox();
            this.listViewDetails = new System.Windows.Forms.ListView();
            this.columnHeaderText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderWorked = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCheck = new DevExpress.XtraBars.BarButtonItem();
            this.bbiChange = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.lorikeetAppDataSet1 = new Lorikeet.LorikeetAppDataSet();
            this.memberTableAdapter1 = new Lorikeet.LorikeetAppDataSetTableAdapters.MemberTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lorikeetAppDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Original Member ID";
            // 
            // textBoxOriginalID
            // 
            this.textBoxOriginalID.Location = new System.Drawing.Point(116, 149);
            this.textBoxOriginalID.Name = "textBoxOriginalID";
            this.textBoxOriginalID.ReadOnly = true;
            this.textBoxOriginalID.Size = new System.Drawing.Size(78, 21);
            this.textBoxOriginalID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Member ID to change to";
            // 
            // textBoxNewID
            // 
            this.textBoxNewID.Location = new System.Drawing.Point(361, 149);
            this.textBoxNewID.Name = "textBoxNewID";
            this.textBoxNewID.Size = new System.Drawing.Size(81, 21);
            this.textBoxNewID.TabIndex = 3;
            // 
            // listViewDetails
            // 
            this.listViewDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderText,
            this.columnHeaderWorked});
            this.listViewDetails.LargeImageList = this.imageList1;
            this.listViewDetails.Location = new System.Drawing.Point(12, 176);
            this.listViewDetails.Name = "listViewDetails";
            this.listViewDetails.Size = new System.Drawing.Size(430, 205);
            this.listViewDetails.SmallImageList = this.imageList1;
            this.listViewDetails.TabIndex = 7;
            this.listViewDetails.UseCompatibleStateImageBehavior = false;
            this.listViewDetails.View = System.Windows.Forms.View.List;
            // 
            // columnHeaderText
            // 
            this.columnHeaderText.Width = 400;
            // 
            // columnHeaderWorked
            // 
            this.columnHeaderWorked.Width = 30;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "checkmark.png");
            this.imageList1.Images.SetKeyName(1, "failed.jpg");
            this.imageList1.Images.SetKeyName(2, "warning.jpg");
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.bbiCheck,
            this.bbiChange});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(455, 143);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Close";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Close";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // bbiCheck
            // 
            this.bbiCheck.Caption = "Check";
            this.bbiCheck.Id = 3;
            this.bbiCheck.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiCheck.ImageOptions.Image")));
            this.bbiCheck.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiCheck.ImageOptions.LargeImage")));
            this.bbiCheck.Name = "bbiCheck";
            this.bbiCheck.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCheck_ItemClick);
            // 
            // bbiChange
            // 
            this.bbiChange.Caption = "Change";
            this.bbiChange.Id = 4;
            this.bbiChange.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiChange.ImageOptions.Image")));
            this.bbiChange.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiChange.ImageOptions.LargeImage")));
            this.bbiChange.Name = "bbiChange";
            this.bbiChange.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiChange_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Main";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Close Window";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiCheck);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiChange);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Change";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 392);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(455, 31);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // lorikeetAppDataSet1
            // 
            this.lorikeetAppDataSet1.DataSetName = "LorikeetAppDataSet";
            this.lorikeetAppDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memberTableAdapter1
            // 
            this.memberTableAdapter1.ClearBeforeFill = true;
            // 
            // FormEditMemberID
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 423);
            this.Controls.Add(this.listViewDetails);
            this.Controls.Add(this.textBoxNewID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxOriginalID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormEditMemberID";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Change Member ID";
            this.Load += new System.EventHandler(this.FormEditMemberID_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lorikeetAppDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOriginalID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNewID;
        private System.Windows.Forms.ListView listViewDetails;
        private System.Windows.Forms.ColumnHeader columnHeaderText;
        private System.Windows.Forms.ColumnHeader columnHeaderWorked;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem bbiCheck;
        private DevExpress.XtraBars.BarButtonItem bbiChange;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private LorikeetAppDataSet lorikeetAppDataSet1;
        private LorikeetAppDataSetTableAdapters.MemberTableAdapter memberTableAdapter1;
    }
}