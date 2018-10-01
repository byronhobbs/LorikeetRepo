using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using GoogleApi;
using GoogleApi.Entities.Places.AutoComplete.Request;
using GoogleApi.Entities.Places.AutoComplete.Request.Enums;
using Lorikeet.CustomEditor;
using GoogleApi.Entities.Places.Details.Request;
using GoogleApi.Entities.Common.Enums;
using Lorikeet.Data;

namespace Lorikeet
{
    public partial class FormNewMemberWizard : DevExpress.XtraEditors.XtraForm
    {
        private int staffID = -1;
        private string autoAddress = "";
        private int count = 0;
        private FormMapHover mapHoverForm;
        private bool overTheButton;
        private bool hoverOverTheButtonEventTriggered = false;
        private bool _isTimerRunning = false;
        private int counter = 0;
        private Timer timer1 = new Timer();

        public FormNewMemberWizard(int staffID)
        { 
            InitializeComponent();

            this.staffID = staffID;

            mleAddress.Text = "";

            mapHoverForm = new FormMapHover();

            timer1.Tick += new EventHandler(timer1_Tick_1);
        }

        private void buttonCheckMemberID_Click(object sender, EventArgs e)
        {
            if (textBoxMemberID.Text != "")
            {
                try
                {
                    int memberIDToCheck = int.Parse(textBoxMemberID.Text);

                    using (var context = new LorikeetAppEntities())
                    {
                        var checkMemberID = (from m in context.Members
                                             where m.MemberID == memberIDToCheck
                                             select m).Count();
                        
                        if (checkMemberID > 0)
                        {
                            MessageBox.Show("Member ID has been taken");
                        }
                        else
                        {
                            buttonCheckMemberID.Enabled = false;
                            wizardControl1.SelectedPage.AllowNext = true;
                            return;
                        }
                    }
                }
                catch (InvalidCastException)
                {
                    MessageBox.Show("You must enter a valid number");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            wizardControl1.SelectedPage.AllowNext = false;
        }

        private void wizardPage3_PageInit(object sender, EventArgs e)
        {
            textBoxMemberID.Text = "";
            wizardControl1.SelectedPage.AllowNext = false;
            buttonCheckMemberID.Enabled = false;
        }

        private void textBoxMemberID_TextChanged(object sender, EventArgs e)
        {
            if (textBoxMemberID.Text.Equals(""))
            {
                buttonCheckMemberID.Enabled = false;
            }
            else
            {
                try
                {
                    int memberIDToCheck = int.Parse(textBoxMemberID.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    textBoxMemberID.Text = textBoxMemberID.Text.TrimEnd(textBoxMemberID.Text[textBoxMemberID.Text.Length - 1]);
                }
                buttonCheckMemberID.Enabled = true;
            }
        }

        private bool wizardPage1Valid()
        {
            if (textBoxFirstName.Text.Equals("") || textBoxSurname.Text.Equals(""))
                return false;
            else
                return true;           
        }

        private bool wizardPage2Valid()
        {
            if (textBoxStreet.Text.Equals("") || textBoxPostcode.Text.Equals("") || comboBoxEditState.Text.Equals("") || textBoxSuburb.Text.Equals("") || textBoxCountry.Text.Equals("") || textBoxTelephone.Text.Equals(""))
                return false;
            else
                return true;
        }

        private void wizardPage2_PageInit(object sender, EventArgs e)
        {
            if (wizardPage2Valid())
            {
                wizardControl1.SelectedPage.AllowNext = true;
            }
            else
            {
                wizardControl1.SelectedPage.AllowNext = false;
            }

            if (!MiscStuff.CheckForInternetConnection())
            {
                mleAddress.Enabled = false;
                buttonChooseAddress.Enabled = false;
            }
            else
            {
                mleAddress.Enabled = true;
                buttonChooseAddress.Enabled = true;
            }
        }

        private void wizardPage1_PageInit(object sender, EventArgs e)
        {
            if (wizardPage1Valid())
            {
                wizardControl1.SelectedPage.AllowNext = true;
            }
            else
            {
                wizardControl1.SelectedPage.AllowNext = false;
            }

            if (!MiscStuff.CheckForInternetConnection())
            {
                buttonMap.Enabled = false;
            }
            else
            {
                buttonMap.Enabled = true;
            }
        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            if (wizardPage1Valid())
            {
                wizardControl1.SelectedPage.AllowNext = true;
            }
            else
            {
                wizardControl1.SelectedPage.AllowNext = false;
            }
        }

        private void textBoxSurname_TextChanged(object sender, EventArgs e)
        {
            if (wizardPage1Valid())
            {
                wizardControl1.SelectedPage.AllowNext = true;
            }
            else
            {
                wizardControl1.SelectedPage.AllowNext = false;
            }
        }

        private void dateEditDOB_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCOO_TextChanged(object sender, EventArgs e)
        {
            if (wizardPage2Valid())
            {
                wizardControl1.SelectedPage.AllowNext = true;
            }
            else
            {
                wizardControl1.SelectedPage.AllowNext = false;
            }
        }

        private void textBoxStreet_TextChanged(object sender, EventArgs e)
        {
            if (wizardPage2Valid())
            {
                wizardControl1.SelectedPage.AllowNext = true;
            }
            else
            {
                wizardControl1.SelectedPage.AllowNext = false;
            }
        }

        private void textBoxPostcode_EditValueChanged(object sender, EventArgs e)
        {
            if (wizardPage2Valid())
            {
                wizardControl1.SelectedPage.AllowNext = true;
            }
            else
            {
                wizardControl1.SelectedPage.AllowNext = false;
            }
        }

        private void comboBoxEditState_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (wizardPage2Valid())
            {
                wizardControl1.SelectedPage.AllowNext = true;
            }
            else
            {
                wizardControl1.SelectedPage.AllowNext = false;
            }
        }

        private void textBoxCountry_TextChanged(object sender, EventArgs e)
        {
            if (wizardPage2Valid())
            {
                wizardControl1.SelectedPage.AllowNext = true;
            }
            else
            {
                wizardControl1.SelectedPage.AllowNext = false;
            }
        }

        private void textBoxSuburb_TextChanged(object sender, EventArgs e)
        {
            if (wizardPage2Valid())
            {
                wizardControl1.SelectedPage.AllowNext = true;
            }
            else
            {
                wizardControl1.SelectedPage.AllowNext = false;
            }
        }

        private void textBoxTelephone_EditValueChanged(object sender, EventArgs e)
        {
            if (wizardPage2Valid())
            {
                wizardControl1.SelectedPage.AllowNext = true;
            }
            else
            {
                wizardControl1.SelectedPage.AllowNext = false;
            }
        }

        private void buttonContacts_Click(object sender, EventArgs e)
        {

        }

        private void wizardControl1_FinishClick(object sender, CancelEventArgs e)
        {
            try
            {
                int memberID;

                if (int.TryParse(textBoxMemberID.Text, out memberID))
                {
                    using (var context = new LorikeetAppEntities())
                    {
                        var memberToAdd = new Member();
                        memberToAdd.MemberID = memberID;
                        memberToAdd.FirstName = textBoxFirstName.Text;
                        memberToAdd.Surname = textBoxSurname.Text;
                        memberToAdd.DateOfBirth = dateEditDOB.DateTime;
                        memberToAdd.Aboriginal = checkBoxAboriginal.Checked;
                        memberToAdd.Agency = checkBoxAgency.Checked;

                        if (comboBoxSex.Text.Equals("Male"))
                        {
                            memberToAdd.Sex = true;
                        }
                        else
                        {
                            memberToAdd.Sex = false;
                        }
                        memberToAdd.CountryOfOrigin = textBoxCOO.Text;
                        memberToAdd.ReceiveNewsletter = checkBoxNewsletter.Checked;
                        memberToAdd.ReceiveByMail = checkBoxByMail.Checked;
                        memberToAdd.BirthdayCard = checkBoxBirthdayCard.Checked;
                        memberToAdd.Working = checkBoxWorking.Checked;
                        memberToAdd.Volunteering = checkBoxVolunteering.Checked;
                        memberToAdd.Studying = checkBoxStudying.Checked;
                        memberToAdd.StreetAddress = textBoxStreet.Text;
                        memberToAdd.PostCode = textBoxPostcode.Text;
                        memberToAdd.Suburb = textBoxSuburb.Text;
                        memberToAdd.State = comboBoxEditState.Text;
                        memberToAdd.Country = textBoxCountry.Text;
                        memberToAdd.TelephoneNumber = textBoxTelephone.Text;
                        memberToAdd.MobileNumber = textBoxMobile.Text;
                        memberToAdd.EmailAddress = textBoxEmail.Text;
                        memberToAdd.Archived = false;
                        memberToAdd.DateJoined = DateTime.Today;
                        memberToAdd.DateAltered = DateTime.Today;

                        context.Members.Add(memberToAdd);
                        context.SaveChanges();
                    }
                }

                Logging.AddLogEntry(staffID, Logging.ErrorCodes.Broadcast, Logging.RefreshCodes.Member, "Member " + textBoxFirstName.Text + " " + textBoxSurname.Text + " has been added to the Database", false);
            }
            catch (Exception ex)
            {
                Logging.AddLogEntry(staffID, Logging.ErrorCodes.Error, Logging.RefreshCodes.Member, "Member " + textBoxFirstName.Text + " " + textBoxSurname.Text + " has tried to be added but failed", false);
                MessageBox.Show(ex.Message);
            }
        }

        private void completionWizardPage1_PageInit(object sender, EventArgs e)
        {
            wizardControl1.SelectedPage.AllowFinish = true;
        }

        private void wizardControl1_Click(object sender, EventArgs e)
        {

        }

        private void buttonMap_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            var mapForm = new FormCountryOfOrigin();
            dr = mapForm.ShowDialog();

            if (dr == DialogResult.OK)
            {
                textBoxCOO.Text = mapForm.getCountryName;
            }
        }

        private void myLookUpEdit1_Properties_GetAutoCompleteList(object sender, AutoCompleteListEventArgs e)
        {
            GetAutoCompleteListAsync(e);
        }

        private async void GetAutoCompleteListAsync(AutoCompleteListEventArgs e)
        {
            try
            {
                if (mleAddress.Text.Count() > 3)
                {
                    var request = new PlacesAutoCompleteRequest
                    {
                        Key = MiscStuff.googleApiKey,
                        Input = mleAddress.Text,
                        Types = new List<RestrictPlaceType> { RestrictPlaceType.Address }
                    };

                    var response = await GooglePlaces.AutoComplete.QueryAsync(request);

                    if (response.Status == GoogleApi.Entities.Common.Enums.Status.Ok)
                    {
                        e.AutoCompleteList.Clear();

                        count = 0;

                        foreach (var place in response.Predictions)
                        {
                            e.AutoCompleteList.Add(place.Description);
                            autoAddress = place.Description;
                            count++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
            }
        }

        private void mapControl1_MouseHover(object sender, EventArgs e)
        {
            if (!_isTimerRunning)
            {
                _isTimerRunning = true;
                counter = 0;
                timer1.Interval = 1000;
                timer1.Start();
            }
        }

        private void mapControl1_MouseLeave(object sender, EventArgs e)
        {
            timer1.Stop();
            counter = 0;
            timer1.Enabled = false;
        }

        private void mapControl1_MouseEnter(object sender, EventArgs e)
        {
            overTheButton = true;
            hoverOverTheButtonEventTriggered = false;
            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            try
            {
                counter++;
                if (counter == 2)
                {
                    timer1.Stop();
                    _isTimerRunning = false;
                    counter = 0;

                    mapHoverForm.addressChosen = mleAddress.Text;
                    DialogResult dr = mapHoverForm.ShowDialog();
                    AddressChange(dr, mapHoverForm.addressChosen);
                }
            }
            catch { }
        }

        private void mapControl1_Click(object sender, EventArgs e)
        {
            mapHoverForm.addressChosen = mleAddress.Text;
            DialogResult dr = mapHoverForm.ShowDialog();
            AddressChange(dr, mapHoverForm.addressChosen);
        }
        
        private void AddressChange(DialogResult dr, String addressChosen)
        {
            if (dr == DialogResult.OK)
            {
                textBoxCountry.Text = String.Empty;
                textBoxPostcode.Text = String.Empty;
                textBoxStreet.Text = String.Empty;
                comboBoxEditState.Text = String.Empty;
                textBoxSuburb.Text = String.Empty;

                mleAddress.Text = addressChosen;

                try
                {
                    var request = new PlacesAutoCompleteRequest
                    {
                        Key = MiscStuff.googleApiKey,
                        Input = mleAddress.Text
                    };

                    var response = GooglePlaces.AutoComplete.Query(request);

                    if (response.Status == Status.Ok)
                    {
                        var request2 = new PlacesDetailsRequest
                        {
                            Key = MiscStuff.googleApiKey,
                            PlaceId = response.Predictions.Select(x => x.PlaceId).FirstOrDefault()
                        };

                        var response2 = GooglePlaces.Details.Query(request2);

                        if (response2.Status == Status.Ok)
                        {
                            var result = response2.Result.FormattedAddress;
                            if (result != null)
                            {
                                mleAddress.Text = result.ToString();

                                string[] splitAddress = result.Split(',');
                                if (splitAddress.Count() == 3)
                                {
                                    textBoxStreet.Text = splitAddress[0];
                                    textBoxCountry.Text = splitAddress[2];

                                    string[] splitAddress2 = splitAddress[1].Split(' ');
                                    textBoxPostcode.Text = splitAddress2[splitAddress2.Count() - 1];
                                    comboBoxEditState.Text = ChooseState(splitAddress2[splitAddress2.Count() - 2]);
                                    string address3 = splitAddress[1].Replace(splitAddress2[splitAddress2.Count() - 1], string.Empty);
                                    address3 = address3.Replace(splitAddress2[splitAddress2.Count() - 2], string.Empty);

                                    textBoxSuburb.Text = address3.Trim();
                                }
                                else
                                {
                                    MessageBox.Show("Not a valid address");
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(MiscStuff.GetAllMessages(ex));
                }
            }
        }

        private string ChooseState(string state)
        {
            if (state.Equals("WA"))
                return "Western Australia";
            else return state;
        }

        private void buttonChooseAddress_Click(object sender, EventArgs e)
        {
             AddressChange(DialogResult.OK, mleAddress.Text);
        }

        private void FormNewMemberWizard_Load(object sender, EventArgs e)
        {
            comboBoxSex.SelectedIndex = 0;
        }
    }
}   