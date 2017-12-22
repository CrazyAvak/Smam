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
        private smamController smamControl;

        public homePage()
        {
            InitializeComponent();
            smamControl = new smamController();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            smamControl.openTypelist(1.ToString()); //recept
        }

        private void button2_Click(object sender, EventArgs e)
        {
            smamControl.openTypelist(3.ToString()); //huishouden
        }
    }
}
