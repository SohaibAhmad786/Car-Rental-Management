using System;
using System.Data.SqlClient;

namespace Accesslayer
{
    public class Admin
    {
        String namedb = "";
        String pass;
        String dbpath = @"Data Source=DESKTOP-E188SG7\SQLSERVER2019;Initial Catalog=carRentalManagement;User ID=sa;Password=1234";
        SqlConnection con;
        SqlCommand com;
        private void OpenConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Close();
            }
        }
        public void CloseConnection()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        public void IDU()
        {
            con = new SqlConnection(dbpath);
            con.Open();
            String querry = "select * from Admin";
            com = new SqlCommand(querry, con);
            SqlDataReader sdr = com.ExecuteReader();
            while (sdr.Read())
            {
                namedb = sdr[0].ToString();
                pass = sdr[1].ToString();
            }
            sdr.Close();
            CloseConnection();
        }

        public bool AdminCheck(String name, String password)
        {
            bool check = Validation(name, password);
            if (check)
                return true;
            else
                return false;

        }
        private bool Validation(String name, String password)
        {
            IDU();
            bool ret = false;
            if (namedb.Equals(name))
            {
                if (pass.Equals(password))
                {
                    ret = true;
                }
            }

            return ret;
        }
    }
}
