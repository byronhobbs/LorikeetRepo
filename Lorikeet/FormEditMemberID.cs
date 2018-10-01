using Lorikeet.Data;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Lorikeet
{
    public partial class FormEditMemberID : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private int memberID = -1;
        private int staffID = -1;
        public int newMemberID { get; private set; }

        private bool hasToChangeMemberID = false;

        public FormEditMemberID(int memberID, int staffID)
        {
            InitializeComponent();

            this.memberID = memberID;
            this.staffID = staffID;

            bbiChange.Enabled = false;
            textBoxNewID.Focus();
            textBoxOriginalID.Text = "" + memberID;
            newMemberID = -1;
        }

        private void FormEditMemberID_Load(object sender, EventArgs e)
        {

        }

        private void bbiCheck_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            listViewDetails.Items.Clear();

            if (textBoxNewID.Text != "")
            {
                try
                {
                    newMemberID = int.Parse(textBoxNewID.Text);
                }
                catch
                {

                    listViewDetails.Items.Add("Member ID must be valid", 1);
                    bbiChange.Enabled = false;
                    return;
                }

                try
                {
                    using (var context = new LorikeetAppEntities())
                    {
                        var mID = (from m in context.Members
                                   where m.MemberID == newMemberID
                                   select m).Count();

                        if (mID == 0)
                        {
                            listViewDetails.Items.Add("New Member ID is available", 0);
                        }
                        else
                        {
                            listViewDetails.Items.Add("New Member ID is not available", 1);
                            bbiChange.Enabled = false;
                            return;
                        }

                        var contacts = (from c in context.Contacts
                                        where c.MemberID == memberID
                                        select c).Count();

                        if (contacts != 0)
                        {
                            listViewDetails.Items.Add("There are " + contacts + " contacts associated with the original Member ID", 2);
                            hasToChangeMemberID = true;
                        }
                        else
                        {
                            listViewDetails.Items.Add("There are no contacts associated with the original Member ID", 0);
                        }

                        var appointments = (from a in context.AppointmentMembers
                                            where a.MemberID == memberID
                                            select a).Count();

                        if (appointments != 0)
                        {
                            listViewDetails.Items.Add("There are " + appointments + " appointments associated with the original Member ID", 2);
                            hasToChangeMemberID = true;
                        }
                        else
                        {
                            listViewDetails.Items.Add("There are no appointments associated with the original Member ID", 0);
                        }

                        var attendance = (from a in context.Attendances
                                          where a.MemberID == memberID
                                          select a).Count();

                        if (attendance != 0)
                        {
                            listViewDetails.Items.Add("There are " + attendance + " attendance associated with the original Member ID", 2);
                            hasToChangeMemberID = true;
                        }
                        else
                        {
                            listViewDetails.Items.Add("There are no attendance associated with the original Member ID", 0);
                        }

                        var debitcredit = (from dc in context.DebitSystems
                                           where dc.MemberID == memberID
                                           select dc).Count();

                        if (debitcredit != 0)
                        {
                            listViewDetails.Items.Add("There are " + debitcredit + " debitcredit associated with the original Member ID", 2);
                            hasToChangeMemberID = true;
                        }
                        else
                        {
                            listViewDetails.Items.Add("There are no debitcredit associated with the original Member ID", 0);
                        }

                        var diagnosis = (from d in context.Diagnosis
                                         where d.MemberID == memberID
                                         select d).Count();

                        if (diagnosis != 0)
                        {
                            listViewDetails.Items.Add("There are " + diagnosis + " diagnosis associated with the original Member ID", 2);
                            hasToChangeMemberID = true;
                        }
                        else
                        {
                            listViewDetails.Items.Add("There are no diagnosis associated with the original Member ID", 0);
                        }

                        var medication = (from m in context.Medications
                                          where m.MemberID == memberID
                                          select m).Count();

                        if (medication != 0)
                        {
                            listViewDetails.Items.Add("There are " + medication + " medication associated with the original Member ID", 2);
                            hasToChangeMemberID = true;
                        }
                        else
                        {
                            listViewDetails.Items.Add("There are no medication associated with the original Member ID", 0);
                        }

                        var notes = (from n in context.Notes
                                     where n.MemberID == memberID
                                     select n).Count();

                        if (notes != 0)
                        {
                            listViewDetails.Items.Add("There are " + notes + " notes associated with the original Member ID", 2);
                            hasToChangeMemberID = true;
                        }
                        else
                        {
                            listViewDetails.Items.Add("There are no notes associated with the original Member ID", 0);
                        }

                        if (hasToChangeMemberID)
                        {
                            listViewDetails.Items.Add("Member ID and all associated tables will be changed", 2);
                            bbiChange.Enabled = true;
                            bbiChange.Caption = "Force Change";
                        }
                        else
                        {
                            listViewDetails.Items.Add("Member ID can be changed", 0);
                            bbiChange.Enabled = true;
                            bbiChange.Caption = "Change";
                        }
                    }
                }
                catch
                {

                }
            }
            else
            {
                listViewDetails.Items.Add("Member ID must not be empty", 1);
                bbiChange.Enabled = false;
                return;
            }
        }

        private void bbiChange_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            listViewDetails.Items.Clear();

            if (bbiChange.Caption == "Close")
            {
                this.Close();
            }
            else
            {
                try
                {
                    using (var context = new LorikeetAppEntities())
                    {
                        var memberIDToChange = (from m in context.Members
                                                where m.MemberID == memberID
                                                select m).DefaultIfEmpty().First();

                        if (memberIDToChange != null)
                        {
                            context.Members.Remove(memberIDToChange);
                            context.SaveChanges();

                            listViewDetails.Items.Add("Member removed", 0);

                            memberIDToChange.MemberID = newMemberID;
                            context.Members.Add(memberIDToChange);
                            context.SaveChanges();

                            listViewDetails.Items.Add("Member Added with new ID", 0);
                        }
                    }

                    textBoxOriginalID.Text = "" + newMemberID;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                if (hasToChangeMemberID)
                {
                    try
                    {
                        using (var context = new LorikeetAppEntities())
                        {
                            var contacts = (from c in context.Contacts
                                            where c.MemberID == memberID
                                            select c).ToList();

                            if (contacts.Count() != 0)
                            {
                                foreach (var c in contacts)
                                {
                                    c.MemberID = newMemberID;
                                }
                                context.SaveChanges();


                                listViewDetails.Items.Add("There are " + contacts.Count() + " contacts changed to new Member ID", 0);
                            }
                            else
                            {
                                listViewDetails.Items.Add("There are no contacts needed to change", 0);
                            }

                            var appointments = (from a in context.AppointmentMembers
                                                where a.MemberID == memberID
                                                select a).ToList();

                            if (appointments.Count() != 0)
                            {
                                foreach (var c in appointments)
                                {
                                    c.MemberID = newMemberID;
                                }
                                context.SaveChanges();

                                listViewDetails.Items.Add("There are " + appointments.Count() + " appointments changed to new Member ID", 0);
                            }
                            else
                            {
                                listViewDetails.Items.Add("There are no appointments needed to change", 0);
                            }

                            var attendance = (from a in context.Attendances
                                              where a.MemberID == memberID
                                              select a).ToList();

                            if (attendance.Count() != 0)
                            {
                                foreach (var c in attendance)
                                {
                                    c.MemberID = newMemberID;
                                }
                                context.SaveChanges();

                                listViewDetails.Items.Add("There are " + attendance.Count() + " attendances changed to new Member ID", 0);
                            }
                            else
                            {
                                listViewDetails.Items.Add("There are no attendance's needed to change", 0);
                            }

                            var debitcredit = (from dc in context.DebitSystems
                                               where dc.MemberID == memberID
                                               select dc).ToList();

                            if (debitcredit.Count() != 0)
                            {
                                foreach (var c in debitcredit)
                                {
                                    c.MemberID = newMemberID;
                                }
                                context.SaveChanges();

                                listViewDetails.Items.Add("There are " + debitcredit.Count() + " debitcredits changed to new Member ID", 0);
                            }
                            else
                            {
                                listViewDetails.Items.Add("There are no debitcredit's needed to change", 0);
                            }

                            var diagnosis = (from d in context.Diagnosis
                                             where d.MemberID == memberID
                                             select d).ToList();

                            if (diagnosis.Count() != 0)
                            {
                                foreach (var c in diagnosis)
                                {
                                    c.MemberID = newMemberID;
                                }
                                context.SaveChanges();

                                listViewDetails.Items.Add("There are " + diagnosis.Count() + " diagnosis changed to new Member ID", 0);
                            }
                            else
                            {
                                listViewDetails.Items.Add("There are no diagnosis needed to change", 0);
                            }

                            var medication = (from m in context.Medications
                                              where m.MemberID == memberID
                                              select m).ToList();

                            if (medication.Count() != 0)
                            {
                                foreach (var c in medication)
                                {
                                    c.MemberID = newMemberID;
                                }
                                context.SaveChanges();

                                listViewDetails.Items.Add("There are " + medication.Count() + " medication changed to new Member ID", 0);
                            }
                            else
                            {
                                listViewDetails.Items.Add("There are no medication needed to change", 0);
                            }

                            var notes = (from n in context.Notes
                                         where n.MemberID == memberID
                                         select n).ToList();

                            if (notes.Count() != 0)
                            {
                                foreach (var c in notes)
                                {
                                    c.MemberID = newMemberID;
                                }
                                context.SaveChanges();

                                listViewDetails.Items.Add("There are " + notes.Count() + " notes changed to new Member ID", 0);
                            }
                            else
                            {
                                listViewDetails.Items.Add("There are no notes needed to change", 0);
                            }
                        }

                        Logging.AddLogEntry(staffID, Logging.ErrorCodes.Broadcast, Logging.RefreshCodes.Member, "Member ID " + memberID + " has been changed to " + newMemberID, false);
                    }
                    catch (Exception ex)
                    {
                        Logging.AddLogEntry(staffID, Logging.ErrorCodes.Error, Logging.RefreshCodes.None, "Member ID " + memberID + " has been tried to change to " + newMemberID + " but failed - Error - " + ex.Message, false);
                        MessageBox.Show(ex.Message);
                    }
                }

                bbiChange.Enabled = false;
                bbiCheck.Enabled = false;
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
