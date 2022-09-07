using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAcessLayer
{
    public class ReturnDbLogic
    {
        public String rentId { get; set; }
        public String regNo { get; set; }
        public String custId { get; set; }
        public String custName { get; set; }
        public String returnedDate { get; set; }
        public String returnId { get; set; }
        public float fine { get; set; }
        public int returned { get; set; }
        public void ReturnCar(String querry)
        {

            Db db = new Db();
            db.con = new SqlConnection(db.dbpath);
            db.con.Open();
            db.com = new SqlCommand(querry, db.con);
            db.com.ExecuteNonQuery();
            db.con.Close();
        }
        public List<ReturnDbLogic> readRentedCar(String querry)
        {
            Db db = new Db();
            db.con = new SqlConnection(db.dbpath);
            db.con.Open();
            db.com = new SqlCommand(querry, db.con);
            SqlDataReader sdr = db.com.ExecuteReader();
            List<ReturnDbLogic> returnedCars = new List<ReturnDbLogic>() { };
            while (sdr.Read())
            {
                ReturnDbLogic c = new ReturnDbLogic();
                c.rentId = sdr["RentId"].ToString();
                c.regNo = sdr["RegNum"].ToString();
                c.custId = sdr["CustomerId"].ToString();
                c.custName = sdr["CustomerName"].ToString();
                c.returnId = sdr["ReturnId"].ToString();
                c.fine = float.Parse(sdr["Fine"].ToString());
                c.returned = int.Parse(sdr["returned"].ToString());
                returnedCars.Add(c);
            }
            sdr.Close();
            db.con.Close();
            return returnedCars;

        }
    }
}
