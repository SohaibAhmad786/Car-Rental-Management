using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcessLayer;

namespace CarBusinessLogic.Finance
{
   public class FinanceBl
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
        String querry = "";
        readingFinance rf;


        public List<FinanceBl> readingCarFinances(String reg)
        {
            querry = @"select c.Name,renCar.RegNum,renCar.RentId,renCar.RentDate,renCar.ReturnDate,renCar.fee,retCar.ReturnDate,retCar.Fine from ReturnCars retCar
                       join CarRental renCar on  renCar.CustomerId=retCar.CustomerId join Car c on renCar.RegNum=c.RegNum where retCar.RegNum='"+reg+"' and renCar.returned !=0";
            rf = new readingFinance();
            var carData=rf.readCarData(querry);
            return convert(carData);        
        }

        #region convert
        public List<FinanceBl> convert(List<readingFinance> rList)
        {
            List<FinanceBl> aLogic = new List<FinanceBl>();
            foreach (var i in rList)
            {
                FinanceBl fb = new FinanceBl();
                fb.carName = i.carName;
                fb.regNum = i.regNum;
                fb.rentId = i.rentId;
                fb.rentDate = i.rentDate;
                fb.returnDate = i.returnDate;
                fb.fee = i.fee;
                fb.returnedDate = i.returnedDate;
                fb.fine = i.fine;
                aLogic.Add(fb);
            }
            return aLogic;
        }
        #endregion
    }
}
