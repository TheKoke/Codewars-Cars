using System;

namespace Cars
{
    public class DrivingDisplay : IDrivingDisplay
    {
        private DrivingProcessor drivingProcessor;

        public DrivingDisplay(DrivingProcessor drivingProcessor)
        {
            this.drivingProcessor = drivingProcessor;
        }

        public int ActualSpeed
        {
            get
            {
                return drivingProcessor.ActualSpeed;
            }
        }
    }
}
