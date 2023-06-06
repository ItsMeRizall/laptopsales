namespace penjualan_laptop.lib.Customer_Data
{
    partial class EditCustomers
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
            EditBtn = new Button();
            panel1 = new Panel();
            alert = new Label();
            label2 = new Label();
            customers_id_input_user = new TextBox();
            PanelTittle = new Panel();
            label1 = new Label();
            DeleteDataTittle = new Label();
            panel1.SuspendLayout();
            PanelTittle.SuspendLayout();
            SuspendLayout();
            // 
            // EditBtn
            // 
            EditBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EditBtn.BackColor = Color.FromArgb(63, 130, 109);
            EditBtn.FlatAppearance.BorderSize = 2;
            EditBtn.FlatStyle = FlatStyle.Flat;
            EditBtn.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            EditBtn.ForeColor = SystemColors.Control;
            EditBtn.Location = new Point(52, 216);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(395, 40);
            EditBtn.TabIndex = 9;
            EditBtn.Text = "PILIH";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(alert);
            panel1.Controls.Add(EditBtn);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(customers_id_input_user);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 103);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(40);
            panel1.Size = new Size(508, 462);
            panel1.TabIndex = 15;
            // 
            // alert
            // 
            alert.Anchor = AnchorStyles.None;
            alert.AutoSize = true;
            alert.Font = new Font("Poppins", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point);
            alert.ForeColor = Color.Red;
            alert.Location = new Point(135, 259);
            alert.Name = "alert";
            alert.Size = new Size(227, 23);
            alert.TabIndex = 15;
            alert.Text = "ID CUSTOMER TIDAK DI TEMUKAN !!!";
            alert.Visible = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(52, 146);
            label2.Name = "label2";
            label2.Size = new Size(121, 26);
            label2.TabIndex = 10;
            label2.Text = "ID CUSTOMERS";
            // 
            // customers_id_input_user
            // 
            customers_id_input_user.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            customers_id_input_user.Location = new Point(52, 174);
            customers_id_input_user.Margin = new Padding(12);
            customers_id_input_user.Name = "customers_id_input_user";
            customers_id_input_user.Size = new Size(395, 27);
            customers_id_input_user.TabIndex = 7;
            // 
            // PanelTittle
            // 
            PanelTittle.BackColor = Color.FromArgb(63, 130, 109);
            PanelTittle.Controls.Add(label1);
            PanelTittle.Controls.Add(DeleteDataTittle);
            PanelTittle.Dock = DockStyle.Top;
            PanelTittle.Location = new Point(0, 0);
            PanelTittle.Name = "PanelTittle";
            PanelTittle.Size = new Size(508, 103);
            PanelTittle.TabIndex = 14;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Poppins SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(199, 27);
            label1.Name = "label1";
            label1.Size = new Size(122, 41);
            label1.TabIndex = 11;
            label1.Text = "EDIT ITEM";
            // 
            // DeleteDataTittle
            // 
            DeleteDataTittle.Anchor = AnchorStyles.None;
            DeleteDataTittle.AutoSize = true;
            DeleteDataTittle.Font = new Font("Poppins SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteDataTittle.ForeColor = SystemColors.Control;
            DeleteDataTittle.Location = new Point(510, -165);
            DeleteDataTittle.Name = "DeleteDataTittle";
            DeleteDataTittle.Size = new Size(151, 41);
            DeleteDataTittle.TabIndex = 10;
            DeleteDataTittle.Text = "DELETE ITEM";
            // 
            // EditCustomers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 565);
            Controls.Add(panel1);
            Controls.Add(PanelTittle);
            Name = "EditCustomers";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EditCustomers";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            PanelTittle.ResumeLayout(false);
            PanelTittle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button EditBtn;
        private Panel panel1;
        private Label label2;
        private TextBox customers_id_input_user;
        private Panel PanelTittle;
        private Label label1;
        private Label DeleteDataTittle;
        private Label alert;
    }
}