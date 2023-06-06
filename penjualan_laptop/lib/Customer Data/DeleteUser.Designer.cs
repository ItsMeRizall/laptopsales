namespace penjualan_laptop.lib.Customer_Data
{
    partial class DeleteUser
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
            DeleteDataTittle = new Label();
            DeleteBtn = new Button();
            label2 = new Label();
            delete_id_input = new TextBox();
            panel1 = new Panel();
            alert = new Label();
            PanelTittle.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // PanelTittle
            // 
            PanelTittle.BackColor = Color.FromArgb(63, 130, 109);
            PanelTittle.Controls.Add(DeleteDataTittle);
            PanelTittle.Dock = DockStyle.Top;
            PanelTittle.Location = new Point(0, 0);
            PanelTittle.Name = "PanelTittle";
            PanelTittle.Size = new Size(508, 103);
            PanelTittle.TabIndex = 12;
            // 
            // DeleteDataTittle
            // 
            DeleteDataTittle.Anchor = AnchorStyles.None;
            DeleteDataTittle.AutoSize = true;
            DeleteDataTittle.Font = new Font("Poppins SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteDataTittle.ForeColor = SystemColors.Control;
            DeleteDataTittle.Location = new Point(170, 33);
            DeleteDataTittle.Name = "DeleteDataTittle";
            DeleteDataTittle.Size = new Size(151, 41);
            DeleteDataTittle.TabIndex = 10;
            DeleteDataTittle.Text = "DELETE ITEM";
            // 
            // DeleteBtn
            // 
            DeleteBtn.Anchor = AnchorStyles.None;
            DeleteBtn.BackColor = Color.FromArgb(63, 130, 109);
            DeleteBtn.FlatAppearance.BorderSize = 2;
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteBtn.ForeColor = SystemColors.Control;
            DeleteBtn.Location = new Point(42, 334);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(430, 42);
            DeleteBtn.TabIndex = 9;
            DeleteBtn.Text = "DELETE";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(42, 264);
            label2.Name = "label2";
            label2.Size = new Size(112, 26);
            label2.TabIndex = 10;
            label2.Text = "ID CUSTOMER";
            // 
            // delete_id_input
            // 
            delete_id_input.Anchor = AnchorStyles.None;
            delete_id_input.Location = new Point(42, 292);
            delete_id_input.Margin = new Padding(12);
            delete_id_input.Name = "delete_id_input";
            delete_id_input.Size = new Size(430, 27);
            delete_id_input.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Controls.Add(alert);
            panel1.Controls.Add(DeleteBtn);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(delete_id_input);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(40);
            panel1.Name = "panel1";
            panel1.Size = new Size(508, 565);
            panel1.TabIndex = 13;
            // 
            // alert
            // 
            alert.Anchor = AnchorStyles.None;
            alert.AutoSize = true;
            alert.Font = new Font("Poppins", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point);
            alert.ForeColor = Color.Red;
            alert.Location = new Point(142, 379);
            alert.Name = "alert";
            alert.Size = new Size(227, 23);
            alert.TabIndex = 14;
            alert.Text = "ID CUSTOMER TIDAK DI TEMUKAN !!!";
            alert.Visible = false;
            // 
            // DeleteUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 565);
            Controls.Add(PanelTittle);
            Controls.Add(panel1);
            Name = "DeleteUser";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DeleteUser";
            PanelTittle.ResumeLayout(false);
            PanelTittle.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelTittle;
        private Label DeleteDataTittle;
        private Button DeleteBtn;
        private Label label2;
        private TextBox delete_id_input;
        private Panel panel1;
        private Label alert;
    }
}