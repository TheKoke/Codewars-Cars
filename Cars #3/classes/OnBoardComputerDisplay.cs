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

        public int ActualSpeed
        {
            get => computer.ActualSpeed;
        }

        public double ActualConsumptionByTime
        {
            get => computer.ActualConsumptionByTime;
        }

        public double ActualConsumptionByDistance
        {
            get => computer.ActualConsumptionByDistance;
        }

        public double TripAverageConsumptionByTime
        {
            get => computer.TripAverageConsumptionByTime;
        }

        public double TotalAverageConsumptionByTime
        {
            get => computer.TotalAverageConsumptionByTime;
        }

        public double TripAverageConsumptionByDistance
        {
            get => computer.TripAverageConsumptionByDistance;
        }

        public double TotalAverageConsumptionByDistance
        {
            get => computer.TotalAverageConsumptionByDistance;
        }

        public int EstimatedRange
        {
            get => computer.EstimatedRange;
        }

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
