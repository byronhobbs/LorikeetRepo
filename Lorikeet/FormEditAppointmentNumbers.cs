using Lorikeet.Data;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Lorikeet
{
    public partial class FormEditAppointmentNumbers : Form
    {
        private int staffID = -1;
        public FormEditAppointmentNumbers(int staffID)
        {
            InitializeComponent();

            this.staffID = staffID;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Logging.AddLogEntry(staffID, Logging.ErrorCodes.OK, Logging.RefreshCodes.Schedule, "Changed the Activity numbers", false);
            this.Close();
        }

        private void buttonAddNext_Click(object sender, EventArgs e)
        {
            UpdateActivityNumbers();
            textBoxNumber.Focus();
            AddDayToDate();
            GetActivityNumbers();
        }

        private void buttonPrevNum_Click(object sender, EventArgs e)
        {
            UpdateActivityNumbers();
            textBoxNumber.Focus();
            MinusDayToDate();
            GetActivityNumbers();
        }

        private void FormEditAppointmentNumbers_Load(object sender, EventArgs e)
        {
            dateEditEditActivity.Properties.Mask.UseMaskAsDisplayFormat = true;
            dateEditEditActivity.DateTime = DateTime.Today.AddDays(-1);
            AddDayToDate();
            UpdateLabelsList();
            GetActivityNumbers();
        }

        private void UpdateLabelsList()
        {
            try
            {
                using (var context = new LorikeetAppEntities())
                {
                    var labelsToAddToList = (from l in context.Labels
                                             select l).ToList();

                    if (labelsToAddToList.Any())
                    {
                        foreach (var labels in labelsToAddToList)
                        {
                            comboBoxEditLabels.Properties.Items.Add(labels.DisplayName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
            }

            comboBoxEditLabels.SelectedIndex = 0;
        }

        private void AddDayToDate()
        {
            if (dateEditEditActivity.DateTime.DayOfWeek == DayOfWeek.Monday)
            {
                dateEditEditActivity.EditValue = ((DateTime)dateEditEditActivity.EditValue).AddDays(1);
            }
            else if (dateEditEditActivity.DateTime.DayOfWeek == DayOfWeek.Tuesday)
            {
                dateEditEditActivity.EditValue = ((DateTime)dateEditEditActivity.EditValue).AddDays(1);
            }
            else if (dateEditEditActivity.DateTime.DayOfWeek == DayOfWeek.Wednesday)
            {
                dateEditEditActivity.EditValue = ((DateTime)dateEditEditActivity.EditValue).AddDays(1);
            }
            else if (dateEditEditActivity.DateTime.DayOfWeek == DayOfWeek.Thursday)
            {
                dateEditEditActivity.EditValue = ((DateTime)dateEditEditActivity.EditValue).AddDays(1);
            }
            else if (dateEditEditActivity.DateTime.DayOfWeek == DayOfWeek.Friday)
            {
                dateEditEditActivity.EditValue = ((DateTime)dateEditEditActivity.EditValue).AddDays(4);
            }
            else if (dateEditEditActivity.DateTime.DayOfWeek == DayOfWeek.Saturday)
            {
                dateEditEditActivity.EditValue = ((DateTime)dateEditEditActivity.EditValue).AddDays(3);
            }
            else if (dateEditEditActivity.DateTime.DayOfWeek == DayOfWeek.Sunday)
            {
                dateEditEditActivity.EditValue = ((DateTime)dateEditEditActivity.EditValue).AddDays(2);
            }
        }

        private void MinusDayToDate()
        {
            if (dateEditEditActivity.DateTime.DayOfWeek == DayOfWeek.Monday)
            {
                dateEditEditActivity.EditValue = ((DateTime)dateEditEditActivity.EditValue).AddDays(-3);
            }
            else if (dateEditEditActivity.DateTime.DayOfWeek == DayOfWeek.Tuesday)
            {
                dateEditEditActivity.EditValue = ((DateTime)dateEditEditActivity.EditValue).AddDays(-4);
            }
            else if (dateEditEditActivity.DateTime.DayOfWeek == DayOfWeek.Wednesday)
            {
                dateEditEditActivity.EditValue = ((DateTime)dateEditEditActivity.EditValue).AddDays(-1);
            }
            else if (dateEditEditActivity.DateTime.DayOfWeek == DayOfWeek.Thursday)
            {
                dateEditEditActivity.EditValue = ((DateTime)dateEditEditActivity.EditValue).AddDays(-1);
            }
            else if (dateEditEditActivity.DateTime.DayOfWeek == DayOfWeek.Friday)
            {
                dateEditEditActivity.EditValue = ((DateTime)dateEditEditActivity.EditValue).AddDays(-1);
            }
            else if (dateEditEditActivity.DateTime.DayOfWeek == DayOfWeek.Saturday)
            {
                dateEditEditActivity.EditValue = ((DateTime)dateEditEditActivity.EditValue).AddDays(-1);
            }
            else if (dateEditEditActivity.DateTime.DayOfWeek == DayOfWeek.Sunday)
            {
                dateEditEditActivity.EditValue = ((DateTime)dateEditEditActivity.EditValue).AddDays(-2);
            }
        }

        private void UpdateActivityNumbers()
        {
            try
            {
                int numberToAdd = 0;
                DateTime dateOfActivityToAdd;

                if (int.TryParse(textBoxNumber.Text, out numberToAdd) && DateTime.TryParse(dateEditEditActivity.Text, out dateOfActivityToAdd))
                {
                    if (numberToAdd > 0)
                    {
                        using (var context = new LorikeetAppEntities())
                        {
                            var updateOrAddActivityNumbers = (from a in context.AppointmentsNumbers
                                                              join l in context.Labels on a.LabelID equals l.LabelID
                                                              where DbFunctions.TruncateTime(a.Date) == DbFunctions.TruncateTime(dateOfActivityToAdd) && l.DisplayName == comboBoxEditLabels.Text
                                                              select a).DefaultIfEmpty().First();
                            if (updateOrAddActivityNumbers != null)
                            {
                                updateOrAddActivityNumbers.Number = numberToAdd;
                            }
                            else
                            {
                                var getLabelID = (from l in context.Labels
                                                  where l.DisplayName == comboBoxEditLabels.Text
                                                  select l).DefaultIfEmpty().First();

                                if (getLabelID != null)
                                {
                                    var activityToAdd = new AppointmentsNumber();
                                    activityToAdd.Number = numberToAdd;
                                    activityToAdd.Date = dateOfActivityToAdd;
                                    activityToAdd.LabelID = getLabelID.LabelID;
                                    context.AppointmentsNumbers.Add(activityToAdd);
                                }
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

        private void GetActivityNumbers()
        {
            try
            {
                DateTime todaysDate;

                if (DateTime.TryParse(dateEditEditActivity.Text, out todaysDate))
                {
                    using (var context = new LorikeetAppEntities())
                    {
                        var activityNumber = (from a in context.AppointmentsNumbers
                                              join l in context.Labels on a.LabelID equals l.LabelID
                                              where DbFunctions.TruncateTime(a.Date) == todaysDate.Date && l.DisplayName == comboBoxEditLabels.Text
                                              select a).DefaultIfEmpty().First();

                        if (activityNumber != null)
                        {
                            textBoxNumber.Text = activityNumber.Number.ToString();
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

        private void comboBoxEditLabels_SelectedValueChanged(object sender, EventArgs e)
        {
            GetActivityNumbers();
        }

        private void dateEditEditActivity_TextChanged(object sender, EventArgs e)
        {
            GetActivityNumbers();
        }
    }
}
