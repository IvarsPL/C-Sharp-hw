using PhoneBook;
using System;

namespace Phonebook
{
    class Phone
    {
        static void Main(string[] args)
        {
            var directory = new PhoneDirectory();
            directory.PutNumber("Ivars", "26626878");
            Console.WriteLine(directory.GetNumber("Ivars"));
            directory.PutNumber("Peteris", "123123");
            Console.WriteLine(directory.GetNumber("Peteris"));
            Console.ReadKey();
        }
    }
}
