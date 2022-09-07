using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAcessLayer
{
    public class Db
    {
        public String namedb = "";
        public String pass;
        public String dbpath = @"Data Source=DESKTOP-E188SG7\SQLSERVER2019;Initial Catalog=carRentalManagement;User ID=sa;Password=1234";
        public SqlConnection con;
        public SqlCommand com;
        
    }
}
