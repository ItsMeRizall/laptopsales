namespace penjualan_laptop.lib
{
    partial class CustomerForm
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
            DataCustomers = new DataGridView();
            panel2 = new Panel();
            EditCustomers = new Button();
            RemoveCustomers = new Button();
            AddCustomers = new Button();
            ((System.ComponentModel.ISupportInitialize)DataCustomers).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // DataCustomers
            // 
            DataCustomers.AllowUserToAddRows = false;
            DataCustomers.AllowUserToDeleteRows = false;
            DataCustomers.AllowUserToResizeColumns = false;
            DataCustomers.AllowUserToResizeRows = false;
            DataCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataCustomers.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(81, 144, 124);
            dataGridViewCellStyle1.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DataCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DataCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DataCustomers.DefaultCellStyle = dataGridViewCellStyle2;
            DataCustomers.Dock = DockStyle.Fill;
            DataCustomers.GridColor = Color.DimGray;
            DataCustomers.Location = new Point(12, 12);
            DataCustomers.Name = "DataCustomers";
            DataCustomers.ReadOnly = true;
            DataCustomers.RowHeadersVisible = false;
            DataCustomers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            DataCustomers.RowTemplate.Height = 29;
            DataCustomers.Size = new Size(600, 426);
            DataCustomers.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(EditCustomers);
            panel2.Controls.Add(RemoveCustomers);
            panel2.Controls.Add(AddCustomers);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(612, 12);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(176, 426);
            panel2.TabIndex = 3;
            // 
            // EditCustomers
            // 
            EditCustomers.BackColor = Color.FromArgb(63, 130, 109);
            EditCustomers.Dock = DockStyle.Top;
            EditCustomers.FlatAppearance.BorderSize = 2;
            EditCustomers.FlatStyle = FlatStyle.Flat;
            EditCustomers.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            EditCustomers.ForeColor = SystemColors.Control;
            EditCustomers.Location = new Point(10, 94);
            EditCustomers.Name = "EditCustomers";
            EditCustomers.Size = new Size(156, 42);
            EditCustomers.TabIndex = 2;
            EditCustomers.Text = "EDIT";
            EditCustomers.UseVisualStyleBackColor = false;
            EditCustomers.Click += EditCustomers_Click;
            // 
            // RemoveCustomers
            // 
            RemoveCustomers.BackColor = Color.FromArgb(63, 130, 109);
            RemoveCustomers.Dock = DockStyle.Top;
            RemoveCustomers.FlatAppearance.BorderSize = 2;
            RemoveCustomers.FlatStyle = FlatStyle.Flat;
            RemoveCustomers.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            RemoveCustomers.ForeColor = SystemColors.Control;
            RemoveCustomers.Location = new Point(10, 52);
            RemoveCustomers.Name = "RemoveCustomers";
            RemoveCustomers.Size = new Size(156, 42);
            RemoveCustomers.TabIndex = 1;
            RemoveCustomers.Text = "REMOVE";
            RemoveCustomers.UseVisualStyleBackColor = false;
            RemoveCustomers.Click += RemoveCustomers_Click;
            // 
            // AddCustomers
            // 
            AddCustomers.BackColor = Color.FromArgb(63, 130, 109);
            AddCustomers.Dock = DockStyle.Top;
            AddCustomers.FlatAppearance.BorderSize = 2;
            AddCustomers.FlatStyle = FlatStyle.Flat;
            AddCustomers.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AddCustomers.ForeColor = SystemColors.Control;
            AddCustomers.Location = new Point(10, 10);
            AddCustomers.Name = "AddCustomers";
            AddCustomers.Size = new Size(156, 42);
            AddCustomers.TabIndex = 0;
            AddCustomers.Text = "ADD";
            AddCustomers.UseVisualStyleBackColor = false;
            AddCustomers.Click += AddCustomers_Click;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DataCustomers);
            Controls.Add(panel2);
            Name = "CustomerForm";
            Padding = new Padding(12);
            Text = "CUSTOMERS";
            ((System.ComponentModel.ISupportInitialize)DataCustomers).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataCustomers;
        private Panel panel2;
        private Button EditCustomers;
        private Button RemoveCustomers;
        private Button AddCustomers;
    }
}