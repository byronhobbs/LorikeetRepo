using Lorikeet.Data;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Lorikeet
{
    public partial class FormLogin : Form
    {
        public int staffID { get; set; }

        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new LorikeetAppEntities())
                {
                    var validLogin = (from s in context.Staffs
                                        join l in context.Logins on s.LoginID equals l.LoginID
                                        where l.LoginName == textBoxUsername.Text && l.LoginPass == textBoxPassword.Text
                                        select s).DefaultIfEmpty().First();

                    if (validLogin != null)
                    {
                        DialogResult = DialogResult.OK;
                        this.staffID = validLogin.StaffID;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Not a Valid Login and Password");
                        DialogResult = DialogResult.Cancel;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            textBoxUsername.Focus();   

            if (!CheckIfLoginsExists())
            {
                var formPassword = new FormInput("Enter in an Administrator Password", "OK");
                DialogResult dr = formPassword.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    var formPasswordReEnter = new FormInput("Re-enter Administrator Password", "OK");
                    DialogResult dr2 = formPasswordReEnter.ShowDialog();
                    if (dr2 == DialogResult.OK && formPassword.inputText.Equals(formPasswordReEnter.inputText))
                    {
                        using (var context = new LorikeetAppEntities())
                        {
                            var loginAdmin = new Login();
                            loginAdmin.LoginName = "Administrator";
                            loginAdmin.LoginPass = formPassword.inputText;
                            loginAdmin.Pin = 0000;
                            loginAdmin.Access = 10;
                            context.Logins.Add(loginAdmin);
                            context.SaveChanges();

                            var getLoginAdmin = context.Logins.ToList().Last().LoginID;

                            var staffAdmin = new Staff();
                            staffAdmin.LoginID = getLoginAdmin;
                            staffAdmin.StaffName = "Administrator";
                            context.Staffs.Add(staffAdmin);
                            context.SaveChanges();

                            var staffsID = context.Staffs.ToList().Last().StaffID;
                            this.staffID = staffsID;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Passwords are not the same... Exiting...");
                        DialogResult = DialogResult.Cancel;
                        this.Close();
                    }
                }
                else
                {
                    DialogResult = DialogResult.Cancel;
                    this.Close();
                }
            }
        }

        private bool CheckIfLoginsExists()
        {
            try
            {
                using (var context = new LorikeetAppEntities())
                {
                    var checkLoginExists = context.Logins;
                    if (checkLoginExists.Count() > 0)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
                return false;
            }
            return false;
        }
    }
}
