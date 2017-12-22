using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmamForms
{
    class Image
    {
        //fields
        private int id;
        private string name;
        private string url;

        public Image() //constructor
        {

        }

        //properties
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Url { get => url; set => url = value; }

        public override string ToString()
        {
            return name + " - " + Url;
        }
    }
}
