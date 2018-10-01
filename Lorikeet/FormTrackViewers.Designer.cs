namespace Lorikeet
{
    partial class FormTrackViewers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrackViewers));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.imageCollectionTypes = new DevExpress.Utils.ImageCollection(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riImageEditType = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.gridColumnFormName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCommands = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ributtonCommands = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riImageEditType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ributtonCommands)).BeginInit();
            this.SuspendLayout();
            // 
            // imageCollectionTypes
            // 
            this.imageCollectionTypes.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollectionTypes.ImageStream")));
            this.imageCollectionTypes.InsertGalleryImage("exporttopdf_16x16.png", "images/export/exporttopdf_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttopdf_16x16.png"), 0);
            this.imageCollectionTypes.Images.SetKeyName(0, "exporttopdf_16x16.png");
            this.imageCollectionTypes.InsertGalleryImage("wordwrap_16x16.png", "images/grid/wordwrap_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/grid/wordwrap_16x16.png"), 1);
            this.imageCollectionTypes.Images.SetKeyName(1, "wordwrap_16x16.png");
            this.imageCollectionTypes.InsertGalleryImage("freezepanes_16x16.png", "images/spreadsheet/freezepanes_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/spreadsheet/freezepanes_16x16.png"), 2);
            this.imageCollectionTypes.Images.SetKeyName(2, "freezepanes_16x16.png");
            this.imageCollectionTypes.InsertGalleryImage("save_16x16.png", "images/save/save_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/save/save_16x16.png"), 3);
            this.imageCollectionTypes.Images.SetKeyName(3, "save_16x16.png");
            this.imageCollectionTypes.InsertGalleryImage("cancel_16x16.png", "images/actions/cancel_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/cancel_16x16.png"), 4);
            this.imageCollectionTypes.Images.SetKeyName(4, "cancel_16x16.png");
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ributtonCommands,
            this.riImageEditType});
            this.gridControl1.Size = new System.Drawing.Size(302, 209);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseDown);
            this.gridControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseMove);
            this.gridControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseUp);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnType,
            this.gridColumnFormName,
            this.gridColumnCommands});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Images = this.imageCollectionTypes;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // gridColumnType
            // 
            this.gridColumnType.ColumnEdit = this.riImageEditType;
            this.gridColumnType.FieldName = "Type";
            this.gridColumnType.Name = "gridColumnType";
            this.gridColumnType.Visible = true;
            this.gridColumnType.VisibleIndex = 0;
            this.gridColumnType.Width = 33;
            // 
            // riImageEditType
            // 
            this.riImageEditType.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("riImageEditType.Appearance.Image")));
            this.riImageEditType.Appearance.Options.UseImage = true;
            this.riImageEditType.AutoHeight = false;
            this.riImageEditType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riImageEditType.Images = this.imageCollectionTypes;
            this.riImageEditType.Name = "riImageEditType";
            this.riImageEditType.ReadOnly = true;
            // 
            // gridColumnFormName
            // 
            this.gridColumnFormName.FieldName = "FileName";
            this.gridColumnFormName.Name = "gridColumnFormName";
            this.gridColumnFormName.OptionsColumn.ReadOnly = true;
            this.gridColumnFormName.Visible = true;
            this.gridColumnFormName.VisibleIndex = 1;
            this.gridColumnFormName.Width = 204;
            // 
            // gridColumnCommands
            // 
            this.gridColumnCommands.ColumnEdit = this.ributtonCommands;
            this.gridColumnCommands.Name = "gridColumnCommands";
            this.gridColumnCommands.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnCommands.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            this.gridColumnCommands.Visible = true;
            this.gridColumnCommands.VisibleIndex = 2;
            this.gridColumnCommands.Width = 47;
            // 
            // ributtonCommands
            // 
            this.ributtonCommands.Appearance.Options.UseImage = true;
            this.ributtonCommands.AutoHeight = false;
            editorButtonImageOptions1.ImageIndex = 4;
            editorButtonImageOptions1.ImageList = this.imageCollectionTypes;
            serializableAppearanceObject1.Options.UseImage = true;
            editorButtonImageOptions2.ImageIndex = 3;
            editorButtonImageOptions2.ImageList = this.imageCollectionTypes;
            serializableAppearanceObject5.Options.UseImage = true;
            this.ributtonCommands.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", "Close", null, DevExpress.Utils.ToolTipAnchor.Default),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", "Save", null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.ributtonCommands.Name = "ributtonCommands";
            this.ributtonCommands.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // FormTrackViewers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(302, 209);
            this.Controls.Add(this.gridControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTrackViewers";
            this.ShowIcon = false;
            this.Text = "FormTrackViewers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTrackViewers_FormClosing);
            this.Load += new System.EventHandler(this.FormTrackViewers_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormTrackViewers_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormTrackViewers_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormTrackViewers_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riImageEditType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ributtonCommands)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnType;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnFormName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCommands;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ributtonCommands;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit riImageEditType;
        private DevExpress.Utils.ImageCollection imageCollectionTypes;
    }
}