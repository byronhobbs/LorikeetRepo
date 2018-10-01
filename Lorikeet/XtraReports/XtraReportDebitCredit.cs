using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Lorikeet.XtraReports
{
    public partial class XtraReportDebitCredit : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportDebitCredit(int memberID)
        {
            InitializeComponent();
            this.memberID.Value = memberID;
        }

    }
}
