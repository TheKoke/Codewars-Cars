using System;

namespace Cars
{
    class OnBoardComputerDisplay : IOnBoardComputer
    {
        private OnBoardComputer computer;
        
        public OnBoardComputerDisplay(OnBoardComputer comp)
        {
            this.computer = comp;
        }
    
        public int TripRealTime
        {
            get => computer.TripRealTime;
        }

        public int TripDrivingTime
        {
            get => computer.TripDrivingTime;
        }

        public int TripDrivenDistance
        {
            get => computer.TripDrivenDistance;
        }

        public int TotalRealTime
        {
            get => computer.TotalRealTime;
        }

        public int TotalDrivingTime
        {
            get => computer.TotalDrivingTime;
        }

        public int TotalDrivenDistance
        {
            get => computer.TotalDrivenDistance;
        }

        public double TripAverageSpeed
        {
            get => computer.TripAverageSpeed;
        }

        public double TotalAverageSpeed
        {
            get => computer.TotalAverageSpeed;
        }

        public int ActualSpeed => throw new NotImplementedException();

        public double ActualConsumptionByTime => throw new NotImplementedException();

        public double ActualConsumptionByDistance => throw new NotImplementedException();

        public double TripAverageConsumptionByTime => throw new NotImplementedException();

        public double TotalAverageConsumptionByTime => throw new NotImplementedException();

        public double TripAverageConsumptionByDistance => throw new NotImplementedException();

        public double TotalAverageConsumptionByDistance => throw new NotImplementedException();

        public int EstimatedRange => throw new NotImplementedException();

        public void ElapseSecond()
        {
            throw new NotImplementedException();
        }

        public void TotalReset()
        {
            throw new NotImplementedException();
        }

        public void TripReset()
        {
            throw new NotImplementedException();
        }
    }
}
