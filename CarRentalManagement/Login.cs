using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarBusinessLogic.Admin;
using System.Text.RegularExpressions;


namespace CarRentalManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
           
        }
        private void ErrorShow(String errors)
        {
            lblCredentialError.Text = errors.ToString();
        }

        private void label13_Click(object sender, EventArgs e)
        {

            txtsAdminLogin.Text = "";
            txtPasswordLogin.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                LoginLogic a = new LoginLogic();
                a.name = txtsAdminLogin.Text;
                a.password = txtPasswordLogin.Text;
                String patternName = @"^[a-zA-Z]+$";
                String patternPass = @"^\d+$";
                if (a.name != String.Empty && a.password != String.Empty)
                {
                    if (Regex.IsMatch(a.name, patternName))
                    {
                        if (Regex.IsMatch(a.password, patternPass))
                        {
                            if (a.CarDataCheck())
                            {
                                MainForm msf = new MainForm();
                                msf.Show();
                                this.Hide();
                            }
                            else
                            {
                                txtPasswordLogin.Text = "";
                                txtsAdminLogin.Text = "";
                                ErrorShow("Please Provide Correct Credentials");
                            }
                        }
                        else
                            ErrorShow("Please follow the format of password");
                    }
                    else
                    {
                        ErrorShow("Name can only have alphabets.");
                    }
                }
                else
                    ErrorShow("Please Fill the Fields");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
