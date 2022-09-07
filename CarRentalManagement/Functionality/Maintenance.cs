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
using CarBusinessLogic.Maintenance;
using System.Text.RegularExpressions;


namespace CarRentalManagement.Functionality
{
    public partial class Maintenance : Form
    {
        private List<String> patternsList;

        public Maintenance()
        {
            InitializeComponent();
        }

        #region private functions
        private void readingCars()
        {
            AddCarLogic car = new AddCarLogic();
            var carList = car.carLogicRead();
            foreach (var c in carList)
            {
                if (c.availability != "No")
                {
                    cmbxMaintenanceCarRegNo.Items.Add(c.regNo);
                }
            }
        }
        private void patterns()
        {
            patternsList = new List<String>();
            //Id
            patternsList.Add(@"^[a-zA-Z]{2}-\d{4}$");
            patternsList.Add(@"^\d+$");
        }
      
        private bool CheckingTextBoxes()
        {
            // SettingLabels();
            try
            {
                if (txtMaintenanceId.Text != String.Empty && txtMaintenancePrice.Text != String.Empty)
                {
                    if (!checking())
                    {
                        MaintenanceBl m = new MaintenanceBl();
                        m.maintenanceId = txtMaintenanceId.Text.ToString();
                        m.regNo = cmbxMaintenanceCarRegNo.SelectedItem.ToString();
                        m.price = float.Parse(txtMaintenancePrice.Text);
                        m.date = dtMaintenanceDate.Value.ToShortDateString();
                        m.saveMaintenaceBl();
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
                    if (txtMaintenanceId.Text == String.Empty)
                        Error += "Please enter maintenance ID\n";
                    if (txtMaintenancePrice.Text == String.Empty)
                        Error += "Please enter price ID\n";
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
            String maintenanceId = "",price="",err="";
            bool check = false;
            if (Regex.IsMatch(txtMaintenanceId.Text, patternsList[0]))
                maintenanceId = txtMaintenanceId.Text;
            else
            {
                err += txtMaintenanceId.Text;
                // lblPlateNoError.Text = "Please enter correct plate no";
                check = true;
            }
            if (Regex.IsMatch(txtMaintenancePrice.Text, patternsList[1]))
                price = txtMaintenancePrice.Text;
            else
            {
                err += "price" + txtMaintenancePrice;
                // lblPlateNoError.Text = "Please enter correct plate no";
                check = true;
            }
            return check;
        }
        private void readingMaintenanceCars()
        {
            MaintenanceBl mb = new MaintenanceBl();
            var list = mb.readMaintenance();
            dgvMaintenanceCrs.Rows.Clear();
            foreach (var item in list)
            {
                dgvMaintenanceCrs.Rows.Add(item.maintenanceId, item.regNo, item.price, DateTime.Parse(item.date).ToShortDateString());

            }
        }
        #endregion


        private void Maintenance_Load(object sender, EventArgs e)
        {
            patterns();
            readingCars();
            readingMaintenanceCars();
        }

        private void btnMaintenanceAdd_Click(object sender, EventArgs e)
        {
            if(CheckingTextBoxes())
                MessageBox.Show("Success");
        }
    }
}
