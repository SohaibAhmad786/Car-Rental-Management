using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcessLayer;


namespace CarBusinessLogic.Maintenance
{
    public class MaintenanceBl
    {
        public String maintenanceId { get; set; }
        public String regNo { get; set; }
        public float price { get; set; }
        public String date { get; set; }
        String querry;

        public void saveMaintenaceBl()
        {
            querry = @"insert into maintenance values('"+maintenanceId+ "','"+regNo+ "','"+price+ "','"+date+"')";
            MaintenanceDbLogic dc = new MaintenanceDbLogic();
            dc.saveMaintenance(querry);
        }
        public List<MaintenanceBl> readMaintenance()
        {
            querry = @"select * from maintenance";
            MaintenanceDbLogic dc = new MaintenanceDbLogic();
            var maintlist = dc.readMaintenance(querry);
            return convert(maintlist);

        }
        public List<MaintenanceBl> readMaintenance(String querryy)
        {  
            MaintenanceDbLogic dc = new MaintenanceDbLogic();
            var maintlist = dc.readMaintenance(querryy);
            return convert(maintlist);

        }

        #region privTE FUNCTIONS
        private List<MaintenanceBl> convert(List<MaintenanceDbLogic> list)
        {
            List<MaintenanceBl> aLogic = new List<MaintenanceBl>();
            foreach (var i in list)
            {
                MaintenanceBl a = new MaintenanceBl();
                a.maintenanceId = i.maintenanceId;
                a.regNo = i.regNo;
                a.price = i.price;
                a.date = i.date;
                aLogic.Add(a);
            }
            return aLogic;
        }

        #endregion


    }

}
