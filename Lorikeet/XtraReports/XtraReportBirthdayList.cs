using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Lorikeet.XtraReports
{
    public partial class XtraReportBirthdayList : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportBirthdayList(int param1, int param2)
        {
            InitializeComponent();

            this.birthdayMonth1.Value = param1;
            this.birthdayMonth2.Value = param2;

            if (param1 == 1 && param2 == 2)
            {
                this.xrLabelBirthdayMonths.Text = "January to February";
            }
            else if (param1 == 3 && param2 == 4)
            {
                this.xrLabelBirthdayMonths.Text = "March to April";
            }
            else if (param1 == 5 && param2 == 6)
            {
                this.xrLabelBirthdayMonths.Text = "May to June";
            }
            else if (param1 == 7 && param2 == 8)
            {
                this.xrLabelBirthdayMonths.Text = "July to August";
            }
            else if (param1 == 9 && param2 == 10)
            {
                this.xrLabelBirthdayMonths.Text = "September to October";
            }
            else if (param1 == 11 && param2 == 12)
            {
                this.xrLabelBirthdayMonths.Text = "November to December";
            }
        }
    }
}
