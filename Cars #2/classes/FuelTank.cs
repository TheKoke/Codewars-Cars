using System;
using System.Collections.Generic;
using System.Linq;

namespace Cars
{
    public class FuelTank : IFuelTank
    {
        public FuelTank()
        {
            fillLevel = 20d;
        }

        public FuelTank(double fuelLevel)
        {
            fillLevel = fuelLevel;

            if (fillLevel > 60)
            {
                fillLevel = 60;
            }

            if (fillLevel < 0)
            {
                fillLevel = 0;
            }
        }

        private double fillLevel;
        public double FillLevel
        {
            get => fillLevel;
        }

        public bool IsOnReserve
        {
            get => fillLevel <= 5;
        }

        public bool IsComplete
        {
            get => fillLevel >= 60;
        }

        public void Consume(double liters)
        {
            fillLevel -= liters;

            if (fillLevel < 0)
            {
                fillLevel = 0;
            }
        }

        public void Refuel(double liters)
        {
            if (!IsComplete)
            {
                fillLevel += liters;

                if (fillLevel > 60)
                {
                    fillLevel = 60;
                }
            }
        }
    }
}
