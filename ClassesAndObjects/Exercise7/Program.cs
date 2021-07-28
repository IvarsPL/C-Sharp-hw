using System;

namespace Exercise7
{
    class DogTest
    {
        static void Main(string[] args)
        {
            Dog sparkyDog = new Dog("Sparky", "male");
            Dog samDog = new Dog("Sam", "male");
            Dog ladyDog = new Dog("Lady", "female");
            Dog mollyDog = new Dog("Molly", "female");

            Dog busterDog = new Dog("Buster", "male", sparkyDog.Name, ladyDog.Name);
            Dog rockyDog = new Dog("Rocky", "male", samDog.Father, mollyDog.Name);
            Dog cocoDog = new Dog("Coco", "female", busterDog.Name, mollyDog.Name);
            Dog maxDog = new Dog("Max", "male", rockyDog.Name, ladyDog.Name);

            Console.WriteLine(cocoDog.FathersName());
            Console.WriteLine(sparkyDog.FathersName());

            Console.WriteLine(cocoDog.HasSameMotherAs(rockyDog));


            Console.Read();
        }
    }
}
