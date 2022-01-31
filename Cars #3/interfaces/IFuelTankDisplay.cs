using System;
using System.Collections.Generic;
using System.Linq;

namespace Cars
{
    public interface IFuelTankDisplay
    {
        double FillLevel { get; }

        bool IsOnReserve { get; }

        bool IsComplete { get; }
    }
}
