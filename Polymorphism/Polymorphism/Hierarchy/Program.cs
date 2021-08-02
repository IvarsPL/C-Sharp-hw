using System;
using System.Collections.Generic;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            var animalList = new List<Animal>();
            do
            {
                Console.WriteLine("Please enter animal information:");
                var input = Console.ReadLine().Split(' ');
                var animalType = input[0];
                var animalName = input[1];
                var animalWeight = Double.Parse(input[2]);
                var animalRegion = input[3];
                var breed = "";
                if (animalType == "Cat")
                {
                    breed = input[4];
                    var newCat = new Cat(animalType, animalName, animalWeight, animalRegion, breed);
                    animalList.Add(newCat);
                    newCat.MakeSound();

                    Console.WriteLine("Please enter food type and amount:");
                    var foodInput = Console.ReadLine().Split(' ');

                    var foodName = foodInput[0];
                    var foodQuant = Int32.Parse(foodInput[1]);
                    var newMeat = new Meat(foodName, foodQuant);
                    var newVegetable = new Vegetable(foodName, foodQuant);

                    if (foodName == "Meat") newCat.EatFood(newMeat);
                    else if (foodName == "Vegetable") newCat.EatFood(newVegetable);
                    newCat.ShowInfo();
                }
                else if (animalType == "Tiger")
                {
                    var newTiger = new Tiger(animalType, animalName, animalWeight, animalRegion);
                    animalList.Add(newTiger);
                    newTiger.MakeSound();

                    Console.WriteLine("Please enter food type and amount:");
                    var foodInput = Console.ReadLine().Split(' ');

                    var foodName = foodInput[0];
                    var foodQuant = Int32.Parse(foodInput[1]);
                    var newMeat = new Meat(foodName, foodQuant);
                    var newVegetable = new Vegetable(foodName, foodQuant);

                    if (foodName == "Meat") newTiger.EatFood(newMeat);
                    else if (foodName == "Vegetable") newTiger.EatFood(newVegetable);
                    newTiger.ShowInfo();
                }
                else if (animalType == "Mouse")
                {
                    var newMouse = new Mouse(animalType, animalName, animalWeight, animalRegion);
                    animalList.Add(newMouse);
                    newMouse.MakeSound();

                    Console.WriteLine("Please enter food type and amount:");
                    var foodInput = Console.ReadLine().Split(' ');

                    var foodName = foodInput[0];
                    var foodQuant = Int32.Parse(foodInput[1]);
                    var newMeat = new Meat(foodName, foodQuant);
                    var newVegetable = new Vegetable(foodName, foodQuant);

                    if (foodName == "Meat") newMouse.EatFood(newMeat);
                    else if (foodName == "Vegetable") newMouse.EatFood(newVegetable);
                    newMouse.ShowInfo();
                }
                else if (animalType == "Zebra")
                {
                    var newZebra = new Zebra(animalType, animalName, animalWeight, animalRegion);
                    animalList.Add(newZebra);
                    newZebra.MakeSound();

                    Console.WriteLine("Please enter food type and amount:");
                    var foodInput = Console.ReadLine().Split(' ');

                    var foodName = foodInput[0];
                    var foodQuant = Int32.Parse(foodInput[1]);
                    var newMeat = new Meat(foodName, foodQuant);
                    var newVegetable = new Vegetable(foodName, foodQuant);

                    if (foodName == "Meat") newZebra.EatFood(newMeat);
                    else if (foodName == "Vegetable") newZebra.EatFood(newVegetable);
                    newZebra.ShowInfo();
                }

            } while (Console.ReadLine() != "End");

            foreach (var v in animalList)
            {
                v.ShowInfo();
            }

            Console.Read();
        }
    }
}