﻿using System;

namespace CarLibrary
{
    public class SportCar : Car
    {
        public SportCar()
        {

        }

        public SportCar(string name, short maxSpeed, short currentSpeed)
            : base(name, maxSpeed, currentSpeed)
        {

        }

        public override void Acceleration()
        { 
            Console.WriteLine("This is SportCar");
        }
    }

    internal class SecretCar : Car
    {
        public override void Acceleration()
        {
            throw new NotImplementedException();
        }
    }
}
