namespace Hierarchy
{
    public abstract class Animal
    {
        protected Animal(string animalType, string animalName, double animalWeight) { }

        public abstract void MakeSound();
        public abstract void EatFood(Food food);
        public abstract void ShowInfo();
    }
}
