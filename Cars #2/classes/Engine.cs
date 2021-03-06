using System;
using System.Collections.Generic;
using System.Linq;

namespace Cars
{
    public class Engine : IEngine
    {
        private FuelTank fuel;

        public Engine(FuelTank fuelTank)
        {
            this.fuel = fuelTank;
        }

        private bool isRunning = false;
        public bool IsRunning
        {
            get
            {
                return isRunning;
            }
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
