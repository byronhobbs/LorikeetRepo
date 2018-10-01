using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Lorikeet.XtraReports
{
    public partial class XtraReportAttendance : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportAttendance(DateTime startDate, DateTime endDate)
        {
            InitializeComponent();

            this.startDate.Value = startDate;
            this.endDate.Value = endDate;
        }

    }
}
