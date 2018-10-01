namespace Lorikeet
{
    partial class FormSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSchedule));
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler3 = new DevExpress.XtraScheduler.TimeRuler();
            this.schedulerStorage1 = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.appointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lorikeetAppDataSet = new Lorikeet.LorikeetAppDataSet();
            this.resourcesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.radialMenu1 = new DevExpress.XtraBars.Ribbon.RadialMenu(this.components);
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.appointmentsTableAdapter = new Lorikeet.LorikeetAppDataSetTableAdapters.AppointmentsTableAdapter();
            this.resourcesTableAdapter = new Lorikeet.LorikeetAppDataSetTableAdapters.ResourcesTableAdapter();
            this.labelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelsTableAdapter = new Lorikeet.LorikeetAppDataSetTableAdapters.LabelsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lorikeetAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radialMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // schedulerStorage1
            // 
            this.schedulerStorage1.AppointmentDependencies.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentDependencyCustomFieldMapping("AllDay", "AllDay"));
            this.schedulerStorage1.AppointmentDependencies.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentDependencyCustomFieldMapping("Description", "Description"));
            this.schedulerStorage1.AppointmentDependencies.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentDependencyCustomFieldMapping("EndDate", "EndDate"));
            this.schedulerStorage1.AppointmentDependencies.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentDependencyCustomFieldMapping("Label", "Label"));
            this.schedulerStorage1.AppointmentDependencies.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentDependencyCustomFieldMapping("Location", "Location"));
            this.schedulerStorage1.AppointmentDependencies.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentDependencyCustomFieldMapping("RecurrenceInfo", "RecurrenceInfo"));
            this.schedulerStorage1.AppointmentDependencies.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentDependencyCustomFieldMapping("ReminderInfo", "ReminderInfo"));
            this.schedulerStorage1.AppointmentDependencies.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentDependencyCustomFieldMapping("ResourceID", "ResourceID"));
            this.schedulerStorage1.AppointmentDependencies.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentDependencyCustomFieldMapping("ResourceIDs", "ResourceIDs"));
            this.schedulerStorage1.AppointmentDependencies.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentDependencyCustomFieldMapping("Status", "Status"));
            this.schedulerStorage1.AppointmentDependencies.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentDependencyCustomFieldMapping("Subject", "Subject"));
            this.schedulerStorage1.AppointmentDependencies.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentDependencyCustomFieldMapping("TimeZoneId", "TimeZoneId"));
            this.schedulerStorage1.AppointmentDependencies.DataSource = this.appointmentsBindingSource;
            this.schedulerStorage1.AppointmentDependencies.Mappings.DependentId = "StartDate";
            this.schedulerStorage1.AppointmentDependencies.Mappings.ParentId = "UniqueID";
            this.schedulerStorage1.AppointmentDependencies.Mappings.Type = "Type";
            this.schedulerStorage1.Appointments.DataSource = this.appointmentsBindingSource;
            this.schedulerStorage1.Appointments.Mappings.AllDay = "AllDay";
            this.schedulerStorage1.Appointments.Mappings.Description = "Description";
            this.schedulerStorage1.Appointments.Mappings.End = "EndDate";
            this.schedulerStorage1.Appointments.Mappings.Label = "Label";
            this.schedulerStorage1.Appointments.Mappings.Location = "Location";
            this.schedulerStorage1.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo";
            this.schedulerStorage1.Appointments.Mappings.ReminderInfo = "ReminderInfo";
            this.schedulerStorage1.Appointments.Mappings.ResourceId = "ResourceID";
            this.schedulerStorage1.Appointments.Mappings.Start = "StartDate";
            this.schedulerStorage1.Appointments.Mappings.Status = "Status";
            this.schedulerStorage1.Appointments.Mappings.Subject = "Subject";
            this.schedulerStorage1.Appointments.Mappings.TimeZoneId = "TimeZoneId";
            this.schedulerStorage1.Appointments.Mappings.Type = "Type";
            this.schedulerStorage1.Resources.DataSource = this.resourcesBindingSource;
            this.schedulerStorage1.Resources.Mappings.Caption = "ResourceName";
            this.schedulerStorage1.Resources.Mappings.Color = "Color";
            this.schedulerStorage1.Resources.Mappings.Id = "ResourceID";
            this.schedulerStorage1.Resources.Mappings.ParentId = "UniqueID";
            // 
            // appointmentsBindingSource
            // 
            this.appointmentsBindingSource.DataMember = "Appointments";
            this.appointmentsBindingSource.DataSource = this.lorikeetAppDataSet;
            // 
            // lorikeetAppDataSet
            // 
            this.lorikeetAppDataSet.DataSetName = "LorikeetAppDataSet";
            this.lorikeetAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resourcesBindingSource
            // 
            this.resourcesBindingSource.DataMember = "Resources";
            this.resourcesBindingSource.DataSource = this.lorikeetAppDataSet;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItem1,
            this.barButtonItem2});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1579, 143);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Edit Activities";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Refresh";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Edit";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Edit";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "ribbonPage3";
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
            this.barManager1.MaxItemId = 11;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1579, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 774);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1579, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 774);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1579, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 774);
            // 
            // radialMenu1
            // 
            this.radialMenu1.Name = "radialMenu1";
            this.radialMenu1.Ribbon = this.ribbonControl1;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 143);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.schedulerControl1);
            this.splitContainerControl1.Panel2.Controls.Add(this.labelControl2);
            this.splitContainerControl1.Panel2.Controls.Add(this.listBoxControl1);
            this.splitContainerControl1.Panel2.Controls.Add(this.labelControl1);
            this.splitContainerControl1.Size = new System.Drawing.Size(1579, 631);
            this.splitContainerControl1.SplitterPosition = 1294;
            this.splitContainerControl1.TabIndex = 12;
            // 
            // schedulerControl1
            // 
            this.schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Month;
            this.schedulerControl1.DataStorage = this.schedulerStorage1;
            this.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControl1.Location = new System.Drawing.Point(0, 0);
            this.schedulerControl1.MenuManager = this.ribbonControl1;
            this.schedulerControl1.Name = "schedulerControl1";
            this.schedulerControl1.OptionsBehavior.SelectOnRightClick = true;
            this.schedulerControl1.OptionsCustomization.AllowAppointmentDelete = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.schedulerControl1.OptionsCustomization.AllowAppointmentDragBetweenResources = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.schedulerControl1.OptionsCustomization.AllowAppointmentEdit = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.schedulerControl1.OptionsCustomization.AllowAppointmentMultiSelect = false;
            this.schedulerControl1.OptionsCustomization.AllowAppointmentResize = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.schedulerControl1.Size = new System.Drawing.Size(1294, 631);
            this.schedulerControl1.Start = new System.DateTime(2017, 11, 13, 0, 0, 0, 0);
            this.schedulerControl1.TabIndex = 13;
            this.schedulerControl1.Text = "schedulerControl1";
            this.schedulerControl1.Views.AgendaView.Enabled = false;
            this.schedulerControl1.Views.DayView.Enabled = false;
            this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl1.Views.FullWeekView.TimeRulers.Add(timeRuler2);
            this.schedulerControl1.Views.GanttView.Enabled = false;
            this.schedulerControl1.Views.TimelineView.Enabled = false;
            this.schedulerControl1.Views.WeekView.Enabled = false;
            this.schedulerControl1.Views.WorkWeekView.Enabled = false;
            this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler3);
            this.schedulerControl1.SelectionChanged += new System.EventHandler(this.schedulerControl1_SelectionChanged);
            this.schedulerControl1.PopupMenuShowing += new DevExpress.XtraScheduler.PopupMenuShowingEventHandler(this.schedulerControl1_PopupMenuShowing);
            this.schedulerControl1.CustomizeAppointmentFlyout += new DevExpress.XtraScheduler.CustomizeAppointmentFlyoutEventHandler(this.schedulerControl1_CustomizeAppointmentFlyout);
            this.schedulerControl1.AppointmentFlyoutShowing += new DevExpress.XtraScheduler.AppointmentFlyoutShowingEventHandler(this.schedulerControl1_AppointmentFlyoutShowing);
            this.schedulerControl1.EditAppointmentFormShowing += new DevExpress.XtraScheduler.AppointmentFormEventHandler(this.schedulerControl1_EditAppointmentFormShowing_1);
            this.schedulerControl1.Click += new System.EventHandler(this.schedulerControl1_Click);
            this.schedulerControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.schedulerControl1_MouseMove);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(1, 30);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(38, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Label1";
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.listBoxControl1.Location = new System.Drawing.Point(1, 52);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(265, 573);
            this.listBoxControl1.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(1, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Label1";
            // 
            // appointmentsTableAdapter
            // 
            this.appointmentsTableAdapter.ClearBeforeFill = true;
            // 
            // resourcesTableAdapter
            // 
            this.resourcesTableAdapter.ClearBeforeFill = true;
            // 
            // labelsBindingSource
            // 
            this.labelsBindingSource.DataMember = "Labels";
            this.labelsBindingSource.DataSource = this.lorikeetAppDataSet;
            // 
            // labelsTableAdapter
            // 
            this.labelsTableAdapter.ClearBeforeFill = true;
            // 
            // FormSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 797);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSchedule";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Schedule Activities";
            this.Load += new System.EventHandler(this.FormSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lorikeetAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radialMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraScheduler.SchedulerStorage schedulerStorage1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Ribbon.RadialMenu radialMenu1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private Lorikeet.LorikeetAppDataSet lorikeetAppDataSet;
        private System.Windows.Forms.BindingSource appointmentsBindingSource;
        private Lorikeet.LorikeetAppDataSetTableAdapters.AppointmentsTableAdapter appointmentsTableAdapter;
        private System.Windows.Forms.BindingSource resourcesBindingSource;
        private Lorikeet.LorikeetAppDataSetTableAdapters.ResourcesTableAdapter resourcesTableAdapter;
        private System.Windows.Forms.BindingSource labelsBindingSource;
        private Lorikeet.LorikeetAppDataSetTableAdapters.LabelsTableAdapter labelsTableAdapter;
    }
}