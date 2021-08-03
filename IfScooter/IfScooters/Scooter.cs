using System;

namespace IfScooters
{
    public class Scooter
    {
        public string Id { get; set; }
        public decimal PricePerMinute { get; set; }
        public bool IsRented { get; set; }
        public decimal Turnover { get; set; }
        public TimeSpan StartingTime { get; set; }

        public Scooter(string id, decimal pricePerMinute)
        {
            Id = id;
            PricePerMinute = pricePerMinute;
            IsRented = false;
        }

    }
}
