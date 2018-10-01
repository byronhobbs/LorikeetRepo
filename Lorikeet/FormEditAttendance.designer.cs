namespace Lorikeet
{
    partial class FormEditAttendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditAttendance));
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveAndClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReset = new DevExpress.XtraBars.BarButtonItem();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.listBoxControlMembers = new DevExpress.XtraEditors.ListBoxControl();
            this.listBoxControlMembersToAdd = new DevExpress.XtraEditors.ListBoxControl();
            this.ButtonAddMember = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonRemoveMember = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonClearMembers = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMemberFilter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControlMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControlMembersToAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // mainRibbonControl
            // 
            this.mainRibbonControl.ExpandCollapseItem.Id = 0;
            this.mainRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbonControl.ExpandCollapseItem,
            this.bbiSave,
            this.bbiSaveAndClose,
            this.bbiReset,
            this.bbiClose});
            this.mainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonControl.MaxItemId = 10;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.Size = new System.Drawing.Size(528, 143);
            this.mainRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            this.mainRibbonControl.Click += new System.EventHandler(this.mainRibbonControl_Click);
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "Save";
            this.bbiSave.Id = 2;
            this.bbiSave.ImageOptions.ImageUri.Uri = "Save";
            this.bbiSave.Name = "bbiSave";
            this.bbiSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSave_ItemClick);
            // 
            // bbiSaveAndClose
            // 
            this.bbiSaveAndClose.Caption = "Save And Close";
            this.bbiSaveAndClose.Id = 3;
            this.bbiSaveAndClose.ImageOptions.ImageUri.Uri = "SaveAndClose";
            this.bbiSaveAndClose.Name = "bbiSaveAndClose";
            this.bbiSaveAndClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSaveAndClose_ItemClick);
            // 
            // bbiReset
            // 
            this.bbiReset.Caption = "Reset Changes";
            this.bbiReset.Id = 5;
            this.bbiReset.ImageOptions.ImageUri.Uri = "Reset";
            this.bbiReset.Name = "bbiReset";
            this.bbiReset.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiReset_ItemClick);
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
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiSaveAndClose);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiReset);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiClose);
            this.mainRibbonPageGroup.Name = "mainRibbonPageGroup";
            this.mainRibbonPageGroup.ShowCaptionButton = false;
            this.mainRibbonPageGroup.Text = "Tasks";
            // 
            // listBoxControlMembers
            // 
            this.listBoxControlMembers.Cursor = System.Windows.Forms.Cursors.Default;
            this.listBoxControlMembers.Location = new System.Drawing.Point(12, 212);
            this.listBoxControlMembers.Name = "listBoxControlMembers";
            this.listBoxControlMembers.Size = new System.Drawing.Size(219, 398);
            this.listBoxControlMembers.TabIndex = 2;
            // 
            // listBoxControlMembersToAdd
            // 
            this.listBoxControlMembersToAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.listBoxControlMembersToAdd.Location = new System.Drawing.Point(275, 154);
            this.listBoxControlMembersToAdd.Name = "listBoxControlMembersToAdd";
            this.listBoxControlMembersToAdd.Size = new System.Drawing.Size(238, 456);
            this.listBoxControlMembersToAdd.TabIndex = 3;
            // 
            // ButtonAddMember
            // 
            this.ButtonAddMember.Location = new System.Drawing.Point(237, 269);
            this.ButtonAddMember.Name = "ButtonAddMember";
            this.ButtonAddMember.Size = new System.Drawing.Size(32, 32);
            this.ButtonAddMember.TabIndex = 4;
            this.ButtonAddMember.Text = ">";
            this.ButtonAddMember.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // ButtonRemoveMember
            // 
            this.ButtonRemoveMember.Location = new System.Drawing.Point(237, 307);
            this.ButtonRemoveMember.Name = "ButtonRemoveMember";
            this.ButtonRemoveMember.Size = new System.Drawing.Size(32, 32);
            this.ButtonRemoveMember.TabIndex = 5;
            this.ButtonRemoveMember.Text = "<";
            this.ButtonRemoveMember.Click += new System.EventHandler(this.ButtonRemoveMember_Click);
            // 
            // ButtonClearMembers
            // 
            this.ButtonClearMembers.Location = new System.Drawing.Point(237, 345);
            this.ButtonClearMembers.Name = "ButtonClearMembers";
            this.ButtonClearMembers.Size = new System.Drawing.Size(32, 32);
            this.ButtonClearMembers.TabIndex = 6;
            this.ButtonClearMembers.Text = "<<";
            this.ButtonClearMembers.Click += new System.EventHandler(this.ButtonClearMembers_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(51, 154);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.ReadOnly = true;
            this.textBoxDate.Size = new System.Drawing.Size(180, 21);
            this.textBoxDate.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Filter";
            // 
            // textBoxMemberFilter
            // 
            this.textBoxMemberFilter.Location = new System.Drawing.Point(51, 185);
            this.textBoxMemberFilter.Name = "textBoxMemberFilter";
            this.textBoxMemberFilter.Size = new System.Drawing.Size(180, 21);
            this.textBoxMemberFilter.TabIndex = 14;
            this.textBoxMemberFilter.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FormEditAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(528, 622);
            this.Controls.Add(this.textBoxMemberFilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonClearMembers);
            this.Controls.Add(this.ButtonRemoveMember);
            this.Controls.Add(this.ButtonAddMember);
            this.Controls.Add(this.listBoxControlMembersToAdd);
            this.Controls.Add(this.listBoxControlMembers);
            this.Controls.Add(this.mainRibbonControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormEditAttendance";
            this.Ribbon = this.mainRibbonControl;
            this.Text = "Attendance";
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControlMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControlMembersToAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl mainRibbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage mainRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup mainRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarButtonItem bbiSaveAndClose;
        private DevExpress.XtraBars.BarButtonItem bbiReset;
        private DevExpress.XtraBars.BarButtonItem bbiClose;
        private DevExpress.XtraEditors.ListBoxControl listBoxControlMembers;
        private DevExpress.XtraEditors.ListBoxControl listBoxControlMembersToAdd;
        private DevExpress.XtraEditors.SimpleButton ButtonAddMember;
        private DevExpress.XtraEditors.SimpleButton ButtonRemoveMember;
        private DevExpress.XtraEditors.SimpleButton ButtonClearMembers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMemberFilter;
    }
}