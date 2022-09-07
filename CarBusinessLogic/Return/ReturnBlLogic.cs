using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcessLayer;

namespace CarBusinessLogic.Return
{
    public class ReturnBlLogic
    {
        public String rentId { get; set; }
        public String regNo { get; set; }
        public String custId { get; set; }
        public String custName { get; set; }
        public String returnedDate { get; set; }
        public String returnId { get; set; }
        public float fine { get; set; }
        public int returned { get; set; }
        private ReturnDbLogic rdl;
        private String querry;
        public void returnCar()
        {
            rdl = new ReturnDbLogic();
            querry = @"insert into ReturnCars values('" + returnId + "','" + regNo + "','" + custId + "','" + returnedDate + "','" + fine + "')";
            rdl.ReturnCar(querry);
            querry = @"update Car set Available='Yes' where RegNum='"+regNo+"'";
            rdl.ReturnCar(querry);
            querry = @"update CarRental set returned=1 where RegNum='" + regNo + "'";
            rdl.ReturnCar(querry);
        }
        public List<ReturnBlLogic> readingReturnedCars()
        {
            rdl = new ReturnDbLogic();
            querry = @"select crs.RentId,crs.RegNum,crs.CustomerId,c.CustomerName,cr.ReturnId,cr.Fine,crs.returned from Customers c 
left join ReturnCars cr on c.CustomerId=cr.CustomerId inner join Car ca on cr.RegNum=ca.RegNum
right join CarRental crs on c.CustomerId=crs.CustomerId and cr.RegNum=crs.RegNum where cr.ReturnId is not Null";
            var rentedList = rdl.readRentedCar(querry);
            return convert(rentedList);
        }


        #region convert functions
        private List<ReturnBlLogic> convert(List<ReturnDbLogic> list)
        {
            List<ReturnBlLogic> rentedCars = new List<ReturnBlLogic>();
            foreach (var i in list)
            {
                ReturnBlLogic rentCar = new ReturnBlLogic();
                rentCar.rentId = i.rentId;
                rentCar.regNo = i.regNo;
                rentCar.custId = i.custId;
                rentCar.custName = i.custName;
                rentCar.returnId = i.returnId;
                rentCar.fine = i.fine;
                rentCar.returned = i.returned;
                rentedCars.Add(rentCar);
            }
            return rentedCars;
        }
        #endregion

    }
}

