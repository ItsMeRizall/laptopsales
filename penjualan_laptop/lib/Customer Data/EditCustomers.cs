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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace penjualan_laptop.lib.Customer_Data
{
    public partial class EditCustomers : Form
    {
        private CustomerForm customerForm;
        Db_Helper db_Helper = new Db_Helper("localhost", "5432", "penjualan_laptop", "postgres", "Rizal020304");
        public EditCustomers(CustomerForm _customersForm)
        {
            InitializeComponent();
            customerForm = _customersForm;
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {

            try
            {
                List<dynamic> data_id = db_Helper.ConvertToList("Select id_customers from customers");
                int id_customers = int.Parse(customers_id_input_user.Text);
                if (data_id.Contains(id_customers))
                {
                    EditDataCustomers dataCustomers = new EditDataCustomers(id_customers, customerForm);
                    dataCustomers.ShowDialog();
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
