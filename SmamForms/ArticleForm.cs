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
    public partial class ArticleForm : Form
    {
        public ArticleForm() //constructor
        {
            InitializeComponent();
            CenterToScreen(); //Form in het midden zetten
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Drukte backbutton in");
        }
    }
}
