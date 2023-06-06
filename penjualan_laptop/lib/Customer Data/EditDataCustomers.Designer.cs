namespace penjualan_laptop.lib.Customer_Data
{
    partial class EditDataCustomers
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
            EditCustomerTittle = new Label();
            panel1 = new Panel();
            alert = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            EditBtn = new Button();
            user_alamat_edit = new TextBox();
            user_no_hp_edit = new TextBox();
            user_name_edit = new TextBox();
            user_id_edit = new TextBox();
            PanelTittle = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            PanelTittle.SuspendLayout();
            SuspendLayout();
            // 
            // EditCustomerTittle
            // 
            EditCustomerTittle.Anchor = AnchorStyles.None;
            EditCustomerTittle.AutoSize = true;
            EditCustomerTittle.Font = new Font("Poppins SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            EditCustomerTittle.ForeColor = SystemColors.Control;
            EditCustomerTittle.Location = new Point(187, 30);
            EditCustomerTittle.Name = "EditCustomerTittle";
            EditCustomerTittle.Size = new Size(122, 41);
            EditCustomerTittle.TabIndex = 10;
            EditCustomerTittle.Text = "EDIT ITEM";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(alert);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(EditBtn);
            panel1.Controls.Add(user_alamat_edit);
            panel1.Controls.Add(user_no_hp_edit);
            panel1.Controls.Add(user_name_edit);
            panel1.Controls.Add(user_id_edit);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 103);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(40);
            panel1.Size = new Size(508, 462);
            panel1.TabIndex = 8;
            // 
            // alert
            // 
            alert.Anchor = AnchorStyles.None;
            alert.AutoSize = true;
            alert.Font = new Font("Poppins", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point);
            alert.ForeColor = Color.Red;
            alert.Location = new Point(141, 372);
            alert.Name = "alert";
            alert.Size = new Size(227, 23);
            alert.TabIndex = 16;
            alert.Text = "ID CUSTOMER TIDAK DI TEMUKAN !!!";
            alert.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(43, 249);
            label5.Name = "label5";
            label5.Size = new Size(69, 26);
            label5.TabIndex = 9;
            label5.Text = "ALAMAT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(43, 184);
            label4.Name = "label4";
            label4.Size = new Size(58, 26);
            label4.TabIndex = 8;
            label4.Text = "NO HP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(43, 119);
            label3.Name = "label3";
            label3.Size = new Size(56, 26);
            label3.TabIndex = 7;
            label3.Text = "NAMA";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(43, 54);
            label2.Name = "label2";
            label2.Size = new Size(121, 26);
            label2.TabIndex = 6;
            label2.Text = "ID CUSTOMERS";
            // 
            // EditBtn
            // 
            EditBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            EditBtn.BackColor = Color.FromArgb(63, 130, 109);
            EditBtn.FlatAppearance.BorderSize = 2;
            EditBtn.FlatStyle = FlatStyle.Flat;
            EditBtn.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            EditBtn.ForeColor = SystemColors.Control;
            EditBtn.Location = new Point(43, 327);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(424, 42);
            EditBtn.TabIndex = 5;
            EditBtn.Text = "SAVE";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // user_alamat_edit
            // 
            user_alamat_edit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            user_alamat_edit.ForeColor = SystemColors.InfoText;
            user_alamat_edit.Location = new Point(43, 275);
            user_alamat_edit.Margin = new Padding(12);
            user_alamat_edit.Name = "user_alamat_edit";
            user_alamat_edit.Size = new Size(424, 27);
            user_alamat_edit.TabIndex = 3;
            // 
            // user_no_hp_edit
            // 
            user_no_hp_edit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            user_no_hp_edit.ForeColor = SystemColors.InfoText;
            user_no_hp_edit.Location = new Point(43, 210);
            user_no_hp_edit.Margin = new Padding(12);
            user_no_hp_edit.Name = "user_no_hp_edit";
            user_no_hp_edit.Size = new Size(424, 27);
            user_no_hp_edit.TabIndex = 2;
            // 
            // user_name_edit
            // 
            user_name_edit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            user_name_edit.ForeColor = SystemColors.InfoText;
            user_name_edit.Location = new Point(43, 145);
            user_name_edit.Margin = new Padding(12);
            user_name_edit.Name = "user_name_edit";
            user_name_edit.Size = new Size(424, 27);
            user_name_edit.TabIndex = 1;
            // 
            // user_id_edit
            // 
            user_id_edit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            user_id_edit.Location = new Point(43, 80);
            user_id_edit.Margin = new Padding(12);
            user_id_edit.Name = "user_id_edit";
            user_id_edit.Size = new Size(424, 27);
            user_id_edit.TabIndex = 0;
            // 
            // PanelTittle
            // 
            PanelTittle.BackColor = Color.FromArgb(63, 130, 109);
            PanelTittle.Controls.Add(EditCustomerTittle);
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
            // EditDataCustomers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 565);
            Controls.Add(panel1);
            Controls.Add(PanelTittle);
            Controls.Add(label1);
            Name = "EditDataCustomers";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EditDataCustomers";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            PanelTittle.ResumeLayout(false);
            PanelTittle.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EditCustomerTittle;
        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button EditBtn;
        private TextBox user_alamat_edit;
        private TextBox user_no_hp_edit;
        private TextBox user_name_edit;
        private TextBox user_id_edit;
        private Panel PanelTittle;
        private Label label1;
        private Label alert;
    }
}