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
using GMap.NET.MapProviders;
using Geocoding;
using Geocoding.Google;

namespace SmamForms
{
    public partial class POI : Form
    {
        public POI()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private async void POI_LoadAsync(object sender, EventArgs e)
        {
            //geocoding
            GoogleGeocoder geocoder = new GoogleGeocoder() { ApiKey = "AIzaSyAoNyqmp8yYfRw0T5nMmGMiUKR3tyc5_JQ" };
            Console.WriteLine(Properties.Settings.Default.City.ToString());
            IEnumerable<Address> addresses = await geocoder.GeocodeAsync(Properties.Settings.Default.City.ToString() + " " + Properties.Settings.Default.Street.ToString());
            //google maps control
            gMapControl1.MapProvider = GoogleMapProvider.Instance; //Google gebruiken
            gMapControl1.Manager.Mode = AccessMode.ServerOnly;
            GMapProvider.WebProxy = null; //geen proxy
            Console.WriteLine(addresses.First().Coordinates.Latitude.ToString(), addresses.First().Coordinates.Longitude.ToString()); //debug
            gMapControl1.Position = new PointLatLng(addresses.First().Coordinates.Latitude, addresses.First().Coordinates.Longitude); //location
            gMapControl1.DragButton = MouseButtons.Left; //drag instellen
            gMapControl1.MinZoom = 1;
            gMapControl1.MaxZoom = 20;
            gMapControl1.Zoom = 14;
        }

        private void buttonZoomOut_Click(object sender, EventArgs e)
        {
            gMapControl1.Zoom -= 1; //uitzoomen
        }

        private void buttonZoomIn_Click(object sender, EventArgs e)
        {
            gMapControl1.Zoom += 1; //inzoomen
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
