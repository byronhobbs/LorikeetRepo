namespace Lorikeet
{
    partial class FormReportCountryOfOriginsReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReportCountryOfOriginsReport));
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.imageLayer1 = new DevExpress.XtraMap.ImageLayer();
            this.bingMapDataProvider1 = new DevExpress.XtraMap.BingMapDataProvider();
            this.informationLayer1 = new DevExpress.XtraMap.InformationLayer();
            this.bingGeocodeDataProvider1 = new DevExpress.XtraMap.BingGeocodeDataProvider();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            this.SuspendLayout();
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
            this.mapControl1.Size = new System.Drawing.Size(716, 648);
            this.mapControl1.TabIndex = 1;
            this.mapControl1.ZoomLevel = 3D;
            this.imageLayer1.DataProvider = this.bingMapDataProvider1;
            this.bingMapDataProvider1.BingKey = "Ah_GLvMCtg2uzZkeG7EEOdYRfJu0mZH0YBcLPhtqc73YBnfoeWvLrpeTwL1qVsjO";
            this.informationLayer1.DataProvider = this.bingGeocodeDataProvider1;
            this.bingGeocodeDataProvider1.BingKey = "Ah_GLvMCtg2uzZkeG7EEOdYRfJu0mZH0YBcLPhtqc73YBnfoeWvLrpeTwL1qVsjO";
            this.bingGeocodeDataProvider1.MaxVisibleResultCount = 3;
            this.bingGeocodeDataProvider1.ProcessMouseEvents = true;
            // 
            // FormReportCountryOfOriginsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 648);
            this.Controls.Add(this.mapControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormReportCountryOfOriginsReport";
            this.Text = "Country Of Origins Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormReportCountryOfOriginsReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraMap.MapControl mapControl1;
        private DevExpress.XtraMap.ImageLayer imageLayer1;
        private DevExpress.XtraMap.BingMapDataProvider bingMapDataProvider1;
        private DevExpress.XtraMap.InformationLayer informationLayer1;
        private DevExpress.XtraMap.BingGeocodeDataProvider bingGeocodeDataProvider1;
    }
}