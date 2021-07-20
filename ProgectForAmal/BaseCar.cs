using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgectForAmal
{
    struct BaseCar: IBaseCar
    {
        private List<ICarInformation> baseCar;
        public void CheakCar(ICarInformation Car)
        {
           foreach(var car in baseCar)
           {
                if(Car == car)
                {
                    Car.PrintInformation();
                }
                else
                {
                    Console.WriteLine("Car not faund in CarBase!");
                }
           }
        }

        public void AddCar(ICarInformation Car)
        {
            baseCar.Add(Car);
        }

        public void RemoveCar(ICarInformation Car)
        {
            baseCar.Remove(Car);
        }
    }
}
