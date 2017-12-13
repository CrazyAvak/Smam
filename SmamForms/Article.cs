using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmamForms
{
    class Article
    {
        //fields
        private List<Image> images;
        private int id;
        private string name;
        private string description;
        
        public Article() //constructor
        {

        }

        //properties
        public List<Image> Images { get => images; set => images = value; }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
    }
}
