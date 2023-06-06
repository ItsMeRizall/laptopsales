namespace penjualan_laptop.lib
{
    partial class OrderForm
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
            DataOrder = new DataGridView();
            panel2 = new Panel();
            RemoveOrder = new Button();
            AddOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)DataOrder).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // DataOrder
            // 
            DataOrder.AllowUserToAddRows = false;
            DataOrder.AllowUserToDeleteRows = false;
            DataOrder.AllowUserToResizeColumns = false;
            DataOrder.AllowUserToResizeRows = false;
            DataOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataOrder.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(81, 144, 124);
            dataGridViewCellStyle1.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DataOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DataOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DataOrder.DefaultCellStyle = dataGridViewCellStyle2;
            DataOrder.Dock = DockStyle.Fill;
            DataOrder.GridColor = Color.DimGray;
            DataOrder.Location = new Point(12, 12);
            DataOrder.Name = "DataOrder";
            DataOrder.ReadOnly = true;
            DataOrder.RowHeadersVisible = false;
            DataOrder.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            DataOrder.RowTemplate.Height = 29;
            DataOrder.Size = new Size(600, 426);
            DataOrder.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(RemoveOrder);
            panel2.Controls.Add(AddOrder);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(612, 12);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(176, 426);
            panel2.TabIndex = 3;
            // 
            // RemoveOrder
            // 
            RemoveOrder.BackColor = Color.FromArgb(63, 130, 109);
            RemoveOrder.Dock = DockStyle.Top;
            RemoveOrder.FlatAppearance.BorderSize = 2;
            RemoveOrder.FlatStyle = FlatStyle.Flat;
            RemoveOrder.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            RemoveOrder.ForeColor = SystemColors.Control;
            RemoveOrder.Location = new Point(10, 52);
            RemoveOrder.Name = "RemoveOrder";
            RemoveOrder.Size = new Size(156, 42);
            RemoveOrder.TabIndex = 1;
            RemoveOrder.Text = "REMOVE";
            RemoveOrder.UseVisualStyleBackColor = false;
            RemoveOrder.Click += RemoveOrder_Click;
            // 
            // AddOrder
            // 
            AddOrder.BackColor = Color.FromArgb(63, 130, 109);
            AddOrder.Dock = DockStyle.Top;
            AddOrder.FlatAppearance.BorderSize = 2;
            AddOrder.FlatStyle = FlatStyle.Flat;
            AddOrder.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AddOrder.ForeColor = SystemColors.Control;
            AddOrder.Location = new Point(10, 10);
            AddOrder.Name = "AddOrder";
            AddOrder.Size = new Size(156, 42);
            AddOrder.TabIndex = 0;
            AddOrder.Text = "ADD";
            AddOrder.UseVisualStyleBackColor = false;
            AddOrder.Click += AddOrder_Click;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DataOrder);
            Controls.Add(panel2);
            Name = "OrderForm";
            Padding = new Padding(12);
            Text = "ORDER";
            ((System.ComponentModel.ISupportInitialize)DataOrder).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataOrder;
        private Panel panel2;
        private Button RemoveOrder;
        private Button AddOrder;
    }
}