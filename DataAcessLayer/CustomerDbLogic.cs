using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace DataAcessLayer
{
    public class CustomerDbLogic
    {
        public String id { get; set; }
        public String name { get; set; }
        public String address { get; set; }
        public String phone { get; set; }

        public void saveCustomer(String querry)
        {
            Db db = new Db();
            db.con = new SqlConnection(db.dbpath);
            db.con.Open();
            db.com = new SqlCommand(querry, db.con);
            db.com.ExecuteNonQuery();
            db.con.Close();
        }
        public List<CustomerDbLogic> readCustomer(String querry)
        {
            Db db = new Db();
            db.con = new SqlConnection(db.dbpath);
            db.con.Open();
            db.com = new SqlCommand(querry, db.con);
            SqlDataReader sdr = db.com.ExecuteReader();
            List<CustomerDbLogic> carList = new List<CustomerDbLogic>() { };
            while (sdr.Read())
            {
                CustomerDbLogic cd = new CustomerDbLogic();
                cd.id = sdr["CustomerId"].ToString();
                cd.name = sdr["CustomerName"].ToString();
                cd.address = sdr["CustomerAddress"].ToString();
                cd.phone = sdr["Phone"].ToString();
                carList.Add(cd);
            }
            sdr.Close();
            db.con.Close();
            return carList;

        }

    }
}
