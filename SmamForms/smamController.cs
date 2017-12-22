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
        private Article article;

        public smamController()
        {
            dbconn = new dbConnection();
            article = new Article();
        }

        public string GetArticleText(string articlename)
        {
            article.Description = dbconn.GetArticleText(articlename);
            return article.Description;
        }

        //lijst van strings terugsturen naar form met alle titels

        public List<string> GetArticleTitles(string type) //alle titels ophalen
        {
            return dbconn.GetArticleTitles(type); //returned de list
        }

        public void openArtikel(string articlename) //één artikel openen
        {
            article.Name = articlename;
            ArticleForm articleForm = new ArticleForm(article.Name);
            articleForm.Show();
        }

        public void openTypelist(string type)
        {
            Typelist typelist = new Typelist(type);
            typelist.Show();
        }

        public string GetTypeName(string type)
        {
            return dbconn.GetTypeName(type);
        }

        public override string ToString()
        {
            //toString methode voor een methode
            return dbconn.ToString();
        }
    }
}
