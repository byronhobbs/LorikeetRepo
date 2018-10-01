namespace Lorikeet
{
    partial class FormChooseMember
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
            this.listBoxMemberName = new System.Windows.Forms.ListBox();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.listBoxAllMemberNames = new System.Windows.Forms.ListBox();
            this.textBoxMName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMNameToChangeTo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxMemberName
            // 
            this.listBoxMemberName.FormattingEnabled = true;
            this.listBoxMemberName.Location = new System.Drawing.Point(352, 33);
            this.listBoxMemberName.Name = "listBoxMemberName";
            this.listBoxMemberName.Size = new System.Drawing.Size(231, 446);
            this.listBoxMemberName.TabIndex = 1;
            this.listBoxMemberName.SelectedIndexChanged += new System.EventHandler(this.listBoxMemberName_SelectedIndexChanged);
            // 
            // buttonChoose
            // 
            this.buttonChoose.Location = new System.Drawing.Point(261, 485);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(75, 23);
            this.buttonChoose.TabIndex = 2;
            this.buttonChoose.Text = "OK";
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
            // 
            // listBoxAllMemberNames
            // 
            this.listBoxAllMemberNames.FormattingEnabled = true;
            this.listBoxAllMemberNames.Location = new System.Drawing.Point(15, 111);
            this.listBoxAllMemberNames.Name = "listBoxAllMemberNames";
            this.listBoxAllMemberNames.Size = new System.Drawing.Size(321, 368);
            this.listBoxAllMemberNames.TabIndex = 3;
            this.listBoxAllMemberNames.SelectedIndexChanged += new System.EventHandler(this.listBoxAllMemberNames_SelectedIndexChanged);
            // 
            // textBoxMName
            // 
            this.textBoxMName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxMName.Location = new System.Drawing.Point(18, 24);
            this.textBoxMName.Name = "textBoxMName";
            this.textBoxMName.ReadOnly = true;
            this.textBoxMName.Size = new System.Drawing.Size(318, 20);
            this.textBoxMName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Here is a List of All the Members";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Here is a List of Possible Member Names";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Member Name shown in the Spreadsheet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Member Name to be changed to";
            // 
            // textBoxMNameToChangeTo
            // 
            this.textBoxMNameToChangeTo.Location = new System.Drawing.Point(18, 66);
            this.textBoxMNameToChangeTo.Name = "textBoxMNameToChangeTo";
            this.textBoxMNameToChangeTo.Size = new System.Drawing.Size(318, 20);
            this.textBoxMNameToChangeTo.TabIndex = 9;
            this.textBoxMNameToChangeTo.TextChanged += new System.EventHandler(this.textBoxMNameToChangeTo_TextChanged);
            // 
            // FormChooseMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 514);
            this.Controls.Add(this.textBoxMNameToChangeTo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMName);
            this.Controls.Add(this.listBoxAllMemberNames);
            this.Controls.Add(this.buttonChoose);
            this.Controls.Add(this.listBoxMemberName);
            this.Name = "FormChooseMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Choose Member";
            this.Load += new System.EventHandler(this.FormChooseMember_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxMemberName;
        private System.Windows.Forms.Button buttonChoose;
        private System.Windows.Forms.ListBox listBoxAllMemberNames;
        private System.Windows.Forms.TextBox textBoxMName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMNameToChangeTo;
    }
}