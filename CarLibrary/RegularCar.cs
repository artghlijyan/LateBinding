using System;

namespace CarLibrary
{
    public class RegularCar : Car
    {
        public RegularCar()
        {

        }

        public RegularCar(string name, short maxSpeed, short currentSpeed) 
            : base(name, maxSpeed, currentSpeed)
        {

        }

        public override void Acceleration()
        {
            state = EngineState.EngineDead;
            Console.WriteLine("Engine is dead");
        }
    }
}
