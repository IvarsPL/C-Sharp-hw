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

        public void PrintProduct()
        {
            Console.WriteLine($"{this.Name}, price {this.PriceAtStart:0.00} EUR, amount {this.Amount}");
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
    
    class Program
    {
        static void Main(string[] args)
        {
            Product mouse = new Product("Logitech Mouse", 70.00, 14);
            mouse.PrintProduct();
            Product phone = new Product("Iphone 5s", 999.99, 3);
            phone.PrintProduct();
            Product projector = new Product("Epson EB-U05", 440.46, 1);
            projector.PrintProduct();

            projector.PriceChange(500.654);
            mouse.AmountChange(10);

            mouse.PrintProduct();
            projector.PrintProduct();


            Console.Read();
        }
    }
}
