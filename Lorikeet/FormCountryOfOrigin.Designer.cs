namespace Lorikeet
{
    partial class FormCountryOfOrigin
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.imageLayer1 = new DevExpress.XtraMap.ImageLayer();
            this.bingMapDataProvider = new DevExpress.XtraMap.BingMapDataProvider();
            this.informationLayer1 = new DevExpress.XtraMap.InformationLayer();
            this.bingGeocodeDataProvider1 = new DevExpress.XtraMap.BingGeocodeDataProvider();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBoxCountryName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.mapControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.buttonCancel);
            this.splitContainerControl1.Panel2.Controls.Add(this.buttonOK);
            this.splitContainerControl1.Panel2.Controls.Add(this.textBoxCountryName);
            this.splitContainerControl1.Panel2.Controls.Add(this.label1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1161, 651);
            this.splitContainerControl1.SplitterPosition = 616;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // mapControl1
            // 
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.Layers.Add(this.imageLayer1);
            this.mapControl1.Layers.Add(this.informationLayer1);
            this.mapControl1.Location = new System.Drawing.Point(0, 0);
            this.mapControl1.MaxZoomLevel = 6D;
            this.mapControl1.MinZoomLevel = 2D;
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.NavigationPanelOptions.Visible = false;
            this.mapControl1.ShowToolTips = false;
            this.mapControl1.Size = new System.Drawing.Size(1161, 616);
            this.mapControl1.TabIndex = 1;
            this.mapControl1.ZoomLevel = 3D;
            this.imageLayer1.DataProvider = this.bingMapDataProvider;
            this.bingMapDataProvider.BingKey = "YOUR BING MAPS KEY";
            this.informationLayer1.DataProvider = this.bingGeocodeDataProvider1;
            this.bingGeocodeDataProvider1.MaxVisibleResultCount = 3;
            this.bingGeocodeDataProvider1.ProcessMouseEvents = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(423, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(90, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(327, 2);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(90, 23);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textBoxCountryName
            // 
            this.textBoxCountryName.Location = new System.Drawing.Point(68, 2);
            this.textBoxCountryName.Name = "textBoxCountryName";
            this.textBoxCountryName.Size = new System.Drawing.Size(253, 21);
            this.textBoxCountryName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Country:";
            // 
            // FormCountryOfOrigin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 651);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FormCountryOfOrigin";
            this.Text = "Choose Country Of Origin";
            this.Load += new System.EventHandler(this.FormCountryOfOrigin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraMap.MapControl mapControl1;
        private DevExpress.XtraMap.ImageLayer imageLayer1;
        private DevExpress.XtraMap.BingMapDataProvider bingMapDataProvider;
        private DevExpress.XtraMap.InformationLayer informationLayer1;
        private DevExpress.XtraMap.BingGeocodeDataProvider bingGeocodeDataProvider1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBoxCountryName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancel;
    }
}