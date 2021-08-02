﻿using System;

namespace Exercise1
{


    class Program
    {
        static void Main(string[] args)
        {
            Product mouse = new Product("Logitech Mouse", 70.00, 14);
            mouse.PrintProduct();
            Product phone = new Product("Iphone 5s", 999.99, 3);
            phone.PrintProduct();
            Product projector = new Product("Epson EB-U05", 440.46, 1);
            var print = projector.PrintProduct();
            Console.WriteLine(print);

            projector.PriceChange(500.654);
            mouse.AmountChange(10);

            print = mouse.PrintProduct();
            Console.WriteLine(print);
            
            print = projector.PrintProduct();
            Console.WriteLine(print);


            Console.Read();
        }
    }
}
