using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace IfScooters
{
    public class ScooterRent : IRentalCompany
    {
        public string Name { get; }
        
        public Stopwatch Stopwatch = new();
        public void StartRent(string id)
        {
            scooty.GetScooterById(id).IsRented = true;
            Stopwatch.Start();
            Thread.Sleep(10000);
        }
        public ScooterService scooty = new();
        public decimal EndRent(string id)
        {
            scooty.GetScooterById(id).IsRented = false;
            Stopwatch.Stop();
            TimeSpan ts = Stopwatch.Elapsed;
            var price = scooty.GetScooterById(id).PricePerMinute * ts.Minutes;
            scooty.GetScooterById(id).Turnover += price;
            return price;
        }

        public decimal CalculateIncome(int? year, bool includeNotCompletedRentals)
        {
            decimal income = 0;
            foreach (var scooter in scooty.ScootersList)
            {
                income += scooter.Turnover;
            }
            return income;
        }
        public static void Main()
        {}
    }
}
