namespace Lorikeet
{
    partial class FormAddEditDebitCredit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddEditDebitCredit));
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbiFixMistake = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDebit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCredit = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.debitSystemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lorikeetAppDataSet = new Lorikeet.LorikeetAppDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDebitID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMemberID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCredit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDebit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRunningTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetails = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStaffName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStaffID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.textBoxDetails = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.debitSystemTableAdapter = new Lorikeet.LorikeetAppDataSetTableAdapters.DebitSystemTableAdapter();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debitSystemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lorikeetAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainRibbonControl
            // 
            this.mainRibbonControl.ExpandCollapseItem.Id = 0;
            this.mainRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbonControl.ExpandCollapseItem,
            this.bbiClose,
            this.bbiFixMistake});
            this.mainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonControl.MaxItemId = 13;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.Size = new System.Drawing.Size(792, 116);
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
            // bbiFixMistake
            // 
            this.bbiFixMistake.Caption = "Fix Mistake";
            this.bbiFixMistake.Id = 12;
            this.bbiFixMistake.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiFixMistake.ImageOptions.Image")));
            this.bbiFixMistake.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiFixMistake.ImageOptions.LargeImage")));
            this.bbiFixMistake.Name = "bbiFixMistake";
            this.bbiFixMistake.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiFixMistake_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiFixMistake);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Fix";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add Debit";
            // 
            // textBoxDebit
            // 
            this.textBoxDebit.Location = new System.Drawing.Point(244, 148);
            this.textBoxDebit.Name = "textBoxDebit";
            this.textBoxDebit.Size = new System.Drawing.Size(105, 21);
            this.textBoxDebit.TabIndex = 3;
            this.textBoxDebit.TextChanged += new System.EventHandler(this.textBoxDebit_TextChanged);
            this.textBoxDebit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDebit_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Add Credit";
            // 
            // textBoxCredit
            // 
            this.textBoxCredit.Location = new System.Drawing.Point(72, 148);
            this.textBoxCredit.Name = "textBoxCredit";
            this.textBoxCredit.Size = new System.Drawing.Size(100, 21);
            this.textBoxCredit.TabIndex = 1;
            this.textBoxCredit.TextChanged += new System.EventHandler(this.textBoxCredit_TextChanged);
            this.textBoxCredit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCredit_KeyPress);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(674, 146);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(104, 23);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.debitSystemBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.mainRibbonControl;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(766, 410);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // debitSystemBindingSource
            // 
            this.debitSystemBindingSource.DataMember = "DebitSystem";
            this.debitSystemBindingSource.DataSource = this.lorikeetAppDataSet;
            // 
            // lorikeetAppDataSet
            // 
            this.lorikeetAppDataSet.DataSetName = "LorikeetAppDataSet";
            this.lorikeetAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDebitID,
            this.colMemberID,
            this.colDate,
            this.colCredit,
            this.colDebit,
            this.colRunningTotal,
            this.colDetails,
            this.colStaffName,
            this.colStaffID});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AllowFindPanel = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView1_CustomDrawCell);
            this.gridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridView1_MouseUp);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colDebitID
            // 
            this.colDebitID.FieldName = "DebitID";
            this.colDebitID.Name = "colDebitID";
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
            this.colDate.Width = 85;
            // 
            // colCredit
            // 
            this.colCredit.FieldName = "Credit";
            this.colCredit.Name = "colCredit";
            this.colCredit.Visible = true;
            this.colCredit.VisibleIndex = 1;
            this.colCredit.Width = 76;
            // 
            // colDebit
            // 
            this.colDebit.FieldName = "Debit";
            this.colDebit.Name = "colDebit";
            this.colDebit.Visible = true;
            this.colDebit.VisibleIndex = 2;
            this.colDebit.Width = 69;
            // 
            // colRunningTotal
            // 
            this.colRunningTotal.FieldName = "RunningTotal";
            this.colRunningTotal.Name = "colRunningTotal";
            this.colRunningTotal.Visible = true;
            this.colRunningTotal.VisibleIndex = 3;
            this.colRunningTotal.Width = 88;
            // 
            // colDetails
            // 
            this.colDetails.FieldName = "Details";
            this.colDetails.Name = "colDetails";
            this.colDetails.Visible = true;
            this.colDetails.VisibleIndex = 4;
            this.colDetails.Width = 314;
            // 
            // colStaffName
            // 
            this.colStaffName.FieldName = "StaffName";
            this.colStaffName.Name = "colStaffName";
            this.colStaffName.Visible = true;
            this.colStaffName.VisibleIndex = 5;
            this.colStaffName.Width = 116;
            // 
            // colStaffID
            // 
            this.colStaffID.FieldName = "StaffID";
            this.colStaffID.Name = "colStaffID";
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Grid = this.gridControl1;
            this.gridSplitContainer1.Location = new System.Drawing.Point(12, 173);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            this.gridSplitContainer1.Panel1.Controls.Add(this.gridControl1);
            this.gridSplitContainer1.Size = new System.Drawing.Size(766, 410);
            this.gridSplitContainer1.TabIndex = 7;
            // 
            // textBoxDetails
            // 
            this.textBoxDetails.Location = new System.Drawing.Point(398, 148);
            this.textBoxDetails.Name = "textBoxDetails";
            this.textBoxDetails.Size = new System.Drawing.Size(270, 21);
            this.textBoxDetails.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Details";
            // 
            // debitSystemTableAdapter
            // 
            this.debitSystemTableAdapter.ClearBeforeFill = true;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.MaxItemId = 0;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(792, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 572);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(792, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 572);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(792, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 572);
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "moveup_16x16.png");
            this.imageCollection1.Images.SetKeyName(1, "movedown_16x16.png");
            this.imageCollection1.Images.SetKeyName(2, "removecellscommandgroup_16x16.png");
            this.imageCollection1.Images.SetKeyName(3, "cleartablestyle_16x16.png");
            // 
            // FormAddEditDebitCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(792, 595);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDetails);
            this.Controls.Add(this.gridSplitContainer1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxCredit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDebit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainRibbonControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAddEditDebitCredit";
            this.Text = "Debit / Credit";
            this.Load += new System.EventHandler(this.FormAddEditDebitCredit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debitSystemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lorikeetAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl mainRibbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage mainRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup mainRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem bbiClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDebit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCredit;
        private System.Windows.Forms.Button buttonAdd;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colDebitID;
        private DevExpress.XtraGrid.Columns.GridColumn colMemberID;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCredit;
        private DevExpress.XtraGrid.Columns.GridColumn colDebit;
        private DevExpress.XtraGrid.Columns.GridColumn colDetails;
        private DevExpress.XtraGrid.Columns.GridColumn colStaffName;
        private DevExpress.XtraGrid.Columns.GridColumn colStaffID;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.TextBox textBoxDetails;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.Columns.GridColumn colRunningTotal;
        private LorikeetAppDataSet lorikeetAppDataSet;
        private System.Windows.Forms.BindingSource debitSystemBindingSource;
        private LorikeetAppDataSetTableAdapters.DebitSystemTableAdapter debitSystemTableAdapter;
        private DevExpress.XtraBars.BarButtonItem bbiFixMistake;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.Utils.ImageCollection imageCollection1;
    }
}