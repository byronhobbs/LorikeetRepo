using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using GoogleApi.Entities.Maps.Geocode.Request;
using GoogleApi;
using GoogleApi.Entities.Common.Enums;
using Lorikeet.CustomMarkers;

namespace Lorikeet
{
    public partial class FormMapHover : Form
    {
        private readonly GMapOverlay top = new GMapOverlay();
        internal readonly GMapOverlay objects = new GMapOverlay("objects");
        private GMapOverlay markers;
        private bool isMouseDown = false;

        private GMapMarker currentMarker;
        private GMapMarkerRect CurentRectMarker = null;

        private const double perthLatitude = -31.9505;
        private const double perthLongitude = 115.8605;

        public string addressChosen { get; set; }

        public FormMapHover()
        {
            InitializeComponent();

            markers = new GMapOverlay("markers");
        }

        private void InitMaps()
        {
            if (!GMapControl.IsDesignerHosted)
            {
                try
                {
                    gmap.Manager.Mode = AccessMode.ServerAndCache;

                    if (!MiscStuff.CheckForInternetConnection())
                    {
                        gmap.Manager.Mode = AccessMode.CacheOnly;
                        MessageBox.Show("No internet connection available, going to CacheOnly mode.", "Server Only", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    gmap.MapProvider = GMapProviders.OpenStreetMap;

                    CenterOnPosition(addressChosen);

                    gmap.MinZoom = 10;
                    gmap.MaxZoom = 17;
                    gmap.Zoom = 12;

                    gmap.Overlays.Add(objects);
                    gmap.Overlays.Add(top);

                    currentMarker = new GMarkerGoogle(gmap.Position, GMarkerGoogleType.arrow);
                    currentMarker.IsHitTestVisible = false;
                    top.Markers.Add(currentMarker);

                    gmap.ShowCenter = false;

                    if (objects.Markers.Count > 0)
                    {
                        gmap.ZoomAndCenterMarkers(null);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(MiscStuff.GetAllMessages(ex));
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FormMapHover_Load(object sender, EventArgs e)
        {
            InitMaps();

            gmap.MouseMove += new MouseEventHandler(MainMap_MouseMove);
            gmap.MouseDown += new MouseEventHandler(MainMap_MouseDown);
            gmap.MouseUp += new MouseEventHandler(MainMap_MouseUp);
            gmap.MouseDoubleClick += new MouseEventHandler(MainMap_MouseDoubleClick);
        }

        private void MainMap_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                try
                {
                    isMouseDown = false;

                    var request = new GeocodingRequest
                    {
                        Key = MiscStuff.googleApiKey,
                        Location = new GoogleApi.Entities.Common.Location(currentMarker.Position.Lat, currentMarker.Position.Lng)
                    };
                    var response = GoogleMaps.Geocode.Query(request);

                    if (response.Status == Status.Ok)
                    {
                        textBoxAddress.Text = response.Results.First().FormattedAddress;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(MiscStuff.GetAllMessages(ex));
                }
            }
        }

        private void MainMap_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var cc = new GMapMarkerCircle(gmap.FromLocalToLatLng(e.X, e.Y));
            objects.Markers.Add(cc);
        }

        private void MainMap_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;

                if (currentMarker.IsVisible)
                {
                    currentMarker.Position = gmap.FromLocalToLatLng(e.X, e.Y);

                    var px = gmap.MapProvider.Projection.FromLatLngToPixel(currentMarker.Position.Lat, currentMarker.Position.Lng, (int)gmap.Zoom);
                    var tile = gmap.MapProvider.Projection.FromPixelToTileXY(px);
                }
            }
        }

        private void MainMap_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && isMouseDown)
            {
                if (CurentRectMarker == null)
                {
                    if (currentMarker.IsVisible)
                    {
                        currentMarker.Position = gmap.FromLocalToLatLng(e.X, e.Y);
                    }
                }
                else // move rect marker
                {
                    PointLatLng pnew = gmap.FromLocalToLatLng(e.X, e.Y);

                    if (currentMarker.IsVisible)
                    {
                        currentMarker.Position = pnew;
                    }
                    CurentRectMarker.Position = pnew;

                    if (CurentRectMarker.InnerMarker != null)
                    {
                        CurentRectMarker.InnerMarker.Position = pnew;
                    }
                }

                gmap.Refresh();
            }
        }

        private void buttonCenter_Click(object sender, EventArgs e)
        {
            try
            {
                CenterOnPosition(textBoxAddress.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
            }
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            if (textBoxAddress.Text.Count() > 0)
            {
                DialogResult = DialogResult.OK;
                addressChosen = textBoxAddress.Text;
                this.Close();
            }
            else
            {
                DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void CenterOnPosition(string addressText)
        {
            try
            {
                if (addressText.Count() > 5)
                {
                    var request = new GeocodingRequest
                    {
                        Key = MiscStuff.googleApiKey,
                        Address = addressText
                    };

                    var result = GoogleMaps.Geocode.Query(request);

                    if (result.Status == Status.Ok)
                    {
                        var geocodeResult = result.Results.FirstOrDefault();
                        if (geocodeResult != null)
                        {
                            textBoxAddress.Text = addressText;
                            gmap.Position = new PointLatLng(geocodeResult.Geometry.Location.Latitude, geocodeResult.Geometry.Location.Longitude);
                        }
                    }
                }
                else
                {
                    gmap.Position = new PointLatLng(perthLatitude, perthLongitude);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MiscStuff.GetAllMessages(ex));
            }
        }

        private void gmap_Load(object sender, EventArgs e)
        {

        }
    }
}
