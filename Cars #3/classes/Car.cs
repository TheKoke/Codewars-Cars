using System;
using System.Collections.Generic;
using System.Linq;

namespace Cars
{
    public class Car : ICar
    {
        private Engine engine;

        private FuelTank fuelTank;

        public FuelTankDisplay fuelTankDisplay;

        private DrivingProcessor drivingProcessor;

        public DrivingDisplay drivingDisplay;

        public Car()
        {
            fuelTank = new FuelTank();
            engine = new Engine(fuelTank);
            fuelTankDisplay = new FuelTankDisplay(fuelTank);

            drivingProcessor = new DrivingProcessor();
            drivingDisplay = new DrivingDisplay(drivingProcessor);
        }
        
        public Car(double fuelLevel)
        {
            fuelTank = new FuelTank(fuelLevel);
            engine = new Engine(fuelTank);
            fuelTankDisplay = new FuelTankDisplay(fuelTank);
            
            drivingProcessor = new DrivingProcessor();
            drivingDisplay = new DrivingDisplay(drivingProcessor);
        }

        public Car(double fuelLevel, int maxAccelerate)
        {
            fuelTank = new FuelTank(fuelLevel);
            engine = new Engine(fuelTank);
            fuelTankDisplay = new FuelTankDisplay(fuelTank);

            drivingProcessor = new DrivingProcessor(maxAccelerate);
            drivingDisplay = new DrivingDisplay(drivingProcessor);
        }

        public bool EngineIsRunning
        {
            get
            {
                return engine.IsRunning;
            }
        }

        public void EngineStart()
        {
            if ((!EngineIsRunning) && fuelTank.FillLevel > 0)
            {
                engine.Start();
            }
        }

        public void EngineStop()
        {
            if (engine.IsRunning)
            {
                engine.Stop();
            }
        }

        public void BrakeBy(int speed)
        {
            if (EngineIsRunning && drivingProcessor.ActualSpeed > 0)
            {
                drivingProcessor.ReduceSpeed(speed);
                Consumption(drivingProcessor.ActualSpeed);
            }
        }

        public void Accelerate(int speed)
        {
            if (EngineIsRunning)
            {
                drivingProcessor.IncreaseSpeedTo(speed);
                Consumption(drivingProcessor.ActualSpeed);
            }
        }

        public void FreeWheel()
        {
            if (EngineIsRunning)
            {
                if (drivingProcessor.ActualSpeed > 0)
                {
                    drivingProcessor.ReduceSpeed(1);
                    Consumption(drivingProcessor.ActualSpeed);
                }
                else
                {
                    RunningIdle();
                }
            }
        }

        public void Refuel(double liters)
        {
            fuelTank.Refuel(liters);
        }

        public void RunningIdle()
        {
            if (EngineIsRunning)
            {
                engine.Consume(0.0003);
            }
        }

        private void Consumption(int actualSpeed)
        {
            if (actualSpeed >= 1 && actualSpeed <= 60)
                engine.Consume(0.0020);

            if (actualSpeed >= 61 && actualSpeed <= 100)
                engine.Consume(0.0014);

            if (actualSpeed >= 101 && actualSpeed <= 140)
                engine.Consume(0.0020);

            if (actualSpeed >= 141 && actualSpeed <= 200)
                engine.Consume(0.0025);

            if (actualSpeed >= 201 && actualSpeed <= 250)
                engine.Consume(0.0030);

            if (fuelTank.FillLevel <= 0)
            {
                EngineStop();
            }
        }
    }
}
