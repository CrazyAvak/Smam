using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmamForms
{
    public partial class startSettings : Form
    {
        public startSettings()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveUserSettings save = new saveUserSettings();            
            save.saveUser(textBoxName.Text,textBoxCity.Text, textBoxStreet.Text, textBoxSchool.Text, textBoxOpleiding.Text, textBoxHuur.Text);
            save.isInstalled();
        }
    }
}
