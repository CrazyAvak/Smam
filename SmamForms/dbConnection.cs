using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            string connectionString = "Server=localhost;Database=smamdb;Uid=root;Pwd=;";
            conn = new MySqlConnection(connectionString);
            try
            {

            }
            catch (Exception)
            {

                MessageBox.Show("not connected");
            }
        }
       public Hint getMomHints()
        {
            DataTable table = new DataTable();
            try
            {
                conn.Open();
                string query = "SELECT * FROM `hint` ORDER BY RAND() LIMIT 1;";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter();
                myAdapter.SelectCommand = cmd;
                myAdapter.Fill(table);
                Hint hint = new Hint();

                foreach (DataRow item in table.Rows)
                {
                    hint.Id = item["idHints"].ToString();
                    hint.Name = item["Name"].ToString();
                    hint.Body = item["Description"].ToString();
                }
                conn.Close();
                return hint;

            }
            catch(Exception e)
            {
                throw;
            }
        }


    }
}
