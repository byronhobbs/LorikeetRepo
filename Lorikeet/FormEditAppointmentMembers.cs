using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using Lorikeet.Data;

namespace Lorikeet
{
    public partial class FormEditAppointmentMembers : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private List<Member> members = new List<Member>();
        private List<Member> membersToAdd = new List<Member>();
        private DevExpress.XtraScheduler.Appointment apt;
        private int staffID = -1;

        public FormEditAppointmentMembers(DevExpress.XtraScheduler.Appointment apt, int staffID)
        {
            InitializeComponent();

            this.staffID = staffID;
            this.apt = apt;

            textBoxActivity.Text = apt.Subject.ToString();
            textBoxDate.Text = apt.Start.ToShortDateString();


            ResetMembers();
            RefreshMembers();
        }

        private void ResetMembers()
        {
            using (var context = new LorikeetAppEntities())
            {
                try
                {
                    var appointID = GetAppointmentID();

                    var membersTemp = (from m in context.Members
                               select m).ToList();

                    membersToAdd = (from m in context.AppointmentMembers
                                   join r in context.Members on m.MemberID equals r.MemberID
                                   where m.AppointmentsID == appointID
                                   select r).ToList();

                    members = membersTemp.Except(membersToAdd).ToList();
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(MiscStuff.GetAllMessages(ex));
                }
            }
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            using (var context = new LorikeetAppEntities())
            {
                try
                {
                    if (listBoxControlMembers.SelectedIndex != -1)
                    {
                        var memberToRemove = listBoxControlMembers.SelectedItem.ToString().Split(' ');
                        string firstName = memberToRemove[0];
                        string surname = memberToRemove[1];


                        Member memberTemp = (from m in context.Members
                                                             where m.FirstName == firstName && m.Surname == surname
                                                             select m).DefaultIfEmpty().First();

                        if (memberTemp != null)
                        {
                            membersToAdd.Add(memberTemp);
                            members.RemoveAt(listBoxControlMembers.SelectedIndex);

                            textBoxMemberFilter.Text = "";
                            RefreshMembers();
                        }
                        else
                        {
                            MessageBox.Show("Something wrong happened");
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(MiscStuff.GetAllMessages(ex));
                }
            }
        }

        private void bbiReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ClearMembers();
        }

        private void ButtonClearMembers_Click(object sender, EventArgs e)
        {
            ClearMembers();
        }

        private void ClearMembers()
        {
            using (var context = new LorikeetAppEntities())
            {
                try
                {
                    members = (from m in context.Members
                               select m).ToList();

                    membersToAdd = new List<Member>();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(MiscStuff.GetAllMessages(ex));
                }
            }

            RefreshMembers();
        }

        private void RefreshMembers()
        {
            listBoxControlMembers.Items.Clear();
            listBoxControlMembersToAdd.Items.Clear();
            
            try
            {
                if (members != null)
                {
                    foreach (var m in members)
                    {
                        if ((m.FirstName + " " + m.Surname).ToLower().StartsWith(textBoxMemberFilter.Text.ToLower()))
                        {
                            listBoxControlMembers.Items.Add((m.FirstName + " " + m.Surname));
                        }
                    }
                }

                if (membersToAdd != null)
                {
                    foreach (var m in membersToAdd)
                    {
                        listBoxControlMembersToAdd.Items.Add((m.FirstName + " " + m.Surname));
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(MiscStuff.GetAllMessages(ex));
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            RefreshMembers();
        }

        private void ButtonRemoveMember_Click(object sender, EventArgs e)
        {
            using (var context = new LorikeetAppEntities())
            {
                try
                {
                    if (listBoxControlMembersToAdd.SelectedIndex != -1)
                    {
                        var memberToRemove = listBoxControlMembersToAdd.SelectedItem.ToString().Split(' ');
                        string firstName = memberToRemove[0];
                        string surname = memberToRemove[1];


                        Member memberTemp = (from m in context.Members
                                                             where m.FirstName == firstName && m.Surname == surname
                                                             select m).DefaultIfEmpty().First();

                        if (memberTemp != null)
                        {
                            membersToAdd.RemoveAt(listBoxControlMembersToAdd.SelectedIndex);
                            members.Add(memberTemp);

                            textBoxMemberFilter.Text = "";
                            RefreshMembers();
                        }
                        else
                        {
                            MessageBox.Show("Something wrong happened");
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(MiscStuff.GetAllMessages(ex));
                }
            }
        }

        private int GetAppointmentID()
        {
            using (var context = new LorikeetAppEntities())
            {
                try
                {
                    var aptID = (from a in context.Appointments
                                 where DbFunctions.TruncateTime(a.StartDate) == DbFunctions.TruncateTime(apt.Start) && a.Subject == apt.Subject
                                 select a).DefaultIfEmpty().First();

                    return aptID.UniqueID;
                                
                }
                catch (Exception ex)
                {
                    MessageBox.Show(MiscStuff.GetAllMessages(ex));
                }
            }

            return -1;
        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int apptID = GetAppointmentID();

            if (apptID != -1)
            {
                using (var context = new LorikeetAppEntities())
                {
                    try
                    {
                        var appointmentName = (from an in context.Appointments
                                                  where an.UniqueID == apptID
                                                  select an).First();

                        var appointmentsToRemove = (from atr in context.AppointmentMembers
                                                    where atr.AppointmentsID == apptID
                                                    select atr).ToList();

                        var notesToRemove = (from ntr in context.Notes
                                             join a in context.Members on ntr.MemberID equals a.MemberID
                                             where DbFunctions.TruncateTime(ntr.Date) == DbFunctions.TruncateTime(apt.Start) && ntr.Notes == "Member attended " + apt.Subject + " group" && ntr.MemberID == a.MemberID
                                             select ntr).ToList();
                                             
                        if (appointmentsToRemove.Count > 0)
                        {
                            foreach (var atr in appointmentsToRemove)
                            {
                                context.AppointmentMembers.Remove(atr);
                                context.SaveChanges();
                            }

                            foreach (var ntr in notesToRemove)
                            {
                                context.Notes.Remove(ntr);
                                context.SaveChanges();
                            }
                        }
                        
                        foreach (var m in membersToAdd)
                        {
                            var memberAppointmentTemp = new AppointmentMember();
                            memberAppointmentTemp.AppointmentsID = apptID;
                            memberAppointmentTemp.MemberID = m.MemberID;

                            context.AppointmentMembers.Add(memberAppointmentTemp);
                            context.SaveChanges();

                            var notesTemp = new Note();
                            notesTemp.Date = appointmentName.StartDate.Value;
                            notesTemp.MemberID = m.MemberID;
                            notesTemp.StaffID = 0;
                            notesTemp.Notes = "Member attended " + appointmentName.Subject + " group";
                            context.Notes.Add(notesTemp);
                            context.SaveChanges();
                        }

                        var activity = (from an in context.AppointmentsNumbers
                                        join l in context.Labels on an.LabelID equals l.LabelID
                                        where DbFunctions.TruncateTime(an.Date) == DbFunctions.TruncateTime(apt.Start) && l.DisplayName == apt.Subject
                                        select an).DefaultIfEmpty().First();

                        var labelID = (from l in context.Labels
                                       where l.DisplayName == apt.Subject
                                       select l).DefaultIfEmpty().First();

                        if (activity != null)
                        {
                            activity.Number = membersToAdd.Count();
                        }
                        else
                        {
                            if (labelID != null)
                            {
                                var activityNumberToAdd = new AppointmentsNumber();
                                activityNumberToAdd.Date = this.apt.Start;
                                activityNumberToAdd.LabelID = labelID.LabelID;
                                activityNumberToAdd.Number = membersToAdd.Count();

                                context.AppointmentsNumbers.Add(activityNumberToAdd);
                            }
                        }

                        context.SaveChanges();

                        Logging.AddLogEntry(staffID, Logging.ErrorCodes.Broadcast, Logging.RefreshCodes.Schedule, "Changed Appointments in Schedule", false);
                    }
                    catch (Exception ex)
                    {
                        Logging.AddLogEntry(staffID, Logging.ErrorCodes.Error, Logging.RefreshCodes.None, "Tried Changing Appointments in Schedule - Error - " + ex.Message, false);
                        MessageBox.Show(MiscStuff.GetAllMessages(ex));
                    }
                }
            }
            this.Close();
        }

        private void mainRibbonControl_Click(object sender, EventArgs e)
        {

        }
    }
}
