using Lorikeet.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Lorikeet
{
    public partial class FormAddEditDiagnosis : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private List<DiagnosisName> diagnosis = new List<DiagnosisName>();
        private List<DiagnosisName> diagnosisToAdd = new List<DiagnosisName>();
        private int memberID = -1;
        private int staffID = -1;
        public FormAddEditDiagnosis(int memberID, int staffID)
        {
            InitializeComponent();

            this.memberID = memberID;
            this.staffID = staffID;

            ResetDiagnosis();
            RefreshDiagnosis();
        }

        private void RefreshDiagnosis()
        {
            listBoxDiagnosis.Items.Clear();
            listBoxDiagnosisToAdd.Items.Clear();

            if (diagnosis != null)
            {
                foreach (var d in diagnosis)
                {
                    listBoxDiagnosis.Items.Add(d.DiagnosisName1);
                }
            }

            if (diagnosisToAdd != null)
            {
                foreach (var da in diagnosisToAdd)
                {
                    listBoxDiagnosisToAdd.Items.Add(da.DiagnosisName1);
                }
            }
        }

        private void ResetDiagnosis()
        {
            try
            {
                using (var context = new LorikeetAppEntities())
                {
                    var diagnosisTemp = (from d in context.DiagnosisNames
                                         select d).ToList();

                    diagnosisToAdd = (from d in context.Diagnosis
                                      join dn in context.DiagnosisNames on d.DiagnosisNameID equals dn.DiagnosisNameID
                                      join m in context.Members on d.MemberID equals m.MemberID
                                      where m.MemberID == memberID
                                      select dn).ToList();

                    diagnosis = diagnosisTemp.Except(diagnosisToAdd).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bbiReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ResetDiagnosis();
            RefreshDiagnosis();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new LorikeetAppEntities())
                {
                    if (listBoxDiagnosis.SelectedIndex != -1)
                    {
                        var diagnosisToRemove = listBoxDiagnosis.SelectedItem.ToString();

                        DiagnosisName diagnosisTemp = (from d in context.DiagnosisNames
                                                       where d.DiagnosisName1 == diagnosisToRemove
                                                       select d).DefaultIfEmpty().First();

                        if (diagnosisTemp != null)
                        {
                            diagnosisToAdd.Add(diagnosisTemp);
                            diagnosis.RemoveAt(listBoxDiagnosis.SelectedIndex);

                            RefreshDiagnosis();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new LorikeetAppEntities())
                {
                    if (listBoxDiagnosisToAdd.SelectedIndex != -1)
                    {
                        var diagnosisToRemove = listBoxDiagnosisToAdd.SelectedItem.ToString();

                        DiagnosisName diagnosisTemp = (from d in context.DiagnosisNames
                                                       where d.DiagnosisName1 == diagnosisToRemove
                                                       select d).DefaultIfEmpty().First();

                        if (diagnosisTemp != null)
                        {
                            diagnosisToAdd.RemoveAt(listBoxDiagnosisToAdd.SelectedIndex);
                            diagnosis.Add(diagnosisTemp);
                        }
                    }
                }

                RefreshDiagnosis();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            listBoxDiagnosisToAdd.Items.Clear();
            listBoxDiagnosis.Items.Clear();

            try
            {
                using (var context = new LorikeetAppEntities())
                {
                    diagnosis = (from d in context.DiagnosisNames
                                 select d).ToList();

                    diagnosisToAdd.Clear();
                }

                RefreshDiagnosis();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (var context = new LorikeetAppEntities())
                {
                    var diagnosisToRemove = (from dtr in context.Diagnosis
                                             where dtr.MemberID == memberID
                                             select dtr).ToList();

                    if (diagnosisToRemove.Count > 0)
                    {
                        foreach (var dtr in diagnosisToRemove)
                        {
                            context.Diagnosis.Remove(dtr);
                            context.SaveChanges();
                        }
                    }

                    foreach (var dta in diagnosisToAdd)
                    {
                        Diagnosi diagnosisToAdd = new Diagnosi();
                        diagnosisToAdd.MemberID = memberID;
                        diagnosisToAdd.DiagnosisNameID = dta.DiagnosisNameID;

                        context.Diagnosis.Add(diagnosisToAdd);
                        context.SaveChanges();
                    }

                    Logging.AddLogEntry(staffID, Logging.ErrorCodes.Broadcast, Logging.RefreshCodes.Diagnosis, MiscStuff.GetMemberName(memberID) + " Diagnosis has been edited", false);
                }
            }
            catch (Exception ex)
            {
                Logging.AddLogEntry(staffID, Logging.ErrorCodes.Error, Logging.RefreshCodes.None, MiscStuff.GetMemberName(memberID) + " had a problem when editing Diagnosis - Error - " + ex.Message, false);
                MessageBox.Show(ex.Message);
            }

            this.Close();
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}