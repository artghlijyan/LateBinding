using System;
using CarLibrary;

namespace CarClient
{
    class Program
    {
        static void Main(string[] args)
        {
            SportCar sportCar = new SportCar("Ferrari", 320, 80);
            sportCar.Acceleration();

            RegularCar regularCar = new RegularCar();
            regularCar.Acceleration();

            //Console.WriteLine("{0, -15}: {1}", sportCar.Name, sportCar.MaxSpeed);
            Console.ReadKey();
        }
    }
}
