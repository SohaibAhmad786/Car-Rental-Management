using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace DataAcessLayer
{
   public class readingFinance
    {
        public String carName { get; set; }
        public String regNum { get; set; }
        public String rentId { get; set; }
        public String rentDate { get; set; }
        public String returnDate { get; set; }
        public float fee { get; set; }
        public String returnedDate { get; set; }
        public float fine { get; set; }
        public String mDate { get; set; }
        public float mPrice { get; set; }

        public List<readingFinance> readCarData(String querry)
        {
            Db db = new Db();
            db.con = new SqlConnection(db.dbpath);
            db.con.Open();
            db.com = new SqlCommand(querry, db.con);
            SqlDataReader sdr = db.com.ExecuteReader();
            List<readingFinance> carList = new List<readingFinance>() { };
            while (sdr.Read())
            {
                readingFinance c = new readingFinance();
                c.carName = sdr["Name"].ToString();
                c.regNum = sdr["RegNum"].ToString();
                c.rentId = sdr["RentId"].ToString();
                c.rentDate = sdr["RentDate"].ToString();
                c.returnDate = sdr["ReturnDate"].ToString();
                c.fee = float.Parse(sdr["fee"].ToString());
                c.returnedDate = sdr[6].ToString();
                c.fine = float.Parse(sdr["Fine"].ToString());
                carList.Add(c);
            }
            sdr.Close();
            db.con.Close();
            return carList;

        }
    }
}
