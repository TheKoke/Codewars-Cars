using System;

namespace Cars
{
    public class OnBoardComputer : IOnBoardComputer
    {
        private int tripRealTime;
        public int TripRealTime
        {
            get => tripRealTime;
        }

        private int tripDrivingTime;
        public int TripDrivingTime
        {
            get => tripDrivingTime;
        }

        private int tripDrivenDistance;
        public int TripDrivenDistance
        {
            get => tripDrivenDistance;
        }

        private int totalRealTime;
        public int TotalRealTime
        {
            get => totalRealTime;
        }

        private int totalDrivingTime;
        public int TotalDrivingTime
        {
            get => totalDrivingTime;
        }

        private int totalDrivenDistance;
        public int TotalDrivenDistance
        {
            get => totalDrivenDistance;
        }

        private double tripAverageSpeed;
        public double TripAverageSpeed
        {
            get => tripAverageSpeed;
        }

        private double totalAverageSpeed;
        public double TotalAverageSpeed
        {
            get => totalAverageSpeed;
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
