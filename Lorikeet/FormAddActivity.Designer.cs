namespace Lorikeet
{
    partial class FormAddActivity
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxOShortcut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCShortcut = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAddActivity = new System.Windows.Forms.TextBox();
            this.buttonChangeShortcut = new System.Windows.Forms.Button();
            this.buttonAddShortcut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Activity Shortcut shown in Spreadsheet";
            // 
            // textBoxOShortcut
            // 
            this.textBoxOShortcut.Location = new System.Drawing.Point(12, 25);
            this.textBoxOShortcut.Name = "textBoxOShortcut";
            this.textBoxOShortcut.Size = new System.Drawing.Size(192, 20);
            this.textBoxOShortcut.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Activity Shortcut to change to";
            // 
            // textBoxCShortcut
            // 
            this.textBoxCShortcut.Location = new System.Drawing.Point(12, 74);
            this.textBoxCShortcut.Name = "textBoxCShortcut";
            this.textBoxCShortcut.Size = new System.Drawing.Size(192, 20);
            this.textBoxCShortcut.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Add Activity";
            // 
            // textBoxAddActivity
            // 
            this.textBoxAddActivity.Location = new System.Drawing.Point(12, 126);
            this.textBoxAddActivity.Name = "textBoxAddActivity";
            this.textBoxAddActivity.Size = new System.Drawing.Size(192, 20);
            this.textBoxAddActivity.TabIndex = 5;
            // 
            // buttonChangeShortcut
            // 
            this.buttonChangeShortcut.Location = new System.Drawing.Point(210, 74);
            this.buttonChangeShortcut.Name = "buttonChangeShortcut";
            this.buttonChangeShortcut.Size = new System.Drawing.Size(75, 23);
            this.buttonChangeShortcut.TabIndex = 6;
            this.buttonChangeShortcut.Text = "Change";
            this.buttonChangeShortcut.UseVisualStyleBackColor = true;
            this.buttonChangeShortcut.Click += new System.EventHandler(this.buttonChangeShortcut_Click);
            // 
            // buttonAddShortcut
            // 
            this.buttonAddShortcut.Location = new System.Drawing.Point(210, 126);
            this.buttonAddShortcut.Name = "buttonAddShortcut";
            this.buttonAddShortcut.Size = new System.Drawing.Size(75, 23);
            this.buttonAddShortcut.TabIndex = 7;
            this.buttonAddShortcut.Text = "Add";
            this.buttonAddShortcut.UseVisualStyleBackColor = true;
            this.buttonAddShortcut.Click += new System.EventHandler(this.buttonAddShortcut_Click);
            // 
            // FormAddActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 170);
            this.Controls.Add(this.buttonAddShortcut);
            this.Controls.Add(this.buttonChangeShortcut);
            this.Controls.Add(this.textBoxAddActivity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCShortcut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxOShortcut);
            this.Controls.Add(this.label1);
            this.Name = "FormAddActivity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Activity";
            this.Load += new System.EventHandler(this.FormAddActivity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOShortcut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCShortcut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAddActivity;
        private System.Windows.Forms.Button buttonChangeShortcut;
        private System.Windows.Forms.Button buttonAddShortcut;
    }
}