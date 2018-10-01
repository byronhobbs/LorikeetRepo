using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Lorikeet.Data;

namespace Lorikeet
{
    public partial class FormAddEditLogin : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private int staffID = -1;
        private bool addUser = false;
        private int access = -1;
        private bool userEditing = false;

        public FormAddEditLogin(int staffID)
        {
            InitializeComponent();

            this.staffID = staffID;
            access = MiscStuff.GetAccessLevel(staffID);
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbiAddUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bbiEditUser.Enabled = false;
            bbiAddUser.Enabled = false;
            rpgOKCancel.Visible = true;

            textBoxEnterPass.Text = "";
            textBoxReEnterPass.Text = "";
            textBoxLoginName.Text = "";
            textBoxUserName.Text = "";
            textBoxPIN.Text = "";
            comboBoxAccess.SelectedIndex = 0;

            textBoxEnterPass.Enabled = true;
            textBoxReEnterPass.Enabled = true;
            textBoxLoginName.Enabled = true;
            textBoxUserName.Enabled = true;
            textBoxPIN.Enabled = true;
            comboBoxAccess.Enabled = true;

            addUser = true;
            userEditing = true;
        }

        private void FormAddEditLogin_Load(object sender, EventArgs e)
        {
            ResetForm();
            RefreshUserListBox();
            RefreshAccessComboBox();
        }

        private void RefreshAccessComboBox()
        {
            if (access == 10)
            {
                comboBoxAccess.Items.Add("10");
                comboBoxAccess.Items.Add("8");
            }
            if (access >= 8)
            {
                comboBoxAccess.Items.Add("6");
            }
        }

        private void RefreshUserListBox()
        {
            try
            {
                using (var context = new LorikeetAppEntities())
                {
                    listBoxUsers.Items.Clear();

                    var usernames = (from log in context.Logins
                                     join staff in context.Staffs on log.LoginID equals staff.LoginID
                                     select new { staff, log }).ToList();

                    string staffName = MiscStuff.GetStaffName(staffID);

                    foreach (var name in usernames)
                    {
                        if (access == 10)
                        {
                            listBoxUsers.Items.Add(name.staff.StaffName);
                        }
                        else if ((access == 8 && staffName.Equals(name.staff.StaffName)) || name.log.Access <= 6)
                        {
                            listBoxUsers.Items.Add(name.staff.StaffName);
                        }
                        else if (access == 6 && staffName.Equals(name.staff.StaffName))
                        {
                            listBoxUsers.Items.Add(name.staff.StaffName);
                        }
                    }
                }
            }
            catch { }
        }

        private void textBoxEnterPass_TextChanged(object sender, EventArgs e)
        {
            if (userEditing)
            {
                if (textBoxEnterPass.Text.Count() < 6)
                {
                    epPasswordNotValid.SetError(textBoxEnterPass, "Must be more than 6 characters");
                }
                else
                {
                    epPasswordNotValid.Clear();
                }
            }
        }

        private void textBoxReEnterPass_TextChanged(object sender, EventArgs e)
        {
            if (userEditing)
            {
                if (textBoxEnterPass.Text.Count() >= 6 && textBoxEnterPass.Text.Equals(textBoxReEnterPass.Text))
                {
                    epPasswordValid.SetError(textBoxReEnterPass, "Passwords Match");
                }
                else
                {
                    epPasswordValid.Clear();
                }
            }
        }

        private void bbiEditUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            addUser = false;
            textBoxEnterPass.Enabled = true;
            textBoxReEnterPass.Enabled = true;

            bbiAddUser.Enabled = false;
            bbiEditUser.Enabled = false;

            userEditing = true;
            
