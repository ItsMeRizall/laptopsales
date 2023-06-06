namespace penjualan_laptop.lib.dataProduct
{
    partial class EditDataValue
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
            PanelTittle = new Panel();
            EditProductTittle = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            EditBtn = new Button();
            stock_product_edit = new TextBox();
            product_price_edit = new TextBox();
            product_name_edit = new TextBox();
            product_id_Edit = new TextBox();
            alert = new Label();
            PanelTittle.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // PanelTittle
            // 
            PanelTittle.BackColor = Color.FromArgb(63, 130, 109);
            PanelTittle.Controls.Add(EditProductTittle);
            PanelTittle.Dock = DockStyle.Top;
            PanelTittle.Location = new Point(0, 0);
            PanelTittle.Name = "PanelTittle";
            PanelTittle.Size = new Size(508, 103);
            PanelTittle.TabIndex = 4;
            // 
            // EditProductTittle
            // 
            EditProductTittle.Anchor = AnchorStyles.None;
            EditProductTittle.AutoSize = true;
            EditProductTittle.Font = new Font("Poppins SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            EditProductTittle.ForeColor = SystemColors.Control;
            EditProductTittle.Location = new Point(187, 31);
            EditProductTittle.Name = "EditProductTittle";
            EditProductTittle.Size = new Size(122, 41);
            EditProductTittle.TabIndex = 10;
            EditProductTittle.Text = "EDIT ITEM";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(450, 83);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 3;
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
            panel1.Controls.Add(stock_product_edit);
            panel1.Controls.Add(product_price_edit);
            panel1.Controls.Add(product_name_edit);
            panel1.Controls.Add(product_id_Edit);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 103);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(40);
            panel1.Size = new Size(508, 462);
            panel1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(52, 276);
            label5.Name = "label5";
            label5.Size = new Size(50, 26);
            label5.TabIndex = 9;
            label5.Text = "STOK";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(52, 195);
            label4.Name = "label4";
            label4.Size = new Size(63, 26);
            label4.TabIndex = 8;
            label4.Text = "HARGA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(52, 118);
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
            label2.Location = new Point(50, 41);
            label2.Name = "label2";
            label2.Size = new Size(85, 26);
            label2.TabIndex = 6;
            label2.Text = "ID LAPTOP";
            // 
            // EditBtn
            // 
            EditBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            EditBtn.BackColor = Color.FromArgb(63, 130, 109);
            EditBtn.FlatAppearance.BorderSize = 2;
            EditBtn.FlatStyle = FlatStyle.Flat;
            EditBtn.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            EditBtn.ForeColor = SystemColors.Control;
            EditBtn.Location = new Point(52, 360);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(406, 42);
            EditBtn.TabIndex = 5;
            EditBtn.Text = "ADD";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // stock_product_edit
            // 
            stock_product_edit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            stock_product_edit.ForeColor = SystemColors.InfoText;
            stock_product_edit.Location = new Point(52, 303);
            stock_product_edit.Margin = new Padding(12);
            stock_product_edit.Name = "stock_product_edit";
            stock_product_edit.Size = new Size(404, 27);
            stock_product_edit.TabIndex = 3;
            // 
            // product_price_edit
            // 
            product_price_edit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            product_price_edit.ForeColor = SystemColors.InfoText;
            product_price_edit.Location = new Point(52, 223);
            product_price_edit.Margin = new Padding(12);
            product_price_edit.Name = "product_price_edit";
            product_price_edit.Size = new Size(404, 27);
            product_price_edit.TabIndex = 2;
            // 
            // product_name_edit
            // 
            product_name_edit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            product_name_edit.ForeColor = SystemColors.InfoText;
            product_name_edit.Location = new Point(52, 144);
            product_name_edit.Margin = new Padding(12);
            product_name_edit.Name = "product_name_edit";
            product_name_edit.Size = new Size(404, 27);
            product_name_edit.TabIndex = 1;
            // 
            // product_id_Edit
            // 
            product_id_Edit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            product_id_Edit.Location = new Point(52, 67);
            product_id_Edit.Margin = new Padding(12);
            product_id_Edit.Name = "product_id_Edit";
            product_id_Edit.Size = new Size(404, 27);
            product_id_Edit.TabIndex = 0;
            // 
            // alert
            // 
            alert.Anchor = AnchorStyles.None;
            alert.AutoSize = true;
            alert.Font = new Font("Poppins", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point);
            alert.ForeColor = Color.Red;
            alert.Location = new Point(139, 405);
            alert.Name = "alert";
            alert.Size = new Size(227, 23);
            alert.TabIndex = 15;
            alert.Text = "ID CUSTOMER TIDAK DI TEMUKAN !!!";
            alert.Visible = false;
            // 
            // EditDataValue
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 565);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(PanelTittle);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "EditDataValue";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EditDataValue";
            PanelTittle.ResumeLayout(false);
            PanelTittle.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanelTittle;
        private Label EditProductTittle;
        private Label label1;
        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button EditBtn;
        private TextBox stock_product_edit;
        private TextBox product_price_edit;
        private TextBox product_name_edit;
        private TextBox product_id_Edit;
        private Label alert;
    }
}