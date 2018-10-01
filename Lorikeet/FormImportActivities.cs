using DevExpress.Spreadsheet;
using DuoVia.FuzzyStrings;
using Lorikeet.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lorikeet
{
    public partial class FormImportActivities : Form
    {
        public FormImportActivities()
        {
            InitializeComponent();
        }

        private void LoadActivitiesFile()
        {
            try
            {
                DialogResult dr = new DialogResult();
                var importActivityFile = new OpenFileDialog();
                importActivityFile.InitialDirectory = @"C:\";
                importActivityFile.Title = "Import Activity File";
                importActivityFile.CheckFileExists = true;
                importActivityFile.CheckPathExists = true;
                importActivityFile.Filter = "Excel Document (*.xlsx)|*.xlsx";
                importActivityFile.FilterIndex = 0;
                importActivityFile.Multiselect = false;

                dr = importActivityFile.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    string pathAndFile = Application.StartupPath + "\\" + Path.GetFileName(importActivityFile.FileName);
                    if (File.Exists(pathAndFile))
                    {
                        DialogResult dr2 = MessageBox.Show("File already exists, Do you want to overwrite?", "Warning", MessageBoxButtons.YesNo);
                        if (dr2 == DialogResult.Yes)
                            File.Copy(importActivityFile.FileName, pathAndFile, true);
                    }
            
                    spreadsheetControl1.LoadDocument(pathAndFile, DocumentFormat.OpenXml);
                    GetActivityNames();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
            }
        }

        private void AddActivity(DevExpress.Spreadsheet.Cell cellTempActivity)
        {
            try
            {
                if (!cellTempActivity.Value.IsEmpty)
                {
                    DateTime date;
                    String[] splitCellActivity = cellTempActivity.Value.ToString().Split(new char[] { '-', '=' });
                    string strActivity = "";
                    string strActivityShortcut = "";
                    if (!DateTime.TryParseExact(cellTempActivity.Value.ToString(), "MMMM", new CultureInfo("en-US"), DateTimeStyles.None, out date))
                    {
                        if (splitCellActivity.Count() == 1)
                        {
                            splitCellActivity = cellTempActivity.Value.ToString().Split(' ');
                            strActivityShortcut = splitCellActivity.Last().Trim();
                            strActivity = cellTempActivity.Value.ToString().Replace(cellTempActivity.Value.ToString(), "").Trim();
                        }
                        else
                        {
                            strActivityShortcut = splitCellActivity[1].Trim();
                            strActivity = splitCellActivity[0].Trim();
                        }
                        if (strActivity.Equals("") || strActivityShortcut.Equals(""))
                        {
                        }
                        else
                        {
                            using (var context = new LorikeetAppEntities())
                            {
                                var checkIfActivityExists = (from l in context.Labels
                                                             where l.Shortcut == strActivityShortcut
                                                             select l).DefaultIfEmpty().First();

                                if (checkIfActivityExists == null)
                                {
                                    var activityLabel = new Lorikeet.Data.Label();
                                    activityLabel.DisplayName = strActivity;
                                    activityLabel.MenuCaption = strActivity;
                                    activityLabel.Shortcut = strActivityShortcut;
                                    Random r = new Random(DateTime.Now.Millisecond);
                                    Color randomColor = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
                                    activityLabel.Color = randomColor.ToArgb();

                                    context.Labels.Add(activityLabel);
                                    context.SaveChanges();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
                return;
            }
        }

        private bool GetActivityNames()
        {
            try
            {
                IWorkbook workbook = spreadsheetControl1.Document;

                WorksheetCollection worksheets = workbook.Worksheets;
                for (int i = 0; i < worksheets.Count - 1; i++)
                {
                    var worksheetx = workbook.Worksheets[i];
                    string[] dateFull = worksheetx.Name.Split(' ');
                    string monthName = dateFull[0].Trim();
                    string yearName = dateFull[1].Trim();
                    int startNamesRow = 0;
                    int endNamesRow = 0;
                    int startActivitiesRow = 0;
                    int endActivititiesRow = 0;
                    int maxColumn = 0;

                    Dictionary<int, int> dateDictionary = new Dictionary<int, int>();

                    workbook.Worksheets.ActiveWorksheet = workbook.Worksheets[i];

                    int x = 0;
                    bool breakLoop = true;
                    while (breakLoop)
                    {
                        var cellTemp = worksheetx[x, 0];
                        DateTime date;
                        if (cellTemp.Value.ToString().Trim().ToLower().Contains("name") || DateTime.TryParse(cellTemp.Value.ToString().Trim(), out date))
                        {
                            startNamesRow = x;
                            x++;
                            while (breakLoop)
                            {
                                cellTemp = worksheetx[x, 0];
                                if (cellTemp.Value.IsEmpty)
                                {
                                    endNamesRow = x;
                                    x++;
                                    while (breakLoop)
                                    {
                                        cellTemp = worksheetx[x, 0];
                                        if (cellTemp.Value.IsEmpty)
                                        {
                                            x++;
                                        }
                                        else
                                        {
                                            startActivitiesRow = x;
                                            x++;
                                            while (breakLoop)
                                            {
                                                cellTemp = worksheetx[x, 0];
                                                if (cellTemp.Value.IsEmpty)
                                                {
                                                    endActivititiesRow = x;
                                                    breakLoop = false;
                                                }
                                                x++;
                                            }
                                        }
                                    }
                                }
                                x++;
                            }
                        }
                        x++;
                    }

                    breakLoop = true;
                    int z = 0;
                    while (breakLoop)
                    {
                        var cellTemp = worksheetx[startNamesRow, z];
                        if (cellTemp.Value.ToString().Trim().ToLower().Contains("total") || cellTemp.Value.IsEmpty)
                        {
                            maxColumn = z;
                            breakLoop = false;
                        }
                        z++;
                    }

                    for (int b = 1; b < maxColumn; b++)
                    {
                        var cellTemp = worksheetx[startNamesRow, b];

                        int date;

                        string resultString = Regex.Match(cellTemp.Value.ToString(), @"\d+").Value;
                        if (int.TryParse(resultString, out date))
                        {
                            dateDictionary.Add(b, date);
                        }
                    }

                    
                    if (startNamesRow > 0)
                    {
                        for (int y = 0; y < 26; y++)
                        {
                            for (int w = 0; w < startNamesRow; w++)
                            {
                                var cellValue = worksheetx[w, y];
                                AddActivity(cellValue);
                            }
                        }
                    }
                    else
                    {
                        for (int j = startActivitiesRow; j < endActivititiesRow; j++)
                        {
                            var cellValue = worksheetx[j, 0];
                            AddActivity(cellValue);
                        }
                    }
                    
                    
                    var cellPrevious = worksheetx[0, 0];
                    
                    for (int startNames = startNamesRow + 1; startNames < endNamesRow; startNames++)
                    {
                        string[] nameValue = worksheetx[startNames, 0].Value.ToString().Trim().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                        string firstName = "";
                        string lastName = "";

                        var cellValue = worksheetx[startNames, 0];
                        spreadsheetControl1.ActiveWorksheet.ScrollTo(worksheetx[startNames - 1, 0]);

                        var backColor = cellValue.FillColor;

                        cellPrevious.Borders.SetAllBorders(Color.Black, BorderLineStyle.Thin);
                        cellPrevious.FillColor = backColor;
                        cellValue.Borders.SetAllBorders(Color.LightBlue, BorderLineStyle.DashDot);
                        cellValue.Fill.BackgroundColor = Color.Red;

                        cellPrevious = cellValue;

                        firstName = nameValue[0].Trim();

                        if (nameValue.Count() > 1)
                        {
                            lastName = nameValue[1].Trim();
                        }

                        using (var context = new LorikeetAppEntities())
                        {
                            var allMemberNames = context.Members.ToList();

                            if (allMemberNames.Any())
                            {
                                if (lastName.Equals(""))
                                {
                                    var check = (from m in context.Members
                                                 where m.FirstName == firstName
                                                 select m).ToList();

                                    if (check.Count() > 1)
                                    {
                                        DialogResult dr = new DialogResult();
                                        var getMembers = new FormChooseMember(check, firstName + " " + lastName);
                                        dr = getMembers.ShowDialog();
                                        if (dr == DialogResult.OK)
                                        {
                                            cellValue.SetValueFromText(getMembers.memberName);
                                        }
                                    }
                                    else if (check.Count() == 0)
                                    {
                                        List<string> diceNames = new List<string>();

                                        foreach (var m in allMemberNames)
                                        {
                                            double dice = firstName.FuzzyMatch(m.FirstName);
                                            if (dice >= 0.8)
                                            {
                                                diceNames.Add(m.FirstName + " " + m.Surname);
                                            }
                                        }
                                        if (diceNames.Count != 1)
                                        {
                                            DialogResult dr = new DialogResult();
                                            var getMembers = new FormChooseMember(diceNames, firstName + " " + lastName);
                                            dr = getMembers.ShowDialog();
                                            if (dr == DialogResult.OK)
                                            {
                                                cellValue.SetValueFromText(getMembers.memberName);
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    var checkFullName = (from member in allMemberNames
                                                         where member.FirstName == firstName && (member.Surname.StartsWith(lastName) || member.Surname == lastName)
                                                         select member).ToList();

                                    if (checkFullName.Count() > 1)
                                    {
                                        DialogResult dr = new DialogResult();
                                        var getMembers = new FormChooseMember(checkFullName, firstName + " " + lastName);
                                        dr = getMembers.ShowDialog();
                                        if (dr == DialogResult.OK)
                                        {
                                            cellValue.SetValueFromText(getMembers.memberName);
                                        }
                                    }

                                    if (checkFullName.Count() == 0)
                                    {
                                        List<string> diceNames = new List<string>();

                                        foreach (var m in allMemberNames)
                                        {
                                            double dice = (firstName + " " + lastName).FuzzyMatch((m.FirstName + " " + m.Surname));
                                            if (dice >= 0.8)
                                            {
                                                diceNames.Add(m.FirstName + " " + m.Surname);
                                            }
                                        }
                                        if (diceNames.Count > 1 || diceNames.Count == 0)
                                        {
                                            DialogResult dr = new DialogResult();
                                            var getMembers = new FormChooseMember(diceNames, firstName + " " + lastName);
                                            dr = getMembers.ShowDialog();
                                            if (dr == DialogResult.OK)
                                            {
                                                cellValue.SetValueFromText(getMembers.memberName);
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("There are no members in the member DataBase");
                                return false;
                            }
                        }
                        spreadsheetControl1.SaveDocument();
                    }

                    for (int startNames = startNamesRow + 1; startNames < endNamesRow; startNames++)
                    {
                        var namecellName = worksheetx[startNames, 0];

                        for (int c = 1; c < maxColumn; c++)
                        {
                            var cellValue = worksheetx[startNames, c];
                            if (!cellValue.Value.IsEmpty)
                            {
                                var backColor = cellValue.FillColor;

                                cellPrevious.Borders.SetAllBorders(Color.Black, BorderLineStyle.Thin);
                                cellPrevious.FillColor = backColor;
                                cellValue.Borders.SetAllBorders(Color.LightBlue, BorderLineStyle.DashDot);
                                cellValue.Fill.BackgroundColor = Color.Red;
                                spreadsheetControl1.ActiveWorksheet.ScrollTo(worksheetx[startNames - 1, 0]);
                                cellPrevious = cellValue;

                                using (var context = new LorikeetAppEntities())
                                {
                                    char[] splitters = { ' ', ',' };
                                    string removeSpace = cellValue.Value.ToString().Replace(", ", ",");
                                    string[] shortcutSplit = removeSpace.Split(splitters);
                                    
                                    for (int d = 0; d < shortcutSplit.Count(); d++)
                                    {
                                        var shortcut = shortcutSplit[d].Trim();
                                        var checkIfActivityExists = (from a in context.Labels
                                                                     where a.Shortcut == shortcut
                                                                     select a).DefaultIfEmpty().First();

                                        var activityLabel = "";

                                        if (checkIfActivityExists == null)
                                        {
                                            activityLabel = addActivity(shortcut, ref cellValue);
                                        }
                                        else
                                            activityLabel = checkIfActivityExists.DisplayName;

                                        if (activityLabel != null)
                                        {
                                            DateTime tempDate;
                                            string[] dateFormat = { "dd/MMMM/yyyy", "d/MMMM/yyyy" };
                                            int dayName = dateDictionary[c];
                                            if (DateTime.TryParseExact(dayName + "/" + monthName + "/" + yearName, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out tempDate))
                                            {
                                                if (!checkIfAppointmentExists(activityLabel, tempDate))
                                                {
                                                    var getLabelID = (from a in context.Labels
                                                                      where a.DisplayName == activityLabel
                                                                      select a).FirstOrDefault();

                                                    if (getLabelID != null)
                                                    {
                                                        var appToAdd = new Appointment();
                                                        appToAdd.AllDay = false;
                                                        appToAdd.Description = "";
                                                        appToAdd.EndDate = tempDate;
                                                        appToAdd.Label = getLabelID.LabelID;
                                                        appToAdd.Location = "";
                                                        appToAdd.ReminderInfo = "";
                                                        appToAdd.StartDate = tempDate;
                                                        appToAdd.Status = 0;
                                                        appToAdd.Subject = getLabelID.DisplayName;
                                                        appToAdd.TimeZoneId = "";
                                                        appToAdd.Type = 0;

                                                        context.Appointments.Add(appToAdd);
                                                        context.SaveChanges();
                                                    }
                                                }
                                                int memberID = MiscStuff.GetMemberID(namecellName.Value.ToString());
                                                int appointmentID = (from a in context.Appointments
                                                                     where DbFunctions.TruncateTime(a.StartDate) == DbFunctions.TruncateTime(tempDate) && a.Subject == activityLabel
                                                                     select a.UniqueID).FirstOrDefault();

                                                if (appointmentID != -1 && memberID != -1)
                                                {
                                                    var checkIfAppointmentMembersExists = (from a in context.AppointmentMembers
                                                                                    where a.AppointmentsID == appointmentID && a.MemberID == memberID
                                                                                    select a).FirstOrDefault();

                                                    if (checkIfAppointmentMembersExists == null)
                                                    {
                                                        var apptMemberToAdd = new AppointmentMember();
                                                        apptMemberToAdd.AppointmentsID = appointmentID;
                                                        apptMemberToAdd.MemberID = memberID;

                                                        context.AppointmentMembers.Add(apptMemberToAdd);
                                                        context.SaveChanges();
                                                    }
                                                }

                                                var checkIfNoteExists = (from n in context.Notes
                                                                         where n.Date == tempDate && n.MemberID == memberID && n.Notes == "Member attended " + activityLabel + " group"
                                                                         select n).FirstOrDefault();

                                                if (checkIfNoteExists == null)
                                                {
                                                    var noteToAdd = new Note();
                                                    noteToAdd.Date = tempDate;
                                                    noteToAdd.Editable = false;
                                                    noteToAdd.MemberID = memberID;
                                                    noteToAdd.Notes = "Member attended " + activityLabel + " group";
                                                    noteToAdd.StaffID = 1;

                                                    context.Notes.Add(noteToAdd);
                                                    context.SaveChanges();
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    spreadsheetControl1.SaveDocument();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
                return false;
            }
            return true;
        }

        private string addActivity(string activityShortcut, ref Cell cellToEdit)
        {
            try
            {
                var formGetInput = new FormAddActivity(activityShortcut);
                DialogResult dr = new DialogResult();

                dr = formGetInput.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    using (var context = new LorikeetAppEntities())
                    {
                        var activityLabel = new Lorikeet.Data.Label
                        {
                            DisplayName = formGetInput.activity,
                            MenuCaption = formGetInput.activity,
                            Shortcut = activityShortcut
                        };
                        Random r = new Random(DateTime.Now.Millisecond);
                        Color randomColor = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
                        activityLabel.Color = randomColor.ToArgb();

                        context.Labels.Add(activityLabel);
                        context.SaveChanges();
                    }
                    return formGetInput.activity;
                }
                else
                {
                    string cellString = cellToEdit.Value.ToString();
                    cellString.Replace(activityShortcut, formGetInput.shortcut);
                    cellToEdit.SetValueFromText(formGetInput.shortcut);
                    using (var context = new LorikeetAppEntities())
                    {
                        var getActivityLabel = (from l in context.Labels
                                                where l.Shortcut == activityShortcut
                                                select l).FirstOrDefault();

                        if (getActivityLabel != null)
                        {
                            return getActivityLabel.DisplayName;
                        }
                        else
                            return null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
                DialogResult = DialogResult.Abort;
                return null;
            }
        }

        private bool checkIfAppointmentExists(string appointmentName, DateTime date)
        {
            try
            {
                using (var context = new LorikeetAppEntities())
                {
                    var checkIfAppointmentExists = (from app in context.Appointments
                                                    where app.Subject == appointmentName && DbFunctions.TruncateTime(app.StartDate) == DbFunctions.TruncateTime(date)
                                                    select app).FirstOrDefault();

                    if (checkIfAppointmentExists == null)
                        return false;
                    else return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
            }
            return false;
        }

        private void FormImportActivities_Load(object sender, EventArgs e)
        {

        }

        private void FormImportActivities_Shown(object sender, EventArgs e)
        {
            LoadActivitiesFile();
        }

        private void spreadsheetControl1_SelectionChanged(object sender, EventArgs e)
        {
            
        }
    }
}
