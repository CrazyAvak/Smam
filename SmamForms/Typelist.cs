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
    public partial class Typelist : Form
    {
        private smamController smamControl;
        private string naamType;

        public Typelist(string naamtype)
        {
            InitializeComponent();
            CenterToScreen(); //Form in het midden zetten
            smamControl = new smamController();
            this.naamType = naamtype;
        }

        private void Typelist_Load(object sender, EventArgs e)
        {
            foreach (string item in smamControl.GetArticleTitles(1.ToString()))
            {
                listBox1.Items.Add(item);
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            string articlename = listBox1.SelectedItem.ToString();
            Console.WriteLine(articlename);
            smamControl.openArtikel(articlename);
        }
    }
}
