
namespace CarRentalManagement.Functionality
{
    partial class Maintenance
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
            this.label5 = new System.Windows.Forms.Label();
            this.xuiGradientPanel1 = new XanderUI.XUIGradientPanel();
            this.dtMaintenanceDate = new ReaLTaiizor.Controls.PoisonDateTime();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbxMaintenanceCarRegNo = new ReaLTaiizor.Controls.SkyComboBox();
            this.txtMaintenancePrice = new ReaLTaiizor.Controls.DungeonTextBox();
            this.txtMaintenanceId = new ReaLTaiizor.Controls.DungeonTextBox();
            this.btnMaintenanceAdd = new XanderUI.XUISuperButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.xuiGradientPanel2 = new XanderUI.XUIGradientPanel();
            this.dgvMaintenanceCrs = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xuiGradientPanel1.SuspendLayout();
            this.xuiGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenanceCrs)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Lucida Handwriting", 38F);
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(265, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(413, 66);
            this.label5.TabIndex = 16;
            this.label5.Text = "Maintenance";
            // 
            // xuiGradientPanel1
            // 
            this.xuiGradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xuiGradientPanel1.BottomLeft = System.Drawing.Color.SlateGray;
            this.xuiGradientPanel1.BottomRight = System.Drawing.Color.SlateGray;
            this.xuiGradientPanel1.Controls.Add(this.dtMaintenanceDate);
            this.xuiGradientPanel1.Controls.Add(this.label1);
            this.xuiGradientPanel1.Controls.Add(this.cmbxMaintenanceCarRegNo);
            this.xuiGradientPanel1.Controls.Add(this.txtMaintenancePrice);
            this.xuiGradientPanel1.Controls.Add(this.txtMaintenanceId);
            this.xuiGradientPanel1.Controls.Add(this.btnMaintenanceAdd);
            this.xuiGradientPanel1.Controls.Add(this.label7);
            this.xuiGradientPanel1.Controls.Add(this.label4);
            this.xuiGradientPanel1.Controls.Add(this.label3);
            this.xuiGradientPanel1.Location = new System.Drawing.Point(-1, 103);
            this.xuiGradientPanel1.Name = "xuiGradientPanel1";
            this.xuiGradientPanel1.PrimerColor = System.Drawing.Color.White;
            this.xuiGradientPanel1.Size = new System.Drawing.Size(410, 444);
            this.xuiGradientPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiGradientPanel1.TabIndex = 17;
            this.xuiGradientPanel1.TopLeft = System.Drawing.Color.DarkTurquoise;
            this.xuiGradientPanel1.TopRight = System.Drawing.Color.DarkTurquoise;
            // 
            // dtMaintenanceDate
            // 
            this.dtMaintenanceDate.Location = new System.Drawing.Point(192, 229);
            this.dtMaintenanceDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtMaintenanceDate.Name = "dtMaintenanceDate";
            this.dtMaintenanceDate.Size = new System.Drawing.Size(196, 29);
            this.dtMaintenanceDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(25, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "Maintenance Date";
            // 
            // cmbxMaintenanceCarRegNo
            // 
            this.cmbxMaintenanceCarRegNo.BackColor = System.Drawing.Color.Transparent;
            this.cmbxMaintenanceCarRegNo.BGColorA = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.cmbxMaintenanceCarRegNo.BGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.cmbxMaintenanceCarRegNo.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.cmbxMaintenanceCarRegNo.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cmbxMaintenanceCarRegNo.BorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.cmbxMaintenanceCarRegNo.BorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.cmbxMaintenanceCarRegNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbxMaintenanceCarRegNo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbxMaintenanceCarRegNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxMaintenanceCarRegNo.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold);
            this.cmbxMaintenanceCarRegNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.cmbxMaintenanceCarRegNo.FormattingEnabled = true;
            this.cmbxMaintenanceCarRegNo.ItemHeight = 16;
            this.cmbxMaintenanceCarRegNo.ItemHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(176)))), ((int)(((byte)(214)))));
            this.cmbxMaintenanceCarRegNo.LineColorA = System.Drawing.Color.White;
            this.cmbxMaintenanceCarRegNo.LineColorB = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.cmbxMaintenanceCarRegNo.LineColorC = System.Drawing.Color.White;
            this.cmbxMaintenanceCarRegNo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbxMaintenanceCarRegNo.ListBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbxMaintenanceCarRegNo.ListDashType = System.Drawing.Drawing2D.DashStyle.Dot;
            this.cmbxMaintenanceCarRegNo.ListForeColor = System.Drawing.Color.Black;
            this.cmbxMaintenanceCarRegNo.ListSelectedBackColorA = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbxMaintenanceCarRegNo.ListSelectedBackColorB = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbxMaintenanceCarRegNo.Location = new System.Drawing.Point(192, 95);
            this.cmbxMaintenanceCarRegNo.Name = "cmbxMaintenanceCarRegNo";
            this.cmbxMaintenanceCarRegNo.Size = new System.Drawing.Size(196, 22);
            this.cmbxMaintenanceCarRegNo.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.cmbxMaintenanceCarRegNo.StartIndex = 0;
            this.cmbxMaintenanceCarRegNo.TabIndex = 1;
            this.cmbxMaintenanceCarRegNo.TriangleColorA = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(176)))), ((int)(((byte)(214)))));
            this.cmbxMaintenanceCarRegNo.TriangleColorB = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            // 
            // txtMaintenancePrice
            // 
            this.txtMaintenancePrice.BackColor = System.Drawing.Color.Transparent;
            this.txtMaintenancePrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtMaintenancePrice.EdgeColor = System.Drawing.Color.White;
            this.txtMaintenancePrice.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtMaintenancePrice.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtMaintenancePrice.Location = new System.Drawing.Point(192, 162);
            this.txtMaintenancePrice.MaxLength = 32767;
            this.txtMaintenancePrice.Multiline = false;
            this.txtMaintenancePrice.Name = "txtMaintenancePrice";
            this.txtMaintenancePrice.ReadOnly = false;
            this.txtMaintenancePrice.Size = new System.Drawing.Size(196, 28);
            this.txtMaintenancePrice.TabIndex = 27;
            this.txtMaintenancePrice.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaintenancePrice.UseSystemPasswordChar = false;
            // 
            // txtMaintenanceId
            // 
            this.txtMaintenanceId.BackColor = System.Drawing.Color.Transparent;
            this.txtMaintenanceId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtMaintenanceId.EdgeColor = System.Drawing.Color.White;
            this.txtMaintenanceId.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtMaintenanceId.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtMaintenanceId.Location = new System.Drawing.Point(192, 33);
            this.txtMaintenanceId.MaxLength = 32767;
            this.txtMaintenanceId.Multiline = false;
            this.txtMaintenanceId.Name = "txtMaintenanceId";
            this.txtMaintenanceId.ReadOnly = false;
            this.txtMaintenanceId.Size = new System.Drawing.Size(196, 28);
            this.txtMaintenanceId.TabIndex = 3;
            this.txtMaintenanceId.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaintenanceId.UseSystemPasswordChar = false;
            // 
            // btnMaintenanceAdd
            // 
            this.btnMaintenanceAdd.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.btnMaintenanceAdd.ButtonImage = null;
            this.btnMaintenanceAdd.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnMaintenanceAdd.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnMaintenanceAdd.ButtonText = "Add";
            this.btnMaintenanceAdd.CornerRadius = 25;
            this.btnMaintenanceAdd.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaintenanceAdd.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnMaintenanceAdd.HoverBackgroundColor = System.Drawing.Color.Gray;
            this.btnMaintenanceAdd.HoverTextColor = System.Drawing.Color.White;
            this.btnMaintenanceAdd.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnMaintenanceAdd.Location = new System.Drawing.Point(137, 352);
            this.btnMaintenanceAdd.Name = "btnMaintenanceAdd";
            this.btnMaintenanceAdd.SelectedBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnMaintenanceAdd.SelectedTextColor = System.Drawing.Color.Snow;
            this.btnMaintenanceAdd.Size = new System.Drawing.Size(100, 40);
            this.btnMaintenanceAdd.SuperSelected = false;
            this.btnMaintenanceAdd.TabIndex = 22;
            this.btnMaintenanceAdd.TextColor = System.Drawing.Color.Red;
            this.btnMaintenanceAdd.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnMaintenanceAdd.Click += new System.EventHandler(this.btnMaintenanceAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FloralWhite;
            this.label7.Location = new System.Drawing.Point(25, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "Maintenance price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FloralWhite;
            this.label4.Location = new System.Drawing.Point(25, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Car RegNo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FloralWhite;
            this.label3.Location = new System.Drawing.Point(25, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Maintenance Id";
            // 
            // xuiGradientPanel2
            // 
            this.xuiGradientPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xuiGradientPanel2.BottomLeft = System.Drawing.Color.Gray;
            this.xuiGradientPanel2.BottomRight = System.Drawing.Color.Lavender;
            this.xuiGradientPanel2.Controls.Add(this.dgvMaintenanceCrs);
            this.xuiGradientPanel2.Location = new System.Drawing.Point(409, 103);
            this.xuiGradientPanel2.Name = "xuiGradientPanel2";
            this.xuiGradientPanel2.PrimerColor = System.Drawing.Color.White;
            this.xuiGradientPanel2.Size = new System.Drawing.Size(464, 444);
            this.xuiGradientPanel2.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiGradientPanel2.TabIndex = 18;
            this.xuiGradientPanel2.TopLeft = System.Drawing.Color.DeepPink;
            this.xuiGradientPanel2.TopRight = System.Drawing.Color.DarkSalmon;
            // 
            // dgvMaintenanceCrs
            // 
            this.dgvMaintenanceCrs.AllowUserToAddRows = false;
            this.dgvMaintenanceCrs.AllowUserToDeleteRows = false;
            this.dgvMaintenanceCrs.AllowUserToResizeColumns = false;
            this.dgvMaintenanceCrs.AllowUserToResizeRows = false;
            this.dgvMaintenanceCrs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvMaintenanceCrs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvMaintenanceCrs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMaintenanceCrs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvMaintenanceCrs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMaintenanceCrs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMaintenanceCrs.ColumnHeadersHeight = 25;
            this.dgvMaintenanceCrs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvMaintenanceCrs.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMaintenanceCrs.EnableHeadersVisualStyles = false;
            this.dgvMaintenanceCrs.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvMaintenanceCrs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvMaintenanceCrs.HighLightPercentage = 0.5F;
            this.dgvMaintenanceCrs.Location = new System.Drawing.Point(23, 60);
            this.dgvMaintenanceCrs.Name = "dgvMaintenanceCrs";
            this.dgvMaintenanceCrs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMaintenanceCrs.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMaintenanceCrs.RowHeadersWidth = 50;
            this.dgvMaintenanceCrs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMaintenanceCrs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvMaintenanceCrs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaintenanceCrs.Size = new System.Drawing.Size(416, 110);
            this.dgvMaintenanceCrs.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Maintenance Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Car RegNo";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Price";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Date";
            this.Column4.Name = "Column4";
            // 
            // Maintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(873, 547);
            this.Controls.Add(this.xuiGradientPanel2);
            this.Controls.Add(this.xuiGradientPanel1);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Maintenance";
            this.Text = "Maintenance";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Maintenance_Load);
            this.xuiGradientPanel1.ResumeLayout(false);
            this.xuiGradientPanel1.PerformLayout();
            this.xuiGradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenanceCrs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private XanderUI.XUIGradientPanel xuiGradientPanel1;
        private ReaLTaiizor.Controls.PoisonDateTime dtMaintenanceDate;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.SkyComboBox cmbxMaintenanceCarRegNo;
        private ReaLTaiizor.Controls.DungeonTextBox txtMaintenancePrice;
        private ReaLTaiizor.Controls.DungeonTextBox txtMaintenanceId;
        private XanderUI.XUISuperButton btnMaintenanceAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private XanderUI.XUIGradientPanel xuiGradientPanel2;
        private ReaLTaiizor.Controls.PoisonDataGridView dgvMaintenanceCrs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}