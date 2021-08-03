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
        private ScooterService Scooty = new ScooterService(); // neesmu drošs par šo pieeju. Itkā jau viņš tiek izmantots, tikai lai izsauktu metodes, bet tāpat nekas nestrādā;
        
        public ScooterRent()
        {

        }
        public void StartRent(string id)
        {
            Scooty.GetScooterById(id).IsRented = true;

            Stopwatch.Start();
            Thread.Sleep(10000);
        }
        
        public decimal EndRent(string id) // šeit vēl neesmu ticis klāt - labošu pēc tam formulas.
        {
            Scooty.GetScooterById(id).IsRented = false;
            Stopwatch.Stop();
            TimeSpan ts = Stopwatch.Elapsed;
            var price = Scooty.GetScooterById(id).PricePerMinute * ts.Minutes;
            Scooty.GetScooterById(id).Turnover += price;
            return price;
        }

        public decimal CalculateIncome(int? year, bool includeNotCompletedRentals)
        {
            decimal income = 0;
            foreach (var scooter in Scooty.ScootersList)
            {
                income += scooter.Turnover;
            }
            return income;
        }
        public static void Main()
        {}
    }
}
