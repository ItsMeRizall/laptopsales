namespace penjualan_laptop.lib
{
    partial class ProductForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            dataProduct = new DataGridView();
            panel2 = new Panel();
            EditProduct = new Button();
            RemoveProduct = new Button();
            AddProductBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataProduct).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataProduct);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 0;
            // 
            // dataProduct
            // 
            dataProduct.AllowUserToAddRows = false;
            dataProduct.AllowUserToDeleteRows = false;
            dataProduct.AllowUserToResizeColumns = false;
            dataProduct.AllowUserToResizeRows = false;
            dataProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataProduct.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(81, 144, 124);
            dataGridViewCellStyle1.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataProduct.DefaultCellStyle = dataGridViewCellStyle2;
            dataProduct.Dock = DockStyle.Fill;
            dataProduct.GridColor = Color.DimGray;
            dataProduct.Location = new Point(0, 0);
            dataProduct.Name = "dataProduct";
            dataProduct.ReadOnly = true;
            dataProduct.RowHeadersVisible = false;
            dataProduct.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataProduct.RowTemplate.Height = 29;
            dataProduct.Size = new Size(600, 426);
            dataProduct.TabIndex = 1;
            dataProduct.CellContentClick += dataProduct_CellContentClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(EditProduct);
            panel2.Controls.Add(RemoveProduct);
            panel2.Controls.Add(AddProductBtn);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(600, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(176, 426);
            panel2.TabIndex = 1;
            // 
            // EditProduct
            // 
            EditProduct.BackColor = Color.FromArgb(63, 130, 109);
            EditProduct.Dock = DockStyle.Top;
            EditProduct.FlatAppearance.BorderSize = 2;
            EditProduct.FlatStyle = FlatStyle.Flat;
            EditProduct.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            EditProduct.ForeColor = SystemColors.Control;
            EditProduct.Location = new Point(10, 94);
            EditProduct.Name = "EditProduct";
            EditProduct.Size = new Size(156, 42);
            EditProduct.TabIndex = 2;
            EditProduct.Text = "EDIT";
            EditProduct.UseVisualStyleBackColor = false;
            EditProduct.Click += EditProduct_Click;
            // 
            // RemoveProduct
            // 
            RemoveProduct.BackColor = Color.FromArgb(63, 130, 109);
            RemoveProduct.Dock = DockStyle.Top;
            RemoveProduct.FlatAppearance.BorderSize = 2;
            RemoveProduct.FlatStyle = FlatStyle.Flat;
            RemoveProduct.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            RemoveProduct.ForeColor = SystemColors.Control;
            RemoveProduct.Location = new Point(10, 52);
            RemoveProduct.Name = "RemoveProduct";
            RemoveProduct.Size = new Size(156, 42);
            RemoveProduct.TabIndex = 1;
            RemoveProduct.Text = "REMOVE";
            RemoveProduct.UseVisualStyleBackColor = false;
            RemoveProduct.Click += RemoveProduct_Click;
            // 
            // AddProductBtn
            // 
            AddProductBtn.BackColor = Color.FromArgb(63, 130, 109);
            AddProductBtn.Dock = DockStyle.Top;
            AddProductBtn.FlatAppearance.BorderSize = 2;
            AddProductBtn.FlatStyle = FlatStyle.Flat;
            AddProductBtn.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AddProductBtn.ForeColor = SystemColors.Control;
            AddProductBtn.Location = new Point(10, 10);
            AddProductBtn.Name = "AddProductBtn";
            AddProductBtn.Size = new Size(156, 42);
            AddProductBtn.TabIndex = 0;
            AddProductBtn.Text = "ADD";
            AddProductBtn.UseVisualStyleBackColor = false;
            AddProductBtn.Click += AddProduct_Click;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "ProductForm";
            Padding = new Padding(12);
            Text = "PRODUCT";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataProduct).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataProduct;
        private Panel panel2;
        private Button AddProductBtn;
        private Button RemoveProduct;
        private Button EditProduct;
    }
}