
namespace CarRentalManagement.CarsForm
{
    partial class Car
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.xuiGradientPanel1 = new XanderUI.XUIGradientPanel();
            this.txtAddCarPrice = new ReaLTaiizor.Controls.DungeonTextBox();
            this.txtAddCarName = new ReaLTaiizor.Controls.DungeonTextBox();
            this.txtAddCarColor = new ReaLTaiizor.Controls.DungeonTextBox();
            this.txtAddCarCompany = new ReaLTaiizor.Controls.DungeonTextBox();
            this.txtAddCarRegNo = new ReaLTaiizor.Controls.DungeonTextBox();
            this.btnAddCarDelete = new XanderUI.XUISuperButton();
            this.btnAddCarUpdate = new XanderUI.XUISuperButton();
            this.btnAddCar = new XanderUI.XUISuperButton();
            this.cmbxAddCarAvailable = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cmbxAddCarTransmission = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.xuiGradientPanel2 = new XanderUI.XUIGradientPanel();
            this.dgvAddCar = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddCarRefresh = new XanderUI.XUISuperButton();
            this.cmbxAddCarRefresh = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.xuiGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbxAddCarAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbxAddCarTransmission)).BeginInit();
            this.xuiGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbxAddCarRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 38F);
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(479, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(67, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Car Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FloralWhite;
            this.label3.Location = new System.Drawing.Point(25, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Registration No";
            // 
            // xuiGradientPanel1
            // 
            this.xuiGradientPanel1.BottomLeft = System.Drawing.Color.SlateGray;
            this.xuiGradientPanel1.BottomRight = System.Drawing.Color.SlateGray;
            this.xuiGradientPanel1.Controls.Add(this.txtAddCarPrice);
            this.xuiGradientPanel1.Controls.Add(this.txtAddCarName);
            this.xuiGradientPanel1.Controls.Add(this.txtAddCarColor);
            this.xuiGradientPanel1.Controls.Add(this.txtAddCarCompany);
            this.xuiGradientPanel1.Controls.Add(this.txtAddCarRegNo);
            this.xuiGradientPanel1.Controls.Add(this.btnAddCarDelete);
            this.xuiGradientPanel1.Controls.Add(this.btnAddCarUpdate);
            this.xuiGradientPanel1.Controls.Add(this.btnAddCar);
            this.xuiGradientPanel1.Controls.Add(this.cmbxAddCarAvailable);
            this.xuiGradientPanel1.Controls.Add(this.cmbxAddCarTransmission);
            this.xuiGradientPanel1.Controls.Add(this.label9);
            this.xuiGradientPanel1.Controls.Add(this.label8);
            this.xuiGradientPanel1.Controls.Add(this.label7);
            this.xuiGradientPanel1.Controls.Add(this.label5);
            this.xuiGradientPanel1.Controls.Add(this.label6);
            this.xuiGradientPanel1.Controls.Add(this.label4);
            this.xuiGradientPanel1.Controls.Add(this.label2);
            this.xuiGradientPanel1.Controls.Add(this.label3);
            this.xuiGradientPanel1.Location = new System.Drawing.Point(0, 93);
            this.xuiGradientPanel1.Name = "xuiGradientPanel1";
            this.xuiGradientPanel1.PrimerColor = System.Drawing.Color.White;
            this.xuiGradientPanel1.Size = new System.Drawing.Size(389, 484);
            this.xuiGradientPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiGradientPanel1.TabIndex = 11;
            this.xuiGradientPanel1.TopLeft = System.Drawing.Color.DarkTurquoise;
            this.xuiGradientPanel1.TopRight = System.Drawing.Color.DarkTurquoise;
            // 
            // txtAddCarPrice
            // 
            this.txtAddCarPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtAddCarPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtAddCarPrice.EdgeColor = System.Drawing.Color.White;
            this.txtAddCarPrice.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtAddCarPrice.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtAddCarPrice.Location = new System.Drawing.Point(175, 229);
            this.txtAddCarPrice.MaxLength = 32767;
            this.txtAddCarPrice.Multiline = false;
            this.txtAddCarPrice.Name = "txtAddCarPrice";
            this.txtAddCarPrice.ReadOnly = false;
            this.txtAddCarPrice.Size = new System.Drawing.Size(196, 28);
            this.txtAddCarPrice.TabIndex = 32;
            this.txtAddCarPrice.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAddCarPrice.UseSystemPasswordChar = false;
            // 
            // txtAddCarName
            // 
            this.txtAddCarName.BackColor = System.Drawing.Color.Transparent;
            this.txtAddCarName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtAddCarName.EdgeColor = System.Drawing.Color.White;
            this.txtAddCarName.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtAddCarName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtAddCarName.Location = new System.Drawing.Point(175, 179);
            this.txtAddCarName.MaxLength = 32767;
            this.txtAddCarName.Multiline = false;
            this.txtAddCarName.Name = "txtAddCarName";
            this.txtAddCarName.ReadOnly = false;
            this.txtAddCarName.Size = new System.Drawing.Size(196, 28);
            this.txtAddCarName.TabIndex = 31;
            this.txtAddCarName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAddCarName.UseSystemPasswordChar = false;
            // 
            // txtAddCarColor
            // 
            this.txtAddCarColor.BackColor = System.Drawing.Color.Transparent;
            this.txtAddCarColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtAddCarColor.EdgeColor = System.Drawing.Color.White;
            this.txtAddCarColor.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtAddCarColor.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtAddCarColor.Location = new System.Drawing.Point(175, 278);
            this.txtAddCarColor.MaxLength = 32767;
            this.txtAddCarColor.Multiline = false;
            this.txtAddCarColor.Name = "txtAddCarColor";
            this.txtAddCarColor.ReadOnly = false;
            this.txtAddCarColor.Size = new System.Drawing.Size(196, 28);
            this.txtAddCarColor.TabIndex = 30;
            this.txtAddCarColor.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAddCarColor.UseSystemPasswordChar = false;
            // 
            // txtAddCarCompany
            // 
            this.txtAddCarCompany.BackColor = System.Drawing.Color.Transparent;
            this.txtAddCarCompany.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtAddCarCompany.EdgeColor = System.Drawing.Color.White;
            this.txtAddCarCompany.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtAddCarCompany.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtAddCarCompany.Location = new System.Drawing.Point(176, 124);
            this.txtAddCarCompany.MaxLength = 32767;
            this.txtAddCarCompany.Multiline = false;
            this.txtAddCarCompany.Name = "txtAddCarCompany";
            this.txtAddCarCompany.ReadOnly = false;
            this.txtAddCarCompany.Size = new System.Drawing.Size(196, 28);
            this.txtAddCarCompany.TabIndex = 29;
            this.txtAddCarCompany.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAddCarCompany.UseSystemPasswordChar = false;
            // 
            // txtAddCarRegNo
            // 
            this.txtAddCarRegNo.BackColor = System.Drawing.Color.Transparent;
            this.txtAddCarRegNo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtAddCarRegNo.EdgeColor = System.Drawing.Color.White;
            this.txtAddCarRegNo.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtAddCarRegNo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtAddCarRegNo.Location = new System.Drawing.Point(176, 70);
            this.txtAddCarRegNo.MaxLength = 32767;
            this.txtAddCarRegNo.Multiline = false;
            this.txtAddCarRegNo.Name = "txtAddCarRegNo";
            this.txtAddCarRegNo.ReadOnly = false;
            this.txtAddCarRegNo.Size = new System.Drawing.Size(196, 28);
            this.txtAddCarRegNo.TabIndex = 28;
            this.txtAddCarRegNo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAddCarRegNo.UseSystemPasswordChar = false;
            // 
            // btnAddCarDelete
            // 
            this.btnAddCarDelete.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAddCarDelete.ButtonImage = null;
            this.btnAddCarDelete.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnAddCarDelete.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnAddCarDelete.ButtonText = "Delete";
            this.btnAddCarDelete.CornerRadius = 25;
            this.btnAddCarDelete.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCarDelete.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddCarDelete.HoverBackgroundColor = System.Drawing.Color.Gray;
            this.btnAddCarDelete.HoverTextColor = System.Drawing.Color.White;
            this.btnAddCarDelete.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnAddCarDelete.Location = new System.Drawing.Point(275, 421);
            this.btnAddCarDelete.Name = "btnAddCarDelete";
            this.btnAddCarDelete.SelectedBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAddCarDelete.SelectedTextColor = System.Drawing.Color.Snow;
            this.btnAddCarDelete.Size = new System.Drawing.Size(100, 40);
            this.btnAddCarDelete.SuperSelected = false;
            this.btnAddCarDelete.TabIndex = 24;
            this.btnAddCarDelete.TextColor = System.Drawing.Color.Red;
            this.btnAddCarDelete.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddCarDelete.Click += new System.EventHandler(this.btnAddCarDelete_Click);
            // 
            // btnAddCarUpdate
            // 
            this.btnAddCarUpdate.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAddCarUpdate.ButtonImage = null;
            this.btnAddCarUpdate.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnAddCarUpdate.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnAddCarUpdate.ButtonText = "Update";
            this.btnAddCarUpdate.CornerRadius = 25;
            this.btnAddCarUpdate.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCarUpdate.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddCarUpdate.HoverBackgroundColor = System.Drawing.Color.Gray;
            this.btnAddCarUpdate.HoverTextColor = System.Drawing.Color.White;
            this.btnAddCarUpdate.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnAddCarUpdate.Location = new System.Drawing.Point(151, 421);
            this.btnAddCarUpdate.Name = "btnAddCarUpdate";
            this.btnAddCarUpdate.SelectedBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAddCarUpdate.SelectedTextColor = System.Drawing.Color.Snow;
            this.btnAddCarUpdate.Size = new System.Drawing.Size(100, 40);
            this.btnAddCarUpdate.SuperSelected = false;
            this.btnAddCarUpdate.TabIndex = 23;
            this.btnAddCarUpdate.TextColor = System.Drawing.Color.Red;
            this.btnAddCarUpdate.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddCarUpdate.Click += new System.EventHandler(this.btnAddCarUpdate_Click);
            // 
            // btnAddCar
            // 
            this.btnAddCar.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAddCar.ButtonImage = null;
            this.btnAddCar.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnAddCar.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnAddCar.ButtonText = "Add";
            this.btnAddCar.CornerRadius = 25;
            this.btnAddCar.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCar.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddCar.HoverBackgroundColor = System.Drawing.Color.Gray;
            this.btnAddCar.HoverTextColor = System.Drawing.Color.White;
            this.btnAddCar.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnAddCar.Location = new System.Drawing.Point(26, 421);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.SelectedBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAddCar.SelectedTextColor = System.Drawing.Color.Snow;
            this.btnAddCar.Size = new System.Drawing.Size(100, 40);
            this.btnAddCar.SuperSelected = false;
            this.btnAddCar.TabIndex = 22;
            this.btnAddCar.TextColor = System.Drawing.Color.Red;
            this.btnAddCar.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // cmbxAddCarAvailable
            // 
            this.cmbxAddCarAvailable.DropDownWidth = 186;
            this.cmbxAddCarAvailable.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
            this.cmbxAddCarAvailable.Location = new System.Drawing.Point(177, 334);
            this.cmbxAddCarAvailable.Name = "cmbxAddCarAvailable";
            this.cmbxAddCarAvailable.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.cmbxAddCarAvailable.Size = new System.Drawing.Size(186, 21);
            this.cmbxAddCarAvailable.TabIndex = 21;
            this.cmbxAddCarAvailable.Text = "Please select Availability";
            // 
            // cmbxAddCarTransmission
            // 
            this.cmbxAddCarTransmission.DropDownWidth = 186;
            this.cmbxAddCarTransmission.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
            this.cmbxAddCarTransmission.Location = new System.Drawing.Point(176, 378);
            this.cmbxAddCarTransmission.Name = "cmbxAddCarTransmission";
            this.cmbxAddCarTransmission.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.cmbxAddCarTransmission.Size = new System.Drawing.Size(186, 21);
            this.cmbxAddCarTransmission.TabIndex = 13;
            this.cmbxAddCarTransmission.Text = "Please select transmission";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FloralWhite;
            this.label9.Location = new System.Drawing.Point(25, 376);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 23);
            this.label9.TabIndex = 20;
            this.label9.Text = "Transmission";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FloralWhite;
            this.label8.Location = new System.Drawing.Point(25, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 23);
            this.label8.TabIndex = 19;
            this.label8.Text = "Available";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FloralWhite;
            this.label7.Location = new System.Drawing.Point(25, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FloralWhite;
            this.label5.Location = new System.Drawing.Point(25, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Color";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FloralWhite;
            this.label6.Location = new System.Drawing.Point(25, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FloralWhite;
            this.label4.Location = new System.Drawing.Point(25, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Company";
            // 
            // xuiGradientPanel2
            // 
            this.xuiGradientPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xuiGradientPanel2.BottomLeft = System.Drawing.Color.Gray;
            this.xuiGradientPanel2.BottomRight = System.Drawing.Color.Lavender;
            this.xuiGradientPanel2.Controls.Add(this.dgvAddCar);
            this.xuiGradientPanel2.Controls.Add(this.btnAddCarRefresh);
            this.xuiGradientPanel2.Controls.Add(this.cmbxAddCarRefresh);
            this.xuiGradientPanel2.Location = new System.Drawing.Point(381, 93);
            this.xuiGradientPanel2.Name = "xuiGradientPanel2";
            this.xuiGradientPanel2.PrimerColor = System.Drawing.Color.White;
            this.xuiGradientPanel2.Size = new System.Drawing.Size(506, 484);
            this.xuiGradientPanel2.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiGradientPanel2.TabIndex = 12;
            this.xuiGradientPanel2.TopLeft = System.Drawing.Color.DeepPink;
            this.xuiGradientPanel2.TopRight = System.Drawing.Color.DarkSalmon;
            this.xuiGradientPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.xuiGradientPanel2_Paint);
            // 
            // dgvAddCar
            // 
            this.dgvAddCar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvAddCar.AllowUserToAddRows = false;
            this.dgvAddCar.AllowUserToDeleteRows = false;
            this.dgvAddCar.AllowUserToResizeColumns = false;
            this.dgvAddCar.AllowUserToResizeRows = false;
            this.dgvAddCar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAddCar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAddCar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAddCar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAddCar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAddCar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAddCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddCar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvAddCar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAddCar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAddCar.EnableHeadersVisualStyles = false;
            this.dgvAddCar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvAddCar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAddCar.Location = new System.Drawing.Point(14, 106);
            this.dgvAddCar.MultiSelect = false;
            this.dgvAddCar.Name = "dgvAddCar";
            this.dgvAddCar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAddCar.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAddCar.RowHeadersWidth = 20;
            this.dgvAddCar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAddCar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAddCar.Size = new System.Drawing.Size(482, 249);
            this.dgvAddCar.TabIndex = 26;
            this.dgvAddCar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAddCar_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Reg No";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Company";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Name";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Color";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Available";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Transmission";
            this.Column7.Name = "Column7";
            // 
            // btnAddCarRefresh
            // 
            this.btnAddCarRefresh.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAddCarRefresh.ButtonImage = null;
            this.btnAddCarRefresh.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnAddCarRefresh.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnAddCarRefresh.ButtonText = "Refresh";
            this.btnAddCarRefresh.CornerRadius = 25;
            this.btnAddCarRefresh.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCarRefresh.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddCarRefresh.HoverBackgroundColor = System.Drawing.Color.Gray;
            this.btnAddCarRefresh.HoverTextColor = System.Drawing.Color.White;
            this.btnAddCarRefresh.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnAddCarRefresh.Location = new System.Drawing.Point(426, 36);
            this.btnAddCarRefresh.Name = "btnAddCarRefresh";
            this.btnAddCarRefresh.SelectedBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAddCarRefresh.SelectedTextColor = System.Drawing.Color.Snow;
            this.btnAddCarRefresh.Size = new System.Drawing.Size(121, 40);
            this.btnAddCarRefresh.SuperSelected = false;
            this.btnAddCarRefresh.TabIndex = 25;
            this.btnAddCarRefresh.TextColor = System.Drawing.Color.Red;
            this.btnAddCarRefresh.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddCarRefresh.Click += new System.EventHandler(this.btnAddCarRefresh_Click);
            // 
            // cmbxAddCarRefresh
            // 
            this.cmbxAddCarRefresh.DropDownWidth = 186;
            this.cmbxAddCarRefresh.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
            this.cmbxAddCarRefresh.Location = new System.Drawing.Point(183, 45);
            this.cmbxAddCarRefresh.Name = "cmbxAddCarRefresh";
            this.cmbxAddCarRefresh.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.cmbxAddCarRefresh.Size = new System.Drawing.Size(235, 21);
            this.cmbxAddCarRefresh.TabIndex = 25;
            this.cmbxAddCarRefresh.Text = "Available or not";
            this.cmbxAddCarRefresh.SelectedValueChanged += new System.EventHandler(this.cmbxAddCarRefresh_SelectedValueChanged);
            // 
            // Car
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(889, 586);
            this.ControlBox = false;
            this.Controls.Add(this.xuiGradientPanel2);
            this.Controls.Add(this.xuiGradientPanel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Car";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddCar_Load);
            this.xuiGradientPanel1.ResumeLayout(false);
            this.xuiGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbxAddCarAvailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbxAddCarTransmission)).EndInit();
            this.xuiGradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbxAddCarRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private XanderUI.XUIGradientPanel xuiGradientPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbxAddCarAvailable;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbxAddCarTransmission;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private XanderUI.XUISuperButton btnAddCar;
        private XanderUI.XUISuperButton btnAddCarDelete;
        private XanderUI.XUISuperButton btnAddCarUpdate;
        private XanderUI.XUIGradientPanel xuiGradientPanel2;
        private XanderUI.XUISuperButton btnAddCarRefresh;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbxAddCarRefresh;
        private ReaLTaiizor.Controls.DungeonTextBox txtAddCarPrice;
        private ReaLTaiizor.Controls.DungeonTextBox txtAddCarName;
        private ReaLTaiizor.Controls.DungeonTextBox txtAddCarColor;
        private ReaLTaiizor.Controls.DungeonTextBox txtAddCarCompany;
        private ReaLTaiizor.Controls.DungeonTextBox txtAddCarRegNo;
        private ReaLTaiizor.Controls.PoisonDataGridView dgvAddCar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}