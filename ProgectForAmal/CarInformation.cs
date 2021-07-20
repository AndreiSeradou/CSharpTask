using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgectForAmal
{
    struct CarInformation : ICarInformation
    {
        private const decimal USDtoBYN = 2.589m;
        public string Model { get; set; }
        public string Color { get; set; }
        public int DateOfManufacture { get; set; }
        public int Mileage { get; set; }

        public decimal CostUSD {
            get
            {
                return CostUSD;
            } 
            set
            {
                CostUSD = value;
                if(CostBYN!= CostUSD * USDtoBYN)
                CostBYN = CostUSD * USDtoBYN;
            }
        }

        public decimal CostBYN
        {
            get
            {
                return CostBYN;
            }
            set
            {
                CostBYN = value;
                if(CostUSD!=(CostBYN / USDtoBYN))
                CostUSD = CostBYN / USDtoBYN; 
            }
        }

        public CarInformation(string model,string color, int dateOfManufacture, int mileage)
        {
            Model = model;
            Color = color;
            DateOfManufacture = dateOfManufacture;
            Mileage = mileage;
        }

        public void PrintInformation()
        {
            Console.WriteLine($"Model car {Model}, Date of manufacture {DateOfManufacture}, Color {Color}, Mileage {Mileage}");
        }

        public void CheakInBase(IBaseCar baseCar)
        {
            baseCar.CheakCar(this);
        }

        public void AddInBase(IBaseCar baseCar)
        {
            baseCar.AddCar(this);
        }

        public void RemoveInBase(IBaseCar baseCar)
        {
            baseCar.RemoveCar(this);
        }
    }
}
