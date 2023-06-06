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
    public partial class EditData : Form
    {
        private int id_input;
        private ProductForm productForm;


        Db_Helper db_Helper = new Db_Helper("Localhost", "5432", "penjualan_laptop", "postgres", "Rizal020304");
        public EditData(ProductForm _productForm)
        {
            InitializeComponent();
            productForm = _productForm;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

            try
            {
            List<dynamic> data_id = db_Helper.ConvertToList("Select id_product from laptop");
            id_input = int.Parse(product_id_input_user.Text);
                if (data_id.Contains(id_input))
                {
                    EditDataValue editDataValue = new EditDataValue(id_input, productForm);
                    editDataValue.ShowDialog();
                    db_Helper.CloseConnection();
                }
                else
                {
                    alert.Visible = true;
                    alert.Text = "ID PRODUCT TIDAK DI TEMUKAN !!!";
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
