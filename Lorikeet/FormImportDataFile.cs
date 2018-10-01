using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Globalization;
using DevExpress.XtraSplashScreen;
using NHunspell;
using Lorikeet.Data;

namespace Lorikeet
{
    public partial class FormImportDataFile : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private string fileName = "";
        private string newFileDirectory = "";
        private string password = "";

        private int maxRowCount = 0;
        private int rowCount = 0;
        private int errorRowCount = 0;

        public FormImportDataFile()
        {
            InitializeComponent();

            bbiConvert.Enabled = false;
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xtraOpenFileDialog.InitialDirectory = "c:\\";
            xtraOpenFileDialog.Filter = "Access Database File (*.mdb)|*.mdb";
            xtraOpenFileDialog.FilterIndex = 1;
            xtraOpenFileDialog.RestoreDirectory = true;

            if (xtraOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = xtraOpenFileDialog.FileName;

                var myDataTable = new DataTable();

                DialogResult dr = new DialogResult();
                var passForm = new FormPassword(xtraOpenFileDialog.FileName);
                dr = passForm.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    password = passForm.password;

                    try
                    {
                        newFileDirectory = Path.Combine(Environment.CurrentDirectory, Path.GetFileName(fileName));
                        File.Copy(fileName, newFileDirectory, true);
                    }
                    catch (Exception ex)
                    {
                        listViewImport.Items.Add("Error - " + ex.Message, 2);
                        return;
                    }

                    try
                    {
                        using (var connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + newFileDirectory + ";Jet OLEDB:Database Password=" + password + ";"))
                        {
                            connection.Open();

                            var query = "SELECT * FROM [Membership Details]";
                            var command = new OleDbCommand(query, connection);

                            var reader = command.ExecuteReader();

                            connection.Close();
                        }
                        listViewImport.Items.Add("Access database opened successfully with correct password ", 0);
                        bbiConvert.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        listViewImport.Items.Add("Error - " + ex.Message, 2);
                        bbiConvert.Enabled = false;
                    }
                }
            }
        }

        private void bbiConvert_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("This will Delete all Member Details in Database. Is this OK?", "WARNING", MessageBoxButtons.YesNo);

            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    using (var context = new LorikeetAppEntities())
                    {
                        var membersToRemove = (from m in context.Members
                                               select m).ToList();

                        var contactToRemove = (from c in context.Contacts
                                               select c).ToList();

                        var diagnosisToRemove = (from d in context.Diagnosis
                                                 select d).ToList();

                        var diagnosisNamesToRemove = (from dn in context.DiagnosisNames
                                                      select dn).ToList();

                        if (contactToRemove.Any())
                        {
                            context.Contacts.RemoveRange(contactToRemove);
                            context.SaveChanges();

                            listViewImport.Items.Add("Removed all Contacts", 0);
                        }

                        if (diagnosisNamesToRemove.Any())
                        {
                            context.DiagnosisNames.RemoveRange(diagnosisNamesToRemove);
                            context.SaveChanges();

                            listViewImport.Items.Add("Removed all Diagnosis Names", 0);
                        }

                        if (diagnosisToRemove.Any())
                        {
                            context.Diagnosis.RemoveRange(diagnosisToRemove);                           
                            context.SaveChanges();

                            listViewImport.Items.Add("Removed all Diagnosis", 0);
                        }

                        if (membersToRemove.Any())
                        {
                            context.Members.RemoveRange(membersToRemove);
                            context.SaveChanges();

                            listViewImport.Items.Add("Removed all Members", 0);
                        }
                    }
                }
                catch (Exception ex)
                {
                    listViewImport.Items.Add("Couldn't wipe Database - Error - " + ex.Message, 2);
                    SplashScreenManager.CloseForm();
                    return;
                }

                SplashScreenManager.CloseForm();

                try
                {
                    using (var connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + newFileDirectory + ";Jet OLEDB:Database Password=" + password + ";"))
                    {
                        connection.Open();

                        var countquery = "SELECT * FROM [Membership Details]";
                        var query = "SELECT * FROM [Membership Details] ORDER BY [Membership No]";
                        var commandCount = new OleDbCommand(countquery, connection);

                        var readercount = commandCount.ExecuteReader();

                        while (readercount.Read())
                        {
                            maxRowCount++;
                        }

                        var progressForm = new FormProgress(maxRowCount);
                        progressForm.Show();

                        var command = new OleDbCommand(query, connection);
                        var reader = command.ExecuteReader();
                        using (var context = new LorikeetAppEntities())
                        {
                            using (var hunspell = new Hunspell("en_us.aff", "en_us.dic"))
                            {
                                hunspell.Add("OCD");
                                hunspell.Add("PTSD");
                                hunspell.Add("OCD");
                                hunspell.Add("Cognative");
                                hunspell.Add("Psychosis");
                                hunspell.Add("BPAD");
                                hunspell.Add("BPD");
                                hunspell.Add("Traumatic");

                                while (reader.Read())
                                {
                                    var memberToAdd = new Member();

                                    if (reader["First Name"].ToString().Equals("") && reader["Surname"].ToString().Equals(""))
                                    {
                                        errorRowCount++;
                                        listViewImport.Items.Add("Cannot add Member Number " + reader["Membership No"], 2);
                                    }
                                    else
                                    {
                                        if (reader["Diagnosis"].ToString().Trim().ToLower().Equals("agency"))
                                        {
                                            memberToAdd.Agency = true;
                                        }
                                        else
                                        {
                                            memberToAdd.Agency = false;
                                        }
                                        memberToAdd.FirstName = reader["First Name"].ToString();
                                        memberToAdd.Surname = reader["Surname"].ToString();
                                        memberToAdd.Aboriginal = false;
                                        memberToAdd.Archived = (bool)reader["Archived"];
                                        memberToAdd.BirthdayCard = (bool)reader["Birthday Card"];
                                        memberToAdd.Country = "";
                                        memberToAdd.CountryOfOrigin = "";
                                        memberToAdd.DateAltered = DateTime.Today;

                                        DateTime memberJoinedDate;

                                        if (DateTime.TryParse(reader["When member joined"].ToString(), out memberJoinedDate))
                                        {
                                            memberToAdd.DateJoined = memberJoinedDate;
                                        }
                                        else
                                        {
                                            memberToAdd.DateJoined = DateTime.Today;
                                        }

                                        DateTime tempDOB;

                                        string tempDateOfBirth = reader["DOB"].ToString();

                                        string[] formats = { "dd-MM-yy", "dd-M-yy", "dd-M-yyyy", "d-MM-yy", "d-MM-yyyy", "d-M-yyyy", "dd-MMM-yyyy", "dd/MM/yy", "dd/M/yy", "dd/M/yyyy", "d/MM/yy", "d/MM/yyyy", "d/M/yyyy", "dd MMM yyyy", "dd.MM.yy", "d MMM yyyy", "d MMM yy", "d MMMM yyyy", " d MMMM yy", "d-MMM-yyyy", "d/M/yy", "d/M/yyyy" };

                                        if (DateTime.TryParseExact(tempDateOfBirth, formats, new CultureInfo("en-AU"), DateTimeStyles.None, out tempDOB))
                                        {
                                            memberToAdd.DateOfBirth = tempDOB;
                                        }
                                        else
                                        {
                                            memberToAdd.DateOfBirth = null;
                                        }

                                        memberToAdd.EmailAddress = reader["email"].ToString();
                                        memberToAdd.MemberID = (int)reader["Membership No"];
                                        memberToAdd.MobileNumber = reader["MobilePhone"].ToString();
                                        memberToAdd.PostCode = reader["Postcode"].ToString();

                                        int postCode = 6000;

                                        if (int.TryParse(reader["Postcode"].ToString(), out postCode))
                                        {
                                            if (postCode >= 1000 && postCode < 3000)
                                            {
                                                memberToAdd.State = "New South Wales";
                                                memberToAdd.Country = "Australia";
                                            }
                                            else if ((postCode >= 200 && postCode < 300) || (postCode >= 2600 && postCode < 3000))
                                            {
                                                memberToAdd.State = "ACT";
                                                memberToAdd.Country = "Australia";
                                            }
                                            else if ((postCode >= 3000 && postCode < 4000) || (postCode >= 8000 && postCode < 9000))
                                            {
                                                memberToAdd.State = "Victoria";
                                                memberToAdd.Country = "Australia";
                                            }
                                            else if ((postCode >= 4000 && postCode < 5000) || (postCode >= 9000 && postCode < 10000))
                                            {
                                                memberToAdd.State = "Queensland";
                                                memberToAdd.Country = "Australia";
                                            }
                                            else if (postCode >= 5000 && postCode < 6000)
                                            {
                                                memberToAdd.State = "South Australia";
                                                memberToAdd.Country = "Australia";
                                            }
                                            else if (postCode >= 6000 && postCode < 7000)
                                            {
                                                memberToAdd.State = "Western Australia";
                                                memberToAdd.Country = "Australia";
                                            }
                                            else if (postCode >= 7000 && postCode < 8000)
                                            {
                                                memberToAdd.State = "Tasmania";
                                                memberToAdd.Country = "Australia";
                                            }
                                            else if (postCode >= 800 && postCode < 1000)
                                            {
                                                memberToAdd.State = "Northern Territory";
                                                memberToAdd.Country = "Australia";
                                            }
                                        }
                                        

                                        memberToAdd.ReceiveByMail = (bool)reader["Email Newsletter"];
                                        memberToAdd.ReceiveNewsletter = (bool)reader["Newsletter"];
                                        if (reader["Gender"].ToString().ToLower() == "m")
                                        {
                                            memberToAdd.Sex = true;
                                        }
                                        else
                                        {
                                            memberToAdd.Sex = false;
                                        }
                                        memberToAdd.State = "";
                                        memberToAdd.StreetAddress = reader["Street Address"].ToString();
                                        memberToAdd.Suburb = reader["Suburb"].ToString();
                                        memberToAdd.TelephoneNumber = reader["Phone Number"].ToString();
                                        memberToAdd.Studying = false;
                                        memberToAdd.Volunteering = false;
                                        memberToAdd.Working = false;

                                        context.Members.Add(memberToAdd);
                                        context.SaveChanges();

                                        if (!reader["Emergency Contact"].ToString().Equals("") && !reader["Emergency Phone"].ToString().Equals("") && !reader["Emergency Relationship"].ToString().Equals(""))
                                        {
                                            var contactToAdd = new Contact();
                                            contactToAdd.MemberID = (int)reader["Membership No"];
                                            contactToAdd.ContactAddress = "";
                                            contactToAdd.ContactName = reader["Emergency Contact"].ToString();
                                            contactToAdd.ContactPhone = reader["Emergency Phone"].ToString();
                                            contactToAdd.ContactType = "Emergency - " + reader["Emergency Relationship"].ToString();

                                            context.Contacts.Add(contactToAdd);
                                            context.SaveChanges();
                                        }

                                        var contactToAdd2 = new Contact();
                                        contactToAdd2.MemberID = (int)reader["Membership No"];

                                        if (!(reader["HCareAddress"].ToString().Trim().Equals("") && reader["HCareSuburb"].ToString().Trim().Equals("") && reader["HCareState"].ToString().Trim().Equals("") && reader["HealthCareProvider"].ToString().Trim().Equals("") && reader["GPName"].ToString().Trim().Equals("") && reader["HCarePhone"].ToString().Trim().Equals("")))
                                        {
                                            contactToAdd2.ContactAddress = (reader["HCareAddress"].ToString() + ", " + reader["HCareSuburb"].ToString() + ", " + reader["HCareState"].ToString()).Trim(',');
                                            contactToAdd2.ContactName = (reader["HealthCareProvider"].ToString() + ", " + reader["GPName"].ToString()).Trim(',');
                                            contactToAdd2.ContactPhone = reader["HCarePhone"].ToString();
                                            contactToAdd2.ContactType = "Health Care Provider";
                                            context.Contacts.Add(contactToAdd2);
                                            context.SaveChanges();
                                        }
                                        
                                        String diagnosis = reader["Diagnosis"].ToString().Trim();
                                        if (!diagnosis.ToLower().Trim().Equals("agency") && !diagnosis.Trim().Equals(""))
                                        {
                                            if (diagnosis.Contains("x"))
                                                diagnosis = diagnosis.Replace("X", "");

                                            diagnosis = diagnosis.ToLower().Trim();
                                            if (diagnosis.Contains("?"))
                                                diagnosis.Replace("?", "");
                                            if (diagnosis.Contains("n/a"))
                                                diagnosis = diagnosis.Replace("n/a", "");
                                            if (diagnosis.Contains("archive box 1"))
                                                diagnosis = diagnosis.Replace("archive box 1", "");
                                            if (diagnosis.Contains("archived 2014"))
                                                diagnosis = diagnosis.Replace("archived 2014", "");
                                            if (diagnosis.Contains("archive"))
                                                diagnosis = diagnosis.Replace("archive", "");
                                            if (diagnosis.Contains("and"))
                                                diagnosis = diagnosis.Replace(" and ", ",");
                                            if (diagnosis.Contains("="))
                                                diagnosis = diagnosis.Replace("=", "-");
                                            if (diagnosis.Contains("/"))
                                                diagnosis = diagnosis.Replace("/", ",");
                                            if (diagnosis.Contains("."))
                                                diagnosis = diagnosis.Replace(".", "");
                                            if (diagnosis.Contains("with"))
                                                diagnosis = diagnosis.Replace("with", ",");
                                            if (diagnosis.Contains("***"))
                                                diagnosis = diagnosis.Replace("***", "");

                                            if (!diagnosis.Trim().Equals("") && diagnosis.Trim().Count() > 2)
                                            {
                                                string[] diagnosisSplit = diagnosis.Split(',');
                                                foreach (var d in diagnosisSplit)
                                                {
                                                    string tempString = "";
                                                    var sTemp = d.Trim();

                                                    string[] stringSplit = sTemp.Split(' ');

                                                    if (stringSplit.Count() > 1)
                                                    {
                                                        foreach (var sp in stringSplit)
                                                        {
                                                            if (!sp.Equals(""))
                                                            {
                                                                if (hunspell.Spell(sp))
                                                                {
                                                                    tempString = tempString + " " + sp;
                                                                }
                                                                else
                                                                {
                                                                    tempString = tempString + " " + hunspell.Suggest(sp)[0];
                                                                }
                                                            }
                                                        }
                                                    }
                                                    else
                                                    {
                                                        if (!d.Equals(""))
                                                        {
                                                            if (hunspell.Spell(d))
                                                            {
                                                                tempString = d;
                                                            }
                                                            else
                                                            {
                                                                tempString = hunspell.Suggest(d)[0];
                                                            }
                                                        }
                                                    }

                                                    if (!tempString.Trim().Equals(""))
                                                    {
                                                        tempString = tempString.Trim();

                                                        var diagnosisNames = (from dn in context.DiagnosisNames
                                                                              where tempString.Contains(dn.DiagnosisName1)
                                                                              select dn).DefaultIfEmpty().First();

                                                        var diagnosisNameToAdd = new DiagnosisName();
                                                        if (diagnosisNames == null)
                                                        {
                                                            diagnosisNameToAdd.DiagnosisName1 = tempString;

                                                            context.DiagnosisNames.Add(diagnosisNameToAdd);
                                                            context.SaveChanges();

                                                            var diagnosisToAdd = new Diagnosi();
                                                            diagnosisToAdd.DiagnosisNameID = diagnosisNameToAdd.DiagnosisNameID;
                                                            diagnosisToAdd.MemberID = (int)reader["Membership No"];

                                                            context.Diagnosis.Add(diagnosisToAdd);
                                                            context.SaveChanges();
                                                        }
                                                        else
                                                        {
                                                            var diagnosisName = (from dn in context.DiagnosisNames
                                                                                 where tempString.Contains(dn.DiagnosisName1)
                                                                                 select dn).DefaultIfEmpty().First();
                                                            if (diagnosisName != null)
                                                            {
                                                                var diagnosisToAdd = new Diagnosi();
                                                                diagnosisToAdd.DiagnosisNameID = diagnosisName.DiagnosisNameID;
                                                                diagnosisToAdd.MemberID = (int)reader["Membership No"];

                                                                context.Diagnosis.Add(diagnosisToAdd);
                                                                context.SaveChanges();
                                                            }
                                                        }
                                                    }
                                                    
                                                }
                                            }
                                        }                                    
                                        rowCount++;
                                        progressForm.StepProgress();
                                    }
                                }
                                listViewImport.Items.Add("Out of a total " + maxRowCount + " " + (rowCount - errorRowCount) + " Members were added", 0);
                                listViewImport.Items.Add("There were " + errorRowCount + " errors in rows which were not added", 1);
                            }
                            progressForm.Hide();

                            connection.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    listViewImport.Items.Add("Error - " + ex.Message, 2);
                    MessageBox.Show(MiscStuff.GetAllMessages(ex));
                }
            }

            bbiConvert.Enabled = false;
        }

        private void listViewImport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}