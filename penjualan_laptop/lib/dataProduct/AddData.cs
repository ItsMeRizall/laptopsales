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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace penjualan_laptop.lib.data
{
    public partial class AddProductForm : Form
    {
        private ProductForm parent;

        public AddProductForm(ProductForm _parent)
        {
            InitializeComponent();

            parent = _parent;

        }


        public void RefreshData()
        {
            parent.RefreshData();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Db_Helper db_Helper = new Db_Helper("localhost", "5432", "penjualan_laptop", "postgres", "Rizal020304");
                db_Helper.OpenConnection();
                string query = "INSERT INTO laptop (id_product, name_product, price, units_in_stock) VALUES (@id, @name, @price, @stock)";
                NpgsqlCommand cmd = new NpgsqlCommand(query, db_Helper.GetConnection());
                int tmp_id_product = int.Parse(product_id_input.Text);
                int tmp_id_price = int.Parse(product_price_input.Text);
                int tmp_id_stock = int.Parse(stock_product_input.Text);
                cmd.Parameters.AddWithValue("@id", tmp_id_product);
                cmd.Parameters.AddWithValue("@name", product_name_input.Text);
                cmd.Parameters.AddWithValue("@price", tmp_id_price);
                cmd.Parameters.AddWithValue("@stock", tmp_id_stock);

                cmd.ExecuteNonQuery();
                db_Helper.CloseConnection();
                RefreshData();
                this.Close();
            }
            catch
            {
                alert.Visible = true;
                alert.Text = "Masukkan Format Yang Benar";
            }
        }
    }
}
