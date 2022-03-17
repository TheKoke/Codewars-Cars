using System;

namespace Cars
{
    public class DrivingProcessor : IDrivingProcessor
    {
        private int maxAccelerate;
    
        public DrivingProcessor()
        {
            maxAccelerate = 10;
        }

        public DrivingProcessor(int maxIncrease)
        {
            maxAccelerate = maxIncrease;

            if (maxAccelerate > 20) maxAccelerate = 20;
            if (maxAccelerate < 5) maxAccelerate = 5;
        }

        private int actualSpeed;
        public int ActualSpeed
        {
            get
            {
                return actualSpeed;
            }
        }

        public void IncreaseSpeedTo(int speed)
        {
            if (speed <= actualSpeed)
            {
                ReduceSpeed(1);
                return;
            }

            if (speed - actualSpeed >= maxAccelerate)
            {
                actualSpeed += maxAccelerate;
            }
            else
            {
                actualSpeed = speed;
            }

            if (actualSpeed >= 250)
            {
                actualSpeed = 250;
            }
        }

        public void ReduceSpeed(int speed)
        {
            if (speed > 10)
            {
                speed = 10;
            }

            actualSpeed -= speed;

            if (actualSpeed < 0)
            {
                actualSpeed = 0;
            }
        }
    }
}
