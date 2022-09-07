using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcessLayer.Admin;
namespace CarBusinessLogic.Admin
{
    public class LoginLogic
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
