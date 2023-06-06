using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace penjualan_laptop.Models
{
    internal class Db_Helper
    {

        private NpgsqlConnection conn;

        public Db_Helper(string server, string port, string database, string username, string password)
        {
            string connString = String.Format("Server={0};Port={1};Database={2};User Id={3};Password={4};",
                server, port, database, username, password);
            conn = new NpgsqlConnection(connString);
        }

        public void OpenConnection()
        {
            conn.Open();
        }

        public void CloseConnection()
        {
            conn.Close();
        }

        public NpgsqlConnection GetConnection()
        {
            return conn;
        }

        public List<dynamic> ConvertToList (string query)
        {
            OpenConnection();
            List<dynamic> data = new List<dynamic>();
            NpgsqlCommand sql = new NpgsqlCommand(query, GetConnection());
            NpgsqlDataReader read = sql.ExecuteReader();


            while (read.Read())
            {
                int value = read.GetInt32(0);
                data.Add(value);
            }
            CloseConnection();
            return data;
        }

        public List<dynamic> ConvertToListString(string query)
        {
            OpenConnection();
            List<dynamic> data = new List<dynamic>();
            NpgsqlCommand sql = new NpgsqlCommand(query, GetConnection());
            NpgsqlDataReader read = sql.ExecuteReader();


            while (read.Read())
            {
                string value = read.GetString(0);
                data.Add(value);
            }
            CloseConnection();
            return data;
        }
        public List<dynamic> GetRowAsList(int id, string query)
        {
            List<dynamic> rowValues = new List<dynamic>();


            OpenConnection();
            NpgsqlCommand command = new NpgsqlCommand(query, GetConnection());
            /*command.Parameters.AddWithValue("@id", id);*/
            NpgsqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    string value = reader.GetString(i);
                    rowValues.Add(value);
                }
            }

            return rowValues;
        }


    }
}
