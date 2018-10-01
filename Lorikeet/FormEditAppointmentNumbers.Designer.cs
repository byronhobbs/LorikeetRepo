namespace Lorikeet
{
    partial class FormEditAppointmentNumbers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditAppointmentNumbers));
            this.label1 = new System.Windows.Forms.Label();
            this.dateEditEditActivity = new DevExpress.XtraEditors.DateEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.comboBoxEditLabels = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonAddNext = new System.Windows.Forms.Button();
            this.buttonPrevNum = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditEditActivity.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditEditActivity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditLabels.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date To Edit Activity Numbers";
            // 
            // dateEditEditActivity
            // 
            this.dateEditEditActivity.EditValue = null;
            this.dateEditEditActivity.Location = new System.Drawing.Point(167, 6);
            this.dateEditEditActivity.Name = "dateEditEditActivity";
            this.dateEditEditActivity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditEditActivity.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditEditActivity.Properties.Mask.EditMask = "D";
            this.dateEditEditActivity.Size = new System.Drawing.Size(170, 20);
            this.dateEditEditActivity.TabIndex = 1;
            this.dateEditEditActivity.TextChanged += new System.EventHandler(this.dateEditEditActivity_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Activity Number";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(167, 38);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(170, 20);
            this.textBoxNumber.TabIndex = 3;
            // 
            // comboBoxEditLabels
            // 
            this.comboBoxEditLabels.Location = new System.Drawing.Point(167, 74);
            this.comboBoxEditLabels.Name = "comboBoxEditLabels";
            this.comboBoxEditLabels.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditLabels.Properties.Sorted = true;
            this.comboBoxEditLabels.Size = new System.Drawing.Size(170, 20);
            this.comboBoxEditLabels.TabIndex = 4;
            this.comboBoxEditLabels.SelectedValueChanged += new System.EventHandler(this.comboBoxEditLabels_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Activity";
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(12, 117);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 6;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonAddNext
            // 
            this.buttonAddNext.Location = new System.Drawing.Point(307, 113);
            this.buttonAddNext.Name = "buttonAddNext";
            this.buttonAddNext.Padding = new System.Windows.Forms.Padding(1, 2, 2, 2);
            this.buttonAddNext.Size = new System.Drawing.Size(30, 30);
            this.buttonAddNext.TabIndex = 7;
            this.buttonAddNext.Text = ">>";
            this.buttonAddNext.UseVisualStyleBackColor = true;
            this.buttonAddNext.Click += new System.EventHandler(this.buttonAddNext_Click);
            // 
            // buttonPrevNum
            // 
            this.buttonPrevNum.Location = new System.Drawing.Point(271, 113);
            this.buttonPrevNum.Name = "buttonPrevNum";
            this.buttonPrevNum.Padding = new System.Windows.Forms.Padding(1, 2, 2, 2);
            this.buttonPrevNum.Size = new System.Drawing.Size(30, 30);
            this.buttonPrevNum.TabIndex = 8;
            this.buttonPrevNum.Text = "<<";
            this.buttonPrevNum.UseVisualStyleBackColor = true;
            this.buttonPrevNum.Click += new System.EventHandler(this.buttonPrevNum_Click);
            // 
            // FormEditAppointmentNumbers
            // 
            this.AcceptButton = this.buttonAddNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(347, 151);
            this.Controls.Add(this.buttonPrevNum);
            this.Controls.Add(this.buttonAddNext);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxEditLabels);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateEditEditActivity);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEditAppointmentNumbers";
            this.Text = "Edit Appointment Numbers";
            this.Load += new System.EventHandler(this.FormEditAppointmentNumbers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dateEditEditActivity.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditEditActivity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditLabels.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit dateEditEditActivity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNumber;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditLabels;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonAddNext;
        private System.Windows.Forms.Button buttonPrevNum;
    }
}