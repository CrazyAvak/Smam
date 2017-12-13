using SmamForms.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmamForms
{
    public partial class SplashScreenForm : Form
    {
        Timer time;
        public SplashScreenForm()
        {
            InitializeComponent();
            if (Debugger.IsAttached)
                Settings.Default.Reset();
            checkStart();

        }
        private void checkStart()
        {
            if(Properties.Settings.Default.hasStarted == "1")
            {
                 time = new Timer();
                time.Interval = 1000;
                time.Tick += Timer_Tick;
                time.Enabled = true ;

            }
            else
            {
                buttonNext.Visible = true;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            time.Enabled = false;
            Home home = new Home();
            
            home.Show();
            this.Hide();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            startSettings start = new startSettings();
            this.Hide();
            start.Show();
        }
    }
}
