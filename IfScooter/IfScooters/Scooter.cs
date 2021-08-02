using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace IfScooters
{
    public class Scooter
    {
        public string Id { get; set; } //Scooters individual definition
        public decimal PricePerMinute { get; set; }
        public bool IsRented { get; set; }
        public decimal Turnover { get; set; }


        public Scooter(string id, decimal pricePerMinute)
        {
            Id = id;
            PricePerMinute = pricePerMinute;
        }

    }
}
