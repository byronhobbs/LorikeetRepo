using Lorikeet.Data;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Lorikeet
{
    public partial class FormEditAttendanceNumbers : Form
    {
        private int staffID = -1;
        public FormEditAttendanceNumbers(int staffID)
        {
            InitializeComponent();

            this.staffID = staffID;
        }

        private void FormEditAttendanceNumbers_Load(object sender, EventArgs e)
        {
            dateEditEditAttendance.Properties.Mask.UseMaskAsDisplayFormat = true;
            dateEditEditAttendance.DateTime = DateTime.Today.AddDays(-1);
            AddDayToDate();
            GetAttendanceNumber();
        }

        private void buttonAddClose_Click(object sender, EventArgs e)
        {
            Logging.AddLogEntry(staffID, Logging.ErrorCodes.OK, Logging.RefreshCodes.Schedule, "Changed the Attendance numbers", false);
            this.Close();
        }

        private void buttonAddNext_Click(object sender, EventArgs e)
        {
            UpdateAttendanceNumbers();
            textBoxNumber.Focus();
            AddDayToDate();
        }

        private void buttonPreviousDay_Click(object sender, EventArgs e)
        {
            UpdateAttendanceNumbers();
            textBoxNumber.Focus();
            MinusDayToDate();
        }

        private void AddDayToDate()
        {
            if (dateEditEditAttendance.DateTime.DayOfWeek == DayOfWeek.Monday)
            {
                dateEditEditAttendance.EditValue = ((DateTime)dateEditEditAttendance.EditValue).AddDays(1);
            }
            else if (dateEditEditAttendance.DateTime.DayOfWeek == DayOfWeek.Tuesday)
            {
                dateEditEditAttendance.EditValue = ((DateTime)dateEditEditAttendance.EditValue).AddDays(1);
            }
            else if (dateEditEditAttendance.DateTime.DayOfWeek == DayOfWeek.Wednesday)
            {
                dateEditEditAttendance.EditValue = ((DateTime)dateEditEditAttendance.EditValue).AddDays(1);
            }
            else if (dateEditEditAttendance.DateTime.DayOfWeek == DayOfWeek.Thursday)
            {
                dateEditEditAttendance.EditValue = ((DateTime)dateEditEditAttendance.EditValue).AddDays(1);
            }
            else if (dateEditEditAttendance.DateTime.DayOfWeek == DayOfWeek.Friday)
            {
                dateEditEditAttendance.EditValue = ((DateTime)dateEditEditAttendance.EditValue).AddDays(4);
            }
            else if (dateEditEditAttendance.DateTime.DayOfWeek == DayOfWeek.Saturday)
            {
                dateEditEditAttendance.EditValue = ((DateTime)dateEditEditAttendance.EditValue).AddDays(3);
            }
            else if (dateEditEditAttendance.DateTime.DayOfWeek == DayOfWeek.Sunday)
            {
                dateEditEditAttendance.EditValue = ((DateTime)dateEditEditAttendance.EditValue).AddDays(2);
            }

            GetAttendanceNumber();
        }

        private void MinusDayToDate()
        {
            if (dateEditEditAttendance.DateTime.DayOfWeek == DayOfWeek.Monday)
            {
                dateEditEditAttendance.EditValue = ((DateTime)dateEditEditAttendance.EditValue).AddDays(-3);
            }
            else if (dateEditEditAttendance.DateTime.DayOfWeek == DayOfWeek.Tuesday)
            {
                dateEditEditAttendance.EditValue = ((DateTime)dateEditEditAttendance.EditValue).AddDays(-4);
            }
            else if (dateEditEditAttendance.DateTime.DayOfWeek == DayOfWeek.Wednesday)
            {
                dateEditEditAttendance.EditValue = ((DateTime)dateEditEditAttendance.EditValue).AddDays(-1);
            }
            else if (dateEditEditAttendance.DateTime.DayOfWeek == DayOfWeek.Thursday)
            {
                dateEditEditAttendance.EditValue = ((DateTime)dateEditEditAttendance.EditValue).AddDays(-1);
            }
            else if (dateEditEditAttendance.DateTime.DayOfWeek == DayOfWeek.Friday)
            {
                dateEditEditAttendance.EditValue = ((DateTime)dateEditEditAttendance.EditValue).AddDays(-1);
            }
            else if (dateEditEditAttendance.DateTime.DayOfWeek == DayOfWeek.Saturday)
            {
                dateEditEditAttendance.EditValue = ((DateTime)dateEditEditAttendance.EditValue).AddDays(-1);
            }
            else if (dateEditEditAttendance.DateTime.DayOfWeek == DayOfWeek.Sunday)
            {
                dateEditEditAttendance.EditValue = ((DateTime)dateEditEditAttendance.EditValue).AddDays(-2);
            }

            GetAttendanceNumber();
        }

        private void GetAttendanceNumber()
        {
            try
            {
                DateTime todaysDate;

                if (DateTime.TryParse(dateEditEditAttendance.Text, out todaysDate))
                {
                    using (var context = new LorikeetAppEntities())
                    {
                        var attendanceNumber = (from a in context.AttendanceNumbers
                                                where DbFunctions.TruncateTime(a.Date) == todaysDate.Date
                                                select a).DefaultIfEmpty().First();

                        if (attendanceNumber != null)
                        {
                            textBoxNumber.Text = attendanceNumber.Number.ToString();
                        }
                        else
                        {
                            textBoxNumber.Text = "0";
                        }
                    }
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
            }
        }

        private void UpdateAttendanceNumbers()
        {
            try
            {
                int numberToAdd = 0;
                DateTime dateOfMemberToAdd;

                if (int.TryParse(textBoxNumber.Text, out numberToAdd) && DateTime.TryParse(dateEditEditAttendance.Text, out dateOfMemberToAdd))
                {
                    if (numberToAdd > 0)
                    {
                        using (var context = new LorikeetAppEntities())
                        {
                            var updateOrAddAttendanceNumbers = (from a in context.AttendanceNumbers
                                                                where DbFunctions.TruncateTime(a.Date) == DbFunctions.TruncateTime(dateOfMemberToAdd)
                                                                select a).DefaultIfEmpty().First();

                            if (updateOrAddAttendanceNumbers != null)
                            {
                                updateOrAddAttendanceNumbers.Number = numberToAdd;
                            }
                            else
                            {
                                var attendanceToAdd = new AttendanceNumber();
                                attendanceToAdd.Date = dateOfMemberToAdd;
                                attendanceToAdd.Number = numberToAdd;

                                context.AttendanceNumbers.Add(attendanceToAdd);
                            }
                            context.SaveChanges();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
            }
        }

        private void dateEditEditAttendance_TextChanged(object sender, EventArgs e)
        {
            UpdateAttendanceNumbers();
        }
    }
}
