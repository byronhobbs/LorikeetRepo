using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Lorikeet.XtraReports
{
    public partial class XtraReportMemberInfo : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportMemberInfo(int memberID)
        {
            InitializeComponent();

            this.memberID.Value = memberID;
        }
    }
}
