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
        public Hint getHint()
        {
            return dbconn.getHint();
        }
        public List<string> getGroceryTypes()
        {
            return dbconn.getGroceryTypes();
        }
        public List<string> getGroceryProducts(string Type)
        {
            return dbconn.getGroceryProducts(Type);
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

        public List<String> GetImageURL(string articleID)
        {
            return dbconn.GetImageURL(articleID);
        }

        public string GetArticleID(string articlename)
        {
            return dbconn.GetArticleID(articlename);
        }

        public override string ToString()
        {
            //toString methode voor een methode
            return dbconn.ToString();
        }
    }
}
