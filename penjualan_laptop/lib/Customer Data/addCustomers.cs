using Npgsql;
using penjualan_laptop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace penjualan_laptop.lib.Customer_Data
{
    public partial class addCustomers : Form
    {
        CustomerForm parent;
        public addCustomers(CustomerForm _parent)
        {
            InitializeComponent();
            parent = _parent;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Db_Helper db_Helper = new Db_Helper("localhost", "5432", "penjualan_laptop", "postgres", "Rizal020304");
                db_Helper.OpenConnection();
                string query = "INSERT INTO customers (id_customers, customer_name, no_hp, alamat) VALUES (@id, @name, @no_hp, @alamat)";
                NpgsqlCommand cmd = new NpgsqlCommand(query, db_Helper.GetConnection());
                int tmp_id_customers = int.Parse(user_id_input.Text);
                cmd.Parameters.AddWithValue("@id", tmp_id_customers);
                cmd.Parameters.AddWithValue("@name", user_name_input.Text);
                cmd.Parameters.AddWithValue("@no_hp", user_no_hp_input.Text);
                cmd.Parameters.AddWithValue("@alamat", user_alamat_input.Text);

                cmd.ExecuteNonQuery();
                db_Helper.CloseConnection();
                parent.RefreshData();
                this.Close();
            }
            catch
            {
                alert.Visible = true;
                alert.Text = "MASUKKAN FORMAT YANG BENAR";
            }
        }
    }
}
