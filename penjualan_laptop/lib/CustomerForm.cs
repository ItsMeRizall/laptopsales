using Npgsql;
using penjualan_laptop.lib.Customer_Data;
using penjualan_laptop.lib.data;
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

namespace penjualan_laptop.lib
{
    public partial class CustomerForm : Form
    {
        DataTable dt = new DataTable();
        public CustomerForm()
        {
            InitializeComponent();
            RefreshData();
            DataCustomers.DataSource = dt;
        }

        public void RefreshData()
        {
            dt.Clear();
            Db_Helper db_Helper = new Db_Helper("Localhost", "5432", "penjualan_laptop", "postgres", "Rizal020304");
            db_Helper.OpenConnection();
            string query = "SELECT * FROM customers";
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, db_Helper.GetConnection());
            adapter.Fill(dt);
            db_Helper.CloseConnection();
        }

        private void AddCustomers_Click(object sender, EventArgs e)
        {
            addCustomers Addcst = new addCustomers(this);
            Addcst.ShowDialog();
        }

        public int totalCustomer()
        {
            return dt.Rows.Count;
        }

        private void RemoveCustomers_Click(object sender, EventArgs e)
        {
            DeleteUser deleteUser = new DeleteUser(this);
            deleteUser.ShowDialog();
        }

        private void EditCustomers_Click(object sender, EventArgs e)
        {
            EditCustomers editUser = new EditCustomers(this);
            editUser.ShowDialog();
        }
    }
}
