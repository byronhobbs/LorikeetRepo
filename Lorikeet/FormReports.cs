using System;
using System.Windows.Forms;

namespace Lorikeet
{
    public partial class FormReports : Form
    {
        public FormReports()
        {
            InitializeComponent();
        }

        private void navBarItemMailingLabels_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                DialogResult dr = new DialogResult();
                var frm = new Lorikeet.FormSelectMonths();
                dr = frm.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    var report = new XtraReports.XtraReportMailingLabels(frm.birthdayMonth1, frm.birthdayMonth2);
                    report.CreateDocument();
                    documentViewer1.DocumentSource = report;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
            }
        }

        private void navBarItemMemberReport_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                DialogResult dr = new DialogResult();
                var form = new FormMemberSelect();
                dr = form.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    var report = new XtraReports.XtraReportMemberInfo(form.memberID);
                    report.CreateDocument();
                    documentViewer1.DocumentSource = report;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
            }
        }

        private void navBarItemAttendance_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                DialogResult dr = new DialogResult();
                var form = new FormCheckDates();
                dr = form.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    var report = new XtraReports.XtraReportAttendance(form.startDate, form.endDate);
                    report.CreateDocument();
                    documentViewer1.DocumentSource = report;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
            }
        }

        private void navBarItemBirthdayReport_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                DialogResult dr = new DialogResult();
                var form = new FormSelectMonths();
                dr = form.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    var report = new XtraReports.XtraReportBirthdayList(form.birthdayMonth1, form.birthdayMonth2);
                    report.CreateDocument();
                    documentViewer1.DocumentSource = report;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
            }
        }

        private void navBarItemActivities_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                DialogResult dr = new DialogResult();
                var form = new FormSelectActivities();
                dr = form.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    var report = new XtraReports.XtraReportActivities(form.selectedActivities);
                    report.CreateDocument();
                    documentViewer1.DocumentSource = report;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
            }
        }

        private void navBarItemReportNote_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                DialogResult dr = new DialogResult();
                var form = new FormMemberSelect();
                dr = form.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    var report = new XtraReports.XtraReportNotes(form.memberID);
                    report.CreateDocument();
                    documentViewer1.DocumentSource = report;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
            }
        }

        private void navBarItemDebitCredit_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                DialogResult dr = new DialogResult();
                var form = new FormMemberSelect();
                dr = form.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    var report = new XtraReports.XtraReportDebitCredit(form.memberID);
                    report.CreateDocument();
                    documentViewer1.DocumentSource = report;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
            }
        }

        private void navBarItemDebtors_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                var report = new XtraReports.XtraReportDebtors();
                report.CreateDocument();
                documentViewer1.DocumentSource = report;
            }
            catch (Exception ex)
            {
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
            }
        }

        private void navBarItemCOOReport_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                var report = new FormReportCountryOfOriginsReport();
                report.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
            }
        }

        private void printPreviewBarItem27_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void printPreviewBarItem25_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
