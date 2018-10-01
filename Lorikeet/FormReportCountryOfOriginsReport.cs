using DevExpress.XtraMap;
using GoogleApi;
using GoogleApi.Entities.Common.Enums;
using GoogleApi.Entities.Maps.Geocode.Request;
using Lorikeet.Data;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Lorikeet
{
    public partial class FormReportCountryOfOriginsReport : Form
    {
        const string key = "Ah_GLvMCtg2uzZkeG7EEOdYRfJu0mZH0YBcLPhtqc73YBnfoeWvLrpeTwL1qVsjO";

        public FormReportCountryOfOriginsReport()
        {
            InitializeComponent();
        }

        private void FormReportCountryOfOriginsReport_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new LorikeetAppEntities())
                {
                    var mapNames = (from m in context.Members
                                     where m.CountryOfOrigin != ""
                                     select m).ToList();

                    if (mapNames.Any())
                    {
                        foreach (var name in mapNames)
                        {
                            var countOfMapName = (from m in context.Members
                                                  where m.CountryOfOrigin == name.CountryOfOrigin
                                                  select m).Count();

                            var geocodeCache = (from g in context.GeocodeCaches
                                                where g.Location == name.CountryOfOrigin
                                                select g).FirstOrDefault();

                            if (geocodeCache == null)
                            {

                                var request = new GeocodingRequest
                                {
                                    Key = MiscStuff.googleApiKey,
                                    Address = name.CountryOfOrigin
                                };

                                var result = GoogleMaps.Geocode.Query(request);

                                if (result.Status == Status.Ok)
                                {
                                    var geocodeResult = result.Results.FirstOrDefault();
                                    if (geocodeResult != null)
                                    {
                                        var geocodeToAdd = new GeocodeCache();
                                        geocodeToAdd.Location = name.CountryOfOrigin;
                                        geocodeToAdd.Latitude = (decimal)geocodeResult.Geometry.Location.Latitude;
                                        geocodeToAdd.Longitude = (decimal)geocodeResult.Geometry.Location.Longitude;
                                        context.GeocodeCaches.Add(geocodeToAdd);
                                        context.SaveChanges();

                                        GeoPoint location = new GeoPoint(geocodeResult.Geometry.Location.Latitude, geocodeResult.Geometry.Location.Longitude);

                                        informationLayer1.Data.Items.Add(new MapCallout()
                                        {
                                            Location = location,
                                            Text = name.CountryOfOrigin + " - Count: " + countOfMapName
                                        });
                                    }
                                }
                            }
                            else
                            {
                                GeoPoint location = new GeoPoint((long)geocodeCache.Latitude, (long)geocodeCache.Longitude);

                                informationLayer1.Data.Items.Add(new MapCallout()
                                {
                                    Location = location,
                                    Text = name.CountryOfOrigin + " - Count: " + countOfMapName
                                });
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

        private void mapControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
