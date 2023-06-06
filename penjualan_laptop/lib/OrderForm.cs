using Npgsql;
using penjualan_laptop.lib.Orders;
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
    public partial class OrderForm : Form
    {
        DataTable dt = new DataTable();
        Db_Helper db_Helper = new Db_Helper("Localhost", "5432", "penjualan_laptop", "postgres", "Rizal020304");

        public OrderForm()
        {
            InitializeComponent();
            RefreshData();
            DataOrder.DataSource = dt;
        }

        public void RefreshData()
        {
            dt.Clear();
            db_Helper.OpenConnection();
            string query = "SELECT o.order_id, o.order_date, cust.customer_name, l.name_product, details.quantity\r\nFROM orders o\r\nINNER JOIN customers cust ON o.id_customer = cust.id_customers\r\nINNER JOIN order_details details ON o.order_id = details.order_id\r\nINNER JOIN laptop l ON details.id_laptop = l.id_product";
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, db_Helper.GetConnection());
            adapter.Fill(dt);
            db_Helper.CloseConnection();
        }

        public int totalOrders()
        {
            return dt.Rows.Count;
        }

        private void AddOrder_Click(object sender, EventArgs e)
        {
            AddOrders addOrders = new AddOrders(this);
            addOrders.ShowDialog();
        }

        private void RemoveOrder_Click(object sender, EventArgs e)
        {
            DeleteOrders deleteOrders = new DeleteOrders(this);
            deleteOrders.ShowDialog();
        }
    }
}
