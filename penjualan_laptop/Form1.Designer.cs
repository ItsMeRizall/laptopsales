namespace penjualan_laptop
{
    partial class HomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            label1 = new Label();
            SidePanel = new Panel();
            panelDekstopPane = new Panel();
            DashBoard = new Panel();
            panel3 = new Panel();
            panel8 = new Panel();
            pieChart1 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            panel9 = new Panel();
            productLabel = new Label();
            label3 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel6 = new Panel();
            totalCustomers = new Label();
            pictureBox3 = new PictureBox();
            label8 = new Label();
            panel5 = new Panel();
            totalOrders = new Label();
            label6 = new Label();
            panel4 = new Panel();
            totalProduct = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel1 = new Panel();
            alert = new Label();
            SuhuDerajat = new Label();
            button2 = new Button();
            Detail = new Label();
            Country = new Label();
            textBox1 = new TextBox();
            productTitte = new Panel();
            DekstopTittle = new Label();
            panel2 = new Panel();
            button1 = new Button();
            btnLogout = new Button();
            btnNotifications = new Button();
            btnCustomers = new Button();
            btnOrders = new Button();
            btnProducts = new Button();
            PanelLogo = new Panel();
            pictureBox2 = new PictureBox();
            SidePanel.SuspendLayout();
            panelDekstopPane.SuspendLayout();
            DashBoard.SuspendLayout();
            panel3.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            productTitte.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            // 
            // SidePanel
            // 
            SidePanel.Controls.Add(panelDekstopPane);
            SidePanel.Controls.Add(productTitte);
            SidePanel.Controls.Add(panel2);
            SidePanel.Dock = DockStyle.Fill;
            SidePanel.Location = new Point(0, 0);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(1356, 603);
            SidePanel.TabIndex = 2;
            // 
            // panelDekstopPane
            // 
            panelDekstopPane.Controls.Add(DashBoard);
            panelDekstopPane.Dock = DockStyle.Fill;
            panelDekstopPane.Location = new Point(220, 75);
            panelDekstopPane.Name = "panelDekstopPane";
            panelDekstopPane.Size = new Size(1136, 528);
            panelDekstopPane.TabIndex = 2;
            panelDekstopPane.Paint += panelDekstopPane_Paint;
            // 
            // DashBoard
            // 
            DashBoard.Controls.Add(panel3);
            DashBoard.Controls.Add(panel1);
            DashBoard.Dock = DockStyle.Fill;
            DashBoard.Location = new Point(0, 0);
            DashBoard.Name = "DashBoard";
            DashBoard.Size = new Size(1136, 528);
            DashBoard.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel8);
            panel3.Controls.Add(tableLayoutPanel1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(25);
            panel3.Size = new Size(955, 528);
            panel3.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.Controls.Add(pieChart1);
            panel8.Controls.Add(panel9);
            panel8.Location = new Point(25, 198);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(20);
            panel8.Size = new Size(303, 230);
            panel8.TabIndex = 2;
            // 
            // pieChart1
            // 
            pieChart1.BackColor = SystemColors.Control;
            pieChart1.Dock = DockStyle.Fill;
            pieChart1.InitialRotation = 0D;
            pieChart1.IsClockwise = true;
            pieChart1.Location = new Point(20, 62);
            pieChart1.MaxAngle = 360D;
            pieChart1.Name = "pieChart1";
            pieChart1.Size = new Size(263, 148);
            pieChart1.TabIndex = 1;
            pieChart1.Total = null;
            // 
            // panel9
            // 
            panel9.Controls.Add(productLabel);
            panel9.Controls.Add(label3);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(20, 20);
            panel9.Name = "panel9";
            panel9.Size = new Size(263, 42);
            panel9.TabIndex = 0;
            // 
            // productLabel
            // 
            productLabel.AutoSize = true;
            productLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            productLabel.Location = new Point(70, 8);
            productLabel.Name = "productLabel";
            productLabel.Size = new Size(118, 31);
            productLabel.TabIndex = 1;
            productLabel.Text = "PRODUCT";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(103, -29);
            label3.Name = "label3";
            label3.Size = new Size(118, 31);
            label3.TabIndex = 0;
            label3.Text = "PRODUCT";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(panel6, 0, 0);
            tableLayoutPanel1.Controls.Add(panel5, 0, 0);
            tableLayoutPanel1.Controls.Add(panel4, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(25, 25);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(905, 167);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(63, 130, 109);
            panel6.Controls.Add(totalCustomers);
            panel6.Controls.Add(pictureBox3);
            panel6.Controls.Add(label8);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(601, 13);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(10);
            panel6.Size = new Size(291, 141);
            panel6.TabIndex = 2;
            // 
            // totalCustomers
            // 
            totalCustomers.AutoSize = true;
            totalCustomers.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            totalCustomers.ForeColor = SystemColors.Control;
            totalCustomers.Location = new Point(23, 70);
            totalCustomers.Name = "totalCustomers";
            totalCustomers.Size = new Size(64, 50);
            totalCustomers.TabIndex = 2;
            totalCustomers.Text = "65";
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Right;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(153, 58);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 62);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(23, 10);
            label8.Name = "label8";
            label8.Size = new Size(219, 28);
            label8.TabIndex = 0;
            label8.Text = "TOTAL OF CUSTOMERS";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(63, 130, 109);
            panel5.Controls.Add(pictureBox2);
            panel5.Controls.Add(totalOrders);
            panel5.Controls.Add(label6);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(307, 13);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(10);
            panel5.Size = new Size(288, 141);
            panel5.TabIndex = 1;
            // 
            // totalOrders
            // 
            totalOrders.AutoSize = true;
            totalOrders.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            totalOrders.ForeColor = SystemColors.Control;
            totalOrders.Location = new Point(23, 70);
            totalOrders.Name = "totalOrders";
            totalOrders.Size = new Size(64, 50);
            totalOrders.TabIndex = 2;
            totalOrders.Text = "65";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(23, 10);
            label6.Name = "label6";
            label6.Size = new Size(180, 28);
            label6.TabIndex = 0;
            label6.Text = "TOTAL OF ORDERS";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(63, 130, 109);
            panel4.Controls.Add(totalProduct);
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(13, 13);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(10);
            panel4.Size = new Size(288, 141);
            panel4.TabIndex = 0;
            // 
            // totalProduct
            // 
            totalProduct.AutoSize = true;
            totalProduct.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            totalProduct.ForeColor = SystemColors.Control;
            totalProduct.Location = new Point(13, 70);
            totalProduct.Name = "totalProduct";
            totalProduct.Size = new Size(64, 50);
            totalProduct.TabIndex = 2;
            totalProduct.Text = "65";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.box;
            pictureBox1.Location = new Point(150, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(13, 10);
            label2.Name = "label2";
            label2.Size = new Size(196, 28);
            label2.TabIndex = 0;
            label2.Text = "TOTAL OF PRODUCT";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(alert);
            panel1.Controls.Add(SuhuDerajat);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(Detail);
            panel1.Controls.Add(Country);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(955, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(181, 528);
            panel1.TabIndex = 0;
            // 
            // alert
            // 
            alert.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            alert.AutoSize = true;
            alert.BackColor = Color.Transparent;
            alert.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            alert.ForeColor = Color.Red;
            alert.Location = new Point(13, 37);
            alert.Name = "alert";
            alert.Size = new Size(54, 16);
            alert.TabIndex = 6;
            alert.Text = "DETAIL";
            alert.Visible = false;
            // 
            // SuhuDerajat
            // 
            SuhuDerajat.Anchor = AnchorStyles.Top;
            SuhuDerajat.AutoSize = true;
            SuhuDerajat.BackColor = Color.Transparent;
            SuhuDerajat.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            SuhuDerajat.Location = new Point(35, 75);
            SuhuDerajat.Name = "SuhuDerajat";
            SuhuDerajat.Size = new Size(104, 46);
            SuhuDerajat.TabIndex = 5;
            SuhuDerajat.Text = "36 C";
            SuhuDerajat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.Location = new Point(10, 43);
            button2.Name = "button2";
            button2.Size = new Size(161, 29);
            button2.TabIndex = 4;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Detail
            // 
            Detail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Detail.AutoSize = true;
            Detail.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            Detail.Location = new Point(63, 160);
            Detail.Name = "Detail";
            Detail.Size = new Size(54, 16);
            Detail.TabIndex = 3;
            Detail.Text = "DETAIL";
            // 
            // Country
            // 
            Country.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Country.AutoSize = true;
            Country.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Country.Location = new Point(46, 138);
            Country.Name = "Country";
            Country.Size = new Size(90, 20);
            Country.TabIndex = 2;
            Country.Text = "COUNTRY";
            Country.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Top;
            textBox1.Location = new Point(10, 10);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // productTitte
            // 
            productTitte.BackColor = Color.FromArgb(63, 130, 109);
            productTitte.Controls.Add(DekstopTittle);
            productTitte.Dock = DockStyle.Top;
            productTitte.Location = new Point(220, 0);
            productTitte.Name = "productTitte";
            productTitte.Size = new Size(1136, 75);
            productTitte.TabIndex = 1;
            // 
            // DekstopTittle
            // 
            DekstopTittle.Anchor = AnchorStyles.None;
            DekstopTittle.AutoSize = true;
            DekstopTittle.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            DekstopTittle.ForeColor = SystemColors.Control;
            DekstopTittle.Location = new Point(505, 18);
            DekstopTittle.Name = "DekstopTittle";
            DekstopTittle.Size = new Size(171, 29);
            DekstopTittle.TabIndex = 0;
            DekstopTittle.Text = "DASHBOARD";
            DekstopTittle.Click += DekstopTittle_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(63, 130, 109);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(btnNotifications);
            panel2.Controls.Add(btnCustomers);
            panel2.Controls.Add(btnOrders);
            panel2.Controls.Add(btnProducts);
            panel2.Controls.Add(PanelLogo);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(220, 603);
            panel2.TabIndex = 0;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.Control;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 75);
            button1.Name = "button1";
            button1.Padding = new Padding(12, 0, 0, 0);
            button1.Size = new Size(220, 60);
            button1.TabIndex = 6;
            button1.Text = "    Dashboard";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // btnLogout
            // 
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = SystemColors.Control;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 396);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(12, 0, 0, 0);
            btnLogout.Size = new Size(220, 60);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "    Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click_1;
            // 
            // btnNotifications
            // 
            btnNotifications.FlatAppearance.BorderSize = 0;
            btnNotifications.FlatStyle = FlatStyle.Flat;
            btnNotifications.ForeColor = SystemColors.Control;
            btnNotifications.Image = (Image)resources.GetObject("btnNotifications.Image");
            btnNotifications.ImageAlign = ContentAlignment.MiddleLeft;
            btnNotifications.Location = new Point(0, 330);
            btnNotifications.Name = "btnNotifications";
            btnNotifications.Padding = new Padding(12, 0, 0, 0);
            btnNotifications.Size = new Size(220, 60);
            btnNotifications.TabIndex = 4;
            btnNotifications.Text = "    Notifications";
            btnNotifications.TextAlign = ContentAlignment.MiddleLeft;
            btnNotifications.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNotifications.UseVisualStyleBackColor = true;
            btnNotifications.Click += btnNotifications_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.FlatAppearance.BorderSize = 0;
            btnCustomers.FlatStyle = FlatStyle.Flat;
            btnCustomers.ForeColor = SystemColors.Control;
            btnCustomers.Image = (Image)resources.GetObject("btnCustomers.Image");
            btnCustomers.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomers.Location = new Point(3, 264);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Padding = new Padding(12, 0, 0, 0);
            btnCustomers.Size = new Size(220, 60);
            btnCustomers.TabIndex = 3;
            btnCustomers.Text = "    Customers";
            btnCustomers.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCustomers.UseVisualStyleBackColor = true;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnOrders
            // 
            btnOrders.FlatAppearance.BorderSize = 0;
            btnOrders.FlatStyle = FlatStyle.Flat;
            btnOrders.ForeColor = SystemColors.Control;
            btnOrders.Image = (Image)resources.GetObject("btnOrders.Image");
            btnOrders.ImageAlign = ContentAlignment.MiddleLeft;
            btnOrders.Location = new Point(0, 207);
            btnOrders.Name = "btnOrders";
            btnOrders.Padding = new Padding(12, 0, 0, 0);
            btnOrders.Size = new Size(220, 60);
            btnOrders.TabIndex = 2;
            btnOrders.Text = "    Orders";
            btnOrders.TextAlign = ContentAlignment.MiddleLeft;
            btnOrders.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOrders.UseVisualStyleBackColor = true;
            btnOrders.Click += btnOrders_Click;
            // 
            // btnProducts
            // 
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.ForeColor = SystemColors.Control;
            btnProducts.Image = Properties.Resources.shopping_cart__1_;
            btnProducts.ImageAlign = ContentAlignment.MiddleLeft;
            btnProducts.Location = new Point(0, 141);
            btnProducts.Name = "btnProducts";
            btnProducts.Padding = new Padding(12, 0, 0, 0);
            btnProducts.Size = new Size(220, 60);
            btnProducts.TabIndex = 1;
            btnProducts.Text = "    Products";
            btnProducts.TextAlign = ContentAlignment.MiddleLeft;
            btnProducts.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += button1_Click;
            // 
            // PanelLogo
            // 
            PanelLogo.BackColor = Color.FromArgb(53, 110, 93);
            PanelLogo.Dock = DockStyle.Top;
            PanelLogo.Location = new Point(0, 0);
            PanelLogo.Name = "PanelLogo";
            PanelLogo.Padding = new Padding(12, 0, 0, 0);
            PanelLogo.Size = new Size(220, 75);
            PanelLogo.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(150, 58);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1356, 603);
            Controls.Add(SidePanel);
            Controls.Add(label1);
            MinimumSize = new Size(1374, 650);
            Name = "HomePage";
            Text = "Penjualan Laptop";
            Load += Form1_Load;
            SidePanel.ResumeLayout(false);
            panelDekstopPane.ResumeLayout(false);
            DashBoard.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            productTitte.ResumeLayout(false);
            productTitte.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Panel SidePanel;
        private Panel productTitte;
        private Label DekstopTittle;
        private Panel panelDekstopPane;
        private Panel panel2;
        private Button btnLogout;
        private Button btnNotifications;
        private Button btnCustomers;
        private Button btnOrders;
        private Button btnProducts;
        private Panel PanelLogo;
        private Button button1;
        private Panel DashBoard;
        private Panel panel1;
        private Label Country;
        private TextBox textBox1;
        private Label Detail;
        private Button button2;
        private Label SuhuDerajat;
        private Label alert;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel8;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart1;
        private Panel panel9;
        private Label label3;
        private Label productLabel;
        private Panel panel4;
        private Label label2;
        private PictureBox pictureBox1;
        private Label totalProduct;
        private Panel panel6;
        private Label totalCustomers;
        private PictureBox pictureBox3;
        private Label label8;
        private Panel panel5;
        private Label totalOrders;
        private Label label6;
        private PictureBox pictureBox2;
    }
}