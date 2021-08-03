using System;

namespace IfScooters
{
    public class ScooterRent : IRentalCompany
    {
        public static void Main() { }
        public string Name { get; set; }
        private readonly IScooterService _scooty;

        public ScooterRent(IScooterService scooty)
        {
            _scooty = scooty;
        }
        public void StartRent(string id)
        {
            _scooty.GetScooterById(id).IsRented = true;
            _scooty.GetScooterById(id).StartingTime = DateTime.Now.TimeOfDay;

        }

        public decimal EndRent(string id) // if total amount > 20 eur , stop time until next day 0:00am;
        {
            _scooty.GetScooterById(id).IsRented = false;
            TimeSpan endTime = DateTime.Now.TimeOfDay;
            TimeSpan timeDiff = endTime - _scooty.GetScooterById(id).StartingTime;
            int minutes = Convert.ToInt32(timeDiff.TotalMinutes);
            minutes = (int)Math.Ceiling((double)minutes);
            if (minutes < 1) minutes = 1;

            decimal price = _scooty.GetScooterById(id).PricePerMinute * minutes;
            
            _scooty.GetScooterById(id).Turnover += price;
            return price;
        }

        public decimal CalculateIncome(int? year, bool includeNotCompletedRentals)
        {
            if (includeNotCompletedRentals)
            {
                foreach (var scooter in _scooty.GetScooters())
                {
                    if (scooter.IsRented)
                    {
                        TimeSpan endTime = DateTime.Now.TimeOfDay;
                        TimeSpan timeDiff = endTime - scooter.StartingTime;
                        int minutes = Convert.ToInt32(timeDiff.TotalMinutes);
                        minutes = (int)Math.Ceiling((double)minutes);
                        if (minutes < 1) minutes = 1;

                        decimal price = scooter.PricePerMinute * minutes;

                        scooter.Turnover += price;
                    }
                }
            }
            
            decimal income = 0;
            foreach (var scooter in _scooty.GetScooters())
            {
                income += scooter.Turnover;
            }
            return income;
        }
    }
}
