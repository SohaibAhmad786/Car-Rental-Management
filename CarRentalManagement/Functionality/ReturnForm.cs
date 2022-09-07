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
using System.Text.RegularExpressions;
using CarBusinessLogic.Return;

namespace CarRentalManagement.Functionality
{
    public partial class ReturnForm : Form
    {
        private List<String> patternsList;
        private Dictionary<String, String> delay=new Dictionary<String, String>();
        #region private functions
        private float calculatingFine()
        {
            float dly = 0;
            foreach (KeyValuePair<String,String> item in delay)
            {
                int days = dtReturnedData.Value.ToShortDateString().CompareTo(item.Value);
                 if (days<=0)
                {
                    dly = 0;
                }
                else
                {
                    days = dtReturnedData.Value.ToShortDateString().CompareTo(item.Value);
                    dly = 200 * days;
                }
            }
            return dly;
        }
        private bool CheckingTextBoxes()
        {
            // SettingLabels();
            try
            {
                if (txtReturnId.Text != String.Empty && txtCustomerName.Text != String.Empty)
                {
                    if (!checking())
                    {
                        ReturnBlLogic rbl = new ReturnBlLogic();
                        rbl.returnId = txtReturnId.Text;
                        rbl.regNo = txtCarRegNo.Text;
                        rbl.custId = txtCustomerId.Text;
                        rbl.returnedDate = dtReturnedData.Value.ToShortDateString();
                        rbl.fine=calculatingFine();
                        rbl.returnCar();
                        
                       
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
                    if (txtReturnId.Text == String.Empty)
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
            if (Regex.IsMatch(txtReturnId.Text, patternsList[0]))
                rentId = txtReturnId.Text;
            else
            {
                // lblPlateNoError.Text = "Please enter correct plate no";
                check = true;
            }
            return check;
        }
    
        private void patterns()
        {
            patternsList = new List<String>();
            //Id
            patternsList.Add(@"^[a-zA-Z]{2}-\d{4}$");
        }
        private void readingReturnedCarsFromDb()
        {
            try
            {
                ReturnBlLogic rbl = new ReturnBlLogic();
                var returnedList = rbl.readingReturnedCars();
                dgvReturnedCars.Rows.Clear();
                foreach (var item in returnedList)
                {
                   if(item.returned==1)
                        dgvReturnedCars.Rows.Add(item.rentId, item.regNo, item.custId, item.custName, item.returnId, item.fine);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void readingRentedCarsFromDb()
        {
            try
            {
                RentClass rlc = new RentClass();
                var rentedCarsList = rlc.readingRentedCar();
                dgvRentedCars.Rows.Clear();
                foreach (var item in rentedCarsList)
                {
                    if(item.returned==0)
                    {
                        dgvRentedCars.Rows.Add(item.rentId, item.regNo, item.custId, item.custName, DateTime.Parse(item.rentDate).ToShortDateString(), DateTime.Parse(item.returnDate).ToShortDateString(), item.rentFee);
                        delay.Add(item.rentId, item.returnDate);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        public ReturnForm()
        {
            InitializeComponent();
        }

        private void ReturnForm_Load(object sender, EventArgs e)
        {
            patterns();
            readingRentedCarsFromDb();
            readingReturnedCarsFromDb();   
        }

        private void dgvRentedCars_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvRentedCars.SelectedRows)
            {
               txtCarRegNo.Text = row.Cells[1].Value.ToString();
                txtCustomerId.Text = row.Cells[2].Value.ToString();
                txtCustomerName.Text= row.Cells[3].Value.ToString();
            }
        }

        private void btnReturnCar_Click(object sender, EventArgs e)
        {
            if(CheckingTextBoxes())
            {
                MessageBox.Show("Succesfully added");
                readingReturnedCarsFromDb();
                readingRentedCarsFromDb();
            }
        }
    }
}
