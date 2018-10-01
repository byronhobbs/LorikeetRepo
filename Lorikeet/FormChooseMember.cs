using Lorikeet.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Lorikeet
{
    public partial class FormChooseMember : Form
    {
        public string memberName { get; private set; }

        public FormChooseMember(List<Member> memberNames, string memberName)
        {
            InitializeComponent();

            textBoxMName.Text = memberName;

            foreach (var m in memberNames)
            {
                listBoxMemberName.Items.Add(m.FirstName + " " + m.Surname);
            }

            RefreshMemberListBox();
        }

        public FormChooseMember(List<string> memberNames, string memberName)
        {
            InitializeComponent();

            textBoxMName.Text = memberName;

            foreach (var m in memberNames)
            {
                listBoxMemberName.Items.Add(m);
            }

            RefreshMemberListBox();
        }

        private void RefreshMemberListBox()
        {
            listBoxAllMemberNames.Items.Clear();

            try
            {
                using (var context = new LorikeetAppEntities())
                {
                    var getAllMemberName = (from m in context.Members
                                            select m).ToList();

                    foreach (var m in getAllMemberName)
                    {
                        if ((m.FirstName + " " + m.Surname).ToLower().StartsWith(textBoxMNameToChangeTo.Text.ToLower()))
                        {
                            listBoxAllMemberNames.Items.Add(m.FirstName + " " + m.Surname);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
            }
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            if (textBoxMNameToChangeTo.Text.Trim() != "")
            {
                try
                {
                    using (var context = new LorikeetAppEntities())
                    {
                        string[] nameSplit = textBoxMNameToChangeTo.Text.Trim().Split(' ');
                        if (nameSplit.Count() >= 2)
                        {
                            string fName = nameSplit[0];
                            string sName = nameSplit[1];

                            var checkIfMemberNameExists = (from m in context.Members
                                                           where m.FirstName == fName && m.Surname == sName
                                                           select m).DefaultIfEmpty().First();
                            if (checkIfMemberNameExists != null)
                            {
                                memberName = fName + " " + sName;

                                DialogResult = DialogResult.OK;
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("The member Name has to be the Full Name");
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(MiscStuff.GetAllMessages(ex));
                    return;
                }
            }
            else MessageBox.Show("Please Enter a Member Name");
        }

        private void FormChooseMember_Load(object sender, EventArgs e)
        {

        }

        private void listBoxMemberName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string curItem = listBoxMemberName.SelectedItem.ToString();

                textBoxMNameToChangeTo.Text = curItem;
                RefreshMemberListBox();
            }
            catch { }
        }

        private void textBoxMNameToChangeTo_TextChanged(object sender, EventArgs e)
        {
            RefreshMemberListBox();
        }

        private void listBoxAllMemberNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string curItem = listBoxAllMemberNames.SelectedItem.ToString();

                textBoxMNameToChangeTo.Text = curItem;
                RefreshMemberListBox();
            }
            catch { }
        }
    }
}
