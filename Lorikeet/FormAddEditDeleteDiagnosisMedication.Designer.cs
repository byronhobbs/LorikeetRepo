namespace Lorikeet
{
    partial class FormAddEditDeleteDiagnosisMedication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddEditDeleteDiagnosisMedication));
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.simpleButtonMedicationsEdit = new DevExpress.XtraEditors.SimpleButton();
            this.listBoxMedications = new System.Windows.Forms.ListBox();
            this.simpleButtonMedicationAdd = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonMedicationDelete = new DevExpress.XtraEditors.SimpleButton();
            this.textBoxMedication = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.simpleButtonMergeDiagnosis = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonDiagnosisEdit = new DevExpress.XtraEditors.SimpleButton();
            this.listBoxDiagnosis = new System.Windows.Forms.ListBox();
            this.textBoxDiagnosis = new System.Windows.Forms.TextBox();
            this.simpleButtonDiagnosisAdd = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonDiagnosisDelete = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainRibbonControl
            // 
            this.mainRibbonControl.ExpandCollapseItem.Id = 0;
            this.mainRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbonControl.ExpandCollapseItem,
            this.bbiClose});
            this.mainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonControl.MaxItemId = 10;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.Size = new System.Drawing.Size(519, 143);
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
            this.mainRibbonPageGroup.Name = "mainRibbonPageGroup";
            this.mainRibbonPageGroup.ShowCaptionButton = false;
            this.mainRibbonPageGroup.Text = "Tasks";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.simpleButtonMedicationsEdit);
            this.groupBox1.Controls.Add(this.listBoxMedications);
            this.groupBox1.Controls.Add(this.simpleButtonMedicationAdd);
            this.groupBox1.Controls.Add(this.simpleButtonMedicationDelete);
            this.groupBox1.Controls.Add(this.textBoxMedication);
            this.groupBox1.Location = new System.Drawing.Point(10, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 228);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medications";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // simpleButtonMedicationsEdit
            // 
            this.simpleButtonMedicationsEdit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.simpleButtonMedicationsEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonMedicationsEdit.ImageOptions.Image")));
            this.simpleButtonMedicationsEdit.Location = new System.Drawing.Point(220, 67);
            this.simpleButtonMedicationsEdit.Name = "simpleButtonMedicationsEdit";
            this.simpleButtonMedicationsEdit.Size = new System.Drawing.Size(41, 41);
            this.simpleButtonMedicationsEdit.TabIndex = 4;
            this.simpleButtonMedicationsEdit.Click += new System.EventHandler(this.simpleButtonMedicationsEdit_Click);
            // 
            // listBoxMedications
            // 
            this.listBoxMedications.FormattingEnabled = true;
            this.listBoxMedications.Location = new System.Drawing.Point(267, 20);
            this.listBoxMedications.Name = "listBoxMedications";
            this.listBoxMedications.Size = new System.Drawing.Size(214, 199);
            this.listBoxMedications.TabIndex = 3;
            this.listBoxMedications.SelectedIndexChanged += new System.EventHandler(this.listBoxMedications_SelectedIndexChanged);
            // 
            // simpleButtonMedicationAdd
            // 
            this.simpleButtonMedicationAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.simpleButtonMedicationAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonMedicationAdd.ImageOptions.Image")));
            this.simpleButtonMedicationAdd.Location = new System.Drawing.Point(220, 20);
            this.simpleButtonMedicationAdd.Name = "simpleButtonMedicationAdd";
            this.simpleButtonMedicationAdd.Size = new System.Drawing.Size(41, 41);
            this.simpleButtonMedicationAdd.TabIndex = 2;
            this.simpleButtonMedicationAdd.Click += new System.EventHandler(this.simpleButtonMedicationAdd_Click);
            // 
            // simpleButtonMedicationDelete
            // 
            this.simpleButtonMedicationDelete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.simpleButtonMedicationDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonMedicationDelete.ImageOptions.Image")));
            this.simpleButtonMedicationDelete.Location = new System.Drawing.Point(220, 114);
            this.simpleButtonMedicationDelete.Name = "simpleButtonMedicationDelete";
            this.simpleButtonMedicationDelete.Size = new System.Drawing.Size(41, 41);
            this.simpleButtonMedicationDelete.TabIndex = 1;
            this.simpleButtonMedicationDelete.Click += new System.EventHandler(this.simpleButtonMedicationDelete_Click);
            // 
            // textBoxMedication
            // 
            this.textBoxMedication.Location = new System.Drawing.Point(8, 20);
            this.textBoxMedication.Name = "textBoxMedication";
            this.textBoxMedication.Size = new System.Drawing.Size(206, 21);
            this.textBoxMedication.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.simpleButtonMergeDiagnosis);
            this.groupBox2.Controls.Add(this.simpleButtonDiagnosisEdit);
            this.groupBox2.Controls.Add(this.listBoxDiagnosis);
            this.groupBox2.Controls.Add(this.textBoxDiagnosis);
            this.groupBox2.Controls.Add(this.simpleButtonDiagnosisAdd);
            this.groupBox2.Controls.Add(this.simpleButtonDiagnosisDelete);
            this.groupBox2.Location = new System.Drawing.Point(12, 385);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 228);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Diagnosis";
            // 
            // simpleButtonMergeDiagnosis
            // 
            this.simpleButtonMergeDiagnosis.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.simpleButtonMergeDiagnosis.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonMergeDiagnosis.ImageOptions.Image")));
            this.simpleButtonMergeDiagnosis.Location = new System.Drawing.Point(218, 161);
            this.simpleButtonMergeDiagnosis.Name = "simpleButtonMergeDiagnosis";
            this.simpleButtonMergeDiagnosis.Size = new System.Drawing.Size(41, 41);
            this.simpleButtonMergeDiagnosis.TabIndex = 6;
            this.simpleButtonMergeDiagnosis.Click += new System.EventHandler(this.simpleButtonMergeDiagnosis_Click);
            // 
            // simpleButtonDiagnosisEdit
            // 
            this.simpleButtonDiagnosisEdit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.simpleButtonDiagnosisEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonDiagnosisEdit.ImageOptions.Image")));
            this.simpleButtonDiagnosisEdit.Location = new System.Drawing.Point(218, 67);
            this.simpleButtonDiagnosisEdit.Name = "simpleButtonDiagnosisEdit";
            this.simpleButtonDiagnosisEdit.Size = new System.Drawing.Size(41, 41);
            this.simpleButtonDiagnosisEdit.TabIndex = 5;
            this.simpleButtonDiagnosisEdit.Click += new System.EventHandler(this.simpleButtonDiagnosisEdit_Click);
            // 
            // listBoxDiagnosis
            // 
            this.listBoxDiagnosis.FormattingEnabled = true;
            this.listBoxDiagnosis.Location = new System.Drawing.Point(265, 20);
            this.listBoxDiagnosis.Name = "listBoxDiagnosis";
            this.listBoxDiagnosis.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxDiagnosis.Size = new System.Drawing.Size(214, 199);
            this.listBoxDiagnosis.TabIndex = 4;
            this.listBoxDiagnosis.SelectedIndexChanged += new System.EventHandler(this.listBoxDiagnosis_SelectedIndexChanged);
            // 
            // textBoxDiagnosis
            // 
            this.textBoxDiagnosis.Location = new System.Drawing.Point(6, 20);
            this.textBoxDiagnosis.Name = "textBoxDiagnosis";
            this.textBoxDiagnosis.Size = new System.Drawing.Size(206, 21);
            this.textBoxDiagnosis.TabIndex = 3;
            // 
            // simpleButtonDiagnosisAdd
            // 
            this.simpleButtonDiagnosisAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.simpleButtonDiagnosisAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonDiagnosisAdd.ImageOptions.Image")));
            this.simpleButtonDiagnosisAdd.Location = new System.Drawing.Point(218, 20);
            this.simpleButtonDiagnosisAdd.Name = "simpleButtonDiagnosisAdd";
            this.simpleButtonDiagnosisAdd.Size = new System.Drawing.Size(41, 41);
            this.simpleButtonDiagnosisAdd.TabIndex = 4;
            this.simpleButtonDiagnosisAdd.Click += new System.EventHandler(this.simpleButtonDiagnosisAdd_Click);
            // 
            // simpleButtonDiagnosisDelete
            // 
            this.simpleButtonDiagnosisDelete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.simpleButtonDiagnosisDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonDiagnosisDelete.ImageOptions.Image")));
            this.simpleButtonDiagnosisDelete.Location = new System.Drawing.Point(218, 114);
            this.simpleButtonDiagnosisDelete.Name = "simpleButtonDiagnosisDelete";
            this.simpleButtonDiagnosisDelete.Size = new System.Drawing.Size(41, 41);
            this.simpleButtonDiagnosisDelete.TabIndex = 3;
            this.simpleButtonDiagnosisDelete.Click += new System.EventHandler(this.simpleButtonDiagnosisDelete_Click);
            // 
            // FormAddEditDeleteDiagnosisMedication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(519, 629);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainRibbonControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAddEditDeleteDiagnosisMedication";
            this.Ribbon = this.mainRibbonControl;
            this.Text = "Medications / Diagnosis Names";
            this.Load += new System.EventHandler(this.FormAddEditDeleteDiagnosisMedication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl mainRibbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage mainRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup mainRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem bbiClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton simpleButtonMedicationAdd;
        private DevExpress.XtraEditors.SimpleButton simpleButtonMedicationDelete;
        private System.Windows.Forms.TextBox textBoxMedication;
        private System.Windows.Forms.TextBox textBoxDiagnosis;
        private DevExpress.XtraEditors.SimpleButton simpleButtonDiagnosisAdd;
        private DevExpress.XtraEditors.SimpleButton simpleButtonDiagnosisDelete;
        private System.Windows.Forms.ListBox listBoxMedications;
        private System.Windows.Forms.ListBox listBoxDiagnosis;
        private DevExpress.XtraEditors.SimpleButton simpleButtonMedicationsEdit;
        private DevExpress.XtraEditors.SimpleButton simpleButtonDiagnosisEdit;
        private DevExpress.XtraEditors.SimpleButton simpleButtonMergeDiagnosis;
    }
}