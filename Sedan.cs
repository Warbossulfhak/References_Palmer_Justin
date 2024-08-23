using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_Palmer_Justin
{
     class Sedan : IAutomoblie
    {
        public double Speed { get; private set; }

        public int Wheels { get; private set; }

        public string LicensePlate { get; private set; }

        public Sedan(double speed)
        {
            Wheels = 4;
            Speed = speed;
            LicensePlate = "GCTC-06";
        }
        // writes to console the sedan is travling at speed of it's speed on wheels with a licens palte number of GCTC-06 said license plate
        public void Stringify()
        {
            Console.WriteLine($"The Sedan is travling at a speed of {Speed} on {Wheels} Wheels, with a Licens Palte # of {LicensePlate}.");
        }

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
