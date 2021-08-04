using System;
using System.Collections.Generic;
using System.Windows.Markup;

namespace IfScooters
{
    public class RideHistory
    {

        private double _rideMinutes;
        private double _rideDays;
        public double Turnover { get; set; } = 0;
        public double RideMinutes 
        { get => Convert.ToInt32(Math.Round(_rideMinutes, 0));
            set => _rideMinutes = value;
        }
        public double RideDays
        {
            get => Convert.ToInt32(Math.Round(_rideDays, 0));
            set => _rideDays = value;
        }
        public string Id { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }

        public RideHistory(string id)
        {
            Id = id;
            StartDateTime = DateTime.Now;
            
        }

        public void CalculateScooterRideTime()
        {
            var days = (EndDateTime - StartDateTime).TotalDays;
            var minutes = (EndDateTime - StartDateTime).TotalMinutes;
            if (days < 0)
            {
                RideMinutes = minutes;
            }
            else
            {
                RideDays = days;
                RideMinutes = minutes % 1440;
            }
        }

        public double CalculateScooterTurnover(Scooter scooter)
        {
            if (RideDays >= 1)
            {
                for (int i = 0; i < RideDays; i++)
                {
                    Turnover += 20;
                }

                var minutePrice = RideMinutes * (double)scooter.PricePerMinute;
                Turnover += minutePrice > 20 ? 20 : minutePrice;
                return Turnover;
            }
            else
            {
                var minutePrice = RideMinutes * (double)scooter.PricePerMinute;
                Turnover += minutePrice > 20 ? 20 : minutePrice;
                return Turnover;
            }
        }
    }
}
