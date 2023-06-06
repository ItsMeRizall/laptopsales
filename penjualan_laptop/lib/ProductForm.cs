using Npgsql;
using penjualan_laptop.lib.data;
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

namespace penjualan_laptop.lib
{
    public partial class ProductForm : Form
    {
        DataTable dt = new DataTable();
        public ProductForm()
        {
            InitializeComponent();

            dt.Clear();
            RefreshData();
            dataProduct.DataSource = dt;
        }

        public void RefreshData()
        {
            dt.Clear();
            Db_Helper db_Helper = new Db_Helper("Localhost", "5432", "penjualan_laptop", "postgres", "Rizal020304");
            db_Helper.OpenConnection();
            string query = "SELECT * FROM laptop";
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, db_Helper.GetConnection());
            adapter.Fill(dt);
            db_Helper.CloseConnection();
        }

        public int productTotal()
        {
            return dt.Rows.Count;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            AddProductForm Addfrm = new AddProductForm(this);
            Addfrm.ShowDialog();
        }

        private void RemoveProduct_Click(object sender, EventArgs e)
        {
            DeleteData DltFrm = new DeleteData(this);
            DltFrm.ShowDialog();
        }

        private void EditProduct_Click(object sender, EventArgs e)
        {
            EditData EditFrm = new EditData(this);
            /*EditDataValue dataValue = new EditDataValue(this);*/
            EditFrm.ShowDialog();
        }
    }
}
