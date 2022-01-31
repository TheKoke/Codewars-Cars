using System;
using System.Collections.Generic;
using System.Linq;

namespace Cars
{
    public interface ICar
    {
        bool EngineIsRunning { get; }

        void EngineStart();

        void EngineStop();

        void BrakeBy(int speed);

        void Accelerate(int speed);

        void FreeWheel();

        void Refuel(double liters);

        void RunningIdle();
    }
}
