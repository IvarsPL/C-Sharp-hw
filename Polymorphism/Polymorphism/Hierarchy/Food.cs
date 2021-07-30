namespace Hierarchy
{
    public abstract class Food
    {
        public int Quantity;
        public string TypeOfFood;

        public Food(string typeOfFood, int quantity)
        {
            Quantity = quantity;
            TypeOfFood = typeOfFood;
        }

    }
}
