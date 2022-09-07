using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAcessLayer
{
    public class MaintenanceDbLogic
    {
        public String maintenanceId { get; set; }
        public String regNo { get; set; }
        public float price { get; set; }
        public String date { get; set; }

        public void saveMaintenance(String querry)
        {
            Db db = new Db();
            db.con = new SqlConnection(db.dbpath);
            db.con.Open();
            db.com = new SqlCommand(querry, db.con);
            db.com.ExecuteNonQuery();
            db.con.Close();
        }
        public List<MaintenanceDbLogic> readMaintenance(String querry)
        {
            Db db = new Db();
            db.con = new SqlConnection(db.dbpath);
            db.con.Open();
            db.com = new SqlCommand(querry, db.con);
            SqlDataReader sdr = db.com.ExecuteReader();
            List<MaintenanceDbLogic> carList = new List<MaintenanceDbLogic>() { };
            while (sdr.Read())
            {
                MaintenanceDbLogic dc = new MaintenanceDbLogic();
                dc.regNo = sdr["RegNum"].ToString();
                dc.price = float.Parse(sdr["price"].ToString());
                dc.date = sdr["mdate"].ToString();
                carList.Add(dc);
            }
            sdr.Close();
            db.con.Close();
            return carList;

        }


    }

}
