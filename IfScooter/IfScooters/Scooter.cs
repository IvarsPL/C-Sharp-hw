using System.Collections.Generic;

namespace IfScooters
{
    public class Scooter : IRentalCompany, IScooterService
    {
        private string _id; //Scooters individual definition
        private decimal _pricePerMinute; //Rental price of the scooter per one minute.</param>
        public bool IsRented { get; set; } //True if not available

        public Scooter(string id, decimal pricePerMinute)
        {
            _id = id;
            _pricePerMinute = pricePerMinute;

        }
        public string Id => _id;

        public decimal PricePerMinute => _pricePerMinute;

        string IScooterService.Id { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        decimal IScooterService.PricePerMinute { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public void AddScooter(string id, decimal pricePerMinute)
        {

        }

        public void RemoveScooter(string id)
        {

        }

        Scooter GetScooterById(string scooterId)
        {
            return ;
        }

       
        Scooter IScooterService.GetScooterById(string scooterId)
        {
            throw new System.NotImplementedException();
        }

        public string Name { get; }
        public void StartRent(string id)
        {
            throw new System.NotImplementedException();
        }

        public decimal EndRent(string id)
        {
            throw new System.NotImplementedException();
        }

        public decimal CalculateIncome(int? year, bool includeNotCompletedRentals)
        {
            throw new System.NotImplementedException();
        }

        IList<Scooter> IScooterService.GetScooters()
        {
            throw new System.NotImplementedException();
        }
    }
}
