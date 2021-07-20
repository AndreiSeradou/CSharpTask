using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgectForAmal
{
    interface ICarInformation
    {
         string Model { get; set; }
         string Color { get; set; }
         int DateOfManufacture { get; set; }
         int Mileage { get; set; }
         void PrintInformation();
         void CheakInBase(IBaseCar baseCar);
         void AddInBase(IBaseCar baseCar);
         void RemoveInBase(IBaseCar baseCar);
    }
}
