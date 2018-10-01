namespace Lorikeet
{
    partial class FormAddEditLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddEditLogin));
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveAndClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveAndNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReset = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbiAddUser = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDeleteUser = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEditUser = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bbiOK = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancel = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgOKCancel = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEnterPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxReEnterPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPIN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLoginName = new System.Windows.Forms.TextBox();
            this.tableAdapterManager1 = new Lorikeet.LorikeetAppDataSetTableAdapters.TableAdapterManager();
            this.epPasswordNotValid = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPasswordValid = new System.Windows.Forms.ErrorProvider(this.components);
            this.comboBoxAccess = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPasswordNotValid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPasswordValid)).BeginInit();
            this.SuspendLayout();
            // 
            // mainRibbonControl
            // 
            this.mainRibbonControl.ExpandCollapseItem.Id = 0;
            this.mainRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbonControl.ExpandCollapseItem,
            this.bbiSave,
            this.bbiSaveAndClose,
            this.bbiSaveAndNew,
            this.bbiReset,
            this.bbiDelete,
            this.bbiClose,
            this.bbiAddUser,
            this.bbiDeleteUser,
            this.bbiEditUser,
            this.barButtonItem1,
            this.bbiOK,
            this.bbiCancel});
            this.mainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonControl.MaxItemId = 18;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.Size = new System.Drawing.Size(590, 143);
            this.mainRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "Save";
            this.bbiSave.Id = 2;
            this.bbiSave.ImageOptions.ImageUri.Uri = "Save";
            this.bbiSave.Name = "bbiSave";
            // 
            // bbiSaveAndClose
            // 
            this.bbiSaveAndClose.Caption = "Save And Close";
            this.bbiSaveAndClose.Id = 3;
            this.bbiSaveAndClose.ImageOptions.ImageUri.Uri = "SaveAndClose";
            this.bbiSaveAndClose.Name = "bbiSaveAndClose";
            // 
            // bbiSaveAndNew
            // 
            this.bbiSaveAndNew.Caption = "Save And New";
            this.bbiSaveAndNew.Id = 4;
            this.bbiSaveAndNew.ImageOptions.ImageUri.Uri = "SaveAndNew";
            this.bbiSaveAndNew.Name = "bbiSaveAndNew";
            // 
            // bbiReset
            // 
            this.bbiReset.Caption = "Reset Changes";
            this.bbiReset.Id = 5;
            this.bbiReset.ImageOptions.ImageUri.Uri = "Reset";
            this.bbiReset.Name = "bbiReset";
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Delete";
            this.bbiDelete.Id = 6;
            this.bbiDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiDelete.Name = "bbiDelete";
            // 
            // bbiClose
            // 
            this.bbiClose.Caption = "Close";
            this.bbiClose.Id = 7;
            this.bbiClose.ImageOptions.ImageUri.Uri = "Close";
            this.bbiClose.Name = "bbiClose";
            this.bbiClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiClose_ItemClick);
            // 
            // bbiAddUser
            // 
            this.bbiAddUser.Caption = "Add User";
            this.bbiAddUser.Id = 10;
            this.bbiAddUser.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiAddUser.ImageOptions.Image")));
            this.bbiAddUser.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiAddUser.ImageOptions.LargeImage")));
            this.bbiAddUser.Name = "bbiAddUser";
            this.bbiAddUser.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAddUser_ItemClick);
            // 
            // bbiDeleteUser
            // 
            this.bbiDeleteUser.Id = 17;
            this.bbiDeleteUser.Name = "bbiDeleteUser";
            // 
            // bbiEditUser
            // 
            this.bbiEditUser.Caption = "Edit User Password";
            this.bbiEditUser.Id = 12;
            this.bbiEditUser.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiEditUser.ImageOptions.Image")));
            this.bbiEditUser.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiEditUser.ImageOptions.LargeImage")));
            this.bbiEditUser.Name = "bbiEditUser";
            this.bbiEditUser.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEditUser_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 14;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // bbiOK
            // 
            this.bbiOK.Caption = "OK";
            this.bbiOK.Id = 15;
            this.bbiOK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiOK.ImageOptions.Image")));
            this.bbiOK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiOK.ImageOptions.LargeImage")));
            this.bbiOK.Name = "bbiOK";
            this.bbiOK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiOK_ItemClick);
            // 
            // bbiCancel
            // 
            this.bbiCancel.Caption = "Cancel";
            this.bbiCancel.Id = 16;
            this.bbiCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiCancel.ImageOptions.Image")));
            this.bbiCancel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiCancel.ImageOptions.LargeImage")));
            this.bbiCancel.Name = "bbiCancel";
            this.bbiCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCancel_ItemClick);
            // 
            // mainRibbonPage
            // 
            this.mainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.mainRibbonPageGroup,
            this.ribbonPageGroup1,
            this.rpgOKCancel});
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
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiAddUser);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiEditUser);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Add User";
            // 
            // rpgOKCancel
            // 
            this.rpgOKCancel.ItemLinks.Add(this.bbiOK);
            this.rpgOKCancel.ItemLinks.Add(this.bbiCancel);
            this.rpgOKCancel.Name = "rpgOKCancel";
            this.rpgOKCancel.Text = "OK / Cancel";
            this.rpgOKCancel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter New Password:";
            // 
            // textBoxEnterPass
            // 
            this.textBoxEnterPass.Location = new System.Drawing.Point(144, 230);
            this.textBoxEnterPass.Name = "textBoxEnterPass";
            this.textBoxEnterPass.PasswordChar = '*';
            this.textBoxEnterPass.Size = new System.Drawing.Size(222, 21);
            this.textBoxEnterPass.TabIndex = 5;
            this.textBoxEnterPass.UseSystemPasswordChar = true;
            this.textBoxEnterPass.TextChanged += new System.EventHandler(this.textBoxEnterPass_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Re-enter New Password";
            // 
            // textBoxReEnterPass
            // 
            this.textBoxReEnterPass.Location = new System.Drawing.Point(144, 270);
            this.textBoxReEnterPass.Name = "textBoxReEnterPass";
            this.textBoxReEnterPass.PasswordChar = '*';
            this.textBoxReEnterPass.Size = new System.Drawing.Size(222, 21);
            this.textBoxReEnterPass.TabIndex = 7;
            this.textBoxReEnterPass.UseSystemPasswordChar = true;
            this.textBoxReEnterPass.TextChanged += new System.EventHandler(this.textBoxReEnterPass_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "User Name";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(144, 155);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(222, 21);
            this.textBoxUserName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Pin Number";
            // 
            // textBoxPIN
            // 
            this.textBoxPIN.Location = new System.Drawing.Point(263, 307);
            this.textBoxPIN.Name = "textBoxPIN";
            this.textBoxPIN.Size = new System.Drawing.Size(103, 21);
            this.textBoxPIN.TabIndex = 11;
            this.textBoxPIN.TextChanged += new System.EventHandler(this.textBoxPIN_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Access Level";
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.Location = new System.Drawing.Point(390, 155);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(186, 173);
            this.listBoxUsers.TabIndex = 12;
            this.listBoxUsers.SelectedIndexChanged += new System.EventHandler(this.listBoxUsers_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Login Name";
            // 
            // textBoxLoginName
            // 
            this.textBoxLoginName.Location = new System.Drawing.Point(144, 191);
            this.textBoxLoginName.Name = "textBoxLoginName";
            this.textBoxLoginName.Size = new System.Drawing.Size(222, 21);
            this.textBoxLoginName.TabIndex = 3;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AppointmentMemberTableAdapter = null;
            this.tableAdapterManager1.AppointmentsNumbersTableAdapter = null;
            this.tableAdapterManager1.AppointmentsTableAdapter = null;
            this.tableAdapterManager1.AttendanceNumbersTableAdapter = null;
            this.tableAdapterManager1.AttendanceTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.ContactTableAdapter = null;
            this.tableAdapterManager1.DebitSystemTableAdapter = null;
            this.tableAdapterManager1.DiagnosisNameTableAdapter = null;
            this.tableAdapterManager1.DiagnosisTableAdapter = null;
            this.tableAdapterManager1.GuestTableAdapter = null;
            this.tableAdapterManager1.LabelsTableAdapter = null;
            this.tableAdapterManager1.LoginTableAdapter = null;
            this.tableAdapterManager1.LogTableAdapter = null;
            this.tableAdapterManager1.LunchTableAdapter = null;
            this.tableAdapterManager1.MedicationNameTableAdapter = null;
            this.tableAdapterManager1.MedicationTableAdapter = null;
            this.tableAdapterManager1.MemberTableAdapter = null;
            this.tableAdapterManager1.MenuTableAdapter = null;
            this.tableAdapterManager1.NoteTableAdapter = null;
            this.tableAdapterManager1.PictureTableAdapter = null;
            this.tableAdapterManager1.ResourcesTableAdapter = null;
            this.tableAdapterManager1.SignInTableAdapter = null;
            this.tableAdapterManager1.StaffTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Lorikeet.LorikeetAppDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // epPasswordNotValid
            // 
            this.epPasswordNotValid.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epPasswordNotValid.ContainerControl = this;
            // 
            // epPasswordValid
            // 
            this.epPasswordValid.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epPasswordValid.ContainerControl = this;
            this.epPasswordValid.Icon = ((System.Drawing.Icon)(resources.GetObject("epPasswordValid.Icon")));
            // 
            // comboBoxAccess
            // 
            this.comboBoxAccess.FormattingEnabled = true;
            this.comboBoxAccess.Location = new System.Drawing.Point(144, 307);
            this.comboBoxAccess.Name = "comboBoxAccess";
            this.comboBoxAccess.Size = new System.Drawing.Size(50, 21);
            this.comboBoxAccess.TabIndex = 9;
            // 
            // FormAddEditLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(590, 339);
            this.Controls.Add(this.comboBoxAccess);
            this.Controls.Add(this.textBoxLoginName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBoxUsers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPIN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxReEnterPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxEnterPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainRibbonControl);
            this.Name = "FormAddEditLogin";
            this.Ribbon = this.mainRibbonControl;
            this.Text = "Add / Edit Users";
            this.Load += new System.EventHandler(this.FormAddEditLogin_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormAddEditLogin_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPasswordNotValid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPasswordValid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl mainRibbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage mainRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup mainRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarButtonItem bbiSaveAndClose;
        private DevExpress.XtraBars.BarButtonItem bbiSaveAndNew;
        private DevExpress.XtraBars.BarButtonItem bbiReset;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiClose;
        private DevExpress.XtraBars.BarButtonItem bbiAddUser;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiDeleteUser;
        private DevExpress.XtraBars.BarButtonItem bbiEditUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEnterPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxReEnterPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPIN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxUsers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLoginName;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private LorikeetAppDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private DevExpress.XtraBars.BarButtonItem bbiOK;
        private DevExpress.XtraBars.BarButtonItem bbiCancel;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgOKCancel;
        private System.Windows.Forms.ErrorProvider epPasswordNotValid;
        private System.Windows.Forms.ErrorProvider epPasswordValid;
        private System.Windows.Forms.ComboBox comboBoxAccess;
    }
}