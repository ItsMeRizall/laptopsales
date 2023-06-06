namespace penjualan_laptop.lib.Customer_Data
{
    partial class addCustomers
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
            AddProductTittle = new Label();
            panel1 = new Panel();
            alert = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            AddBtn = new Button();
            user_alamat_input = new TextBox();
            user_no_hp_input = new TextBox();
            user_name_input = new TextBox();
            user_id_input = new TextBox();
            PanelTittle = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            PanelTittle.SuspendLayout();
            SuspendLayout();
            // 
            // AddProductTittle
            // 
            AddProductTittle.Anchor = AnchorStyles.None;
            AddProductTittle.AutoSize = true;
            AddProductTittle.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            AddProductTittle.ForeColor = SystemColors.Control;
            AddProductTittle.Location = new Point(196, 29);
            AddProductTittle.Name = "AddProductTittle";
            AddProductTittle.Size = new Size(141, 29);
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
            panel1.Controls.Add(user_alamat_input);
            panel1.Controls.Add(user_no_hp_input);
            panel1.Controls.Add(user_name_input);
            panel1.Controls.Add(user_id_input);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 103);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(40);
            panel1.Size = new Size(508, 462);
            panel1.TabIndex = 5;
            // 
            // alert
            // 
            alert.Anchor = AnchorStyles.None;
            alert.AutoSize = true;
            alert.Font = new Font("Microsoft Sans Serif", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point);
            alert.ForeColor = Color.Red;
            alert.Location = new Point(139, 333);
            alert.Name = "alert";
            alert.Size = new Size(239, 16);
            alert.TabIndex = 15;
            alert.Text = "ID CUSTOMER TIDAK DI TEMUKAN !!!";
            alert.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(52, 210);
            label5.Name = "label5";
            label5.Size = new Size(65, 18);
            label5.TabIndex = 9;
            label5.Text = "ALAMAT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(52, 145);
            label4.Name = "label4";
            label4.Size = new Size(56, 18);
            label4.TabIndex = 8;
            label4.Text = "NO HP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(52, 80);
            label3.Name = "label3";
            label3.Size = new Size(50, 18);
            label3.TabIndex = 7;
            label3.Text = "NAMA";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(52, 15);
            label2.Name = "label2";
            label2.Size = new Size(123, 18);
            label2.TabIndex = 6;
            label2.Text = "ID CUSTOMERS";
            // 
            // AddBtn
            // 
            AddBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddBtn.BackColor = Color.FromArgb(63, 130, 109);
            AddBtn.FlatAppearance.BorderSize = 2;
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AddBtn.ForeColor = SystemColors.Control;
            AddBtn.Location = new Point(52, 288);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(404, 42);
            AddBtn.TabIndex = 5;
            AddBtn.Text = "ADD";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // user_alamat_input
            // 
            user_alamat_input.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            user_alamat_input.ForeColor = SystemColors.InfoText;
            user_alamat_input.Location = new Point(52, 236);
            user_alamat_input.Margin = new Padding(12);
            user_alamat_input.Name = "user_alamat_input";
            user_alamat_input.Size = new Size(404, 27);
            user_alamat_input.TabIndex = 3;
            // 
            // user_no_hp_input
            // 
            user_no_hp_input.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            user_no_hp_input.ForeColor = SystemColors.InfoText;
            user_no_hp_input.Location = new Point(52, 171);
            user_no_hp_input.Margin = new Padding(12);
            user_no_hp_input.Name = "user_no_hp_input";
            user_no_hp_input.Size = new Size(404, 27);
            user_no_hp_input.TabIndex = 2;
            // 
            // user_name_input
            // 
            user_name_input.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            user_name_input.ForeColor = SystemColors.InfoText;
            user_name_input.Location = new Point(52, 106);
            user_name_input.Margin = new Padding(12);
            user_name_input.Name = "user_name_input";
            user_name_input.Size = new Size(404, 27);
            user_name_input.TabIndex = 1;
            // 
            // user_id_input
            // 
            user_id_input.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            user_id_input.Location = new Point(52, 41);
            user_id_input.Margin = new Padding(12);
            user_id_input.Name = "user_id_input";
            user_id_input.Size = new Size(404, 27);
            user_id_input.TabIndex = 0;
            // 
            // PanelTittle
            // 
            PanelTittle.BackColor = Color.FromArgb(63, 130, 109);
            PanelTittle.Controls.Add(AddProductTittle);
            PanelTittle.Dock = DockStyle.Top;
            PanelTittle.Location = new Point(0, 0);
            PanelTittle.Name = "PanelTittle";
            PanelTittle.Size = new Size(508, 103);
            PanelTittle.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(450, 83);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 3;
            // 
            // addCustomers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 565);
            Controls.Add(panel1);
            Controls.Add(PanelTittle);
            Controls.Add(label1);
            Name = "addCustomers";
            StartPosition = FormStartPosition.CenterParent;
            Text = "addCustomers";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            PanelTittle.ResumeLayout(false);
            PanelTittle.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AddProductTittle;
        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button AddBtn;
        private TextBox user_alamat_input;
        private TextBox user_no_hp_input;
        private TextBox user_name_input;
        private TextBox user_id_input;
        private Panel PanelTittle;
        private Label label1;
        private Label alert;
    }
}