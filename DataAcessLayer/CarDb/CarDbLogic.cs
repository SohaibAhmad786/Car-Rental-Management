using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAcessLayer.CarDb
{
    public class CarDbLogic
    {
        String dbpath = @"Data Source=DESKTOP-E188SG7\SQLSERVER2019;Initial Catalog=carRentalManagement;User ID=sa;Password=1234";
        SqlConnection con;
        SqlCommand com;
        public int addDataToCar(String querry)
        {
            con = new SqlConnection(dbpath);
            com = new SqlCommand(querry, con);
            int rowEffected = com.ExecuteNonQuery();
            return rowEffected;

        }
    }
}
