using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_Palmer_Justin
{
     class Truck : IAutomoblie
    {
        public double Speed { get; private set; }

        public int Wheels { get; private set; }

        public double Weight { get; }
        public string LicensePlate { get; private set; }

        public Truck(double speedParam, double weightParam,string licenseNum)
        {
            Speed = speedParam;
            Weight = weightParam;
            LicensePlate = licenseNum;

            if(Weight < 400)
            {
                Wheels = 8;
            }
            else
            {
                Wheels = 12;
            }
        }
        // writes to console the truck is traveling at a speed of on wheels wtih a licenese plate number.
        public void Stringify()
        {
            Console.WriteLine($"The Truck is traveling at a speed of {Speed} on {Wheels} wheels, with a License Plate # of {LicensePlate}!");
        }

        // omcrease speed ++5 decrease speed -=%
        public void IncreaseSpeed()
        {
            Speed+= 5;
        }


        public void DecreaseSpeed()
        {
            Speed -= 5;
        }
    }
}
