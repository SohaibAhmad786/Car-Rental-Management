using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarBusinessLogic.CarLogic;
using CarBusinessLogic.Customer;


namespace CarRentalManagement.Functionality
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }
        #region private functions
        private void readingCarCount()
        {
            AddCarLogic adc = new AddCarLogic();
            var readData = adc.carLogicRead();
            int tCar = readData.Count;
            lblCarsTotal.Text = tCar.ToString();
        }
        private void readingCustomerCount()
        {
            CustomerBl cust = new CustomerBl();
            var customerList = cust.readCustomer();
            int tCust= customerList.Count;
            lblCustomerCount.Text = tCust.ToString();
        }

        #endregion


        private void DashBoard_Load(object sender, EventArgs e)
        {
            readingCarCount();
            readingCustomerCount();
        }
    }
}
