using System;
using System.Collections.Generic;
using System.Text;

namespace IfScooters
{
    public class ScooterService : IScooterService
    {
        public string Id { get; set; }
        public decimal PricePerMinute { get; set; }
        public List<Scooter> ScootersList = new();

        public ScooterService()
        {
            new List<Scooter>();
        }

        public void AddScooter(string id, decimal pricePerMinute)
        {
            ScootersList.Add(new Scooter(id, pricePerMinute));
        }

        public void RemoveScooter(string id)
        {
            for (var i = 0; i<ScootersList.Count; i++)
            {
                if (ScootersList[i].Id == id) ScootersList.Remove(ScootersList[i]);
            }
        }

        public IList<Scooter> GetScooters()
        {
            return ScootersList;
        }

        public Scooter GetScooterById(string scooterId)
        {
            foreach (var scooter in ScootersList)
            {
                if (scooter.Id == scooterId) return scooter;
            }
            throw new Exception();
        }
    }
}
