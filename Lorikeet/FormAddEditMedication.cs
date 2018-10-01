using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Lorikeet.Data;

namespace Lorikeet
{
    public partial class FormAddEditMedication : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private List<MedicationName> medication = new List<MedicationName>();
        private List<MedicationName> medicationToAdd = new List<MedicationName>();
        private int memberID = -1;
        private int staffID = -1;
        public FormAddEditMedication(int memberID, int staffID)
        {
            InitializeComponent();

            this.memberID = memberID;
            this.staffID = staffID;

            ResetMedication();
            RefreshMedication();
        }

        private void RefreshMedication()
        {
            listBoxMedication.Items.Clear();
            listBoxMedicationToAdd.Items.Clear();

            if (medication != null)
            {
                foreach (var d in medication)
                {
                    listBoxMedication.Items.Add(d.MedicationName1);
                }
            }

            if (medicationToAdd != null)
            {
                foreach (var da in medicationToAdd)
                {
                    listBoxMedicationToAdd.Items.Add(da.MedicationName1);
                }
            }
        }

        private void ResetMedication()
        {
            try
            {
                using (var context = new LorikeetAppEntities())
                {
                    var medicationTemp = (from d in context.MedicationNames
                                         select d).ToList();

                    medicationToAdd = (from d in context.Medications
                                      join dn in context.MedicationNames on d.MedicationNameID equals dn.MedicationNameID
                                      join m in context.Members on d.MemberID equals m.MemberID
                                      where m.MemberID == memberID
                                      select dn).ToList();

                    medication = medicationTemp.Except(medicationToAdd).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bbiReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ResetMedication();
            RefreshMedication();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new LorikeetAppEntities())
                {
                    if (listBoxMedication.SelectedIndex != -1)
                    {
                        var medicationToRemove = listBoxMedication.SelectedItem.ToString();

                        MedicationName medicationTemp = (from d in context.MedicationNames
                                                       where d.MedicationName1 == medicationToRemove
                                                       select d).DefaultIfEmpty().First();

                        if (medicationTemp != null)
                        {
                            medicationToAdd.Add(medicationTemp);
                            medication.RemoveAt(listBoxMedication.SelectedIndex);

                            RefreshMedication();
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
                    if (listBoxMedicationToAdd.SelectedIndex != -1)
                    {
                        var medicationToRemove = listBoxMedicationToAdd.SelectedItem.ToString();

                        MedicationName medicationTemp = (from d in context.MedicationNames
                                                       where d.MedicationName1 == medicationToRemove
                                                       select d).DefaultIfEmpty().First();

                        if (medicationTemp != null)
                        {
                            medicationToAdd.RemoveAt(listBoxMedicationToAdd.SelectedIndex);
                            medication.Add(medicationTemp);
                        }
                    }
                }

                RefreshMedication();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            listBoxMedicationToAdd.Items.Clear();
            listBoxMedication.Items.Clear();

            try
            {
                using (var context = new LorikeetAppEntities())
                {
                    medication = (from d in context.MedicationNames
                                 select d).ToList();

                    medicationToAdd.Clear();
                }

                RefreshMedication();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (var context = new LorikeetAppEntities())
                {
                    var medicationToRemove = (from dtr in context.Medications
                                             where dtr.MemberID == memberID
                                             select dtr).ToList();

                    if (medicationToRemove.Count > 0)
                    {
                        foreach (var dtr in medicationToRemove)
                        {
                            context.Medications.Remove(dtr);
                            context.SaveChanges();
                        }
                    }

                    foreach (var dta in medicationToAdd)
                    {
                        Medication medicationToAdd = new Medication();
                        medicationToAdd.MemberID = memberID;
                        medicationToAdd.MedicationNameID = dta.MedicationNameID;

                        context.Medications.Add(medicationToAdd);
                        context.SaveChanges();
                    }

                    Logging.AddLogEntry(staffID, Logging.ErrorCodes.Broadcast, Logging.RefreshCodes.Medication, MiscStuff.GetMemberName(memberID) + " Medications have been changed", false);
                }
            }
            catch (Exception ex)
            {
                Logging.AddLogEntry(staffID, Logging.ErrorCodes.Error, Logging.RefreshCodes.None, MiscStuff.GetMemberName(memberID) + " Medications have not been changed - Error - " + ex.Message, false);
                MessageBox.Show(ex.Message);
            }

            this.Close();
        }
    }
}