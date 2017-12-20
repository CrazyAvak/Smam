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
    public partial class shoppingList : Form
    {
        smamController smam;
        public shoppingList()
        {
            InitializeComponent();
            CenterToScreen();
            smam = new smamController();
            
            fillTypes();
        }

        private void fillTypes()
        {
            foreach (string type in smam.getGroceryTypes())
            {
                comboBoxTypes.Items.Add(type);
            }
            comboBoxTypes.SelectedIndex = 0;
            fillCheckList();
        }
        private void fillCheckList()
        {
            foreach (string item in smam.getGroceryProducts(comboBoxTypes.Text))
            {
                checkedListBoxProducts.Items.Add(item);
            }
        }

        private void comboBoxTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBoxProducts.Items.Clear();
            fillCheckList();
        }
    }
}
