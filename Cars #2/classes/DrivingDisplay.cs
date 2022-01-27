using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
