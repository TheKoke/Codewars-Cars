using System;
using System.Collections.Generic;
using System.Linq;

namespace Cars
{
    public interface IDrivingProcessor
    {
        int ActualSpeed { get; }

        void IncreaseSpeedTo(int speed);

        void ReduceSpeed(int speed);
    }
}
