namespace Lorikeet
{
    partial class FormSelectMonths
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSelectMonths));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.radioGroupMonths = new DevExpress.XtraEditors.RadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupMonths.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioGroupMonths
            // 
            this.radioGroupMonths.Location = new System.Drawing.Point(12, 12);
            this.radioGroupMonths.Name = "radioGroupMonths";
            this.radioGroupMonths.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.radioGroupMonths.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroupMonths.Properties.Columns = 1;
            this.radioGroupMonths.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.radioGroupMonths.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "January - February"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "March - April"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(3, "May - June"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(4, "July - August"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(5, "September - October"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(6, "November - December")});
            this.radioGroupMonths.Size = new System.Drawing.Size(156, 308);
            this.radioGroupMonths.TabIndex = 2;
            // 
            // FormSelectMonths
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 357);
            this.Controls.Add(this.radioGroupMonths);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormSelectMonths";
            this.Text = "Select";
            this.Load += new System.EventHandler(this.FormSelectMonths_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupMonths.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private DevExpress.XtraEditors.RadioGroup radioGroupMonths;
    }
}