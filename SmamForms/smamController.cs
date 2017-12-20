using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmamForms
{
    class smamController
    {
        dbConnection dbconn;
        public smamController()
        {
            dbconn = new dbConnection();
        }

        public string GetArticleText(string articlename)
        {
            return dbconn.GetArticleText(articlename);
        }

        //lijst van strings terugsturen naar form met alle titels

        public List<string> GetArticleTitles(string type) //alle titels ophalen
        {
            return dbconn.GetArticleTitles(type); //returned de list
        }

        public void openArtikel(string articlename) //één artikel openen
        {
            ArticleForm articleForm = new ArticleForm(articlename);
            articleForm.Show();
        }
    }
}
