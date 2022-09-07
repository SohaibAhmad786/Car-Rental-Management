using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAcessLayer
{
    public class CarDbLogic
    {
        public String regNo { get; set; }
        public String company { get; set; }
        public String name { get; set; }
        public float price { get; set; }
        public String color { get; set; }
        public String availability { get; set; }
        public int transmission { get; set; }

        public void saveCar(String querry)
        {
            Db db = new Db();
            db.con = new SqlConnection(db.dbpath);
            db.con.Open();
            db.com = new SqlCommand(querry, db.con);
            db.com.ExecuteNonQuery();
            db.con.Close();
        }
        public List<CarDbLogic> readCar(String querry)
        {
            Db db = new Db();
            db.con = new SqlConnection(db.dbpath);
            db.con.Open();
            db.com = new SqlCommand(querry, db.con);
            SqlDataReader sdr = db.com.ExecuteReader();
            List<CarDbLogic> carList = new List<CarDbLogic>(){};
            while (sdr.Read())
            {
                CarDbLogic c = new CarDbLogic();
                c.regNo = sdr["RegNum"].ToString();
                c.company = sdr["Company"].ToString();
                c.name = sdr["Name"].ToString();
                c.availability = sdr["Available"].ToString();
                c.price = float.Parse(sdr["Price"].ToString());
                c.color = sdr["Color"].ToString();
                c.transmission = int.Parse(sdr["Transmission"].ToString());
                carList.Add(c);
            }
            sdr.Close();
            db.con.Close();
            return carList;

    }
}
}
