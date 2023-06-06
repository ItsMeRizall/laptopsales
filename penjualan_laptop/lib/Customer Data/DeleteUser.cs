using Npgsql;
using penjualan_laptop.lib.dataProduct;
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
    public partial class DeleteUser : Form
    {
        CustomerForm parent;
        public DeleteUser(CustomerForm _parent)
        {
            InitializeComponent();
            parent = _parent;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

            Db_Helper db_Helper = new Db_Helper("localhost", "5432", "penjualan_laptop", "postgres", "Rizal020304");
            List<dynamic> data_id = db_Helper.ConvertToList("Select id_customers from customers");
            List<dynamic> cust_id = db_Helper.ConvertToList("Select id_customer from orders");
            try
            {
                if (cust_id.Contains(int.Parse(delete_id_input.Text))){
                    alert.Visible = true;
                    alert.Text = "CUSTOMER MEMILIKI RIWAYAT PEMBELIAN";
                }
                else if (data_id.Contains(int.Parse(delete_id_input.Text)))
                {
                    db_Helper.OpenConnection();
                    string query = "DELETE FROM customers WHERE id_customers = @id";
                    NpgsqlCommand cmd = new NpgsqlCommand(query, db_Helper.GetConnection());
                    int deleteId = int.Parse(delete_id_input.Text);
                    cmd.Parameters.AddWithValue("@id", deleteId);
                    cmd.ExecuteNonQuery();
                    db_Helper.CloseConnection();
                    parent.RefreshData();
                    this.Close();
                    db_Helper.CloseConnection();
                }
                else
                {
                    alert.Visible = true;
                    alert.Text = "ID CUSTOMERS TIDAK DI TEMUKAN !!!";
                }
            }
            catch
            {
                alert.Visible = true;
                alert.Text = "MASUKKAN DENGAN FORMAT ANGKA";
            }
        }
    }
}
