namespace penjualan_laptop.lib.data
{
    partial class AddProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            PanelTittle = new Panel();
            AddProductTittle = new Label();
            panel1 = new Panel();
            alert = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            AddBtn = new Button();
            stock_product_input = new TextBox();
            product_price_input = new TextBox();
            product_name_input = new TextBox();
            product_id_input = new TextBox();
            PanelTittle.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(450, 83);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // PanelTittle
            // 
            PanelTittle.BackColor = Color.FromArgb(63, 130, 109);
            PanelTittle.Controls.Add(AddProductTittle);
            PanelTittle.Dock = DockStyle.Top;
            PanelTittle.Location = new Point(0, 0);
            PanelTittle.Name = "PanelTittle";
            PanelTittle.Size = new Size(508, 103);
            PanelTittle.TabIndex = 1;
            // 
            // AddProductTittle
            // 
            AddProductTittle.Anchor = AnchorStyles.None;
            AddProductTittle.AutoSize = true;
            AddProductTittle.Font = new Font("Poppins SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            AddProductTittle.ForeColor = SystemColors.Control;
            AddProductTittle.Location = new Point(196, 30);
            AddProductTittle.Name = "AddProductTittle";
            AddProductTittle.Size = new Size(128, 41);
            AddProductTittle.TabIndex = 10;
            AddProductTittle.Text = "NEW ITEM";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(alert);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(AddBtn);
            panel1.Controls.Add(stock_product_input);
            panel1.Controls.Add(product_price_input);
            panel1.Controls.Add(product_name_input);
            panel1.Controls.Add(product_id_input);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 103);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(40);
            panel1.Size = new Size(508, 462);
            panel1.TabIndex = 2;
            // 
            // alert
            // 
            alert.Anchor = AnchorStyles.None;
            alert.AutoSize = true;
            alert.Font = new Font("Poppins", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point);
            alert.ForeColor = Color.Red;
            alert.Location = new Point(138, 390);
            alert.Name = "alert";
            alert.Size = new Size(227, 23);
            alert.TabIndex = 15;
            alert.Text = "ID CUSTOMER TIDAK DI TEMUKAN !!!";
            alert.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(38, 261);
            label5.Name = "label5";
            label5.Size = new Size(50, 26);
            label5.TabIndex = 9;
            label5.Text = "STOK";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(38, 180);
            label4.Name = "label4";
            label4.Size = new Size(63, 26);
            label4.TabIndex = 8;
            label4.Text = "HARGA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(38, 103);
            label3.Name = "label3";
            label3.Size = new Size(56, 26);
            label3.TabIndex = 7;
            label3.Text = "NAMA";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(36, 26);
            label2.Name = "label2";
            label2.Size = new Size(85, 26);
            label2.TabIndex = 6;
            label2.Text = "ID LAPTOP";
            // 
            // AddBtn
            // 
            AddBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddBtn.BackColor = Color.FromArgb(63, 130, 109);
            AddBtn.FlatAppearance.BorderSize = 2;
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AddBtn.ForeColor = SystemColors.Control;
            AddBtn.Location = new Point(38, 345);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(430, 42);
            AddBtn.TabIndex = 5;
            AddBtn.Text = "ADD";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // stock_product_input
            // 
            stock_product_input.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            stock_product_input.ForeColor = SystemColors.InfoText;
            stock_product_input.Location = new Point(38, 288);
            stock_product_input.Margin = new Padding(12);
            stock_product_input.Name = "stock_product_input";
            stock_product_input.Size = new Size(428, 27);
            stock_product_input.TabIndex = 3;
            // 
            // product_price_input
            // 
            product_price_input.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            product_price_input.ForeColor = SystemColors.InfoText;
            product_price_input.Location = new Point(38, 208);
            product_price_input.Margin = new Padding(12);
            product_price_input.Name = "product_price_input";
            product_price_input.Size = new Size(428, 27);
            product_price_input.TabIndex = 2;
            // 
            // product_name_input
            // 
            product_name_input.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            product_name_input.ForeColor = SystemColors.InfoText;
            product_name_input.Location = new Point(38, 129);
            product_name_input.Margin = new Padding(12);
            product_name_input.Name = "product_name_input";
            product_name_input.Size = new Size(428, 27);
            product_name_input.TabIndex = 1;
            // 
            // product_id_input
            // 
            product_id_input.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            product_id_input.Location = new Point(38, 52);
            product_id_input.Margin = new Padding(12);
            product_id_input.Name = "product_id_input";
            product_id_input.Size = new Size(428, 27);
            product_id_input.TabIndex = 0;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 565);
            Controls.Add(panel1);
            Controls.Add(PanelTittle);
            Controls.Add(label1);
            MaximumSize = new Size(526, 612);
            MinimumSize = new Size(526, 612);
            Name = "AddProductForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Product";
            PanelTittle.ResumeLayout(false);
            PanelTittle.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel PanelTittle;
        private Panel panel1;
        private TextBox stock_product_input;
        private TextBox product_price_input;
        private TextBox product_name_input;
        private TextBox product_id_input;
        private Button AddBtn;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label AddProductTittle;
        private Label alert;
    }
}