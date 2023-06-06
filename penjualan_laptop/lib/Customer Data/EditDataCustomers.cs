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

namespace penjualan_laptop.lib.Customer_Data
{
    public partial class EditDataCustomers : Form
    {
        DataTable dt = new DataTable();
        private int idInputUser;
        CustomerForm parent;
        Db_Helper db_Helper = new Db_Helper("Localhost", "5432", "penjualan_laptop", "postgres", "Rizal020304");
        public EditDataCustomers(int idInputUser, CustomerForm _parent)
        {
            InitializeComponent();
            parent = _parent;
            db_Helper.OpenConnection();
            string query = $"SELECT * FROM customers where id_customers = {idInputUser}";
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, db_Helper.GetConnection());
            adapter.Fill(dt);

            List<dynamic> CustomersDataEdit = new List<dynamic>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int idCustomers = Convert.ToInt32(dt.Rows[i]["id_customers"]);
                string nameCustomers = dt.Rows[i]["customer_name"].ToString();
                string no_hp = dt.Rows[i]["no_hp"].ToString();
                string alamat = dt.Rows[i]["alamat"].ToString();

                CustomersDataEdit.Add(idCustomers);
                CustomersDataEdit.Add(nameCustomers);
                CustomersDataEdit.Add(no_hp);
                CustomersDataEdit.Add(alamat);

            }

            string idcst = CustomersDataEdit[0].ToString();
            user_id_edit.Text = idcst;
            user_name_edit.Text = CustomersDataEdit[1];
            user_no_hp_edit.Text = CustomersDataEdit[2];
            user_alamat_edit.Text = CustomersDataEdit[3];

            db_Helper.CloseConnection();
            this.idInputUser = idInputUser; parent = _parent;
            db_Helper.OpenConnection();
            string cmd = $"SELECT * FROM laptop where id_product = {idInputUser}";
            NpgsqlDataAdapter adapterCst = new NpgsqlDataAdapter(cmd, db_Helper.GetConnection());
            adapter.Fill(dt);

            db_Helper.CloseConnection();
            this.idInputUser = idInputUser;
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Db_Helper db_Helper = new Db_Helper("localhost", "5432", "penjualan_laptop", "postgres", "Rizal020304");
                db_Helper.OpenConnection();
                string query = "UPDATE customers SET customer_name = @name, no_hp = @no_hp, alamat = @alamat WHERE id_customers = @id";
                NpgsqlCommand cmd = new NpgsqlCommand(query, db_Helper.GetConnection());
                cmd.Parameters.AddWithValue("@name", user_name_edit.Text);
                cmd.Parameters.AddWithValue("@no_hp", user_no_hp_edit.Text);
                cmd.Parameters.AddWithValue("@alamat", user_alamat_edit.Text);
                cmd.Parameters.AddWithValue("@id", int.Parse(user_id_edit.Text));
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
