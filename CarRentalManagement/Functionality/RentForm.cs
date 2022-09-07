using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarBusinessLogic.Rent;
using CarBusinessLogic.CarLogic;
using CarBusinessLogic.Customer;
using System.Text.RegularExpressions;


namespace CarRentalManagement.Functionality
{
    public partial class RentForm : Form
    {
        private List<String> patternsList;
        private Dictionary<String, float> fee=new Dictionary<string, float>();

        public RentForm()
        {
            InitializeComponent();
        }
        #region private function
        private void patterns()
        {
            patternsList = new List<String>();
            //Id
            patternsList.Add(@"^[a-zA-Z]{2}-\d{4}$");
        }
        private float calculatingFee()
        {
            int days = int.Parse((dtRenturnDate.Value- dtRentDate.Value ).TotalDays.ToString());
            String sItem = cmbxRentCarRegNo.SelectedItem.ToString();
            float price = 0;
            foreach (KeyValuePair<String,float> item in fee)
            {
                if (item.Key == sItem)
                {
                    price = item.Value;
                }
            }
            return (days * price);

        }
        private bool CheckingTextBoxes(String text)
        {
            // SettingLabels();
            try
            {
                if (txtRentId.Text != String.Empty && txtRentCustomerName.Text != String.Empty)
                {
                    if (!checking())
                    {
                        RentClass rt = new RentClass();
                        rt.rentId = txtRentId.Text;
                        rt.regNo = cmbxRentCarRegNo.SelectedItem.ToString();
                        rt.custId = cmbxRentCustomerId.SelectedItem.ToString();
                        rt.rentDate = dtRentDate.Value.ToShortDateString();
                        rt.returnDate = dtRenturnDate.Value.ToShortDateString();
                        rt.rentFee = calculatingFee();
                        if (text == "Add")
                        {
                            rt.RentCarLogicAdd();
                        }
                        else if(text== "Update")
                        {
                            rt.RentCarLogicupdate();
                        }
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("please folow format");
                    }
                }
                else
                {
                    String Error = "";
                    if (txtRentId.Text == String.Empty)
                        Error += "Please enter rent ID\n";
                    MessageBox.Show(Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
        private bool checking()
        {
            String rentId = "";
            bool check = false;
            if (Regex.IsMatch(txtRentId.Text, patternsList[0]))
                rentId = txtRentId.Text;
            else
            {
                // lblPlateNoError.Text = "Please enter correct plate no";
                check = true;
            } 
            return check;
        }
        #endregion

        private void xuiGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        #region calling cars and customers

        private void readingCars()
        {
            AddCarLogic car = new AddCarLogic();
            var carList = car.carLogicRead();
            foreach (var c in carList)
            {
                if (c.availability != "No")
                {
                    cmbxRentCarRegNo.Items.Add(c.regNo);
                    fee.Add(c.regNo, c.price);
                }
            }
        }
        private void readingCustomers()
        {
            CustomerBl cust = new CustomerBl();
            var carList = cust.readCustomer();
            foreach (var c in carList)
            {
                cmbxRentCustomerId.Items.Add(c.id);
            }
        }
        private void readingRentedCars()
        {
            try
            {
                RentClass rlc = new RentClass();
                var rentedCarsList = rlc.readingRentedCar();
                dgvRentedCars.Rows.Clear();
                foreach (var item in rentedCarsList)
                {
                    if (item.returned == 0) {
                        dgvRentedCars.Rows.Add(item.rentId, item.regNo, item.custId, item.custName, DateTime.Parse(item.rentDate).ToShortDateString(), DateTime.Parse(item.returnDate).ToShortDateString(), item.rentFee);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"hello");
            }
        }


        #endregion

        private void RentForm_Load(object sender, EventArgs e)
        {
            readingCars();
            readingCustomers();
            patterns();
            readingRentedCars();
        }

        private void cmbxRentCustomerId_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerBl cust = new CustomerBl();
            MessageBox.Show(cmbxRentCustomerId.SelectedItem.ToString());
            var carList = cust.readCustomer(cmbxRentCustomerId.SelectedItem.ToString());
            MessageBox.Show("index changed"+carList.id);
            txtRentCustomerName.Text =carList.name;
        }

        private void btnRentAdd_Click(object sender, EventArgs e)
        {
            if (CheckingTextBoxes("Add"))
            {
                MessageBox.Show("added successfully");
            }
        }

        private void dgvRentedCars_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvRentedCars.SelectedRows)
            {
                txtRentId.Text= row.Cells[0].Value.ToString();
                txtRentId.Enabled = false;
                cmbxRentCarRegNo.SelectedItem= row.Cells[1].Value.ToString();
                cmbxRentCustomerId.SelectedItem= row.Cells[2].Value.ToString();
                cmbxRentCustomerId.Enabled = false;
                txtRentCustomerName.Text= row.Cells[3].Value.ToString();
                txtRentCustomerName.Enabled = false;
                dtRentDate.Value= DateTime.Parse(row.Cells[4].Value.ToString());
                dtRentDate.Enabled = false;
                dtRenturnDate.Value= DateTime.Parse(row.Cells[5].Value.ToString());


            }
        }

        private void xuiSuperButton2_Click(object sender, EventArgs e)
        {
            if (CheckingTextBoxes("Update"))
            {
                MessageBox.Show("Update successfully");
            }
        }
    }
}
