using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using penjualan_laptop.Models;
using LiveChartsCore.SkiaSharpView.WinForms;
using penjualan_laptop.lib;
using penjualan_laptop.lib.data;

namespace penjualan_laptop
{
    public partial class HomePage : Form
    {

        private Button crrButton;
        private Form activeForm;
        private List<dynamic> data_id = new List<dynamic>();
        private List<dynamic> product_name = new List<dynamic>();

        public HomePage()
        {
            InitializeComponent();
            refreshData();
            
        }

        public void refreshData()
        {
            data_id.Clear();
            product_name.Clear();
            Db_Helper db_Helper = new Db_Helper("localhost", "5432", "penjualan_laptop", "postgres", "Rizal020304");
            ReadApi("Situbondo");

            data_id = db_Helper.ConvertToList("Select units_in_stock from laptop");
            product_name = db_Helper.ConvertToListString("Select name_product from laptop");

            List<ISeries> seriesList = new List<ISeries>();

            for (int i = 0; i < data_id.Count; i++)
            {
                seriesList.Add(new PieSeries<double> { Values = new double[] { data_id[i] }, Name = product_name[i] });
            }

            pieChart1.Series = seriesList.ToArray();

            ProductForm product = new ProductForm();
            OrderForm orderForm = new OrderForm();
            CustomerForm customerForm = new CustomerForm();

            totalProduct.Text = product.productTotal().ToString();
            totalOrders.Text = orderForm.totalOrders().ToString();
            totalCustomers.Text = customerForm.totalCustomer().ToString();
        }

        public async void ReadApi(String City)
        {

            try
            {
                WeatherAPI weatherAPI = new WeatherAPI();
                WeatherData weatherData = await weatherAPI.GetWeather(City);
                Country.Text = weatherData.name;
                Detail.Text = weatherData.Weather[0].main;
                int suhu = Convert.ToInt32(weatherData.Main.temp - 273);
                SuhuDerajat.Text = suhu.ToString() + " C";
                alert.Visible = false;
                SuhuDerajat.Location = new Point(35, 75);
                button2.Location = new Point(10, 43);
                Detail.Location = new Point(63, 160);
                Country.Location = new Point(46, 138);
            }
            catch (Exception ex)
            {
                alert.Visible = true;
                alert.Text = "Kota Tidak Ditemukan";
                SuhuDerajat.Location = new Point(35, 75 + 17);
                button2.Location = new Point(10, 43 + 17);
                Detail.Location = new Point(63, 160 + 17);
                Country.Location = new Point(46, 138 + 17);
            }
        }






        public void OpenChildFrom(Form childFrom, object btnsender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivatedButton(btnsender);
            activeForm = childFrom;
            childFrom.TopLevel = false;
            childFrom.Dock = DockStyle.Fill;
            childFrom.FormBorderStyle = FormBorderStyle.None;
            this.panelDekstopPane.Controls.Add(childFrom);
            this.panelDekstopPane.Tag = childFrom;
            childFrom.BringToFront();
            childFrom.Show();
            DekstopTittle.Text = childFrom.Text;

        }

        private void ActivatedButton(object btn_sender)
        {
            if (btn_sender != null)
            {
                if (crrButton != (Button)btn_sender)
                {
                    crrButton = (Button)btn_sender;
                    crrButton.ForeColor = Color.White;

                }
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new lib.ProductForm(), sender);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new lib.OrderForm(), sender);
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new lib.CustomerForm(), sender);
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            /*ActivatedButton(sender);*/
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {

        }

        private void panelDekstopPane_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DekstopTittle_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            refreshData();
            DekstopTittle.Text = "DASHBOARD";
            crrButton = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Country_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReadApi(textBox1.Text);
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}