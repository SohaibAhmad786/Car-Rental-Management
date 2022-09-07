using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAcessLayer
{
    public class RentDbLogic
    {
        public String rentId { get; set; }
        public String regNo { get; set; }
        public String custId { get; set; }
        public String custName { get; set; }

        public String rentDate { get; set; }
        public String returnDate { get; set; }
        public float rentFee { get; set; }
        public int returned { get; set; }

        public void SaveRentedCar(String querry)
        {

            Db db = new Db();
            db.con = new SqlConnection(db.dbpath);
            db.con.Open();
            db.com = new SqlCommand(querry, db.con);
            db.com.ExecuteNonQuery();
            db.con.Close();
        }
        public List<RentDbLogic> readRentedCar(String querry)
        {
            Db db = new Db();
            db.con = new SqlConnection(db.dbpath);
            db.con.Open();
            db.com = new SqlCommand(querry, db.con);
            SqlDataReader sdr = db.com.ExecuteReader();
            List<RentDbLogic> rentedCarList = new List<RentDbLogic>() { };
            while (sdr.Read())
            {
                RentDbLogic c = new RentDbLogic();
                c.rentId = sdr["RentId"].ToString();
                c.regNo = sdr["RegNum"].ToString();
                c.custId = sdr["CustomerId"].ToString();
                c.custName = sdr["CustomerName"].ToString();
                c.rentDate = sdr["RentDate"].ToString();
                c.returnDate = sdr["ReturnDate"].ToString();
                c.rentFee = float.Parse(sdr["fee"].ToString());
                c.returned = int.Parse(sdr["returned"].ToString());
                rentedCarList.Add(c);
            }
            sdr.Close();
            db.con.Close();
            return rentedCarList;

        }
    }
}
