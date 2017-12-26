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
    public partial class homePage : Form
    {

        smamController smam;        
        public homePage()
        {
            smam = new smamController();
            InitializeComponent();
            fillHint();
        }   

        private void fillHint()
        {
            labelHint.Text = smam.getHint().Body;
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            this.Hide();
            settingsEdit edit = new settingsEdit();
            edit.ShowDialog();
            edit = null;
            this.Show();
        }

        private void buttonShoppingList_Click(object sender, EventArgs e)
        {
            this.Hide();
            shoppingList shopping = new shoppingList();
            shopping.ShowDialog();
            shopping = null;
            this.Show();

            smam = new smamController();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            smam.openTypelist(1.ToString()); //recept
        }

        private void button2_Click(object sender, EventArgs e)
        {
            smam.openTypelist(3.ToString()); //huishouden

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            POI poi = new POI();
            poi.ShowDialog();
            poi = null;
            this.Show();
        }
    }
}
