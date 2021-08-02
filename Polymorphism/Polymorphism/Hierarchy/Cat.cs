using System;

namespace Hierarchy
{
    public class Cat : Felime
    {
        public string _breed;
        public readonly string _animalName;
        public readonly string _animalType;
        public readonly double _animalWeight;
        public int _foodEaten;
        public readonly string _livingRegion;

        public Cat(string animalType, string animalName, double animalWeight, string livingRegion, string breed) : base(animalType, animalName, animalWeight, livingRegion)
        {
            _animalType = animalType;
            _animalName = animalName;
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
