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

namespace penjualan_laptop.lib.Orders
{
    public partial class DeleteOrders : Form
    {
        private OrderForm parent;
        public DeleteOrders(OrderForm _parent)
        {
            InitializeComponent();
            parent = _parent;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Db_Helper db_Helper = new Db_Helper("localhost", "5432", "penjualan_laptop", "postgres", "Rizal020304");
            List<dynamic> data_id = db_Helper.ConvertToList("Select order_id from orders");

            try {
                if (data_id.Contains(int.Parse(delete_id_order_input.Text)))
                {
                    db_Helper.OpenConnection();
                    string query = "DELETE FROM orders WHERE order_id = @id";
                    NpgsqlCommand cmd = new NpgsqlCommand(query, db_Helper.GetConnection());
                    int deleteId = int.Parse(delete_id_order_input.Text);
                    cmd.Parameters.AddWithValue("@id", deleteId);
                    cmd.ExecuteNonQuery();
                    db_Helper.CloseConnection();
                    parent.RefreshData();
                    this.Close();
                }
                else
                {
                    alert.Visible = true;
                    alert.Text = "ORDER ID TIDAK DI TEMUKAN !!!";
                }
            }
            catch
            {
                alert.Visible = true;
                alert.Text = "Masukkan Dengan Format Angka";
            }
            
            
        }
    }
}
