using System;

namespace Cars
{
    class FuelTankDisplay : IFuelTankDisplay
    {
        private FuelTank fuel;

        public FuelTankDisplay(FuelTank fuelTank)
        {
            this.fuel = fuelTank;
        }

        public double FillLevel
        {
            get => Math.Round(fuel.FillLevel, 2);
        }

        public bool IsOnReserve
        {
            get => fuel.IsOnReserve;
        }

        public bool IsComplete
        {
            get => fuel.IsComplete;
        }
    }
}
