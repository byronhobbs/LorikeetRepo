using Lorikeet.CustomEditor;

namespace Lorikeet
{
    partial class FormNewMemberWizard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewMemberWizard));
            this.wizardControl1 = new DevExpress.XtraWizard.WizardControl();
            this.welcomeWizardPage1 = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.wizardPage1 = new DevExpress.XtraWizard.WizardPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxStudying = new System.Windows.Forms.CheckBox();
            this.checkBoxVolunteering = new System.Windows.Forms.CheckBox();
            this.checkBoxWorking = new System.Windows.Forms.CheckBox();
            this.checkBoxBirthdayCard = new System.Windows.Forms.CheckBox();
            this.checkBoxByMail = new System.Windows.Forms.CheckBox();
            this.checkBoxNewsletter = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxAgency = new System.Windows.Forms.CheckBox();
            this.buttonMap = new System.Windows.Forms.Button();
            this.checkBoxAboriginal = new System.Windows.Forms.CheckBox();
            this.textBoxCOO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateEditDOB = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.completionWizardPage1 = new DevExpress.XtraWizard.CompletionWizardPage();
            this.wizardPage2 = new DevExpress.XtraWizard.WizardPage();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.imageLayer1 = new DevExpress.XtraMap.ImageLayer();
            this.bingMapDataProvider1 = new DevExpress.XtraMap.BingMapDataProvider();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxMobile = new DevExpress.XtraEditors.TextEdit();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxTelephone = new DevExpress.XtraEditors.TextEdit();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonChooseAddress = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxPostcode = new DevExpress.XtraEditors.TextEdit();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxSuburb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxEditState = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mleAddress = new Lorikeet.CustomEditor.MyLookUpEdit();
            this.wizardPage3 = new DevExpress.XtraWizard.WizardPage();
            this.buttonCheckMemberID = new System.Windows.Forms.Button();
            this.textBoxMemberID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
            this.wizardControl1.SuspendLayout();
            this.wizardPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDOB.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDOB.Properties)).BeginInit();
            this.wizardPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxMobile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxTelephone.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPostcode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditState.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mleAddress.Properties)).BeginInit();
            this.wizardPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // wizardControl1
            // 
            this.wizardControl1.Controls.Add(this.welcomeWizardPage1);
            this.wizardControl1.Controls.Add(this.wizardPage1);
            this.wizardControl1.Controls.Add(this.completionWizardPage1);
            this.wizardControl1.Controls.Add(this.wizardPage2);
            this.wizardControl1.Controls.Add(this.wizardPage3);
            this.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl1.Location = new System.Drawing.Point(0, 0);
            this.wizardControl1.Name = "wizardControl1";
            this.wizardControl1.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.welcomeWizardPage1,
            this.wizardPage3,
            this.wizardPage1,
            this.wizardPage2,
            this.completionWizardPage1});
            this.wizardControl1.Size = new System.Drawing.Size(677, 432);
            this.wizardControl1.Text = "";
            this.wizardControl1.FinishClick += new System.ComponentModel.CancelEventHandler(this.wizardControl1_FinishClick);
            this.wizardControl1.Click += new System.EventHandler(this.wizardControl1_Click);
            // 
            // welcomeWizardPage1
            // 
            this.welcomeWizardPage1.IntroductionText = resources.GetString("welcomeWizardPage1.IntroductionText");
            this.welcomeWizardPage1.Name = "welcomeWizardPage1";
            this.welcomeWizardPage1.Size = new System.Drawing.Size(460, 299);
            this.welcomeWizardPage1.Text = "Welcome to the New Member wizard";
            // 
            // wizardPage1
            // 
            this.wizardPage1.Controls.Add(this.groupBox3);
            this.wizardPage1.Controls.Add(this.groupBox1);
            this.wizardPage1.DescriptionText = "Enter in the Basic details for the new member such as name and address";
            this.wizardPage1.Name = "wizardPage1";
            this.wizardPage1.Size = new System.Drawing.Size(645, 287);
            this.wizardPage1.Text = "Member Details";
            this.wizardPage1.PageInit += new System.EventHandler(this.wizardPage1_PageInit);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxStudying);
            this.groupBox3.Controls.Add(this.checkBoxVolunteering);
            this.groupBox3.Controls.Add(this.checkBoxWorking);
            this.groupBox3.Controls.Add(this.checkBoxBirthdayCard);
            this.groupBox3.Controls.Add(this.checkBoxByMail);
            this.groupBox3.Controls.Add(this.checkBoxNewsletter);
            this.groupBox3.Location = new System.Drawing.Point(15, 151);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(614, 121);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mail out Details / Employment Status";
            // 
            // checkBoxStudying
            // 
            this.checkBoxStudying.AutoSize = true;
            this.checkBoxStudying.Location = new System.Drawing.Point(353, 89);
            this.checkBoxStudying.Name = "checkBoxStudying";
            this.checkBoxStudying.Size = new System.Drawing.Size(68, 17);
            this.checkBoxStudying.TabIndex = 5;
            this.checkBoxStudying.Text = "Studying";
            this.checkBoxStudying.UseVisualStyleBackColor = true;
            // 
            // checkBoxVolunteering
            // 
            this.checkBoxVolunteering.AutoSize = true;
            this.checkBoxVolunteering.Location = new System.Drawing.Point(353, 56);
            this.checkBoxVolunteering.Name = "checkBoxVolunteering";
            this.checkBoxVolunteering.Size = new System.Drawing.Size(86, 17);
            this.checkBoxVolunteering.TabIndex = 4;
            this.checkBoxVolunteering.Text = "Volunteering";
            this.checkBoxVolunteering.UseVisualStyleBackColor = true;
            // 
            // checkBoxWorking
            // 
            this.checkBoxWorking.AutoSize = true;
            this.checkBoxWorking.Location = new System.Drawing.Point(353, 23);
            this.checkBoxWorking.Name = "checkBoxWorking";
            this.checkBoxWorking.Size = new System.Drawing.Size(65, 17);
            this.checkBoxWorking.TabIndex = 3;
            this.checkBoxWorking.Text = "Working";
            this.checkBoxWorking.UseVisualStyleBackColor = true;
            // 
            // checkBoxBirthdayCard
            // 
            this.checkBoxBirthdayCard.AutoSize = true;
            this.checkBoxBirthdayCard.Location = new System.Drawing.Point(13, 92);
            this.checkBoxBirthdayCard.Name = "checkBoxBirthdayCard";
            this.checkBoxBirthdayCard.Size = new System.Drawing.Size(92, 17);
            this.checkBoxBirthdayCard.TabIndex = 2;
            this.checkBoxBirthdayCard.Text = "Birthday Card";
            this.checkBoxBirthdayCard.UseVisualStyleBackColor = true;
            // 
            // checkBoxByMail
            // 
            this.checkBoxByMail.AutoSize = true;
            this.checkBoxByMail.Location = new System.Drawing.Point(13, 59);
            this.checkBoxByMail.Name = "checkBoxByMail";
            this.checkBoxByMail.Size = new System.Drawing.Size(100, 17);
            this.checkBoxByMail.TabIndex = 1;
            this.checkBoxByMail.Text = "Receive by mail";
            this.checkBoxByMail.UseVisualStyleBackColor = true;
            // 
            // checkBoxNewsletter
            // 
            this.checkBoxNewsletter.AutoSize = true;
            this.checkBoxNewsletter.Location = new System.Drawing.Point(13, 26);
            this.checkBoxNewsletter.Name = "checkBoxNewsletter";
            this.checkBoxNewsletter.Size = new System.Drawing.Size(119, 17);
            this.checkBoxNewsletter.TabIndex = 0;
            this.checkBoxNewsletter.Text = "Receive Newsletter";
            this.checkBoxNewsletter.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxAgency);
            this.groupBox1.Controls.Add(this.buttonMap);
            this.groupBox1.Controls.Add(this.checkBoxAboriginal);
            this.groupBox1.Controls.Add(this.textBoxCOO);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBoxSex);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateEditDOB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxSurname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxFirstName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Member Details";
            // 
            // checkBoxAgency
            // 
            this.checkBoxAgency.AutoSize = true;
            this.checkBoxAgency.Location = new System.Drawing.Point(541, 87);
            this.checkBoxAgency.Name = "checkBoxAgency";
            this.checkBoxAgency.Size = new System.Drawing.Size(62, 17);
            this.checkBoxAgency.TabIndex = 12;
            this.checkBoxAgency.Text = "Agency";
            this.checkBoxAgency.UseVisualStyleBackColor = true;
            // 
            // buttonMap
            // 
            this.buttonMap.Location = new System.Drawing.Point(307, 85);
            this.buttonMap.Name = "buttonMap";
            this.buttonMap.Size = new System.Drawing.Size(75, 23);
            this.buttonMap.TabIndex = 11;
            this.buttonMap.Text = "Show MAP";
            this.buttonMap.UseVisualStyleBackColor = true;
            this.buttonMap.Click += new System.EventHandler(this.buttonMap_Click);
            // 
            // checkBoxAboriginal
            // 
            this.checkBoxAboriginal.AutoSize = true;
            this.checkBoxAboriginal.Location = new System.Drawing.Point(388, 87);
            this.checkBoxAboriginal.Name = "checkBoxAboriginal";
            this.checkBoxAboriginal.Size = new System.Drawing.Size(73, 17);
            this.checkBoxAboriginal.TabIndex = 10;
            this.checkBoxAboriginal.Text = "Aboriginal";
            this.checkBoxAboriginal.UseVisualStyleBackColor = true;
            // 
            // textBoxCOO
            // 
            this.textBoxCOO.Location = new System.Drawing.Point(109, 85);
            this.textBoxCOO.Name = "textBoxCOO";
            this.textBoxCOO.Size = new System.Drawing.Size(189, 21);
            this.textBoxCOO.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Country of Origin";
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxSex.Location = new System.Drawing.Point(388, 53);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(215, 21);
            this.comboBoxSex.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sex";
            // 
            // dateEditDOB
            // 
            this.dateEditDOB.EditValue = null;
            this.dateEditDOB.Location = new System.Drawing.Point(87, 53);
            this.dateEditDOB.Name = "dateEditDOB";
            this.dateEditDOB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDOB.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDOB.Size = new System.Drawing.Size(211, 20);
            this.dateEditDOB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date of Birth";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(388, 20);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(215, 21);
            this.textBoxSurname.TabIndex = 3;
            this.textBoxSurname.TextChanged += new System.EventHandler(this.textBoxSurname_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(87, 20);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(211, 21);
            this.textBoxFirstName.TabIndex = 1;
            this.textBoxFirstName.TextChanged += new System.EventHandler(this.textBoxFirstName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // completionWizardPage1
            // 
            this.completionWizardPage1.Name = "completionWizardPage1";
            this.completionWizardPage1.Size = new System.Drawing.Size(460, 299);
            this.completionWizardPage1.Text = "New Member Wizard";
            this.completionWizardPage1.PageInit += new System.EventHandler(this.completionWizardPage1_PageInit);
            // 
            // wizardPage2
            // 
            this.wizardPage2.Controls.Add(this.mapControl1);
            this.wizardPage2.Controls.Add(this.groupBox4);
            this.wizardPage2.Controls.Add(this.groupBox2);
            this.wizardPage2.Name = "wizardPage2";
            this.wizardPage2.Size = new System.Drawing.Size(645, 287);
            this.wizardPage2.Text = "Member Contact Page";
            this.wizardPage2.PageInit += new System.EventHandler(this.wizardPage2_PageInit);
            // 
            // mapControl1
            // 
            this.mapControl1.CenterPoint = new DevExpress.XtraMap.GeoPoint(-25.746208D, 133.576756D);
            this.mapControl1.EnableScrolling = false;
            this.mapControl1.EnableZooming = false;
            this.mapControl1.Layers.Add(this.imageLayer1);
            this.mapControl1.Location = new System.Drawing.Point(352, 149);
            this.mapControl1.MaxZoomLevel = 2D;
            this.mapControl1.MinZoomLevel = 2D;
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.NavigationPanelOptions.Visible = false;
            this.mapControl1.ShowToolTips = false;
            this.mapControl1.Size = new System.Drawing.Size(268, 131);
            this.mapControl1.TabIndex = 2;
            this.mapControl1.ZoomLevel = 2D;
            this.mapControl1.Click += new System.EventHandler(this.mapControl1_Click);
            this.mapControl1.MouseEnter += new System.EventHandler(this.mapControl1_MouseEnter);
            this.mapControl1.MouseLeave += new System.EventHandler(this.mapControl1_MouseLeave);
            this.mapControl1.MouseHover += new System.EventHandler(this.mapControl1_MouseHover);
            this.imageLayer1.DataProvider = this.bingMapDataProvider1;
            this.bingMapDataProvider1.BingKey = "Ah_GLvMCtg2uzZkeG7EEOdYRfJu0mZH0YBcLPhtqc73YBnfoeWvLrpeTwL1qVsjO";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxEmail);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.textBoxMobile);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.textBoxTelephone);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Location = new System.Drawing.Point(12, 150);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(313, 130);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Contact Details";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(113, 88);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(185, 21);
            this.textBoxEmail.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Email Address";
            // 
            // textBoxMobile
            // 
            this.textBoxMobile.Location = new System.Drawing.Point(113, 54);
            this.textBoxMobile.Name = "textBoxMobile";
            this.textBoxMobile.Properties.Mask.EditMask = "0000-000-000";
            this.textBoxMobile.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.textBoxMobile.Size = new System.Drawing.Size(185, 20);
            this.textBoxMobile.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Mobile Phone";
            // 
            // textBoxTelephone
            // 
            this.textBoxTelephone.Location = new System.Drawing.Point(113, 21);
            this.textBoxTelephone.Name = "textBoxTelephone";
            this.textBoxTelephone.Properties.Mask.EditMask = "(99) 0000-0000";
            this.textBoxTelephone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.textBoxTelephone.Size = new System.Drawing.Size(185, 20);
            this.textBoxTelephone.TabIndex = 1;
            this.textBoxTelephone.EditValueChanged += new System.EventHandler(this.textBoxTelephone_EditValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Telephone Number";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonChooseAddress);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.textBoxPostcode);
            this.groupBox2.Controls.Add(this.textBoxCountry);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBoxSuburb);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.comboBoxEditState);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxStreet);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.mleAddress);
            this.groupBox2.Location = new System.Drawing.Point(12, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(616, 130);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Address";
            // 
            // buttonChooseAddress
            // 
            this.buttonChooseAddress.Location = new System.Drawing.Point(414, 92);
            this.buttonChooseAddress.Name = "buttonChooseAddress";
            this.buttonChooseAddress.Size = new System.Drawing.Size(57, 23);
            this.buttonChooseAddress.TabIndex = 12;
            this.buttonChooseAddress.Text = "OK";
            this.buttonChooseAddress.UseVisualStyleBackColor = true;
            this.buttonChooseAddress.Click += new System.EventHandler(this.buttonChooseAddress_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(433, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Get Address";
            // 
            // textBoxPostcode
            // 
            this.textBoxPostcode.Location = new System.Drawing.Point(371, 21);
            this.textBoxPostcode.Name = "textBoxPostcode";
            this.textBoxPostcode.Properties.Mask.EditMask = "0000";
            this.textBoxPostcode.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.textBoxPostcode.Size = new System.Drawing.Size(71, 20);
            this.textBoxPostcode.TabIndex = 3;
            this.textBoxPostcode.EditValueChanged += new System.EventHandler(this.textBoxPostcode_EditValueChanged);
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Location = new System.Drawing.Point(87, 89);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(211, 21);
            this.textBoxCountry.TabIndex = 9;
            this.textBoxCountry.TextChanged += new System.EventHandler(this.textBoxCountry_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Country";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(309, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Post Code";
            // 
            // textBoxSuburb
            // 
            this.textBoxSuburb.Location = new System.Drawing.Point(498, 21);
            this.textBoxSuburb.Name = "textBoxSuburb";
            this.textBoxSuburb.Size = new System.Drawing.Size(110, 21);
            this.textBoxSuburb.TabIndex = 7;
            this.textBoxSuburb.TextChanged += new System.EventHandler(this.textBoxSuburb_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(448, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Suburb";
            // 
            // comboBoxEditState
            // 
            this.comboBoxEditState.Location = new System.Drawing.Point(87, 56);
            this.comboBoxEditState.Name = "comboBoxEditState";
            this.comboBoxEditState.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditState.Properties.Items.AddRange(new object[] {
            "Western Australia",
            "South Australia",
            "Northern Territory",
            "New South Wales",
            "Victoria",
            "Tasmania",
            "Queensland",
            "Australian Capital Territory"});
            this.comboBoxEditState.Size = new System.Drawing.Size(211, 20);
            this.comboBoxEditState.TabIndex = 5;
            this.comboBoxEditState.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditState_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "State";
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(87, 20);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(211, 21);
            this.textBoxStreet.TabIndex = 1;
            this.textBoxStreet.TextChanged += new System.EventHandler(this.textBoxStreet_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Street";
            // 
            // mleAddress
            // 
            this.mleAddress.Location = new System.Drawing.Point(312, 62);
            this.mleAddress.Margin = new System.Windows.Forms.Padding(2);
            this.mleAddress.Name = "mleAddress";
            this.mleAddress.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.mleAddress.Properties.ImmediatePopup = true;
            this.mleAddress.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.mleAddress.Properties.GetAutoCompleteList += new Lorikeet.CustomEditor.GetAutoCompleteListEventHandler(this.myLookUpEdit1_Properties_GetAutoCompleteList);
            this.mleAddress.Size = new System.Drawing.Size(296, 20);
            this.mleAddress.TabIndex = 0;
            // 
            // wizardPage3
            // 
            this.wizardPage3.Controls.Add(this.buttonCheckMemberID);
            this.wizardPage3.Controls.Add(this.textBoxMemberID);
            this.wizardPage3.Controls.Add(this.label13);
            this.wizardPage3.DescriptionText = "Checking Member ID against other ones";
            this.wizardPage3.Name = "wizardPage3";
            this.wizardPage3.Size = new System.Drawing.Size(645, 287);
            this.wizardPage3.Text = "Enter Member ID";
            this.wizardPage3.PageInit += new System.EventHandler(this.wizardPage3_PageInit);
            // 
            // buttonCheckMemberID
            // 
            this.buttonCheckMemberID.Location = new System.Drawing.Point(297, 163);
            this.buttonCheckMemberID.Name = "buttonCheckMemberID";
            this.buttonCheckMemberID.Size = new System.Drawing.Size(75, 23);
            this.buttonCheckMemberID.TabIndex = 2;
            this.buttonCheckMemberID.Text = "Check";
            this.buttonCheckMemberID.UseVisualStyleBackColor = true;
            this.buttonCheckMemberID.Click += new System.EventHandler(this.buttonCheckMemberID_Click);
            // 
            // textBoxMemberID
            // 
            this.textBoxMemberID.Location = new System.Drawing.Point(288, 112);
            this.textBoxMemberID.Name = "textBoxMemberID";
            this.textBoxMemberID.Size = new System.Drawing.Size(158, 21);
            this.textBoxMemberID.TabIndex = 1;
            this.textBoxMemberID.TextChanged += new System.EventHandler(this.textBoxMemberID_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(223, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Member ID";
            // 
            // FormNewMemberWizard
            // 
            this.AcceptButton = this.buttonChooseAddress;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 432);
            this.Controls.Add(this.wizardControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNewMemberWizard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Member Wizard";
            this.Load += new System.EventHandler(this.FormNewMemberWizard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
            this.wizardControl1.ResumeLayout(false);
            this.wizardPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDOB.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDOB.Properties)).EndInit();
            this.wizardPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxMobile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxTelephone.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPostcode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditState.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mleAddress.Properties)).EndInit();
            this.wizardPage3.ResumeLayout(false);
            this.wizardPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWizard.WizardControl wizardControl1;
        private DevExpress.XtraWizard.WelcomeWizardPage welcomeWizardPage1;
        private DevExpress.XtraWizard.WizardPage wizardPage1;
        private DevExpress.XtraWizard.CompletionWizardPage completionWizardPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.DateEdit dateEditDOB;
        private System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCOO;
        private System.Windows.Forms.CheckBox checkBoxAboriginal;
        private DevExpress.XtraWizard.WizardPage wizardPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxSuburb;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditState;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxStudying;
        private System.Windows.Forms.CheckBox checkBoxVolunteering;
        private System.Windows.Forms.CheckBox checkBoxWorking;
        private System.Windows.Forms.CheckBox checkBoxBirthdayCard;
        private System.Windows.Forms.CheckBox checkBoxByMail;
        private System.Windows.Forms.CheckBox checkBoxNewsletter;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label15;
        private DevExpress.XtraEditors.TextEdit textBoxMobile;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.TextEdit textBoxTelephone;
        private DevExpress.XtraEditors.TextEdit textBoxPostcode;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label12;
        private DevExpress.XtraWizard.WizardPage wizardPage3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonCheckMemberID;
        private System.Windows.Forms.TextBox textBoxMemberID;
        private System.Windows.Forms.Button buttonMap;
        private System.Windows.Forms.CheckBox checkBoxAgency;
        private System.Windows.Forms.Button buttonChooseAddress;
        private System.Windows.Forms.Label label14;
        private MyLookUpEdit mleAddress;
        private DevExpress.XtraMap.MapControl mapControl1;
        private DevExpress.XtraMap.ImageLayer imageLayer1;
        private DevExpress.XtraMap.BingMapDataProvider bingMapDataProvider1;
    }
}