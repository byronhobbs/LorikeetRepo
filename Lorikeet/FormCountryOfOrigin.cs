using DevExpress.XtraMap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lorikeet
{
    public partial class FormCountryOfOrigin : Form
    {
        const string yourBingKey = "Ah_GLvMCtg2uzZkeG7EEOdYRfJu0mZH0YBcLPhtqc73YBnfoeWvLrpeTwL1qVsjO";
        const string msgMinMaxErrorFormatString = "The {0} must be less than or equal to {2} and greater than or equal to {1}. Correct the input value.";

        /*const string latitudeName = "Latitude";
        const double minLatitude = -90;
        const double maxLatitude = 90;
        const string longitudeName = "Longitude";
        const double minLongitude = -180;
        const double maxLongitude = 180;
        */
        BingGeocodeDataProvider geocodeProvider;

        public string getCountryName { get; set; }
        public double getLongitude { get; set; }
        public double getLatitude { get; set; }


        public FormCountryOfOrigin()
        {
            InitializeComponent();

            buttonOK.Enabled = false;
        }

        private void FormCountryOfOrigin_Load(object sender, EventArgs e)
        {
            if (MiscStuff.CheckForInternetConnection())
            {
                bingMapDataProvider.BingKey = yourBingKey;

                geocodeProvider = new BingGeocodeDataProvider
                {
                    BingKey = yourBingKey,
                    MaxVisibleResultCount = 1
                };
                geocodeProvider.LocationInformationReceived += OnLocationInformationReceived;
                geocodeProvider.LayerItemsGenerating += OnLayerItemsGenerating;
                informationLayer1.DataProvider = geocodeProvider;
            }
            else
            {
                MessageBox.Show("Sorry, No Internet Connection");
                this.Close();
            }
        }

        private void OnLayerItemsGenerating(object sender, LayerItemsGeneratingEventArgs e)
        {
            mapControl1.ZoomToFit(e.Items, 0.4);
        }

        private void OnLocationInformationReceived(object sender, LocationInformationReceivedEventArgs e)
        {
            if ((e.Cancelled) && (e.Result.ResultCode != RequestResultCode.Success)) return;

            informationLayer1.Data.Items.Clear();
            foreach (LocationInformation locationInformation in e.Result.Locations)
            {
                string[] country = locationInformation.DisplayName.Split(',');
                getCountryName = country[country.Count() - 2] + ", " + country[country.Count() - 1];
                getLongitude = locationInformation.Location.Longitude;
                getLatitude = locationInformation.Location.Latitude;

                informationLayer1.Data.Items.Add(new MapCallout()
                {
                    Location = locationInformation.Location,
                    Text = locationInformation.DisplayName
                });
            }

            buttonOK.Enabled = true;
            textBoxCountryName.Text = getCountryName;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
