namespace penjualan_laptop.lib.Orders
{
    partial class AddOrders
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
            panel1 = new Panel();
            alert = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            AddBtn = new Button();
            quantity_input = new TextBox();
            product_id_input = new TextBox();
            cust_id_input = new TextBox();
            order_id_input = new TextBox();
            AddProductTittle = new Label();
            PanelTittle = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            PanelTittle.SuspendLayout();
            SuspendLayout();
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
            panel1.Controls.Add(quantity_input);
            panel1.Controls.Add(product_id_input);
            panel1.Controls.Add(cust_id_input);
            panel1.Controls.Add(order_id_input);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 103);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(40);
            panel1.Size = new Size(508, 467);
            panel1.TabIndex = 8;
            // 
            // alert
            // 
            alert.Anchor = AnchorStyles.None;
            alert.AutoSize = true;
            alert.Font = new Font("Poppins", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point);
            alert.ForeColor = Color.Red;
            alert.Location = new Point(124, 340);
            alert.Name = "alert";
            alert.Size = new Size(240, 23);
            alert.TabIndex = 12;
            alert.Text = "MASUKKAN DENGAN FORMAT ANGKA";
            alert.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(43, 218);
            label5.Name = "label5";
            label5.Size = new Size(84, 26);
            label5.TabIndex = 9;
            label5.Text = "QUANTITY";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(43, 153);
            label4.Name = "label4";
            label4.Size = new Size(102, 26);
            label4.TabIndex = 8;
            label4.Text = "ID PRODUCT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(43, 88);
            label3.Name = "label3";
            label3.Size = new Size(112, 26);
            label3.TabIndex = 7;
            label3.Text = "ID CUSTOMER";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(43, 23);
            label2.Name = "label2";
            label2.Size = new Size(80, 26);
            label2.TabIndex = 6;
            label2.Text = "ID ORDER";
            // 
            // AddBtn
            // 
            AddBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddBtn.BackColor = Color.FromArgb(63, 130, 109);
            AddBtn.FlatAppearance.BorderSize = 2;
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AddBtn.ForeColor = SystemColors.Control;
            AddBtn.Location = new Point(43, 295);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(407, 42);
            AddBtn.TabIndex = 5;
            AddBtn.Text = "ADD";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // quantity_input
            // 
            quantity_input.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            quantity_input.ForeColor = SystemColors.InfoText;
            quantity_input.Location = new Point(43, 244);
            quantity_input.Margin = new Padding(12);
            quantity_input.Name = "quantity_input";
            quantity_input.Size = new Size(407, 27);
            quantity_input.TabIndex = 3;
            // 
            // product_id_input
            // 
            product_id_input.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            product_id_input.ForeColor = SystemColors.InfoText;
            product_id_input.Location = new Point(43, 179);
            product_id_input.Margin = new Padding(12);
            product_id_input.Name = "product_id_input";
            product_id_input.Size = new Size(407, 27);
            product_id_input.TabIndex = 2;
            // 
            // cust_id_input
            // 
            cust_id_input.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cust_id_input.ForeColor = SystemColors.InfoText;
            cust_id_input.Location = new Point(43, 114);
            cust_id_input.Margin = new Padding(12);
            cust_id_input.Name = "cust_id_input";
            cust_id_input.Size = new Size(407, 27);
            cust_id_input.TabIndex = 1;
            // 
            // order_id_input
            // 
            order_id_input.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            order_id_input.Location = new Point(43, 49);
            order_id_input.Margin = new Padding(12);
            order_id_input.Name = "order_id_input";
            order_id_input.Size = new Size(407, 27);
            order_id_input.TabIndex = 0;
            // 
            // AddProductTittle
            // 
            AddProductTittle.Anchor = AnchorStyles.None;
            AddProductTittle.AutoSize = true;
            AddProductTittle.Font = new Font("Poppins SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            AddProductTittle.ForeColor = SystemColors.Control;
            AddProductTittle.Location = new Point(179, 30);
            AddProductTittle.Name = "AddProductTittle";
            AddProductTittle.Size = new Size(152, 41);
            AddProductTittle.TabIndex = 10;
            AddProductTittle.Text = "NEW ORDER";
            // 
            // PanelTittle
            // 
            PanelTittle.BackColor = Color.FromArgb(63, 130, 109);
            PanelTittle.Controls.Add(AddProductTittle);
            PanelTittle.Dock = DockStyle.Top;
            PanelTittle.Location = new Point(0, 0);
            PanelTittle.Name = "PanelTittle";
            PanelTittle.Size = new Size(508, 103);
            PanelTittle.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(450, 83);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 6;
            // 
            // AddOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 570);
            Controls.Add(panel1);
            Controls.Add(PanelTittle);
            Controls.Add(label1);
            MaximumSize = new Size(526, 617);
            MinimumSize = new Size(526, 617);
            Name = "AddOrders";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddOrders";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            PanelTittle.ResumeLayout(false);
            PanelTittle.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button AddBtn;
        private TextBox quantity_input;
        private TextBox product_id_input;
        private TextBox cust_id_input;
        private TextBox order_id_input;
        private Label AddProductTittle;
        private Panel PanelTittle;
        private Label label1;
        private Label alert;
    }
}