namespace Lorikeet
{
    partial class FormEditAttendanceNumbers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditAttendanceNumbers));
            this.label1 = new System.Windows.Forms.Label();
            this.dateEditEditAttendance = new DevExpress.XtraEditors.DateEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.buttonAddClose = new System.Windows.Forms.Button();
            this.buttonAddNext = new System.Windows.Forms.Button();
            this.buttonPreviousDay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditEditAttendance.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditEditAttendance.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date To Edit Attendance";
            // 
            // dateEditEditAttendance
            // 
            this.dateEditEditAttendance.EditValue = null;
            this.dateEditEditAttendance.Location = new System.Drawing.Point(144, 10);
            this.dateEditEditAttendance.Name = "dateEditEditAttendance";
            this.dateEditEditAttendance.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditEditAttendance.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditEditAttendance.Properties.Mask.EditMask = "D";
            this.dateEditEditAttendance.Size = new System.Drawing.Size(158, 20);
            this.dateEditEditAttendance.TabIndex = 1;
            this.dateEditEditAttendance.TextChanged += new System.EventHandler(this.dateEditEditAttendance_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Attendance Number";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(144, 45);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(158, 20);
            this.textBoxNumber.TabIndex = 3;
            // 
            // buttonAddClose
            // 
            this.buttonAddClose.Location = new System.Drawing.Point(16, 78);
            this.buttonAddClose.Name = "buttonAddClose";
            this.buttonAddClose.Size = new System.Drawing.Size(72, 23);
            this.buttonAddClose.TabIndex = 4;
            this.buttonAddClose.Text = "Close";
            this.buttonAddClose.UseVisualStyleBackColor = true;
            this.buttonAddClose.Click += new System.EventHandler(this.buttonAddClose_Click);
            // 
            // buttonAddNext
            // 
            this.buttonAddNext.Location = new System.Drawing.Point(272, 71);
            this.buttonAddNext.Name = "buttonAddNext";
            this.buttonAddNext.Size = new System.Drawing.Size(30, 30);
            this.buttonAddNext.TabIndex = 5;
            this.buttonAddNext.Text = ">>";
            this.buttonAddNext.UseVisualStyleBackColor = true;
            this.buttonAddNext.Click += new System.EventHandler(this.buttonAddNext_Click);
            // 
            // buttonPreviousDay
            // 
            this.buttonPreviousDay.Location = new System.Drawing.Point(236, 71);
            this.buttonPreviousDay.Name = "buttonPreviousDay";
            this.buttonPreviousDay.Size = new System.Drawing.Size(30, 30);
            this.buttonPreviousDay.TabIndex = 8;
            this.buttonPreviousDay.Text = "<<";
            this.buttonPreviousDay.UseVisualStyleBackColor = true;
            this.buttonPreviousDay.Click += new System.EventHandler(this.buttonPreviousDay_Click);
            // 
            // FormEditAttendanceNumbers
            // 
            this.AcceptButton = this.buttonAddNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 121);
            this.Controls.Add(this.buttonPreviousDay);
            this.Controls.Add(this.buttonAddNext);
            this.Controls.Add(this.buttonAddClose);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateEditEditAttendance);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormEditAttendanceNumbers";
            this.Text = "Edit Attendance Numbers";
            this.Load += new System.EventHandler(this.FormEditAttendanceNumbers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dateEditEditAttendance.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditEditAttendance.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit dateEditEditAttendance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Button buttonAddClose;
        private System.Windows.Forms.Button buttonAddNext;
        private System.Windows.Forms.Button buttonPreviousDay;
    }
}