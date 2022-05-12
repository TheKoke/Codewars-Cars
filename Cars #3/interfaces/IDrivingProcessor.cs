using System;
using System.Collections.Generic;
using System.Linq;

namespace Cars
{
    public interface IDrivingProcessor
    {
        int ActualSpeed { get; }
        
        double ActualConsumption { get; }
        
        void EngineStart();
        
        void EngineStop();

        void IncreaseSpeedTo(int speed);

        void ReduceSpeed(int speed);
    }
}
