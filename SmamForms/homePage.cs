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
    }
}
