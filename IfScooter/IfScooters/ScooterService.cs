﻿using System.Collections.Generic;

namespace IfScooters
{
    public class ScooterService : IScooterService
    {
        public string Id { get; set; }
        public decimal PricePerMinute { get; set; }
        public List<RideHistory> RideHistory { get; set; }
        public List<Scooter> ScootersList { get; set; }
        public Scooter MyScooter { get; set; }

        public ScooterService()
        {
            ScootersList = new List<Scooter>();
            RideHistory = new List<RideHistory>();
        }

        public void AddScooter(string id, decimal pricePerMinute)
        {
            ScootersList.Add(new Scooter(id, pricePerMinute));
        }

        public void RemoveScooter(string id)
        {
            for (var i = 0; i < ScootersList.Count; i++)
            {
                if (ScootersList[i].Id == id && ScootersList[i].IsRented == false) ScootersList.Remove(ScootersList[i]);
            }
        }

        public IList<Scooter> GetScooters()
        {
            return ScootersList;
        }

        public Scooter GetScooterById(string scooterId)
        {
            for (var i = 0; i < ScootersList.Count; i++)
            {
                if (ScootersList[i].Id == scooterId) return ScootersList[i];
            }

            throw new MyException(message: "Scooter not found");
        }
    }
}
