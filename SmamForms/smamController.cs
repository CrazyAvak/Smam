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
        public Hint getHint()
        {
            return dbconn.getHint();
        }
    }
}
