namespace Lorikeet
{
    partial class Form1
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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Lorikeet.SplashScreen1), true, true);
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode4 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode5 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gridViewNotes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colContactID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMemberIDContact = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContactType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContactName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContactAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContactPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lorikeetAppDataSet = new Lorikeet.LorikeetAppDataSet();
            this.gridViewContacts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDebitID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMemberIDDebitCredit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCredit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDebit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetails = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStaffID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRunningTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridViewDebitsCredits = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMedicationID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMemberIDMedication = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedicationNameID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedicationName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridViewMedication = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDiagnosisName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiagnosisID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMemberIDDiagnosis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiagnosisNameID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridViewDiagnosis = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridViewMember = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMemberID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateOfBirth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStreetAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelephoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMobileNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmailAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateJoined = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArchived = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateAltered = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAgency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonReportItem = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemAdd = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenuAdd = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonItemMember = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemContact = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDiagnosis = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemMedication = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemNote = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDebitCredit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemEditMedsDiagnosis = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemImportDatabase = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemEditActivityNumbers = new DevExpress.XtraBars.BarButtonItem();
            this.bbiImportSpreadsheet = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDocuments = new DevExpress.XtraBars.BarButtonItem();
            this.bbiWeather = new DevExpress.XtraBars.BarButtonItem();
            this.bbiUsers = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.colNotesID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMemberIDNotes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEditable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStaffName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.radialMenu1 = new DevExpress.XtraBars.Ribbon.RadialMenu(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutConverter1 = new DevExpress.XtraLayout.Converter.LayoutConverter(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.textBoxBroadcast = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.memberTableAdapter = new Lorikeet.LorikeetAppDataSetTableAdapters.MemberTableAdapter();
            this.contactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactTableAdapter = new Lorikeet.LorikeetAppDataSetTableAdapters.ContactTableAdapter();
            this.debitSystemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.debitSystemTableAdapter = new Lorikeet.LorikeetAppDataSetTableAdapters.DebitSystemTableAdapter();
            this.medicationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicationTableAdapter = new Lorikeet.LorikeetAppDataSetTableAdapters.MedicationTableAdapter();
            this.diagnosisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diagnosisTableAdapter = new Lorikeet.LorikeetAppDataSetTableAdapters.DiagnosisTableAdapter();
            this.noteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.noteTableAdapter = new Lorikeet.LorikeetAppDataSetTableAdapters.NoteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lorikeetAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewContacts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDebitsCredits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMedication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDiagnosis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radialMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debitSystemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 400;
            // 
            // gridViewNotes
            // 
            this.gridViewNotes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colContactID,
            this.colMemberIDContact,
            this.colContactType,
            this.colContactName,
            this.colContactAddress,
            this.colContactPhone});
            this.gridViewNotes.GridControl = this.gridControl1;
            this.gridViewNotes.Name = "gridViewNotes";
            this.gridViewNotes.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewNotes.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewNotes.OptionsBehavior.Editable = false;
            this.gridViewNotes.ViewCaption = "Notes";
            this.gridViewNotes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridView2_MouseDown);
            this.gridViewNotes.DoubleClick += new System.EventHandler(this.gridView2_DoubleClick);
            // 
            // colContactID
            // 
            this.colContactID.FieldName = "ContactID";
            this.colContactID.Name = "colContactID";
            // 
            // colMemberIDContact
            // 
            this.colMemberIDContact.FieldName = "MemberID";
            this.colMemberIDContact.Name = "colMemberIDContact";
            // 
            // colContactType
            // 
            this.colContactType.FieldName = "ContactType";
            this.colContactType.Name = "colContactType";
            this.colContactType.Visible = true;
            this.colContactType.VisibleIndex = 0;
            this.colContactType.Width = 184;
            // 
            // colContactName
            // 
            this.colContactName.FieldName = "ContactName";
            this.colContactName.Name = "colContactName";
            this.colContactName.Visible = true;
            this.colContactName.VisibleIndex = 1;
            this.colContactName.Width = 199;
            // 
            // colContactAddress
            // 
            this.colContactAddress.FieldName = "ContactAddress";
            this.colContactAddress.Name = "colContactAddress";
            this.colContactAddress.Visible = true;
            this.colContactAddress.VisibleIndex = 2;
            this.colContactAddress.Width = 751;
            // 
            // colContactPhone
            // 
            this.colContactPhone.FieldName = "ContactPhone";
            this.colContactPhone.Name = "colContactPhone";
            this.colContactPhone.Visible = true;
            this.colContactPhone.VisibleIndex = 3;
            this.colContactPhone.Width = 188;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.memberBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gridViewNotes;
            gridLevelNode1.RelationName = "Member_Note";
            gridLevelNode2.LevelTemplate = this.gridViewContacts;
            gridLevelNode2.RelationName = "Contact_Member";
            gridLevelNode3.LevelTemplate = this.gridViewDebitsCredits;
            gridLevelNode3.RelationName = "DebitSystem_Member";
            gridLevelNode4.LevelTemplate = this.gridViewMedication;
            gridLevelNode4.RelationName = "Medication_Member";
            gridLevelNode5.LevelTemplate = this.gridViewDiagnosis;
            gridLevelNode5.RelationName = "Diagnosis_Member";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2,
            gridLevelNode3,
            gridLevelNode4,
            gridLevelNode5});
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridViewMember;
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1340, 482);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewContacts,
            this.gridViewDebitsCredits,
            this.gridViewMedication,
            this.gridViewDiagnosis,
            this.gridViewMember,
            this.gridViewNotes});
            this.gridControl1.Load += new System.EventHandler(this.gridControl1_Load);
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click_1);
            this.gridControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseUp);
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "Member";
            this.memberBindingSource.DataSource = this.lorikeetAppDataSet;
            // 
            // lorikeetAppDataSet
            // 
            this.lorikeetAppDataSet.DataSetName = "LorikeetAppDataSet";
            this.lorikeetAppDataSet.EnforceConstraints = false;
            this.lorikeetAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewContacts
            // 
            this.gridViewContacts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDebitID,
            this.colMemberIDDebitCredit,
            this.colDate,
            this.colCredit,
            this.colDebit,
            this.colDetails,
            this.colStaffID,
            this.colRunningTotal});
            this.gridViewContacts.GridControl = this.gridControl1;
            this.gridViewContacts.Name = "gridViewContacts";
            this.gridViewContacts.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewContacts.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewContacts.OptionsBehavior.Editable = false;
            this.gridViewContacts.OptionsView.ShowGroupPanel = false;
            this.gridViewContacts.ViewCaption = "Contacts";
            this.gridViewContacts.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView3_CustomDrawCell);
            this.gridViewContacts.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridView3_MouseDown);
            this.gridViewContacts.DoubleClick += new System.EventHandler(this.gridView3_DoubleClick);
            // 
            // colDebitID
            // 
            this.colDebitID.FieldName = "DebitID";
            this.colDebitID.Name = "colDebitID";
            // 
            // colMemberIDDebitCredit
            // 
            this.colMemberIDDebitCredit.FieldName = "MemberID";
            this.colMemberIDDebitCredit.Name = "colMemberIDDebitCredit";
            // 
            // colDate
            // 
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Width = 114;
            // 
            // colCredit
            // 
            this.colCredit.FieldName = "Credit";
            this.colCredit.Name = "colCredit";
            this.colCredit.Width = 135;
            // 
            // colDebit
            // 
            this.colDebit.FieldName = "Debit";
            this.colDebit.Name = "colDebit";
            this.colDebit.Width = 141;
            // 
            // colDetails
            // 
            this.colDetails.FieldName = "Details";
            this.colDetails.Name = "colDetails";
            this.colDetails.Width = 490;
            // 
            // colStaffID
            // 
            this.colStaffID.FieldName = "StaffID";
            this.colStaffID.Name = "colStaffID";
            // 
            // colRunningTotal
            // 
            this.colRunningTotal.FieldName = "RunningTotal";
            this.colRunningTotal.Name = "colRunningTotal";
            this.colRunningTotal.Width = 163;
            // 
            // gridViewDebitsCredits
            // 
            this.gridViewDebitsCredits.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMedicationID,
            this.colMemberIDMedication,
            this.colMedicationNameID,
            this.colMedicationName});
            this.gridViewDebitsCredits.GridControl = this.gridControl1;
            this.gridViewDebitsCredits.Name = "gridViewDebitsCredits";
            this.gridViewDebitsCredits.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewDebitsCredits.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewDebitsCredits.OptionsBehavior.Editable = false;
            this.gridViewDebitsCredits.OptionsView.ShowGroupPanel = false;
            this.gridViewDebitsCredits.ViewCaption = "Debit / Credits";
            this.gridViewDebitsCredits.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridView4_MouseDown);
            this.gridViewDebitsCredits.DoubleClick += new System.EventHandler(this.gridView4_DoubleClick);
            // 
            // colMedicationID
            // 
            this.colMedicationID.FieldName = "MedicationID";
            this.colMedicationID.Name = "colMedicationID";
            // 
            // colMemberIDMedication
            // 
            this.colMemberIDMedication.FieldName = "MemberID";
            this.colMemberIDMedication.Name = "colMemberIDMedication";
            // 
            // colMedicationNameID
            // 
            this.colMedicationNameID.FieldName = "MedicationNameID";
            this.colMedicationNameID.Name = "colMedicationNameID";
            // 
            // colMedicationName
            // 
            this.colMedicationName.FieldName = "MedicationName";
            this.colMedicationName.Name = "colMedicationName";
            this.colMedicationName.Visible = true;
            this.colMedicationName.VisibleIndex = 0;
            // 
            // gridViewMedication
            // 
            this.gridViewMedication.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDiagnosisName,
            this.colDiagnosisID,
            this.colMemberIDDiagnosis,
            this.colDiagnosisNameID});
            this.gridViewMedication.GridControl = this.gridControl1;
            this.gridViewMedication.Name = "gridViewMedication";
            this.gridViewMedication.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewMedication.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewMedication.OptionsBehavior.Editable = false;
            this.gridViewMedication.OptionsView.ShowGroupPanel = false;
            this.gridViewMedication.ViewCaption = "Medication";
            this.gridViewMedication.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridView5_MouseDown);
            this.gridViewMedication.DoubleClick += new System.EventHandler(this.gridView5_DoubleClick);
            // 
            // colDiagnosisName
            // 
            this.colDiagnosisName.FieldName = "DiagnosisName";
            this.colDiagnosisName.Name = "colDiagnosisName";
            // 
            // colDiagnosisID
            // 
            this.colDiagnosisID.FieldName = "DiagnosisID";
            this.colDiagnosisID.Name = "colDiagnosisID";
            // 
            // colMemberIDDiagnosis
            // 
            this.colMemberIDDiagnosis.FieldName = "MemberID";
            this.colMemberIDDiagnosis.Name = "colMemberIDDiagnosis";
            // 
            // colDiagnosisNameID
            // 
            this.colDiagnosisNameID.FieldName = "DiagnosisNameID";
            this.colDiagnosisNameID.Name = "colDiagnosisNameID";
            // 
            // gridViewDiagnosis
            // 
            this.gridViewDiagnosis.GridControl = this.gridControl1;
            this.gridViewDiagnosis.Name = "gridViewDiagnosis";
            this.gridViewDiagnosis.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewDiagnosis.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewDiagnosis.OptionsBehavior.Editable = false;
            this.gridViewDiagnosis.ViewCaption = "Diagnosis";
            // 
            // gridViewMember
            // 
            this.gridViewMember.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMemberID,
            this.colSurname,
            this.colFirstName,
            this.colDateOfBirth,
            this.colSex,
            this.colStreetAddress,
            this.colTelephoneNumber,
            this.colMobileNumber,
            this.colEmailAddress,
            this.colDateJoined,
            this.colArchived,
            this.colDateAltered,
            this.colAgency});
            this.gridViewMember.GridControl = this.gridControl1;
            this.gridViewMember.Name = "gridViewMember";
            this.gridViewMember.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewMember.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewMember.OptionsBehavior.Editable = false;
            this.gridViewMember.OptionsFind.AlwaysVisible = true;
            this.gridViewMember.OptionsView.ShowGroupPanel = false;
            this.gridViewMember.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
            this.gridViewMember.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridView1_MouseDown);
            this.gridViewMember.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colMemberID
            // 
            this.colMemberID.FieldName = "MemberID";
            this.colMemberID.Name = "colMemberID";
            this.colMemberID.Visible = true;
            this.colMemberID.VisibleIndex = 0;
            this.colMemberID.Width = 70;
            // 
            // colSurname
            // 
            this.colSurname.FieldName = "Surname";
            this.colSurname.Name = "colSurname";
            this.colSurname.Visible = true;
            this.colSurname.VisibleIndex = 1;
            this.colSurname.Width = 100;
            // 
            // colFirstName
            // 
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 2;
            this.colFirstName.Width = 100;
            // 
            // colDateOfBirth
            // 
            this.colDateOfBirth.FieldName = "DateOfBirth";
            this.colDateOfBirth.Name = "colDateOfBirth";
            this.colDateOfBirth.Visible = true;
            this.colDateOfBirth.VisibleIndex = 3;
            this.colDateOfBirth.Width = 79;
            // 
            // colSex
            // 
            this.colSex.FieldName = "Sex";
            this.colSex.Name = "colSex";
            this.colSex.Visible = true;
            this.colSex.VisibleIndex = 4;
            this.colSex.Width = 44;
            // 
            // colStreetAddress
            // 
            this.colStreetAddress.FieldName = "StreetAddress";
            this.colStreetAddress.Name = "colStreetAddress";
            this.colStreetAddress.Visible = true;
            this.colStreetAddress.VisibleIndex = 5;
            this.colStreetAddress.Width = 292;
            // 
            // colTelephoneNumber
            // 
            this.colTelephoneNumber.FieldName = "TelephoneNumber";
            this.colTelephoneNumber.Name = "colTelephoneNumber";
            this.colTelephoneNumber.Visible = true;
            this.colTelephoneNumber.VisibleIndex = 6;
            this.colTelephoneNumber.Width = 110;
            // 
            // colMobileNumber
            // 
            this.colMobileNumber.FieldName = "MobileNumber";
            this.colMobileNumber.Name = "colMobileNumber";
            this.colMobileNumber.Visible = true;
            this.colMobileNumber.VisibleIndex = 7;
            this.colMobileNumber.Width = 124;
            // 
            // colEmailAddress
            // 
            this.colEmailAddress.FieldName = "EmailAddress";
            this.colEmailAddress.Name = "colEmailAddress";
            this.colEmailAddress.Visible = true;
            this.colEmailAddress.VisibleIndex = 8;
            this.colEmailAddress.Width = 144;
            // 
            // colDateJoined
            // 
            this.colDateJoined.FieldName = "DateJoined";
            this.colDateJoined.Name = "colDateJoined";
            this.colDateJoined.Visible = true;
            this.colDateJoined.VisibleIndex = 9;
            this.colDateJoined.Width = 70;
            // 
            // colArchived
            // 
            this.colArchived.FieldName = "Archived";
            this.colArchived.Name = "colArchived";
            this.colArchived.Visible = true;
            this.colArchived.VisibleIndex = 12;
            this.colArchived.Width = 68;
            // 
            // colDateAltered
            // 
            this.colDateAltered.FieldName = "DateAltered";
            this.colDateAltered.Name = "colDateAltered";
            this.colDateAltered.Visible = true;
            this.colDateAltered.VisibleIndex = 10;
            this.colDateAltered.Width = 69;
            // 
            // colAgency
            // 
            this.colAgency.FieldName = "Agency";
            this.colAgency.Name = "colAgency";
            this.colAgency.Visible = true;
            this.colAgency.VisibleIndex = 11;
            this.colAgency.Width = 52;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonReportItem,
            this.barButtonItem1,
            this.barButtonItemAdd,
            this.barButtonItemMember,
            this.barButtonItemContact,
            this.barButtonItemDiagnosis,
            this.barButtonItemMedication,
            this.barButtonItemNote,
            this.barButtonItemEditMedsDiagnosis,
            this.barButtonItemDebitCredit,
            this.barButtonItem3,
            this.barButtonItemImportDatabase,
            this.barButtonItemEditActivityNumbers,
            this.bbiImportSpreadsheet,
            this.bbiDocuments,
            this.bbiWeather,
            this.bbiUsers});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 23;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1340, 143);
            // 
            // barButtonReportItem
            // 
            this.barButtonReportItem.Caption = "Reports";
            this.barButtonReportItem.Id = 1;
            this.barButtonReportItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonReportItem.ImageOptions.Image")));
            this.barButtonReportItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonReportItem.ImageOptions.LargeImage")));
            this.barButtonReportItem.Name = "barButtonReportItem";
            this.barButtonReportItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonReportItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonReportItem_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Schedule";
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItemAdd
            // 
            this.barButtonItemAdd.ActAsDropDown = true;
            this.barButtonItemAdd.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItemAdd.Caption = "Add / Edit Details of Member";
            this.barButtonItemAdd.DropDownControl = this.popupMenuAdd;
            this.barButtonItemAdd.Id = 5;
            this.barButtonItemAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemAdd.ImageOptions.Image")));
            this.barButtonItemAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemAdd.ImageOptions.LargeImage")));
            this.barButtonItemAdd.Name = "barButtonItemAdd";
            // 
            // popupMenuAdd
            // 
            this.popupMenuAdd.ItemLinks.Add(this.barButtonItemMember);
            this.popupMenuAdd.ItemLinks.Add(this.barButtonItemContact);
            this.popupMenuAdd.ItemLinks.Add(this.barButtonItemDiagnosis);
            this.popupMenuAdd.ItemLinks.Add(this.barButtonItemMedication);
            this.popupMenuAdd.ItemLinks.Add(this.barButtonItemNote);
            this.popupMenuAdd.ItemLinks.Add(this.barButtonItemDebitCredit);
            this.popupMenuAdd.Name = "popupMenuAdd";
            this.popupMenuAdd.Ribbon = this.ribbonControl1;
            // 
            // barButtonItemMember
            // 
            this.barButtonItemMember.Caption = "Member";
            this.barButtonItemMember.Id = 8;
            this.barButtonItemMember.Name = "barButtonItemMember";
            this.barButtonItemMember.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemMember_ItemClick);
            // 
            // barButtonItemContact
            // 
            this.barButtonItemContact.Caption = "Contact";
            this.barButtonItemContact.Id = 9;
            this.barButtonItemContact.Name = "barButtonItemContact";
            this.barButtonItemContact.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemContact_ItemClick);
            // 
            // barButtonItemDiagnosis
            // 
            this.barButtonItemDiagnosis.Caption = "Diagnosis";
            this.barButtonItemDiagnosis.Id = 10;
            this.barButtonItemDiagnosis.Name = "barButtonItemDiagnosis";
            this.barButtonItemDiagnosis.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDiagnosis_ItemClick);
            // 
            // barButtonItemMedication
            // 
            this.barButtonItemMedication.Caption = "Medication";
            this.barButtonItemMedication.Id = 11;
            this.barButtonItemMedication.Name = "barButtonItemMedication";
            this.barButtonItemMedication.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemMedication_ItemClick);
            // 
            // barButtonItemNote
            // 
            this.barButtonItemNote.Caption = "Note";
            this.barButtonItemNote.Id = 12;
            this.barButtonItemNote.Name = "barButtonItemNote";
            this.barButtonItemNote.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemNote_ItemClick);
            // 
            // barButtonItemDebitCredit
            // 
            this.barButtonItemDebitCredit.Caption = "Debit / Credit";
            this.barButtonItemDebitCredit.Id = 14;
            this.barButtonItemDebitCredit.Name = "barButtonItemDebitCredit";
            this.barButtonItemDebitCredit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDebitCredit_ItemClick);
            // 
            // barButtonItemEditMedsDiagnosis
            // 
            this.barButtonItemEditMedsDiagnosis.Caption = "Edit Diagnosis Medication names";
            this.barButtonItemEditMedsDiagnosis.Id = 13;
            this.barButtonItemEditMedsDiagnosis.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemEditMedsDiagnosis.ImageOptions.Image")));
            this.barButtonItemEditMedsDiagnosis.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemEditMedsDiagnosis.ImageOptions.LargeImage")));
            this.barButtonItemEditMedsDiagnosis.Name = "barButtonItemEditMedsDiagnosis";
            this.barButtonItemEditMedsDiagnosis.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemEditMedsDiagnosis_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Edit Attendance Numbers";
            this.barButtonItem3.Id = 16;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItemImportDatabase
            // 
            this.barButtonItemImportDatabase.Caption = "Import Database";
            this.barButtonItemImportDatabase.Id = 17;
            this.barButtonItemImportDatabase.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemImportDatabase.ImageOptions.Image")));
            this.barButtonItemImportDatabase.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemImportDatabase.ImageOptions.LargeImage")));
            this.barButtonItemImportDatabase.Name = "barButtonItemImportDatabase";
            this.barButtonItemImportDatabase.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemImportDatabase_ItemClick);
            // 
            // barButtonItemEditActivityNumbers
            // 
            this.barButtonItemEditActivityNumbers.Caption = "Edit Activity Numbers";
            this.barButtonItemEditActivityNumbers.Id = 18;
            this.barButtonItemEditActivityNumbers.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemEditActivityNumbers.ImageOptions.Image")));
            this.barButtonItemEditActivityNumbers.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemEditActivityNumbers.ImageOptions.LargeImage")));
            this.barButtonItemEditActivityNumbers.Name = "barButtonItemEditActivityNumbers";
            this.barButtonItemEditActivityNumbers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemEditActivityNumbers_ItemClick);
            // 
            // bbiImportSpreadsheet
            // 
            this.bbiImportSpreadsheet.Caption = "Import Spreadsheet";
            this.bbiImportSpreadsheet.Id = 19;
            this.bbiImportSpreadsheet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiImportSpreadsheet.ImageOptions.Image")));
            this.bbiImportSpreadsheet.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiImportSpreadsheet.ImageOptions.LargeImage")));
            this.bbiImportSpreadsheet.Name = "bbiImportSpreadsheet";
            this.bbiImportSpreadsheet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiImportSpreadsheet_ItemClick);
            // 
            // bbiDocuments
            // 
            this.bbiDocuments.Caption = "Documents";
            this.bbiDocuments.Id = 20;
            this.bbiDocuments.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiDocuments.ImageOptions.Image")));
            this.bbiDocuments.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiDocuments.ImageOptions.LargeImage")));
            this.bbiDocuments.Name = "bbiDocuments";
            this.bbiDocuments.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDocuments_ItemClick);
            // 
            // bbiWeather
            // 
            this.bbiWeather.Caption = "Get Weather";
            this.bbiWeather.Id = 21;
            this.bbiWeather.ImageOptions.LargeImage = global::Lorikeet.Properties.Resources.frostsuncloud;
            this.bbiWeather.Name = "bbiWeather";
            this.bbiWeather.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiWeather_ItemClick);
            // 
            // bbiUsers
            // 
            this.bbiUsers.Caption = "Users";
            this.bbiUsers.Id = 22;
            this.bbiUsers.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiUsers.ImageOptions.Image")));
            this.bbiUsers.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiUsers.ImageOptions.LargeImage")));
            this.bbiUsers.Name = "bbiUsers";
            this.bbiUsers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiUsers_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6,
            this.ribbonPageGroup7,
            this.ribbonPageGroup8});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Main";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonReportItem);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItemAdd);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Add / Edit / Delete";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItemEditMedsDiagnosis);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItemEditActivityNumbers);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Edit";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItemImportDatabase);
            this.ribbonPageGroup5.ItemLinks.Add(this.bbiImportSpreadsheet);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Import";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.bbiDocuments);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Documents";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.bbiWeather);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "Weather";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.bbiUsers);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.Text = "Add / Edit Logins";
            // 
            // colNotesID
            // 
            this.colNotesID.FieldName = "NotesID";
            this.colNotesID.Name = "colNotesID";
            // 
            // colMemberIDNotes
            // 
            this.colMemberIDNotes.FieldName = "MemberID";
            this.colMemberIDNotes.Name = "colMemberIDNotes";
            // 
            // colDate1
            // 
            this.colDate1.FieldName = "Date";
            this.colDate1.Name = "colDate1";
            this.colDate1.Visible = true;
            this.colDate1.VisibleIndex = 0;
            this.colDate1.Width = 145;
            // 
            // colNotes
            // 
            this.colNotes.FieldName = "Notes";
            this.colNotes.Name = "colNotes";
            this.colNotes.Visible = true;
            this.colNotes.VisibleIndex = 1;
            this.colNotes.Width = 867;
            // 
            // colEditable
            // 
            this.colEditable.FieldName = "Editable";
            this.colEditable.Name = "colEditable";
            this.colEditable.Visible = true;
            this.colEditable.VisibleIndex = 3;
            this.colEditable.Width = 66;
            // 
            // colStaffName1
            // 
            this.colStaffName1.FieldName = "StaffName";
            this.colStaffName1.Name = "colStaffName1";
            this.colStaffName1.Visible = true;
            this.colStaffName1.VisibleIndex = 2;
            this.colStaffName1.Width = 244;
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSplitContainer1.Grid = null;
            this.gridSplitContainer1.Horizontal = true;
            this.gridSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            this.gridSplitContainer1.Size = new System.Drawing.Size(1373, 531);
            this.gridSplitContainer1.TabIndex = 0;
            // 
            // radialMenu1
            // 
            this.radialMenu1.Name = "radialMenu1";
            this.radialMenu1.Ribbon = this.ribbonControl1;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1340, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 657);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1340, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 657);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1340, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 657);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 143);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonRefresh);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxBroadcast);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1340, 514);
            this.splitContainer1.SplitterDistance = 28;
            this.splitContainer1.TabIndex = 6;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(1199, 3);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(136, 23);
            this.buttonRefresh.TabIndex = 2;
            this.buttonRefresh.Text = "Refresh Member Grid";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // textBoxBroadcast
            // 
            this.textBoxBroadcast.Location = new System.Drawing.Point(83, 4);
            this.textBoxBroadcast.Name = "textBoxBroadcast";
            this.textBoxBroadcast.ReadOnly = true;
            this.textBoxBroadcast.Size = new System.Drawing.Size(1110, 21);
            this.textBoxBroadcast.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Access";
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
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
            // debitSystemBindingSource
            // 
            this.debitSystemBindingSource.DataMember = "DebitSystem";
            this.debitSystemBindingSource.DataSource = this.lorikeetAppDataSet;
            // 
            // debitSystemTableAdapter
            // 
            this.debitSystemTableAdapter.ClearBeforeFill = true;
            // 
            // medicationBindingSource
            // 
            this.medicationBindingSource.DataMember = "Medication";
            this.medicationBindingSource.DataSource = this.lorikeetAppDataSet;
            // 
            // medicationTableAdapter
            // 
            this.medicationTableAdapter.ClearBeforeFill = true;
            // 
            // diagnosisTableAdapter
            // 
            this.diagnosisTableAdapter.ClearBeforeFill = true;
            // 
            // noteTableAdapter
            // 
            this.noteTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 680);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lorikeet Main Window";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lorikeetAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewContacts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDebitsCredits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMedication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDiagnosis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radialMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debitSystemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonReportItem;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RadialMenu radialMenu1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAdd;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.PopupMenu popupMenuAdd;
        private DevExpress.XtraBars.BarButtonItem barButtonItemMember;
        private DevExpress.XtraBars.BarButtonItem barButtonItemContact;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDiagnosis;
        private DevExpress.XtraBars.BarButtonItem barButtonItemMedication;
        private DevExpress.XtraBars.BarButtonItem barButtonItemNote;
        private DevExpress.XtraBars.BarButtonItem barButtonItemEditMedsDiagnosis;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDebitCredit;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBoxBroadcast;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraLayout.Converter.LayoutConverter layoutConverter1;
        private System.Windows.Forms.Button buttonRefresh;
        private DevExpress.XtraBars.BarButtonItem barButtonItemImportDatabase;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMember;
        private DevExpress.XtraGrid.Columns.GridColumn colMemberID;
        private DevExpress.XtraGrid.Columns.GridColumn colSurname;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colDateOfBirth;
        private DevExpress.XtraGrid.Columns.GridColumn colSex;
        private DevExpress.XtraGrid.Columns.GridColumn colStreetAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colTelephoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colMobileNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colEmailAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colDateJoined;
        private DevExpress.XtraGrid.Columns.GridColumn colArchived;
        private DevExpress.XtraGrid.Columns.GridColumn colDateAltered;
        private DevExpress.XtraGrid.Columns.GridColumn colAgency;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewNotes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewContacts;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDebitsCredits;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMedication;
        private DevExpress.XtraGrid.Columns.GridColumn colContactID;
        private DevExpress.XtraGrid.Columns.GridColumn colMemberIDContact;
        private DevExpress.XtraGrid.Columns.GridColumn colContactType;
        private DevExpress.XtraGrid.Columns.GridColumn colContactName;
        private DevExpress.XtraGrid.Columns.GridColumn colContactAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colContactPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colDebitID;
        private DevExpress.XtraGrid.Columns.GridColumn colMemberIDDebitCredit;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCredit;
        private DevExpress.XtraGrid.Columns.GridColumn colDebit;
        private DevExpress.XtraGrid.Columns.GridColumn colDetails;
        private DevExpress.XtraGrid.Columns.GridColumn colStaffID;
        private DevExpress.XtraGrid.Columns.GridColumn colRunningTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colMedicationID;
        private DevExpress.XtraGrid.Columns.GridColumn colMemberIDMedication;
        private DevExpress.XtraGrid.Columns.GridColumn colMedicationNameID;
        private DevExpress.XtraGrid.Columns.GridColumn colMedicationName;
        private DevExpress.XtraGrid.Columns.GridColumn colDiagnosisName;
        private DevExpress.XtraGrid.Columns.GridColumn colDiagnosisID;
        private DevExpress.XtraGrid.Columns.GridColumn colMemberIDDiagnosis;
        private DevExpress.XtraGrid.Columns.GridColumn colDiagnosisNameID;
        private DevExpress.XtraGrid.Columns.GridColumn colNotesID;
        private DevExpress.XtraGrid.Columns.GridColumn colMemberIDNotes;
        private DevExpress.XtraGrid.Columns.GridColumn colDate1;
        private DevExpress.XtraGrid.Columns.GridColumn colNotes;
        private DevExpress.XtraGrid.Columns.GridColumn colEditable;
        private DevExpress.XtraGrid.Columns.GridColumn colStaffName1;
        private LorikeetAppDataSet lorikeetAppDataSet;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private LorikeetAppDataSetTableAdapters.MemberTableAdapter memberTableAdapter;
        private System.Windows.Forms.BindingSource contactBindingSource;
        private LorikeetAppDataSetTableAdapters.ContactTableAdapter contactTableAdapter;
        private System.Windows.Forms.BindingSource debitSystemBindingSource;
        private LorikeetAppDataSetTableAdapters.DebitSystemTableAdapter debitSystemTableAdapter;
        private System.Windows.Forms.BindingSource medicationBindingSource;
        private LorikeetAppDataSetTableAdapters.MedicationTableAdapter medicationTableAdapter;
        private System.Windows.Forms.BindingSource diagnosisBindingSource;
        private LorikeetAppDataSetTableAdapters.DiagnosisTableAdapter diagnosisTableAdapter;
        private System.Windows.Forms.BindingSource noteBindingSource;
        private LorikeetAppDataSetTableAdapters.NoteTableAdapter noteTableAdapter;
        private DevExpress.XtraBars.BarButtonItem barButtonItemEditActivityNumbers;
        private DevExpress.XtraBars.BarButtonItem bbiImportSpreadsheet;
        private DevExpress.XtraBars.BarButtonItem bbiDocuments;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem bbiWeather;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem bbiUsers;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDiagnosis;
    }
}

