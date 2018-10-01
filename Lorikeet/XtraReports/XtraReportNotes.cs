using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Lorikeet.XtraReports
{
    public partial class XtraReportNotes : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportNotes(int memberID)
        {
            InitializeComponent();

            this.memberID.Value = memberID;
        }
    }
}
