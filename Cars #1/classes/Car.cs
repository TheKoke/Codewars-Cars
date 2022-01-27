using System;

namespace Cars
{
    class Car : ICar
    {
        public FuelTankDisplay fuelTankDisplay;

        private Engine engine;

        private FuelTank fuelTank;

        public Car()
        {
            fuelTank = new FuelTank();
            engine = new Engine(fuelTank);
            fuelTankDisplay = new FuelTankDisplay(fuelTank);
        }

        public Car(double fuelLevel)
        {
            fuelTank = new FuelTank(fuelLevel);
            engine = new Engine(fuelTank);
            fuelTankDisplay = new FuelTankDisplay(fuelTank);
        }

        public bool EngineIsRunning
        {
            get => engine.IsRunning;
        }

        public void EngineStart()
        {
            if ((!EngineIsRunning) && fuelTank.FillLevel > 0)
                engine.Start();
        }

        public void EngineStop()
        {
            if (engine.IsRunning)
                engine.Stop();
        }

        public void Refuel(double liters)
        {
            fuelTank.Refuel(liters);
        }

        public void RunningIdle()
        {
            if (EngineIsRunning)
                engine.Consume(0.0003);
        }
    }
}
