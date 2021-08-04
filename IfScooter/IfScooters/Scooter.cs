namespace IfScooters
{
    public class Scooter
    {
        public string Id { get; }
        public decimal PricePerMinute { get; set; }
        public bool IsRented { get; set; }

        public Scooter(string id, decimal pricePerMinute)
        {
            Id = id;
            PricePerMinute = pricePerMinute;
            IsRented = false;
        }


    }
}
