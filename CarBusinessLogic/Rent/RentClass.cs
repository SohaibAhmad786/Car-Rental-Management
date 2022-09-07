using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcessLayer;

namespace CarBusinessLogic.Rent
{
    public class RentClass
    {
        public String rentId { get; set; }
        public String regNo { get; set; }
        public String custId { get; set; }
        public String custName { get; set; }
        public String rentDate { get; set; }
        public String returnDate { get; set; }
        public float rentFee { get; set; }
        public int returned { get; set; }
        RentDbLogic rdl;
        String querry;
        public void RentCarLogicAdd()
        {
            rdl = new RentDbLogic();
            querry = @"insert into CarRental values('" + rentId + "','" + regNo + "','" + custId + "','" + rentDate + "','" + returnDate + "','" + rentFee + "','"+0+"')";
            rdl.SaveRentedCar(querry);
            querry = @"update Car set Available='No' where RegNum='"+regNo+"'";
            rdl.SaveRentedCar(querry);

        }
        public void RentCarLogicupdate()
        {
            rdl = new RentDbLogic();
            querry = @"update CarRental set RegNum='"+regNo+ "',CustomerId='"+custId+ "',RentDate='"+rentDate+ "',ReturnDate='"+returnDate+ "',fee='"+rentFee+ "' where RentId='"+rentId+"'";
            rdl.SaveRentedCar(querry);
        }
        public List<RentClass> readingRentedCar()
        {
            rdl = new RentDbLogic();
            querry = @"select cr.RentId,ca.RegNum,c.CustomerId,c.CustomerName,cr.RentDate,cr.ReturnDate,cr.fee,cr.returned from Customers c left join CarRental cr on c.CustomerId=cr.CustomerId right join Car ca on cr.RegNum=ca.RegNum where cr.RentId is not null";
            var rentedList = rdl.readRentedCar(querry);
            return convert(rentedList);
        }

        #region convert functions
        private List<RentClass> convert(List<RentDbLogic> list)
        {
            List<RentClass> rentedCars = new List<RentClass>();
            foreach (var i in list)
            {
                RentClass rentCar = new RentClass();
                rentCar.rentId = i.rentId;
                rentCar.regNo = i.regNo;
                rentCar.custId = i.custId;
                rentCar.custName = i.custName;
                rentCar.rentDate = i.rentDate;
                rentCar.returnDate = i.returnDate;
                rentCar.rentFee = i.rentFee;
                rentCar.returned = i.returned;
                rentedCars.Add(rentCar);
            }
            return rentedCars;
        }
        #endregion

    }
}
