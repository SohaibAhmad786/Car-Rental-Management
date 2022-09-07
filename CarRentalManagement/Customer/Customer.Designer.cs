
namespace CarRentalManagement.Customer
{
    partial class Customer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.xuiGradientPanel1 = new XanderUI.XUIGradientPanel();
            this.txtCustomerPhone = new ReaLTaiizor.Controls.DungeonTextBox();
            this.txtCustomerAddress = new ReaLTaiizor.Controls.DungeonTextBox();
            this.txtCustomerName = new ReaLTaiizor.Controls.DungeonTextBox();
            this.txtCustomerId = new ReaLTaiizor.Controls.DungeonTextBox();
            this.BtnUpdateCustomer = new XanderUI.XUISuperButton();
            this.btnAddCustomer = new XanderUI.XUISuperButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.xuiGradientPanel2 = new XanderUI.XUIGradientPanel();
            this.dgvCustomer = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xuiGradientPanel1.SuspendLayout();
            this.xuiGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 38F);
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(354, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 66);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customers";
            // 
            // xuiGradientPanel1
            // 
            this.xuiGradientPanel1.BottomLeft = System.Drawing.Color.SlateGray;
            this.xuiGradientPanel1.BottomRight = System.Drawing.Color.SlateGray;
            this.xuiGradientPanel1.Controls.Add(this.txtCustomerPhone);
            this.xuiGradientPanel1.Controls.Add(this.txtCustomerAddress);
            this.xuiGradientPanel1.Controls.Add(this.txtCustomerName);
            this.xuiGradientPanel1.Controls.Add(this.txtCustomerId);
            this.xuiGradientPanel1.Controls.Add(this.BtnUpdateCustomer);
            this.xuiGradientPanel1.Controls.Add(this.btnAddCustomer);
            this.xuiGradientPanel1.Controls.Add(this.label7);
            this.xuiGradientPanel1.Controls.Add(this.label6);
            this.xuiGradientPanel1.Controls.Add(this.label4);
            this.xuiGradientPanel1.Controls.Add(this.label2);
            this.xuiGradientPanel1.Controls.Add(this.label3);
            this.xuiGradientPanel1.Location = new System.Drawing.Point(-1, 104);
            this.xuiGradientPanel1.Name = "xuiGradientPanel1";
            this.xuiGradientPanel1.PrimerColor = System.Drawing.Color.White;
            this.xuiGradientPanel1.Size = new System.Drawing.Size(525, 483);
            this.xuiGradientPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiGradientPanel1.TabIndex = 12;
            this.xuiGradientPanel1.TopLeft = System.Drawing.Color.DarkTurquoise;
            this.xuiGradientPanel1.TopRight = System.Drawing.Color.DarkTurquoise;
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.BackColor = System.Drawing.Color.Transparent;
            this.txtCustomerPhone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtCustomerPhone.EdgeColor = System.Drawing.Color.White;
            this.txtCustomerPhone.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtCustomerPhone.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtCustomerPhone.Location = new System.Drawing.Point(192, 307);
            this.txtCustomerPhone.MaxLength = 32767;
            this.txtCustomerPhone.Multiline = false;
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.ReadOnly = false;
            this.txtCustomerPhone.Size = new System.Drawing.Size(196, 28);
            this.txtCustomerPhone.TabIndex = 27;
            this.txtCustomerPhone.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCustomerPhone.UseSystemPasswordChar = false;
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.BackColor = System.Drawing.Color.Transparent;
            this.txtCustomerAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtCustomerAddress.EdgeColor = System.Drawing.Color.White;
            this.txtCustomerAddress.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtCustomerAddress.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtCustomerAddress.Location = new System.Drawing.Point(192, 243);
            this.txtCustomerAddress.MaxLength = 32767;
            this.txtCustomerAddress.Multiline = false;
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.ReadOnly = false;
            this.txtCustomerAddress.Size = new System.Drawing.Size(196, 28);
            this.txtCustomerAddress.TabIndex = 26;
            this.txtCustomerAddress.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCustomerAddress.UseSystemPasswordChar = false;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.Color.Transparent;
            this.txtCustomerName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtCustomerName.EdgeColor = System.Drawing.Color.White;
            this.txtCustomerName.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtCustomerName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtCustomerName.Location = new System.Drawing.Point(192, 170);
            this.txtCustomerName.MaxLength = 32767;
            this.txtCustomerName.Multiline = false;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = false;
            this.txtCustomerName.Size = new System.Drawing.Size(196, 28);
            this.txtCustomerName.TabIndex = 25;
            this.txtCustomerName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCustomerName.UseSystemPasswordChar = false;
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.BackColor = System.Drawing.Color.Transparent;
            this.txtCustomerId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtCustomerId.EdgeColor = System.Drawing.Color.White;
            this.txtCustomerId.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtCustomerId.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtCustomerId.Location = new System.Drawing.Point(192, 100);
            this.txtCustomerId.MaxLength = 32767;
            this.txtCustomerId.Multiline = false;
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.ReadOnly = false;
            this.txtCustomerId.Size = new System.Drawing.Size(196, 28);
            this.txtCustomerId.TabIndex = 3;
            this.txtCustomerId.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCustomerId.UseSystemPasswordChar = false;
            // 
            // BtnUpdateCustomer
            // 
            this.BtnUpdateCustomer.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.BtnUpdateCustomer.ButtonImage = null;
            this.BtnUpdateCustomer.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.BtnUpdateCustomer.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.BtnUpdateCustomer.ButtonText = "Update";
            this.BtnUpdateCustomer.CornerRadius = 25;
            this.BtnUpdateCustomer.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateCustomer.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnUpdateCustomer.HoverBackgroundColor = System.Drawing.Color.Gray;
            this.BtnUpdateCustomer.HoverTextColor = System.Drawing.Color.White;
            this.BtnUpdateCustomer.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.BtnUpdateCustomer.Location = new System.Drawing.Point(243, 375);
            this.BtnUpdateCustomer.Name = "BtnUpdateCustomer";
            this.BtnUpdateCustomer.SelectedBackColor = System.Drawing.SystemColors.WindowFrame;
            this.BtnUpdateCustomer.SelectedTextColor = System.Drawing.Color.Snow;
            this.BtnUpdateCustomer.Size = new System.Drawing.Size(100, 40);
            this.BtnUpdateCustomer.SuperSelected = false;
            this.BtnUpdateCustomer.TabIndex = 23;
            this.BtnUpdateCustomer.TextColor = System.Drawing.Color.Red;
            this.BtnUpdateCustomer.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnUpdateCustomer.Click += new System.EventHandler(this.BtnUpdateCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAddCustomer.ButtonImage = null;
            this.btnAddCustomer.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnAddCustomer.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnAddCustomer.ButtonText = "Add";
            this.btnAddCustomer.CornerRadius = 25;
            this.btnAddCustomer.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddCustomer.HoverBackgroundColor = System.Drawing.Color.Gray;
            this.btnAddCustomer.HoverTextColor = System.Drawing.Color.White;
            this.btnAddCustomer.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnAddCustomer.Location = new System.Drawing.Point(113, 375);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.SelectedBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAddCustomer.SelectedTextColor = System.Drawing.Color.Snow;
            this.btnAddCustomer.Size = new System.Drawing.Size(100, 40);
            this.btnAddCustomer.SuperSelected = false;
            this.btnAddCustomer.TabIndex = 22;
            this.btnAddCustomer.TextColor = System.Drawing.Color.Red;
            this.btnAddCustomer.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FloralWhite;
            this.label7.Location = new System.Drawing.Point(25, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FloralWhite;
            this.label6.Location = new System.Drawing.Point(25, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FloralWhite;
            this.label4.Location = new System.Drawing.Point(25, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(24, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(364, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Customer Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FloralWhite;
            this.label3.Location = new System.Drawing.Point(25, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer Id";
            // 
            // xuiGradientPanel2
            // 
            this.xuiGradientPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xuiGradientPanel2.BottomLeft = System.Drawing.Color.Gray;
            this.xuiGradientPanel2.BottomRight = System.Drawing.Color.Lavender;
            this.xuiGradientPanel2.Controls.Add(this.dgvCustomer);
            this.xuiGradientPanel2.Location = new System.Drawing.Point(509, 104);
            this.xuiGradientPanel2.Name = "xuiGradientPanel2";
            this.xuiGradientPanel2.PrimerColor = System.Drawing.Color.White;
            this.xuiGradientPanel2.Size = new System.Drawing.Size(613, 484);
            this.xuiGradientPanel2.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiGradientPanel2.TabIndex = 13;
            this.xuiGradientPanel2.TopLeft = System.Drawing.Color.DeepPink;
            this.xuiGradientPanel2.TopRight = System.Drawing.Color.DarkSalmon;
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.AllowUserToResizeColumns = false;
            this.dgvCustomer.AllowUserToResizeRows = false;
            this.dgvCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCustomer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCustomer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomer.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomer.EnableHeadersVisualStyles = false;
            this.dgvCustomer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvCustomer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCustomer.Location = new System.Drawing.Point(74, 85);
            this.dgvCustomer.MultiSelect = false;
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCustomer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.Size = new System.Drawing.Size(441, 150);
            this.dgvCustomer.TabIndex = 1;
            this.dgvCustomer.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            this.dgvCustomer.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellContentDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Address";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Phone";
            this.Column4.Name = "Column4";
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 587);
            this.Controls.Add(this.xuiGradientPanel2);
            this.Controls.Add(this.xuiGradientPanel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer";
            this.Text = "AddCustomer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.xuiGradientPanel1.ResumeLayout(false);
            this.xuiGradientPanel1.PerformLayout();
            this.xuiGradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private XanderUI.XUIGradientPanel xuiGradientPanel1;
        private XanderUI.XUISuperButton BtnUpdateCustomer;
        private XanderUI.XUISuperButton btnAddCustomer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private XanderUI.XUIGradientPanel xuiGradientPanel2;
        private ReaLTaiizor.Controls.DungeonTextBox txtCustomerPhone;
        private ReaLTaiizor.Controls.DungeonTextBox txtCustomerAddress;
        private ReaLTaiizor.Controls.DungeonTextBox txtCustomerName;
        private ReaLTaiizor.Controls.DungeonTextBox txtCustomerId;
        private ReaLTaiizor.Controls.PoisonDataGridView dgvCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}