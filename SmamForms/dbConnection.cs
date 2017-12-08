using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmamForms
{
    class dbConnection
    {
        MySqlConnection conn;
        public dbConnection()
        {
            string connectionString = "Server=localhost;Database=smam;Uid=root;Pwd=;";
            conn = new MySqlConnection(connectionString);
            try
            {

            }
            catch (Exception)
            {

                MessageBox.Show("not connected");
            }
        }

        
    }
}
