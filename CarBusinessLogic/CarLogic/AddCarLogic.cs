using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcessLayer;
using System.Data.SqlClient;

namespace CarBusinessLogic.CarLogic
{
    public class AddCarLogic
    {
        #region properties

        public String regNo { get; set; }
        public String company { get; set; }
        public String name { get; set; }
        public float price { get; set; }
        public String color { get; set; }
        public String availability { get; set; }
        public int transmission { get; set; }
        CarDbLogic cld;
        String querry;
        #endregion


        public void carLogicAdd()
        {
            cld = new CarDbLogic();
            querry = @"insert into Car values('" + regNo + "','" + company + "','" + name + "','" + availability + "','" + price + "','" + color + "','" + transmission + "')";
            cld.saveCar(querry);
        }
        public List<AddCarLogic> carLogicRead()
        {
            cld = new CarDbLogic();
            querry = @"select * from Car";
            var carList = cld.readCar(querry);
            return convert(carList);
        }
        public List<AddCarLogic> carLogicRead(String avl)
        {
            cld = new CarDbLogic();
            querry = @"select * from Car where Available='" + avl + "'";
            var carList = cld.readCar(querry);
            return convert(carList);
        }

        public void carLogicUpdate()
        {
            cld = new CarDbLogic();
            querry = @"update Car set Company='" + company + "',Name='" + name + "',Available='" + availability + "',Price='" + price + "',Color='" + color + "',transmission='" + transmission + "' where RegNum='" + regNo + "'";
            cld.saveCar(querry);
        }
        public void carLogicDelete()
        {
            cld = new CarDbLogic();
            querry = @"delete from Car where RegNum='" + regNo + "'";
            cld.saveCar(querry);
        }

    #region privTE FUNCTIONS
    private List<AddCarLogic> convert(List<CarDbLogic> list)
        {
            List<AddCarLogic> aLogic = new List<AddCarLogic>();
            foreach(var i in list)
            {
                AddCarLogic a = new AddCarLogic();
                a.regNo = i.regNo;
                a.company = i.company;
                a.name = i.name;
                a.availability = i.availability;
                a.price = i.price;
                a.color = i.color;
                a.transmission = i.transmission;
                aLogic.Add(a);
            }
            return aLogic;
        }

        #endregion


    }
}
