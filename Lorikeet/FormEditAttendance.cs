using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using Lorikeet.Data;

namespace Lorikeet
{
    public partial class FormEditAttendance : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private List<Member> members = new List<Member>();
        private List<Member> membersToAdd = new List<Member>();
        //private DevExpress.XtraScheduler.Appointment apt;
        private DateTime date;
        private int staffID = -1;

        public FormEditAttendance(DateTime date, int staffID)
        {
            InitializeComponent();
            textBoxDate.Text = date.ToLongDateString();

            this.date = date;
            this.staffID = staffID;

            ResetMembers();
            RefreshMembers();
        }

        private void ResetMembers()
        {
            using (var context = new LorikeetAppEntities())
            {
                try
                {
                    var membersTemp = (from m in context.Members
                                       select m).ToList();

                    membersToAdd = (from m in context.Attendances
                                   join r in context.Members on m.MemberID equals r.MemberID
                                   where m.Date == date
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
            ResetMembers();
            RefreshMembers();
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

            using (var context = new LorikeetAppEntities())
            {
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

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (var context = new LorikeetAppEntities())
                {
                    var attendanceToRemove = (from a in context.Attendances
                                                where DbFunctions.TruncateTime(a.Date) == DbFunctions.TruncateTime(date)
                                                select a).ToList();

                    var notesToRemove = (from ntr in context.Notes
                                            join a in context.Members on ntr.MemberID equals a.MemberID
                                            where DbFunctions.TruncateTime(ntr.Date) == DbFunctions.TruncateTime(date) && ntr.Notes == "Member Attended Lorikeet Centre" && ntr.MemberID == a.MemberID
                                            select ntr).ToList();

                    if (attendanceToRemove.Count > 0)
                    {
                        foreach (var atr in attendanceToRemove)
                        {
                            context.Attendances.Remove(atr);
                            context.SaveChanges();
                        }
                        
                        foreach (var ntr in notesToRemove)
                        {
                            context.Notes.Remove(ntr);
                            context.SaveChanges();
                        }
                    }

                    foreach (var mta in membersToAdd)
                    {
                        Attendance attendance = new Attendance();
                        attendance.Date = date;
                        attendance.MemberID = mta.MemberID;

                        context.Attendances.Add(attendance);
                        context.SaveChanges();

                        var notesTemp = new Note();
                        notesTemp.Date = date;
                        notesTemp.MemberID = mta.MemberID;
                        notesTemp.StaffID = 0;
                        notesTemp.Notes = "Member Attended Lorikeet Centre";
                        notesTemp.Editable = false;
                        context.Notes.Add(notesTemp);
                        context.SaveChanges();
                    }

                    try
                    {
                        var check = (from a in context.AttendanceNumbers
                                     where DbFunctions.TruncateTime(a.Date) == DbFunctions.TruncateTime(date)
                                     select a).DefaultIfEmpty().DefaultIfEmpty().First();

                        if (check != null)
                        {
                            check.Number = membersToAdd.Count();
                        }
                        else
                        {
                            var checkToAdd = new AttendanceNumber();
                            checkToAdd.Date = date;
                            checkToAdd.Number = membersToAdd.Count();

                            context.AttendanceNumbers.Add(checkToAdd);
                        }

                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(MiscStuff.GetAllMessages(ex));
                    }
                }

                Logging.AddLogEntry(staffID, Logging.ErrorCodes.Broadcast, Logging.RefreshCodes.Schedule, "Changed Attendance in Schedule", false);
            }
            catch (Exception ex)
            {
                Logging.AddLogEntry(staffID, Logging.ErrorCodes.None, Logging.RefreshCodes.None, "Tried Changing Attendance in Schedule - Error - " + ex.Message, false);
            
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
            }
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mainRibbonControl_Click(object sender, EventArgs e)
        {

        }
    }
}
