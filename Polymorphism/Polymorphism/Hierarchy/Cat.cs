using System;

namespace Hierarchy
{
    public class Cat : Felime
    {
        private string _breed;
        private readonly string _animalName;
        private readonly string _animalType;
        private readonly double _animalWeight;
        private int _foodEaten;
        private readonly string _livingRegion;

        public Cat(string animalType, string animalName, double animalWeight, string livingRegion, string breed) : base(animalType, animalName, animalWeight, livingRegion)
        {
            _animalName = animalName;
            _animalType = animalType;
            _animalWeight = animalWeight;
            _foodEaten = 0;
            _livingRegion = livingRegion;
            _breed = breed;
        }

        public override void MakeSound()
        {
            Console.WriteLine("random cat sound");
        }

        public override void EatFood(Food food)
        {
            _foodEaten = food.Quantity;
        }

        public override void ShowInfo()
        {
            Console.Write($"{_animalType} [{_animalName}, {_animalWeight}, {_livingRegion}, {_breed}, {_foodEaten}] ");
        }
    }
}
