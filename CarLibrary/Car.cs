using System;

namespace CarLibrary
{
    public abstract class Car
    {
        protected string name;
        protected short currentSpeed;
        protected short maxSpeed;
        protected EngineState state;

        public Car()
        {
            state = EngineState.EngineAlive;
        }

        protected Car(string name, short maxSpeed, short currentSpeed) : this()
        {
            this.name = name;
            this.maxSpeed = maxSpeed;
            this.currentSpeed = currentSpeed;
        }

        public abstract void Acceleration();

        public void Driver(string name, int age)
        {
            Console.WriteLine("Driver Name: {0}, Age: {1}", name, age);
        }

        public string Name => name;
        public short CurrentSpeed => currentSpeed;
        public short MaxSpeed { get => maxSpeed; }
        public EngineState EngineState { get => state; }
    }
}
