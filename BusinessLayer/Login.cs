using System;
using DataAcessLayer.Admin;

namespace BusinessLayer
{
    public class Login
    {
        public String name { get; set; }
        public String password { get; set; }


        public bool CarDataCheck()
        {
            AdminClass a = new AdminClass();
            bool chk = a.AdminCheck(name, password);
            return chk;
        }
    }
}
