using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcessLayer;

namespace CarBusinessLogic.Customer
{
   public class CustomerBl
    {
        public String id { get; set; }
        public String name { get; set; }
        public String address { get; set; }
        public String phone { get; set; }
        public String querry;
        public CustomerDbLogic cl;

        public void addCustomerLogic()
        {
            CustomerDbLogic cdl = new CustomerDbLogic();
            querry = @"insert into customers values('"+id+"','"+name+"','"+address+"','"+phone+"')";
            cdl.saveCustomer(querry);
        }
        public List<CustomerBl> readCustomer()
        {
            cl = new CustomerDbLogic();
            querry = @"select * from customers";
            var carList = cl.readCustomer(querry);
            return convert(carList);
        }
        public CustomerBl readCustomer(String id)
        {
            cl = new CustomerDbLogic();
            querry = @"select * from customers where CustomerId='"+id+"'";
            var carList = cl.readCustomer(querry);
            return convertSingle(carList);
        }

        public void customerLogicUpdate()
        {
            cl = new CustomerDbLogic();
            querry = @"update Customers set CustomerName='" + name + "',CustomerAddress='" + address + "',Phone='" + phone + "' where CustomerId='" + id + "'";
            cl.saveCustomer(querry);
        }
        #region privTE FUNCTIONS
        private List<CustomerBl> convert(List<CustomerDbLogic> list)
        {
            List<CustomerBl> aLogic = new List<CustomerBl>();
            foreach (var i in list)
            {
                CustomerBl cs = new CustomerBl();
                cs.id = i.id;
                cs.name = i.name;
                cs.address = i.address;
                cs.phone = i.phone;
                aLogic.Add(cs);
            }
            return aLogic;
        }

        private CustomerBl convertSingle(List<CustomerDbLogic> list)
        {
            CustomerBl cs = new CustomerBl();
            foreach (var i in list)
            {
                cs.id = i.id;
                cs.name = i.name;
                cs.address = i.address;
                cs.phone = i.phone;
            }
            return cs;
        }
        #endregion
    }
}
