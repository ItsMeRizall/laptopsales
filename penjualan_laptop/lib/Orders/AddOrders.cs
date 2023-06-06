using Npgsql;
using penjualan_laptop.Models;

namespace penjualan_laptop.lib.Orders
{
    public partial class AddOrders : Form
    {
        private OrderForm form;
        private DateTime curretDate = DateTime.Now;
        public AddOrders(OrderForm _form)
        {
            InitializeComponent();
            form = _form;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Db_Helper db_Helper = new Db_Helper("localhost", "5432", "penjualan_laptop", "postgres", "Rizal020304");
                List<dynamic> order_id = db_Helper.ConvertToList("Select order_id from orders");
                List<dynamic> customer_id = db_Helper.ConvertToList("Select id_customers from customers");
                List<dynamic> laptop_id = db_Helper.ConvertToList("Select id_product from laptop");

                bool inOrderid = order_id.Contains(int.Parse(order_id_input.Text));
                bool inCustomerid = customer_id.Contains(int.Parse(cust_id_input.Text));
                bool inLaptopid = laptop_id.Contains(int.Parse(product_id_input.Text));


                db_Helper.OpenConnection();
                string query = "INSERT INTO orders (order_id, order_date, id_customer) VALUES (@id, @date, @id_customer)";
                string query2 = "Insert INTO order_details (order_id, id_laptop, quantity) values (@id, @laptop_id, @quantity)";

                NpgsqlCommand cmd = new NpgsqlCommand(query, db_Helper.GetConnection());
                cmd.Parameters.AddWithValue("@id", int.Parse(order_id_input.Text));
                cmd.Parameters.AddWithValue("@date", curretDate.Date);
                cmd.Parameters.AddWithValue("@id_customer", int.Parse(cust_id_input.Text));

                NpgsqlCommand cmd2 = new NpgsqlCommand(query2, db_Helper.GetConnection());
                cmd2.Parameters.AddWithValue("@id", int.Parse(order_id_input.Text));
                cmd2.Parameters.AddWithValue("@laptop_id", int.Parse(product_id_input.Text));
                cmd2.Parameters.AddWithValue("@quantity", int.Parse(quantity_input.Text));

                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();

                db_Helper.CloseConnection();
                form.RefreshData();
                this.Close();
            }

            catch (Exception ex)
            {
                alert.Visible = true;
                alert.Text = "MASUKKAN DNGAN FORMAT YANG BENAR !!!";

                /*Db_Helper db_Helper = new Db_Helper("localhost", "5432", "penjualan_laptop", "postgres", "Rizal020304");
                List<dynamic> order_id = db_Helper.ConvertToList("Select order_id from orders");
                List<dynamic> customer_id = db_Helper.ConvertToList("Select id_customers from customers");
                List<dynamic> laptop_id = db_Helper.ConvertToList("Select id_product from laptop");
                if (!String.IsNullOrEmpty(order_id_input.Text)){
                    alert.Visible = true;
                    alert.Text = "Text Tidak Boleh Kosong";
                }*/

            }
        }
    }
}
