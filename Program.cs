using References_Palmer_Justin;
using System;

namespace MyApp
{
     class Program
    {
        static void Main(string[] args)
        {
            Sedan myFirstSeadan = new Sedan(0);
            IAutomoblie myAutomobiles = myFirstSeadan;

            Sedan myOtherSedan = new Sedan(0);

            myFirstSeadan.IncreaseSpeed();
            Console.WriteLine(myFirstSeadan.Speed);
            Console.WriteLine(myAutomobiles.Speed);
            Console.WriteLine(myFirstSeadan.Equals(myAutomobiles));
            // writes to console line seadan speed other sedan speed first sedan 
            myOtherSedan.IncreaseSpeed();
            Console.WriteLine(myFirstSeadan.Speed);
            Console.WriteLine(myOtherSedan.Speed);
            Console.WriteLine(myFirstSeadan.Equals(myOtherSedan));

            Truck myTruck = new Truck(50, 500, "MyTruck");

            //Calls stringifymethod and describs automobiles
            myFirstSeadan.Stringify();
            myAutomobiles.Stringify();
            myOtherSedan.Stringify();
            myTruck.Stringify();
        }
    }
}