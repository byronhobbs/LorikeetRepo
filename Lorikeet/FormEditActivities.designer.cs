namespace Lorikeet
{
    partial class FormEditActivities
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditActivities));
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.labelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lorikeetAppDataSet = new Lorikeet.LorikeetAppDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLabelID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemColorPickEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemColorPickEdit();
            this.colDisplayName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenuCaption = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShortcut = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.FormEditActivitieslayoutControl1ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.buttonCloseitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.buttonRemoveitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.buttonAdditem = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridControl1item = new DevExpress.XtraLayout.LayoutControlItem();
            this.labelsTableAdapter = new Lorikeet.LorikeetAppDataSetTableAdapters.LabelsTableAdapter();
            this.tableAdapterManager = new Lorikeet.LorikeetAppDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lorikeetAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorPickEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormEditActivitieslayoutControl1ConvertedLayout)).BeginInit();
            this.FormEditActivitieslayoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCloseitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRemoveitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonAdditem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1item)).BeginInit();
            this.SuspendLayout();
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Grid = null;
            this.gridSplitContainer1.Location = new System.Drawing.Point(12, 12);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            this.gridSplitContainer1.Size = new System.Drawing.Size(524, 275);
            this.gridSplitContainer1.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.labelsBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemColorPickEdit1,
            this.repositoryItemTextEdit1});
            this.gridControl1.Size = new System.Drawing.Size(526, 274);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // labelsBindingSource
            // 
            this.labelsBindingSource.DataMember = "Labels";
            this.labelsBindingSource.DataSource = this.lorikeetAppDataSet;
            // 
            // lorikeetAppDataSet
            // 
            this.lorikeetAppDataSet.DataSetName = "LorikeetAppDataSet";
            this.lorikeetAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLabelID,
            this.colColor,
            this.colDisplayName,
            this.colMenuCaption,
            this.colShortcut});
            gridFormatRule1.Name = "Format0";
            gridFormatRule1.Rule = null;
            this.gridView1.FormatRules.Add(gridFormatRule1);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated_1);
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // colLabelID
            // 
            this.colLabelID.FieldName = "LabelID";
            this.colLabelID.Name = "colLabelID";
            // 
            // colColor
            // 
            this.colColor.ColumnEdit = this.repositoryItemColorPickEdit1;
            this.colColor.FieldName = "Color";
            this.colColor.Name = "colColor";
            this.colColor.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.colColor.Visible = true;
            this.colColor.VisibleIndex = 2;
            this.colColor.Width = 166;
            // 
            // repositoryItemColorPickEdit1
            // 
            this.repositoryItemColorPickEdit1.AutoHeight = false;
            this.repositoryItemColorPickEdit1.AutomaticColor = System.Drawing.Color.Black;
            this.repositoryItemColorPickEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemColorPickEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemColorPickEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemColorPickEdit1.Name = "repositoryItemColorPickEdit1";
            this.repositoryItemColorPickEdit1.StoreColorAsInteger = true;
            // 
            // colDisplayName
            // 
            this.colDisplayName.FieldName = "DisplayName";
            this.colDisplayName.Name = "colDisplayName";
            this.colDisplayName.Visible = true;
            this.colDisplayName.VisibleIndex = 0;
            this.colDisplayName.Width = 342;
            // 
            // colMenuCaption
            // 
            this.colMenuCaption.FieldName = "MenuCaption";
            this.colMenuCaption.Name = "colMenuCaption";
            this.colMenuCaption.Width = 191;
            // 
            // colShortcut
            // 
            this.colShortcut.FieldName = "Shortcut";
            this.colShortcut.Name = "colShortcut";
            this.colShortcut.Visible = true;
            this.colShortcut.VisibleIndex = 1;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(90, 290);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(225, 45);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(319, 290);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(219, 45);
            this.buttonRemove.TabIndex = 3;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(12, 290);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(74, 45);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormEditActivitieslayoutControl1ConvertedLayout
            // 
            this.FormEditActivitieslayoutControl1ConvertedLayout.Controls.Add(this.buttonClose);
            this.FormEditActivitieslayoutControl1ConvertedLayout.Controls.Add(this.buttonRemove);
            this.FormEditActivitieslayoutControl1ConvertedLayout.Controls.Add(this.buttonAdd);
            this.FormEditActivitieslayoutControl1ConvertedLayout.Controls.Add(this.gridControl1);
            this.FormEditActivitieslayoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormEditActivitieslayoutControl1ConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.FormEditActivitieslayoutControl1ConvertedLayout.Name = "FormEditActivitieslayoutControl1ConvertedLayout";
            this.FormEditActivitieslayoutControl1ConvertedLayout.Root = this.layoutControlGroup1;
            this.FormEditActivitieslayoutControl1ConvertedLayout.Size = new System.Drawing.Size(550, 347);
            this.FormEditActivitieslayoutControl1ConvertedLayout.TabIndex = 0;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.buttonCloseitem,
            this.buttonRemoveitem,
            this.buttonAdditem,
            this.gridControl1item});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(550, 347);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // buttonCloseitem
            // 
            this.buttonCloseitem.Control = this.buttonClose;
            this.buttonCloseitem.Location = new System.Drawing.Point(0, 278);
            this.buttonCloseitem.Name = "buttonCloseitem";
            this.buttonCloseitem.Size = new System.Drawing.Size(78, 49);
            this.buttonCloseitem.TextSize = new System.Drawing.Size(0, 0);
            this.buttonCloseitem.TextVisible = false;
            // 
            // buttonRemoveitem
            // 
            this.buttonRemoveitem.Control = this.buttonRemove;
            this.buttonRemoveitem.Location = new System.Drawing.Point(307, 278);
            this.buttonRemoveitem.Name = "buttonRemoveitem";
            this.buttonRemoveitem.Size = new System.Drawing.Size(223, 49);
            this.buttonRemoveitem.TextSize = new System.Drawing.Size(0, 0);
            this.buttonRemoveitem.TextVisible = false;
            // 
            // buttonAdditem
            // 
            this.buttonAdditem.Control = this.buttonAdd;
            this.buttonAdditem.Location = new System.Drawing.Point(78, 278);
            this.buttonAdditem.Name = "buttonAdditem";
            this.buttonAdditem.Size = new System.Drawing.Size(229, 49);
            this.buttonAdditem.TextSize = new System.Drawing.Size(0, 0);
            this.buttonAdditem.TextVisible = false;
            // 
            // gridControl1item
            // 
            this.gridControl1item.Control = this.gridControl1;
            this.gridControl1item.Location = new System.Drawing.Point(0, 0);
            this.gridControl1item.Name = "gridControl1item";
            this.gridControl1item.Size = new System.Drawing.Size(530, 278);
            this.gridControl1item.TextSize = new System.Drawing.Size(0, 0);
            this.gridControl1item.TextVisible = false;
            // 
            // labelsTableAdapter
            // 
            this.labelsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AppointmentMemberTableAdapter = null;
            this.tableAdapterManager.AppointmentsTableAdapter = null;
            this.tableAdapterManager.AttendanceNumbersTableAdapter = null;
            this.tableAdapterManager.AttendanceTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ContactTableAdapter = null;
            this.tableAdapterManager.DebitSystemTableAdapter = null;
            this.tableAdapterManager.DiagnosisNameTableAdapter = null;
            this.tableAdapterManager.GuestTableAdapter = null;
            this.tableAdapterManager.LabelsTableAdapter = this.labelsTableAdapter;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.LogTableAdapter = null;
            this.tableAdapterManager.LunchTableAdapter = null;
            this.tableAdapterManager.MedicationNameTableAdapter = null;
            this.tableAdapterManager.MemberTableAdapter = null;
            this.tableAdapterManager.MenuTableAdapter = null;
            this.tableAdapterManager.PictureTableAdapter = null;
            this.tableAdapterManager.ResourcesTableAdapter = null;
            this.tableAdapterManager.SignInTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Lorikeet.LorikeetAppDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FormEditActivities
            // 
            this.AcceptButton = this.buttonAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(550, 347);
            this.Controls.Add(this.FormEditActivitieslayoutControl1ConvertedLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEditActivities";
            this.Text = "Edit Activities";
            this.Load += new System.EventHandler(this.FormEditActivities_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lorikeetAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorPickEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormEditActivitieslayoutControl1ConvertedLayout)).EndInit();
            this.FormEditActivitieslayoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCloseitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRemoveitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonAdditem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1item)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colLabelID;
        private DevExpress.XtraGrid.Columns.GridColumn colDisplayName;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuCaption;
        private DevExpress.XtraEditors.Repository.RepositoryItemColorPickEdit repositoryItemColorPickEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonClose;
        private DevExpress.XtraGrid.Columns.GridColumn colColor;
        private DevExpress.XtraLayout.LayoutControl FormEditActivitieslayoutControl1ConvertedLayout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem buttonCloseitem;
        private DevExpress.XtraLayout.LayoutControlItem buttonRemoveitem;
        private DevExpress.XtraLayout.LayoutControlItem buttonAdditem;
        private DevExpress.XtraLayout.LayoutControlItem gridControl1item;
        private DevExpress.XtraGrid.Columns.GridColumn colShortcut;
        private LorikeetAppDataSet lorikeetAppDataSet;
        private System.Windows.Forms.BindingSource labelsBindingSource;
        private LorikeetAppDataSetTableAdapters.LabelsTableAdapter labelsTableAdapter;
        private LorikeetAppDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}