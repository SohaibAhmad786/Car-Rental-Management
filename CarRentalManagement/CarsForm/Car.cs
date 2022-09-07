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
using CarBusinessLogic;
using System.Text.RegularExpressions;

namespace CarRentalManagement.CarsForm
{
    public partial class Car : Form
    {
      
        private List<String> patternsList;
      
        public Car()
        {
            InitializeComponent();
        }
        private void patterns()
        {
            patternsList = new List<String>();
            //Reg No
            patternsList.Add(@"^[a-zA-Z]{3}(-)\d{4}$");
            //Company
            patternsList.Add(@"^[a-zA-Z]+$");
            //Name
            patternsList.Add(@"^[a-zA-Z \s]+$");
            //Price
            patternsList.Add(@"^\d+$");
            //Color
            patternsList.Add(@"^[a-zA-Z]+$");
        }

        #region private functions
        private bool CheckingTextBoxes(String text)
        {
           // SettingLabels();
            try
            {
                if ( txtAddCarRegNo.Text != String.Empty && txtAddCarCompany.Text != String.Empty && txtAddCarName.Text != String.Empty && txtAddCarPrice.Text != String.Empty && txtAddCarColor.Text != String.Empty
                    && cmbxAddCarAvailable.SelectedItem!=null && cmbxAddCarTransmission.SelectedItem!=null)
                {
                    if (!checking())
                    {
                        AddCarLogic car = new AddCarLogic();
                        car.regNo = txtAddCarRegNo.Text;
                        car.company = txtAddCarCompany.Text;
                        car.name = txtAddCarName.Text;
                        car.price = float.Parse(txtAddCarPrice.Text);
                        car.color = txtAddCarColor.Text;
                        car.availability = cmbxAddCarAvailable.SelectedItem.ToString();
                        if (cmbxAddCarTransmission.SelectedItem.ToString() == "Auto")
                            car.transmission = 1;
                        else if (cmbxAddCarTransmission.SelectedItem.ToString() == "Manual")
                            car.transmission = 0;
                        if (text == "Add")
                            car.carLogicAdd();
                        else if (text == "Update")
                            car.carLogicUpdate();
                        else if (text == "Delete")
                            car.carLogicDelete();
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
                 
                    if (txtAddCarRegNo.Text == String.Empty)
                        Error += "Please enter plate no\n";
                    if (txtAddCarCompany.Text == String.Empty)
                        Error += "Please enter company of car\n";
                    if (txtAddCarName.Text == String.Empty)
                        Error += "Please enter name of Car\n";
                    if (txtAddCarPrice.Text == String.Empty)
                        Error += "Please enter price for Car\n";
                    if (txtAddCarColor.Text == String.Empty)
                        Error += "Please enter color of Car\n";
                    if (cmbxAddCarAvailable.SelectedItem == null)
                        Error += "Please select Availability of Car\n";
                    if (cmbxAddCarTransmission.SelectedItem == null)
                        Error += "Please select transmission of car\n";
                    MessageBox.Show(Error);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return false;
        }
        #region matchingWithPatterns
        private bool checking()
        {
            String regNo = "", carName = "", company = "", color = "", availability = "", transmission = "";
            float price = 0;
            bool check = false;
           

            if (Regex.IsMatch(txtAddCarRegNo.Text, patternsList[0]))
                regNo = txtAddCarRegNo.Text;
            else
            {
               // lblPlateNoError.Text = "Please enter correct plate no";
                check = true;
            }
            if (Regex.IsMatch(txtAddCarCompany.Text, patternsList[1]))
                company = txtAddCarCompany.Text;
            else
            {
               // lblCompanyError.Text = "Please enter correct company name";
                check = true;
            }
            if (Regex.IsMatch(txtAddCarName.Text, patternsList[2]))
                carName = txtAddCarName.Text;
            else
            {
                //lblNameError.Text = "Please enter correct car name";
                check = true;
            }
           
            if (Regex.IsMatch(txtAddCarPrice.Text, patternsList[3]))
                price = float.Parse(txtAddCarPrice.Text);
            else
            {
               // lblColorError.Text = "Please select correct color of car";
                check = true;
            }
            if (Regex.IsMatch(txtAddCarColor.Text, patternsList[4]))
                color = txtAddCarColor.Text;
            else
            {
                //lblEngineNoError.Text = "Please enter correct Engine No";
                check = true;
            }
            if (cmbxAddCarAvailable.SelectedItem != null)
                availability = cmbxAddCarAvailable.SelectedItem.ToString();
            else
            {
                //lblModelError.Text = "Please enter correct model of Car";
                check = true;
            }
            if (cmbxAddCarTransmission.SelectedItem != null)
                transmission = cmbxAddCarTransmission.SelectedItem.ToString();
            else
            {
                //lblModelError.Text = "Please enter correct model of Car";
                check = true;
            }
            return check;
           
        }
        #endregion
        private void settingComboBoxes()
        {
            cmbxAddCarAvailable.Items.Add("yes");
            cmbxAddCarAvailable.Items.Add("No");
            cmbxAddCarTransmission.Items.Add("Auto");
            cmbxAddCarTransmission.Items.Add("Manual");
            cmbxAddCarRefresh.Items.Add("yes");
            cmbxAddCarRefresh.Items.Add("no");
        }
        private void readingCars() {
            AddCarLogic car = new AddCarLogic();
            var carList = car.carLogicRead();
            String tran = "";
            dgvAddCar.Rows.Clear();
            foreach (var c in carList)
            {
                if (c.transmission == 1)
                {
                    tran = "Manual";
                }
                else
                {
                    tran = "Auto";
                }

                dgvAddCar.Rows.Add(c.regNo, c.company, c.name,  c.price, c.color, c.availability, tran);
            }
        }
        private void readingCars(String avl)
        {
            AddCarLogic car = new AddCarLogic();
            var carList = car.carLogicRead(avl);
            String tran = "";
            dgvAddCar.Rows.Clear();
            foreach (var c in carList)
            {
                if (c.transmission == 1)
                {
                    tran = "Manual";
                }
                else
                {
                    tran = "Auto";
                }

                dgvAddCar.Rows.Add(c.regNo, c.company, c.name, c.price, c.color, c.availability, tran);
            }
        }
      
        #endregion
        private void AddCar_Load(object sender, EventArgs e)
        {
            patterns();
            settingComboBoxes();
            readingCars();

            //  SettingLabels();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            if (CheckingTextBoxes("Add"))
                readingCars();
            

        }

        private void btnAddCarRefresh_Click(object sender, EventArgs e)
        {
            readingCars();
        }

        private void dgvAddCar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach(DataGridViewRow row in dgvAddCar.SelectedRows)
            {
                txtAddCarRegNo.Text = row.Cells[0].Value.ToString();
                txtAddCarCompany.Text= row.Cells[1].Value.ToString();
                txtAddCarName.Text= row.Cells[2].Value.ToString();
                txtAddCarPrice.Text = row.Cells[3].Value.ToString();

                txtAddCarColor.Text= row.Cells[4].Value.ToString();

                cmbxAddCarAvailable.SelectedItem= row.Cells[5].Value.ToString();
                if (row.Cells[6].Value.ToString() == "1")
                    cmbxAddCarTransmission.SelectedItem = "Manual";
                else
                    cmbxAddCarTransmission.SelectedItem = "Auto";

            }
        }

        private void cmbxAddCarRefresh_SelectedValueChanged(object sender, EventArgs e)
        {
            readingCars(cmbxAddCarRefresh.SelectedItem.ToString());
        }

        private void btnAddCarUpdate_Click(object sender, EventArgs e)
        {
            if (CheckingTextBoxes("Update"))
                readingCars();
        }

        private void btnAddCarDelete_Click(object sender, EventArgs e)
        {
            if (CheckingTextBoxes("Delete"))
                readingCars();
        }

        private void xuiGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
