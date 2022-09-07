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
using CarBusinessLogic.Finance;
using CarBusinessLogic.Maintenance;

namespace CarRentalManagement.Functionality
{
    public partial class Finance : Form
    {
        FinanceModel fModel = new FinanceModel();
        public Finance()
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
                cmbxFinanceCarSearch.Items.Add(c.regNo);
            }
        }
        private void readingFinanceOfCar()
        {
            FinanceBl fl = new FinanceBl();
                var readFinance = fl.readingCarFinances(cmbxFinanceCarSearch.SelectedItem.ToString());
                dgvFinance.Rows.Clear();
            List<float> price = new List<float>();
            List<float> fine = new List<float>();

            foreach (var item in readFinance)
                {
                price.Add(item.fee);
                fine.Add(item.fine);
                dgvFinance.Rows.Add(item.carName, item.regNum, item.rentId, DateTime.Parse(item.rentDate).ToShortDateString(), DateTime.Parse(item.returnDate).ToShortDateString(), item.fee, DateTime.Parse(item.returnedDate).ToShortDateString(), item.fine);
                }
            fModel.price = price;
            fModel.fine = fine;
            readingMaintenance();

        }
        private void readingMaintenance()
        {
                MaintenanceBl ml = new MaintenanceBl();
                String querry = "select * from maintenance where RegNum='"+cmbxFinanceCarSearch.SelectedItem.ToString()+"'";
               var mlist=ml.readMaintenance(querry);
                dgvMaintenanceInFinance.Rows.Clear();
            List<float> mCost = new List<float>();

            foreach (var item in mlist)
                {
                mCost.Add(item.price);
                    dgvMaintenanceInFinance.Rows.Add(item.regNo, DateTime.Parse(item.date).ToShortDateString(), item.price);
                }
            fModel.maintenanceCost = mCost;
            allCost();  
        }
        private void allCost()
        {
            float Tprice=0, Tfine=0, TmCost=0;
            foreach (var item in fModel.price)
            {
                Tprice += item;
            }
            foreach (var item in fModel.fine)
            {
                Tfine += item;
            }
            foreach (var item in fModel.maintenanceCost)
            {
                TmCost += item;
            }
            float AllEarning = (Tprice + Tfine) - TmCost;
            txtTotalEarned.Text = AllEarning.ToString();
        }

        #endregion

        private void Finance_Load(object sender, EventArgs e)
        {
            readingCars();
        }

        private void btnFinanceSearch_Click(object sender, EventArgs e)
        {
           if(cmbxFinanceCarSearch.SelectedItem!=null)
            {
                readingFinanceOfCar();
            }
        }
    }
}
