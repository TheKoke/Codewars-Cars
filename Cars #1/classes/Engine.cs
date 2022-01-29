using System;

namespace Cars 
{
    class Engine : IEngine
    {
        private FuelTank fuel;

        public Engine(FuelTank fuelTank)
        {
            this.fuel = fuelTank;
        }

        private bool isRunning = false;
        public bool IsRunning
        {
            get => isRunning;
        }

        public void Consume(double liters)
        {
            fuel.Consume(liters);

            if (fuel.FillLevel <= 0)
            {
                Stop();
            }
        }

        public void Start()
        {
            isRunning = true;
        }

        public void Stop()
        {
            isRunning = false;
        }
    }
}
