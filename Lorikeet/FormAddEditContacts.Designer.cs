namespace Lorikeet
{
    partial class FormAddEditContacts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddEditContacts));
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbiAdd = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridViewContactDetails = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colContactID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMemberID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContactType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContactName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContactAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContactPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.buttonClearTextBoxes = new System.Windows.Forms.Button();
            this.lorikeetAppDataSet = new Lorikeet.LorikeetAppDataSet();
            this.contactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactTableAdapter = new Lorikeet.LorikeetAppDataSetTableAdapters.ContactTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewContactDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lorikeetAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).BeginInit();
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
            this.mainRibbonControl.Size = new System.Drawing.Size(613, 143);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxPhone);
            this.groupBox1.Controls.Add(this.textBoxAddress);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.textBoxType);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contact Details";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(67, 114);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(356, 21);
            this.textBoxPhone.TabIndex = 7;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(67, 83);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(356, 21);
            this.textBoxAddress.TabIndex = 5;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(67, 54);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(356, 21);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(67, 26);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(356, 21);
            this.textBoxType.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.contactBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 302);
            this.gridControl1.MainView = this.gridViewContactDetails;
            this.gridControl1.MenuManager = this.mainRibbonControl;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(588, 281);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewContactDetails});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridViewContactDetails
            // 
            this.gridViewContactDetails.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colContactID,
            this.colMemberID,
            this.colContactType,
            this.colContactName,
            this.colContactAddress,
            this.colContactPhone});
            this.gridViewContactDetails.GridControl = this.gridControl1;
            this.gridViewContactDetails.Name = "gridViewContactDetails";
            this.gridViewContactDetails.OptionsBehavior.Editable = false;
            this.gridViewContactDetails.OptionsView.ShowGroupPanel = false;
            this.gridViewContactDetails.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewContactDetails_RowCellClick);
            // 
            // colContactID
            // 
            this.colContactID.FieldName = "ContactID";
            this.colContactID.Name = "colContactID";
            // 
            // colMemberID
            // 
            this.colMemberID.FieldName = "MemberID";
            this.colMemberID.Name = "colMemberID";
            // 
            // colContactType
            // 
            this.colContactType.FieldName = "ContactType";
            this.colContactType.Name = "colContactType";
            this.colContactType.Visible = true;
            this.colContactType.VisibleIndex = 0;
            this.colContactType.Width = 90;
            // 
            // colContactName
            // 
            this.colContactName.FieldName = "ContactName";
            this.colContactName.Name = "colContactName";
            this.colContactName.Visible = true;
            this.colContactName.VisibleIndex = 1;
            this.colContactName.Width = 112;
            // 
            // colContactAddress
            // 
            this.colContactAddress.FieldName = "ContactAddress";
            this.colContactAddress.Name = "colContactAddress";
            this.colContactAddress.Visible = true;
            this.colContactAddress.VisibleIndex = 2;
            this.colContactAddress.Width = 254;
            // 
            // colContactPhone
            // 
            this.colContactPhone.FieldName = "ContactPhone";
            this.colContactPhone.Name = "colContactPhone";
            this.colContactPhone.Visible = true;
            this.colContactPhone.VisibleIndex = 3;
            this.colContactPhone.Width = 114;
            // 
            // buttonClearTextBoxes
            // 
            this.buttonClearTextBoxes.Location = new System.Drawing.Point(456, 216);
            this.buttonClearTextBoxes.Name = "buttonClearTextBoxes";
            this.buttonClearTextBoxes.Size = new System.Drawing.Size(145, 23);
            this.buttonClearTextBoxes.TabIndex = 1;
            this.buttonClearTextBoxes.Text = "Clear";
            this.buttonClearTextBoxes.UseVisualStyleBackColor = true;
            this.buttonClearTextBoxes.Click += new System.EventHandler(this.buttonClearTextBoxes_Click);
            // 
            // lorikeetAppDataSet
            // 
            this.lorikeetAppDataSet.DataSetName = "LorikeetAppDataSet";
            this.lorikeetAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactBindingSource
            // 
            this.contactBindingSource.DataMember = "Contact";
            this.contactBindingSource.DataSource = this.lorikeetAppDataSet;
            // 
            // contactTableAdapter
            // 
            this.contactTableAdapter.ClearBeforeFill = true;
            // 
            // FormAddEditContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(613, 595);
            this.Controls.Add(this.buttonClearTextBoxes);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainRibbonControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAddEditContacts";
            this.Ribbon = this.mainRibbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contacts";
            this.Load += new System.EventHandler(this.FormAddEditContacts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewContactDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lorikeetAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl mainRibbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage mainRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup mainRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem bbiClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewContactDetails;
        private DevExpress.XtraGrid.Columns.GridColumn colContactID;
        private DevExpress.XtraGrid.Columns.GridColumn colMemberID;
        private DevExpress.XtraGrid.Columns.GridColumn colContactType;
        private DevExpress.XtraGrid.Columns.GridColumn colContactName;
        private DevExpress.XtraGrid.Columns.GridColumn colContactAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colContactPhone;
        private System.Windows.Forms.Button buttonClearTextBoxes;
        private DevExpress.XtraBars.BarButtonItem bbiAdd;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private LorikeetAppDataSet lorikeetAppDataSet;
        private System.Windows.Forms.BindingSource contactBindingSource;
        private LorikeetAppDataSetTableAdapters.ContactTableAdapter contactTableAdapter;
    }
}