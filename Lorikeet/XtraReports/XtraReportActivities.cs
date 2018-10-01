using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using DevExpress.XtraReports.Parameters;

namespace Lorikeet.XtraReports
{
    public partial class XtraReportActivities : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportActivities(List<string> selectedItems)
        {
            InitializeComponent();

            
        }

    }
}
