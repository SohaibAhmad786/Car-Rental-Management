
namespace CarRentalManagement
{
    partial class Login
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogin = new XanderUI.XUIButton();
            this.lblCredentialError = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtsAdminLogin = new ReaLTaiizor.Controls.DungeonTextBox();
            this.txtPasswordLogin = new ReaLTaiizor.Controls.DungeonTextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumBlue;
            this.panel2.Controls.Add(this.txtPasswordLogin);
            this.panel2.Controls.Add(this.txtsAdminLogin);
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.lblCredentialError);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(404, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(398, 466);
            this.panel2.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.BackgroundColor = System.Drawing.Color.Honeydew;
            this.btnLogin.ButtonImage = global::CarRentalManagement.Properties.Resources.icon_removebg_preview;
            this.btnLogin.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnLogin.ButtonText = "Login";
            this.btnLogin.ClickBackColor = System.Drawing.Color.Navy;
            this.btnLogin.ClickTextColor = System.Drawing.Color.White;
            this.btnLogin.CornerRadius = 25;
            this.btnLogin.Font = new System.Drawing.Font("Lucida Handwriting", 18F);
            this.btnLogin.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLogin.HoverBackgroundColor = System.Drawing.Color.Honeydew;
            this.btnLogin.HoverTextColor = System.Drawing.Color.Navy;
            this.btnLogin.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnLogin.Location = new System.Drawing.Point(136, 307);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(184, 50);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.TextColor = System.Drawing.Color.MediumBlue;
            this.btnLogin.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblCredentialError
            // 
            this.lblCredentialError.AutoSize = true;
            this.lblCredentialError.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredentialError.ForeColor = System.Drawing.Color.Orange;
            this.lblCredentialError.Location = new System.Drawing.Point(47, 279);
            this.lblCredentialError.Name = "lblCredentialError";
            this.lblCredentialError.Size = new System.Drawing.Size(0, 18);
            this.lblCredentialError.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.MediumBlue;
            this.label13.Font = new System.Drawing.Font("Lucida Handwriting", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Honeydew;
            this.label13.Location = new System.Drawing.Point(183, 370);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 28);
            this.label13.TabIndex = 8;
            this.label13.Text = "clear";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Honeydew;
            this.label12.Location = new System.Drawing.Point(27, 214);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 29);
            this.label12.TabIndex = 6;
            this.label12.Text = "Password";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Honeydew;
            this.label11.Location = new System.Drawing.Point(18, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 29);
            this.label11.TabIndex = 5;
            this.label11.Text = "UserName";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Lucida Handwriting", 35F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Honeydew;
            this.label10.Location = new System.Drawing.Point(125, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 61);
            this.label10.TabIndex = 4;
            this.label10.Text = "Login";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Honeydew;
            this.label8.Font = new System.Drawing.Font("Lucida Handwriting", 19F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(-3, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(403, 34);
            this.label8.TabIndex = 2;
            this.label8.Text = "Car Rental Management";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Honeydew;
            this.label9.Font = new System.Drawing.Font("Lucida Handwriting", 25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkBlue;
            this.label9.Location = new System.Drawing.Point(60, 395);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(321, 44);
            this.label9.TabIndex = 3;
            this.label9.Text = "Choose the Best!";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Honeydew;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::CarRentalManagement.Properties.Resources.charger_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(404, 466);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // txtsAdminLogin
            // 
            this.txtsAdminLogin.BackColor = System.Drawing.Color.Transparent;
            this.txtsAdminLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtsAdminLogin.EdgeColor = System.Drawing.Color.White;
            this.txtsAdminLogin.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtsAdminLogin.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtsAdminLogin.Location = new System.Drawing.Point(159, 131);
            this.txtsAdminLogin.MaxLength = 32767;
            this.txtsAdminLogin.Multiline = false;
            this.txtsAdminLogin.Name = "txtsAdminLogin";
            this.txtsAdminLogin.ReadOnly = false;
            this.txtsAdminLogin.Size = new System.Drawing.Size(196, 28);
            this.txtsAdminLogin.TabIndex = 29;
            this.txtsAdminLogin.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtsAdminLogin.UseSystemPasswordChar = false;
            // 
            // txtPasswordLogin
            // 
            this.txtPasswordLogin.BackColor = System.Drawing.Color.Transparent;
            this.txtPasswordLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtPasswordLogin.EdgeColor = System.Drawing.Color.White;
            this.txtPasswordLogin.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtPasswordLogin.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtPasswordLogin.Location = new System.Drawing.Point(159, 215);
            this.txtPasswordLogin.MaxLength = 32767;
            this.txtPasswordLogin.Multiline = false;
            this.txtPasswordLogin.Name = "txtPasswordLogin";
            this.txtPasswordLogin.ReadOnly = false;
            this.txtPasswordLogin.Size = new System.Drawing.Size(196, 28);
            this.txtPasswordLogin.TabIndex = 30;
            this.txtPasswordLogin.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPasswordLogin.UseSystemPasswordChar = false;
            // 
            // Login
            // 
            this.ClientSize = new System.Drawing.Size(802, 466);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCredentialsError;
       
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblCredentialError;
        private XanderUI.XUIButton btnLogin;
        private ReaLTaiizor.Controls.DungeonTextBox txtPasswordLogin;
        private ReaLTaiizor.Controls.DungeonTextBox txtsAdminLogin;
    }
}