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

namespace SmamForms
{
    public partial class POI : Form
    {
        public POI()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void POI_Load(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GoogleMapProvider.Instance; //Google gebruiken
            gMapControl1.Manager.Mode = AccessMode.ServerOnly;
            GMapProvider.WebProxy = null; //geen proxy
            gMapControl1.Position = new PointLatLng(51.4431256, 5.4783261); //locatie
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
    }
}
