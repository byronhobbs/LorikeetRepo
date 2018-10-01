using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using Lorikeet.Data;

namespace Lorikeet
{
    public partial class FormAddEditDeleteDiagnosisMedication : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private int staffID = -1;
        public FormAddEditDeleteDiagnosisMedication(int staffID)
        {
            InitializeComponent();

            this.staffID = staffID;
            RefreshListBoxes();
        }

        private void RefreshListBoxes()
        {
            textBoxDiagnosis.Text = "";
            textBoxMedication.Text = "";
            listBoxMedications.Items.Clear();
            listBoxDiagnosis.Items.Clear();

            try
            {
                listBoxDiagnosis.Items.Clear();
                listBoxMedications.Items.Clear();

                using (var context = new LorikeetAppEntities())
                {
                    var medListTemp = (from m in context.MedicationNames
                                       select m).ToList();

                    var diagListTemp = (from d in context.DiagnosisNames
                                        select d).ToList();

                    foreach (var mlist in medListTemp)
                    {
                        listBoxMedications.Items.Add(mlist.MedicationName1);
                    }

                    foreach (var dlist in diagListTemp)
                    {
                        listBoxDiagnosis.Items.Add(dlist.DiagnosisName1);
                    }
                }
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

        private void FormAddEditDeleteDiagnosisMedication_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void simpleButtonMedicationAdd_Click(object sender, EventArgs e)
        {
            if (textBoxMedication.Text.Count() > 0)
            {
                try
                {
                    using (var context = new LorikeetAppEntities())
                    {
                        if (textBoxMedication.Text != "")
                        {
                            var medsToAdd = new MedicationName();

                            medsToAdd.MedicationName1 = textBoxMedication.Text;
                            context.MedicationNames.Add(medsToAdd);

                            context.SaveChanges();

                            Logging.AddLogEntry(staffID, Logging.ErrorCodes.Broadcast, Logging.RefreshCodes.Medication, "Medication Name - " + textBoxMedication.Text + " was added", false);

                            RefreshListBoxes();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Logging.AddLogEntry(staffID, Logging.ErrorCodes.Error, Logging.RefreshCodes.None, "Medication Name - " + textBoxMedication.Text + " was not added - Error - " + ex.Message, false);
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void simpleButtonMedicationDelete_Click(object sender, EventArgs e)
        {
            if (listBoxMedications.SelectedItems.Count > 0)
            {
                try
                {
                    using (var context = new LorikeetAppEntities())
                    {
                        var itemSelected = listBoxMedications.GetItemText(listBoxMedications.SelectedItem);

                        var medsToDelete = (from m in context.MedicationNames
                                            where m.MedicationName1 == itemSelected
                                            select m).DefaultIfEmpty().First();

                        if (medsToDelete != null)
                        {
                            context.MedicationNames.Remove(medsToDelete);
                            context.SaveChanges();
                        }
                        Logging.AddLogEntry(staffID, Logging.ErrorCodes.Broadcast, Logging.RefreshCodes.Medication, "Medication Name - " + textBoxMedication.Text + " was deleted", false);
                    }

                    RefreshListBoxes();
                }
                catch (Exception ex)
                {
                    Logging.AddLogEntry(staffID, Logging.ErrorCodes.Error, Logging.RefreshCodes.None, "Medication Name - " + textBoxMedication.Text + " was not deleted - Error - " + ex.Message, false);
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void simpleButtonDiagnosisAdd_Click(object sender, EventArgs e)
        {
            if (textBoxDiagnosis.Text.Count() > 0)
            {
                try
                {
                    using (var context = new LorikeetAppEntities())
                    {
                        if (textBoxDiagnosis.Text != "")
                        {
                            var diagnosisToAdd = new DiagnosisName();
                            diagnosisToAdd.DiagnosisName1 = textBoxDiagnosis.Text;

                            context.DiagnosisNames.Add(diagnosisToAdd);
                            context.SaveChanges();

                            Logging.AddLogEntry(staffID, Logging.ErrorCodes.Broadcast, Logging.RefreshCodes.Diagnosis, "Diagnosis Name - " + textBoxDiagnosis.Text + " was added", false);

                            RefreshListBoxes();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Logging.AddLogEntry(staffID, Logging.ErrorCodes.Error, Logging.RefreshCodes.None, "Diagnosis Name - " + textBoxDiagnosis.Text + " was not added - Error - " + ex.Message, false);
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void simpleButtonDiagnosisDelete_Click(object sender, EventArgs e)
        {
            if (listBoxDiagnosis.SelectedItems.Count > 0)
            {
                try
                {
                    using (var context = new LorikeetAppEntities())
                    {
                        var itemSelected = listBoxDiagnosis.GetItemText(listBoxDiagnosis.SelectedItem);

                        var diagnosisToDelete = (from m in context.DiagnosisNames
                                                where m.DiagnosisName1 == itemSelected
                                                select m).DefaultIfEmpty().First();

                        if (diagnosisToDelete != null)
                        {
                            context.DiagnosisNames.Remove(diagnosisToDelete);
                            context.SaveChanges();
                        }

                        Logging.AddLogEntry(staffID, Logging.ErrorCodes.Broadcast, Logging.RefreshCodes.Diagnosis, "Diagnosis Name - " + textBoxDiagnosis.Text + " was deleted", false);
                    }

                    RefreshListBoxes();
                }
                catch (Exception ex)
                {
                    Logging.AddLogEntry(staffID, Logging.ErrorCodes.Error, Logging.RefreshCodes.None, "Diagnosis Name - " + textBoxDiagnosis.Text + " was not deleted - Error - " + ex.Message, false);
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void simpleButtonMedicationsEdit_Click(object sender, EventArgs e)
        {
            if (textBoxMedication.Text.Count() > 0 && listBoxMedications.SelectedItems.Count > 0)
            {
                try
                {
                    using (var context = new LorikeetAppEntities())
                    {
                        var itemSelected = listBoxMedications.GetItemText(listBoxMedications.SelectedItem);

                        var medsToEdit = (from m in context.MedicationNames
                                          where m.MedicationName1 == itemSelected
                                          select m).DefaultIfEmpty().First();

                        if (medsToEdit != null)
                        {
                            medsToEdit.MedicationName1 = textBoxMedication.Text;

                            context.SaveChanges();
                        }
                    }

                    Logging.AddLogEntry(staffID, Logging.ErrorCodes.Broadcast, Logging.RefreshCodes.Medication, "Medication Name - " + textBoxMedication.Text + " was edited", false);

                    textBoxMedication.Text = "";
                    RefreshListBoxes();
                }
                catch (Exception ex)
                {
                    Logging.AddLogEntry(staffID, Logging.ErrorCodes.Error, Logging.RefreshCodes.None, "Medication Name - " + textBoxMedication.Text + " was not edited - " + ex.Message, false);
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void simpleButtonDiagnosisEdit_Click(object sender, EventArgs e)
        {
            if (textBoxDiagnosis.Text.Count() > 0 && listBoxDiagnosis.SelectedItems.Count > 0)
            {
                try
                {
                    using (var context = new LorikeetAppEntities())
                    {
                        var itemSelected = listBoxDiagnosis.GetItemText(listBoxDiagnosis.SelectedItem);

                        var diagnosisToEdit = (from m in context.DiagnosisNames
                                          where m.DiagnosisName1 == itemSelected
                                          select m).DefaultIfEmpty().First();

                        if (diagnosisToEdit != null)
                        {
                            diagnosisToEdit.DiagnosisName1 = textBoxDiagnosis.Text;

                            context.SaveChanges();
                        }
                    }

                    Logging.AddLogEntry(staffID, Logging.ErrorCodes.Broadcast, Logging.RefreshCodes.Diagnosis, "Diagnosis Name - " + textBoxDiagnosis.Text + " was edited", false);

                    textBoxDiagnosis.Text = "";
                    RefreshListBoxes();
                }
                catch (Exception ex)
                {
                    Logging.AddLogEntry(staffID, Logging.ErrorCodes.Error, Logging.RefreshCodes.None, "Diagnosis Name - " + textBoxDiagnosis.Text + " was not edited - " + ex.Message, false);
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void listBoxMedications_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxMedications.SelectedItems.Count > 0)
                textBoxMedication.Text = listBoxMedications.SelectedItem.ToString();
        }

        private void listBoxDiagnosis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDiagnosis.SelectedItems.Count > 0)
                textBoxDiagnosis.Text = listBoxDiagnosis.SelectedItem.ToString();
        }

        private void simpleButtonMergeDiagnosis_Click(object sender, EventArgs e)
        {
            var itemsSelected = listBoxDiagnosis.SelectedItems;

            if (itemsSelected.Count > 1)
            {
                SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);

                try
                {
                    using (var context = new LorikeetAppEntities())
                    {
                        var dr = new DialogResult();
                        var form = new FormInput();
                        dr = form.ShowDialog();
                        if (dr == DialogResult.OK)
                        {
                            var diagnosisToAdd = new DiagnosisName();
                            diagnosisToAdd.DiagnosisName1 = form.inputText;
                            context.DiagnosisNames.Add(diagnosisToAdd);
                            context.SaveChanges();

                            int i = diagnosisToAdd.DiagnosisNameID;
                            
                            for (int x = 0; x < itemsSelected.Count - 1; x++)
                            {
                                string diagnosisString = itemsSelected[x].ToString();

                                var diagnosisToUpdate = (from d in context.Diagnosis
                                                         join dn in context.DiagnosisNames on d.DiagnosisNameID equals dn.DiagnosisNameID
                                                         where dn.DiagnosisName1 == diagnosisString
                                                         select d).ToList();

                                if (diagnosisToUpdate.Any())
                                {
                                    foreach (var dtu in diagnosisToUpdate)
                                    {
                                        dtu.DiagnosisNameID = i;
                                        context.SaveChanges();
                                    }
                                }
                            }
                            foreach (var item in itemsSelected)
                            {
                                string itemString = item.ToString();

                                var diagnosisNamesToRemove = (from dn in context.DiagnosisNames
                                                              where dn.DiagnosisName1 == itemString
                                                              select dn).ToList();

                                if (diagnosisNamesToRemove.Any())
                                {
                                    foreach (var dmtr in diagnosisNamesToRemove)
                                    {
                                        context.DiagnosisNames.Remove(dmtr);
                                    }
                                    
                                    context.SaveChanges();
                                }
                            }
                        }
                        else
                        {
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(MiscStuff.GetAllMessages(ex));
                }
                SplashScreenManager.CloseForm();
            }
            else
            {
                MessageBox.Show("You must select at least 2 items");
            }
            RefreshListBoxes();
        }
        
    }
}
