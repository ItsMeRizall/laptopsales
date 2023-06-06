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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace penjualan_laptop.lib.dataProduct
{
    public partial class EditDataValue : Form
    {
        DataTable dt = new DataTable();
        private int idInputUser;
        private ProductForm parent;

        public EditDataValue(int idInputUser, ProductForm _parent)
        {
            InitializeComponent();
            parent = _parent;
            Db_Helper db_Helper = new Db_Helper("Localhost", "5432", "penjualan_laptop", "postgres", "Rizal020304");
            db_Helper.OpenConnection();
            string query = $"SELECT * FROM laptop where id_product = {idInputUser}";
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, db_Helper.GetConnection());
            adapter.Fill(dt);

            List<dynamic> laptopDataEdit = new List<dynamic>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int idProduct = Convert.ToInt32(dt.Rows[i]["id_product"]);
                string nameProduct = dt.Rows[i]["name_product"].ToString();
                int price = Convert.ToInt32(dt.Rows[i]["price"]);
                int units_in_stock = Convert.ToInt32(dt.Rows[i]["units_in_stock"]);

                laptopDataEdit.Add(idProduct);
                laptopDataEdit.Add(nameProduct);
                laptopDataEdit.Add(price);
                laptopDataEdit.Add(units_in_stock);

            }

            string idTmp = laptopDataEdit[0].ToString();
            string priceTmp = laptopDataEdit[2].ToString();
            string stockTmp = laptopDataEdit[3].ToString();
            product_id_Edit.Text = idTmp;
            product_name_edit.Text = laptopDataEdit[1];
            product_price_edit.Text = priceTmp;
            stock_product_edit.Text = stockTmp;

            db_Helper.CloseConnection();
            this.idInputUser = idInputUser;
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Db_Helper db_Helper = new Db_Helper("localhost", "5432", "penjualan_laptop", "postgres", "Rizal020304");
                db_Helper.OpenConnection();
                string query = "UPDATE laptop SET name_product = @name, price = @price, units_in_stock = @stock WHERE id_product = @id";
                NpgsqlCommand cmd = new NpgsqlCommand(query, db_Helper.GetConnection());
                cmd.Parameters.AddWithValue("@name", product_name_edit.Text);
                cmd.Parameters.AddWithValue("@price", int.Parse(product_price_edit.Text));
                cmd.Parameters.AddWithValue("@stock", int.Parse(stock_product_edit.Text));
                cmd.Parameters.AddWithValue("@id", int.Parse(product_id_Edit.Text));
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
