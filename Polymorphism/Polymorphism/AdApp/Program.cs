using System;

namespace AdApp
{
    class Program
    {
        private static void Main(string[] args)
        {
            var c = new Campaign();
            c.AddAdvert(new Advert(1000));
            c.AddAdvert(new Hoarding(500, 7, 200));
            c.AddAdvert(new NewspaperAd(0, 30, 20));
            c.AddAdvert(new TvAd(50000));
            c.AddAdvert(new Poster(300, 23, 233, 250, 3));

            Console.WriteLine(c.GetCost());

            Console.Read();
        }
    }
}