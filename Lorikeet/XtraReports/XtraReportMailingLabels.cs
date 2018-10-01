using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;

namespace Lorikeet.XtraReports
{
    public partial class XtraReportMailingLabels : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportMailingLabels(int param1, int param2)
        {
            InitializeComponent();

            this.parameterBirthdayMonth1.Value = param1;
            this.parameterBirthdayMonth2.Value = param2;
        }
    }
}
