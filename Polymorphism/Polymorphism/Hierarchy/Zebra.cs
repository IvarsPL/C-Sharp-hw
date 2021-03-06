using System;

namespace Hierarchy
{
    public class Zebra : Mammal
    {
        private readonly string _animalName;
        private readonly string _animalType;
        private readonly double _animalWeight;
        private int _foodEaten;
        private readonly string _livingRegion;

        public Zebra(string animalType, string animalName, double animalWeight, string livingRegion) : base(animalType, animalName, animalWeight, livingRegion)
        {
            _animalName = animalName;
            _animalType = animalType;
            _animalWeight = animalWeight;
            _foodEaten = 0;
            _livingRegion = livingRegion;
        }

        public override void MakeSound()
        {
            Console.WriteLine("random zebra sound");
        }

        public override void EatFood(Food food)
        {
            if (food is Vegetable)
            {
                _foodEaten = food.Quantity;
            }
            else {Console.WriteLine($"{_animalType} are not eating that type of food");}
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"{_animalType} [{_animalName}, {_animalWeight}, {_livingRegion}, {_foodEaten}] ");
        }

    }
}
