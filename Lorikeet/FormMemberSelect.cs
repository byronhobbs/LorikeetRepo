using Lorikeet.Data;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Lorikeet
{
    public partial class FormMemberSelect : Form
    {
        public int memberID { get; set; }
        public FormMemberSelect()
        {
            InitializeComponent();

            try
            {
                using (var context = new LorikeetAppEntities())
                {
                    var listItemMemberNames = (from m in context.Members
                                               select m).ToList();

                    if (listItemMemberNames != null)
                    {
                        foreach (var names in listItemMemberNames)
                        {
                            comboBoxEditMemberNames.Properties.Items.Add(names.FirstName + " " + names.Surname);
                        }
                    }
                }
            }
            catch
            {
                DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new LorikeetAppEntities())
                {
                    var memberChosen = comboBoxEditMemberNames.SelectedItem.ToString().Split(' ');
                    var firstName = memberChosen[0];
                    var surname = memberChosen[1];


                    var memberIDSelected = (from m in context.Members
                                            where m.FirstName == firstName && m.Surname == surname
                                            select m).DefaultIfEmpty().First();

                    if (memberIDSelected != null)
                    {
                        this.memberID = memberIDSelected.MemberID;
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch
            {
                DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void FormMemberSelect_Load(object sender, EventArgs e)
        {

        }
    }
}
