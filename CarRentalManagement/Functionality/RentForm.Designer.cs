
namespace CarRentalManagement.Functionality
{
    partial class RentForm
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
            this.xuiGradientPanel1 = new XanderUI.XUIGradientPanel();
            this.dtRenturnDate = new ReaLTaiizor.Controls.PoisonDateTime();
            this.dtRentDate = new ReaLTaiizor.Controls.PoisonDateTime();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbxRentCustomerId = new ReaLTaiizor.Controls.SkyComboBox();
            this.cmbxRentCarRegNo = new ReaLTaiizor.Controls.SkyComboBox();
            this.txtRentCustomerName = new ReaLTaiizor.Controls.DungeonTextBox();
            this.txtRentId = new ReaLTaiizor.Controls.DungeonTextBox();
            this.xuiSuperButton2 = new XanderUI.XUISuperButton();
            this.btnRentAdd = new XanderUI.XUISuperButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.xuiGradientPanel2 = new XanderUI.XUIGradientPanel();
            this.dgvRentedCars = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.xuiGradientPanel1.SuspendLayout();
            this.xuiGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentedCars)).BeginInit();
            this.SuspendLayout();
            // 
            // xuiGradientPanel1
            // 
            this.xuiGradientPanel1.BottomLeft = System.Drawing.Color.SlateGray;
            this.xuiGradientPanel1.BottomRight = System.Drawing.Color.SlateGray;
            this.xuiGradientPanel1.Controls.Add(this.dtRenturnDate);
            this.xuiGradientPanel1.Controls.Add(this.dtRentDate);
            this.xuiGradientPanel1.Controls.Add(this.label2);
            this.xuiGradientPanel1.Controls.Add(this.label1);
            this.xuiGradientPanel1.Controls.Add(this.cmbxRentCustomerId);
            this.xuiGradientPanel1.Controls.Add(this.cmbxRentCarRegNo);
            this.xuiGradientPanel1.Controls.Add(this.txtRentCustomerName);
            this.xuiGradientPanel1.Controls.Add(this.txtRentId);
            this.xuiGradientPanel1.Controls.Add(this.xuiSuperButton2);
            this.xuiGradientPanel1.Controls.Add(this.btnRentAdd);
            this.xuiGradientPanel1.Controls.Add(this.label7);
            this.xuiGradientPanel1.Controls.Add(this.label6);
            this.xuiGradientPanel1.Controls.Add(this.label4);
            this.xuiGradientPanel1.Controls.Add(this.label3);
            this.xuiGradientPanel1.Location = new System.Drawing.Point(0, 103);
            this.xuiGradientPanel1.Name = "xuiGradientPanel1";
            this.xuiGradientPanel1.PrimerColor = System.Drawing.Color.White;
            this.xuiGradientPanel1.Size = new System.Drawing.Size(410, 483);
            this.xuiGradientPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiGradientPanel1.TabIndex = 13;
            this.xuiGradientPanel1.TopLeft = System.Drawing.Color.DarkTurquoise;
            this.xuiGradientPanel1.TopRight = System.Drawing.Color.DarkTurquoise;
            // 
            // dtRenturnDate
            // 
            this.dtRenturnDate.Location = new System.Drawing.Point(192, 304);
            this.dtRenturnDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtRenturnDate.Name = "dtRenturnDate";
            this.dtRenturnDate.Size = new System.Drawing.Size(196, 29);
            this.dtRenturnDate.TabIndex = 31;
            // 
            // dtRentDate
            // 
            this.dtRentDate.Location = new System.Drawing.Point(192, 248);
            this.dtRentDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtRentDate.Name = "dtRentDate";
            this.dtRentDate.Size = new System.Drawing.Size(196, 29);
            this.dtRentDate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FloralWhite;
            this.label2.Location = new System.Drawing.Point(24, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "Return Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(25, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "Rent Date";
            // 
            // cmbxRentCustomerId
            // 
            this.cmbxRentCustomerId.BackColor = System.Drawing.Color.Transparent;
            this.cmbxRentCustomerId.BGColorA = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.cmbxRentCustomerId.BGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.cmbxRentCustomerId.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.cmbxRentCustomerId.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cmbxRentCustomerId.BorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.cmbxRentCustomerId.BorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.cmbxRentCustomerId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbxRentCustomerId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbxRentCustomerId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxRentCustomerId.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold);
            this.cmbxRentCustomerId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.cmbxRentCustomerId.FormattingEnabled = true;
            this.cmbxRentCustomerId.ItemHeight = 16;
            this.cmbxRentCustomerId.ItemHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(176)))), ((int)(((byte)(214)))));
            this.cmbxRentCustomerId.LineColorA = System.Drawing.Color.White;
            this.cmbxRentCustomerId.LineColorB = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.cmbxRentCustomerId.LineColorC = System.Drawing.Color.White;
            this.cmbxRentCustomerId.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbxRentCustomerId.ListBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbxRentCustomerId.ListDashType = System.Drawing.Drawing2D.DashStyle.Dot;
            this.cmbxRentCustomerId.ListForeColor = System.Drawing.Color.Black;
            this.cmbxRentCustomerId.ListSelectedBackColorA = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbxRentCustomerId.ListSelectedBackColorB = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbxRentCustomerId.Location = new System.Drawing.Point(192, 139);
            this.cmbxRentCustomerId.Name = "cmbxRentCustomerId";
            this.cmbxRentCustomerId.Size = new System.Drawing.Size(196, 22);
            this.cmbxRentCustomerId.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.cmbxRentCustomerId.StartIndex = 0;
            this.cmbxRentCustomerId.TabIndex = 28;
            this.cmbxRentCustomerId.TriangleColorA = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(176)))), ((int)(((byte)(214)))));
            this.cmbxRentCustomerId.TriangleColorB = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.cmbxRentCustomerId.SelectedIndexChanged += new System.EventHandler(this.cmbxRentCustomerId_SelectedIndexChanged);
            // 
            // cmbxRentCarRegNo
            // 
            this.cmbxRentCarRegNo.BackColor = System.Drawing.Color.Transparent;
            this.cmbxRentCarRegNo.BGColorA = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.cmbxRentCarRegNo.BGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.cmbxRentCarRegNo.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.cmbxRentCarRegNo.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cmbxRentCarRegNo.BorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.cmbxRentCarRegNo.BorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.cmbxRentCarRegNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbxRentCarRegNo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbxRentCarRegNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxRentCarRegNo.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold);
            this.cmbxRentCarRegNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.cmbxRentCarRegNo.FormattingEnabled = true;
            this.cmbxRentCarRegNo.ItemHeight = 16;
            this.cmbxRentCarRegNo.ItemHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(176)))), ((int)(((byte)(214)))));
            this.cmbxRentCarRegNo.LineColorA = System.Drawing.Color.White;
            this.cmbxRentCarRegNo.LineColorB = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.cmbxRentCarRegNo.LineColorC = System.Drawing.Color.White;
            this.cmbxRentCarRegNo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbxRentCarRegNo.ListBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbxRentCarRegNo.ListDashType = System.Drawing.Drawing2D.DashStyle.Dot;
            this.cmbxRentCarRegNo.ListForeColor = System.Drawing.Color.Black;
            this.cmbxRentCarRegNo.ListSelectedBackColorA = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbxRentCarRegNo.ListSelectedBackColorB = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbxRentCarRegNo.Location = new System.Drawing.Point(192, 87);
            this.cmbxRentCarRegNo.Name = "cmbxRentCarRegNo";
            this.cmbxRentCarRegNo.Size = new System.Drawing.Size(196, 22);
            this.cmbxRentCarRegNo.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.cmbxRentCarRegNo.StartIndex = 0;
            this.cmbxRentCarRegNo.TabIndex = 1;
            this.cmbxRentCarRegNo.TriangleColorA = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(176)))), ((int)(((byte)(214)))));
            this.cmbxRentCarRegNo.TriangleColorB = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            // 
            // txtRentCustomerName
            // 
            this.txtRentCustomerName.BackColor = System.Drawing.Color.Transparent;
            this.txtRentCustomerName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtRentCustomerName.EdgeColor = System.Drawing.Color.White;
            this.txtRentCustomerName.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtRentCustomerName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtRentCustomerName.Location = new System.Drawing.Point(192, 196);
            this.txtRentCustomerName.MaxLength = 32767;
            this.txtRentCustomerName.Multiline = false;
            this.txtRentCustomerName.Name = "txtRentCustomerName";
            this.txtRentCustomerName.ReadOnly = false;
            this.txtRentCustomerName.Size = new System.Drawing.Size(196, 28);
            this.txtRentCustomerName.TabIndex = 27;
            this.txtRentCustomerName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRentCustomerName.UseSystemPasswordChar = false;
            // 
            // txtRentId
            // 
            this.txtRentId.BackColor = System.Drawing.Color.Transparent;
            this.txtRentId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtRentId.EdgeColor = System.Drawing.Color.White;
            this.txtRentId.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtRentId.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtRentId.Location = new System.Drawing.Point(192, 33);
            this.txtRentId.MaxLength = 32767;
            this.txtRentId.Multiline = false;
            this.txtRentId.Name = "txtRentId";
            this.txtRentId.ReadOnly = false;
            this.txtRentId.Size = new System.Drawing.Size(196, 28);
            this.txtRentId.TabIndex = 3;
            this.txtRentId.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRentId.UseSystemPasswordChar = false;
            // 
            // xuiSuperButton2
            // 
            this.xuiSuperButton2.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.xuiSuperButton2.ButtonImage = null;
            this.xuiSuperButton2.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.xuiSuperButton2.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.xuiSuperButton2.ButtonText = "Update";
            this.xuiSuperButton2.CornerRadius = 25;
            this.xuiSuperButton2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiSuperButton2.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiSuperButton2.HoverBackgroundColor = System.Drawing.Color.Gray;
            this.xuiSuperButton2.HoverTextColor = System.Drawing.Color.White;
            this.xuiSuperButton2.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.xuiSuperButton2.Location = new System.Drawing.Point(207, 400);
            this.xuiSuperButton2.Name = "xuiSuperButton2";
            this.xuiSuperButton2.SelectedBackColor = System.Drawing.SystemColors.WindowFrame;
            this.xuiSuperButton2.SelectedTextColor = System.Drawing.Color.Snow;
            this.xuiSuperButton2.Size = new System.Drawing.Size(100, 40);
            this.xuiSuperButton2.SuperSelected = false;
            this.xuiSuperButton2.TabIndex = 23;
            this.xuiSuperButton2.TextColor = System.Drawing.Color.Red;
            this.xuiSuperButton2.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiSuperButton2.Click += new System.EventHandler(this.xuiSuperButton2_Click);
            // 
            // btnRentAdd
            // 
            this.btnRentAdd.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.btnRentAdd.ButtonImage = null;
            this.btnRentAdd.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnRentAdd.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnRentAdd.ButtonText = "Add";
            this.btnRentAdd.CornerRadius = 25;
            this.btnRentAdd.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentAdd.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnRentAdd.HoverBackgroundColor = System.Drawing.Color.Gray;
            this.btnRentAdd.HoverTextColor = System.Drawing.Color.White;
            this.btnRentAdd.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnRentAdd.Location = new System.Drawing.Point(77, 400);
            this.btnRentAdd.Name = "btnRentAdd";
            this.btnRentAdd.SelectedBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnRentAdd.SelectedTextColor = System.Drawing.Color.Snow;
            this.btnRentAdd.Size = new System.Drawing.Size(100, 40);
            this.btnRentAdd.SuperSelected = false;
            this.btnRentAdd.TabIndex = 22;
            this.btnRentAdd.TextColor = System.Drawing.Color.Red;
            this.btnRentAdd.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnRentAdd.Click += new System.EventHandler(this.btnRentAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FloralWhite;
            this.label7.Location = new System.Drawing.Point(25, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "Customer Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FloralWhite;
            this.label6.Location = new System.Drawing.Point(25, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Customer Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FloralWhite;
            this.label4.Location = new System.Drawing.Point(25, 87);
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
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rent Id";
            // 
            // xuiGradientPanel2
            // 
            this.xuiGradientPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xuiGradientPanel2.BottomLeft = System.Drawing.Color.Gray;
            this.xuiGradientPanel2.BottomRight = System.Drawing.Color.Lavender;
            this.xuiGradientPanel2.Controls.Add(this.dgvRentedCars);
            this.xuiGradientPanel2.Location = new System.Drawing.Point(409, 102);
            this.xuiGradientPanel2.Name = "xuiGradientPanel2";
            this.xuiGradientPanel2.PrimerColor = System.Drawing.Color.White;
            this.xuiGradientPanel2.Size = new System.Drawing.Size(480, 484);
            this.xuiGradientPanel2.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiGradientPanel2.TabIndex = 14;
            this.xuiGradientPanel2.TopLeft = System.Drawing.Color.DeepPink;
            this.xuiGradientPanel2.TopRight = System.Drawing.Color.DarkSalmon;
            this.xuiGradientPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.xuiGradientPanel2_Paint);
            // 
            // dgvRentedCars
            // 
            this.dgvRentedCars.AllowUserToAddRows = false;
            this.dgvRentedCars.AllowUserToDeleteRows = false;
            this.dgvRentedCars.AllowUserToResizeColumns = false;
            this.dgvRentedCars.AllowUserToResizeRows = false;
            this.dgvRentedCars.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRentedCars.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvRentedCars.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRentedCars.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvRentedCars.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRentedCars.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRentedCars.ColumnHeadersHeight = 18;
            this.dgvRentedCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRentedCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRentedCars.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRentedCars.EnableHeadersVisualStyles = false;
            this.dgvRentedCars.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvRentedCars.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvRentedCars.Location = new System.Drawing.Point(7, 60);
            this.dgvRentedCars.Name = "dgvRentedCars";
            this.dgvRentedCars.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRentedCars.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRentedCars.RowHeadersWidth = 35;
            this.dgvRentedCars.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvRentedCars.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvRentedCars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRentedCars.Size = new System.Drawing.Size(461, 150);
            this.dgvRentedCars.TabIndex = 0;
            this.dgvRentedCars.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRentedCars_CellContentDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "RentId";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Car Regno";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "CustomerId";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Customer Name";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Rent Date";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Return Date";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Fee";
            this.Column7.Name = "Column7";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Lucida Handwriting", 38F);
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(405, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(327, 66);
            this.label5.TabIndex = 15;
            this.label5.Text = "Rent Form";
            // 
            // RentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 586);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.xuiGradientPanel2);
            this.Controls.Add(this.xuiGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RentForm";
            this.Text = "RentForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RentForm_Load);
            this.xuiGradientPanel1.ResumeLayout(false);
            this.xuiGradientPanel1.PerformLayout();
            this.xuiGradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentedCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.XUIGradientPanel xuiGradientPanel1;
        private ReaLTaiizor.Controls.DungeonTextBox txtRentCustomerName;
        private ReaLTaiizor.Controls.DungeonTextBox txtRentId;
        private XanderUI.XUISuperButton xuiSuperButton2;
        private XanderUI.XUISuperButton btnRentAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private XanderUI.XUIGradientPanel xuiGradientPanel2;
        private ReaLTaiizor.Controls.PoisonDataGridView dgvRentedCars;
        private ReaLTaiizor.Controls.PoisonDateTime dtRenturnDate;
        private ReaLTaiizor.Controls.PoisonDateTime dtRentDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.SkyComboBox cmbxRentCustomerId;
        private ReaLTaiizor.Controls.SkyComboBox cmbxRentCarRegNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label label5;
    }
}