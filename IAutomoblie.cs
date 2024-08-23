using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_Palmer_Justin
{
     interface IAutomoblie
    {
        public double Speed { get; }

        public int Wheels { get; }


        public string LicensePlate { get; }

        public void Stringify();

    }
}
