using System;

namespace Exercise1
{
    public class Product
    {
        public string Name { get; set; }
        public double PriceAtStart { get; set; }
        public int Amount { get; set; }

        public Product(string name, double priceAtStart, int amount)
        {
            this.Name = name;
            this.PriceAtStart = priceAtStart;
            this.Amount = amount;
        }

        public string  PrintProduct()
        {
            return $"{this.Name}, price {this.PriceAtStart:0.00} EUR, amount {this.Amount}";
        }

        public void PriceChange(double newPrice)
        {
            this.PriceAtStart = newPrice;
        }

        public void AmountChange(int newAmount)
        {
            this.Amount = newAmount;
        }
    }
}
