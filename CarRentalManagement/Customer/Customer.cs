using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using CarBusinessLogic.Customer;
namespace CarRentalManagement.Customer
{
    public partial class Customer : Form
    {
        List<String> patternsList;
        String erroree;
        public Customer()
        {
            InitializeComponent();
        }
        #region

        private void patterns()
        {
            patternsList = new List<String>();
            //Id
            patternsList.Add(@"^[a-zA-Z]{2}-\d{4}$");
            //Name
            patternsList.Add(@"^[a-zA-Z\s]+$");
            //Address
            patternsList.Add(@"^[a-zA-Z]+$");
            //Phone
             patternsList.Add(@"^(03)\d{9}$");
            //phone 2
            patternsList.Add(@"^\+923\d{9}$");

            //patternsList.Add(@"^\d+$");
        }
        private bool CheckingTextBoxes(String fName)
        {
            // SettingLabels();
            try
            {
                if (txtCustomerId.Text != String.Empty && txtCustomerName.Text != String.Empty && txtCustomerAddress.Text != String.Empty && txtCustomerPhone.Text != String.Empty)
                {
                    if (!checking())
                    {
                        CustomerBl c = new CustomerBl();
                        c.id = txtCustomerId.Text;
                        c.name = txtCustomerName.Text;
                        c.address = txtCustomerAddress.Text;
                        c.phone = txtCustomerPhone.Text;
                        if (fName == "Add")
                            c.addCustomerLogic();
                        else
                            c.customerLogicUpdate();
                    }
                    else
                    {
                       MessageBox.Show("please folow format\n"+erroree);
                    }
                }
                else
                {
                    String Error = "";

                    if (txtCustomerId.Text == String.Empty)
                        Error += "Please enter Id of Customer\n";
                    if (txtCustomerName.Text == String.Empty)
                        Error += "Please enter Name of Customer\n";
                    if (txtCustomerAddress.Text == String.Empty)
                        Error += "Please Address of customer\n";
                    if (txtCustomerPhone.Text == String.Empty)
                        Error += "Please enter phone of customer\n";
                   
                    MessageBox.Show(Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message+"hello");
            }
            return false;
        }
        private bool checking()
        {
            String id = "", Name = "", address = "", phone = "";
           
            bool check = false;
          


            if (Regex.IsMatch(txtCustomerId.Text, patternsList[0]))
                id = txtCustomerId.Text;
            else
            {
                // lblPlateNoError.Text = "Please enter correct plate no";
                erroree+="in Id\n "+"'"+txtCustomerId.Text+"'"+"'"+patternsList[0]+"'";
                check = true;
            }
            if (Regex.IsMatch(txtCustomerName.Text, patternsList[1]))
                Name = txtCustomerName.Text;
            else
            {
                // lblCompanyError.Text = "Please enter correct company name";
                erroree += "in NAme\n";
                check = true;
            }
            if (Regex.IsMatch(txtCustomerAddress.Text, patternsList[2]))
                address = txtCustomerAddress.Text;
            else
            {
                //lblNameError.Text = "Please enter correct car name";
                check = true;
                erroree += "in Address\n";
            }

            if (Regex.IsMatch(txtCustomerPhone.Text, patternsList[3]) || Regex.IsMatch(txtCustomerPhone.Text, patternsList[4]))
                phone = (txtCustomerPhone.Text);
            else
            {
                // lblColorError.Text = "Please select correct color of car";
                check = true;
                erroree += "in Phone\n";
            }
            return check;

        }
        private void readingCustomers()
        {
            CustomerBl cust = new CustomerBl();
            var carList = cust.readCustomer();
            String tran = "";
            dgvCustomer.Rows.Clear();
            foreach (var c in carList)
            {
                dgvCustomer.Rows.Add(c.id, c.name, c.address, c.phone);
            }
        }

        #endregion


        private void Customer_Load(object sender, EventArgs e)
        {
            patterns();
            readingCustomers();

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            CheckingTextBoxes("Add");
            readingCustomers();
        }

        private void dgvCustomer_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvCustomer.SelectedRows)
            {
                txtCustomerId.Text = row.Cells[0].Value.ToString();
                txtCustomerName.Text = row.Cells[1].Value.ToString();
                txtCustomerAddress.Text = row.Cells[2].Value.ToString();
                txtCustomerPhone.Text = row.Cells[3].Value.ToString();
            }
            }

        private void BtnUpdateCustomer_Click(object sender, EventArgs e)
        {
            CheckingTextBoxes("Update");
            readingCustomers();
        }
    }
}
