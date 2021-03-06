﻿using MySql.Data.MySqlClient;
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
        public Hint getHint()
        {
            DataTable table = new DataTable();
            conn.Open();
            string query = "SELECT * FROM `hint` ORDER BY RAND() LIMIT 1;";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter myAdapter = new MySqlDataAdapter();
            myAdapter.SelectCommand = cmd;
            myAdapter.Fill(table);
            conn.Close();
            Hint hint = new Hint();
            foreach (DataRow item in table.Rows)
            {
                hint.Id = item["idHints"].ToString();
                hint.Name = item["Name"].ToString();
                hint.Body = item["Description"].ToString();
            }
            return hint;

        }
        public List<string> getGroceryTypes()
        {
            DataTable table = new DataTable();
            conn.Open();
            string query = "SELECT * FROM `grocery`";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter myAdapter = new MySqlDataAdapter();
            myAdapter.SelectCommand = cmd;
            myAdapter.Fill(table);
            conn.Close();
            List<string> types = new List<string>();
            foreach (DataRow item in table.Rows)
            {
                types.Add(item["Name"].ToString());
            }
            return types;
        }
        private string getGroceryId(string type)
        {
            DataTable table = new DataTable();
            
            string query = "SELECT * FROM `grocery` WHERE grocery.Name = '" + type + "'" ;
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter myAdapter = new MySqlDataAdapter();
            myAdapter.SelectCommand = cmd;
            myAdapter.Fill(table);
            
            string id = "";
            foreach (DataRow item in table.Rows)
            {
                id = item["idGrocery"].ToString();
            }
            return id;
        }
        public List<string> getGroceryProducts(string type)
        {
            DataTable table = new DataTable();
            conn.Open();
            string query = " SELECT * FROM `groceryproduct` " +
                "INNER JOIN groceries_has_grocery ON groceries_has_grocery.Groceries_idGroceries=groceryproduct.idGroceries " +
                "WHERE groceries_has_grocery.Grocery_idGrocery=" + getGroceryId(type);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter myAdapter = new MySqlDataAdapter();
            myAdapter.SelectCommand = cmd;
            myAdapter.Fill(table);
            conn.Close();
            List<string> products = new List<string>();
            foreach (DataRow item in table.Rows)
            {
                products.Add(item["Name"].ToString());
            }
            return products;
        }
    }
}
