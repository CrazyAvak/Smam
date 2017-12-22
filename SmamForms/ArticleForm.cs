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
        private smamController smamControl;
        private string articleName;
        private int i;
            
        public ArticleForm(string articlename) //constructor
        {
            InitializeComponent();
            smamControl = new smamController();
            CenterToScreen(); //Form in het midden zetten
            this.articleName = articlename;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Drukte backbutton in");
        }

        private void ArticleForm_Load(object sender, EventArgs e)
        {
            labelTitelArticle.Text = articleName;
            txtArticleText.Text = smamControl.GetArticleText(articleName); //test
            string articleID = smamControl.GetArticleID(articleName);
            Console.WriteLine(articleID);
            foreach (string plaatje in smamControl.GetImageURL(articleID))
            {
                Console.WriteLine(plaatje);
                PictureBox p = new PictureBox();
                p.Size = new System.Drawing.Size(75, 75);
                p.Location = new System.Drawing.Point(252, 52 + 81 * i);
                Console.WriteLine(p.Location.ToString());   
                this.Controls.Add(p);
                p.Load(plaatje);
                i++;
            }
        }

        private void txtArticleText_MouseDown(object sender, MouseEventArgs e)
        {
            labelTitelArticle.Focus(); //focussen op een label zorgt ervoor dat er geen knipperende cursor is
        }
    }
}
