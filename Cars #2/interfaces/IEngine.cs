using System;
using System.Collections.Generic;
using System.Linq;

namespace Cars
{
    public interface IEngine
    {
        bool IsRunning { get; }

        void Consume(double liters);

        void Start();

        void Stop();
    }
}
