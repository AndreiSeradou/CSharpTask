using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgectForAmal
{
    interface IBaseCar
    {
        void CheakCar(ICarInformation Car);
        void AddCar(ICarInformation Car);
        void RemoveCar(ICarInformation Car);
    }
}