            rpgOKCancel.Visible = true;
        }

        private void listBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string curItem = listBoxUsers.SelectedItem.ToString();

                using (var context = new LorikeetAppEntities())
                {
                    var userSelected = (from log in context.Logins
                                        join staff in context.Staffs on log.LoginID equals staff.LoginID
                                        where staff.StaffName == curItem
                                        select new { log, staff }).FirstOrDefault();

                    if (userSelected != null)
                    {
                        textBoxEnterPass.Text = userSelected.log.LoginPass;
                        textBoxReEnterPass.Text = userSelected.log.LoginPass;
                        textBoxLoginName.Text = userSelected.log.LoginName;
                        textBoxUserName.Text = userSelected.staff.StaffName;
                        textBoxPIN.Text = userSelected.log.Pin.ToString();
                        comboBoxAccess.Text = userSelected.log.Access.ToString();
                        bbiEditUser.Enabled = true;
                    }
                }
            }
            catch { }
        }

        private void bbiOK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (addUser)
                {
                    if (textBoxLoginName.Text.Count() >= 4 && textBoxUserName.Text.Count() >= 4)
                    {
                        if (textBoxEnterPass.Text.Count() >= 6)
                        {
                            if (textBoxEnterPass.Text.Equals(textBoxReEnterPass.Text))
                            {
                                if (textBoxPIN.Text.Count() == 4)
                                {
                                    using (var context = new LorikeetAppEntities())
                                    {
                                        var checkIfUserExists = (from log in context.Logins
                                                                 join staff in context.Staffs on log.LoginID equals staff.LoginID
                                                                 where staff.StaffName == textBoxUserName.Text && log.LoginName == textBoxLoginName.Text
                                                                 select new { staff, log }).FirstOrDefault();

                                        if (checkIfUserExists == null)
                                        {
                                            var loginToAdd = new Login();
                                            loginToAdd.Access = int.Parse(comboBoxAccess.Text);
                                            loginToAdd.LoginName = textBoxLoginName.Text;
                                            loginToAdd.LoginPass = textBoxEnterPass.Text;
                                            loginToAdd.Pin = int.Parse(textBoxPIN.Text);
                                            context.Logins.Add(loginToAdd);
                                            context.SaveChanges();

                                            var idForStaffToAdd = context.Logins.ToList().Last();

                                            if (idForStaffToAdd != null)
                                            {
                                                var staffToAdd = new Staff();
                                                staffToAdd.StaffName = textBoxUserName.Text;
                                                staffToAdd.LoginID = idForStaffToAdd.LoginID;

                                                context.Staffs.Add(staffToAdd);
                                                context.SaveChanges();
                                            }

                                            ResetForm();
                                            RefreshUserListBox();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Username and/or Login name is already taken");
                                            return;
                                        }

                                    }
                                }
                                else
                                {
                                    MessageBox.Show("PIM Must be 4 characters");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Passwords do not match");
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Password must be more than 6 characters");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Login and Usernames must be more than 4 characters");
                        return;
                    }
                }
                else
                {
                    using (var context = new LorikeetAppEntities())
                    {
                        if (textBoxEnterPass.Text.Count() >= 6)
                        {
                            if (textBoxEnterPass.Text.Equals(textBoxReEnterPass.Text))
                            {
                                var loginToEdit = (from l in context.Logins
                                                   where l.LoginName == textBoxLoginName.Text
                                                   select l).FirstOrDefault();

                                if (loginToEdit != null)
                                {
                                    loginToEdit.LoginPass = textBoxEnterPass.Text;

                                    context.Logins.Add(loginToEdit);
                                    context.SaveChanges();

                                    ResetForm();
                                    RefreshUserListBox();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Passwords don't match");
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Password must be at least 6 characters");
                            return;
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

        private void ResetForm()
        {
            bbiEditUser.Enabled = false;
            if (access >= 8)
            {
                bbiAddUser.Enabled = true;
            }
            else
            {
                bbiAddUser.Enabled = false;
            }

            rpgOKCancel.Visible = false;

            textBoxEnterPass.Enabled = false;
            textBoxReEnterPass.Enabled = false;
            textBoxLoginName.Enabled = false;
            textBoxUserName.Enabled = false;
            textBoxPIN.Enabled = false;
            comboBoxAccess.Enabled = false;
            userEditing = false;
        }

        private void bbiCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ResetForm();
        }

        private void textBoxPIN_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FormAddEditLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}