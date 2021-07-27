using System;

namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {
           var student = new Students(gpa: 4.5)
            {
                FirstName = "Ivars",
                LastName = "Plaudis - Lasmanis",
                Address = "Riga",
                Id = 27
            };

            var employee = new Employees(jobTitle: "Janitor")
            {
                FirstName = "Rick",
                LastName = "Sanchez",
                Address = "USA",
                Id = 289101
            };

            student.Display();
            employee.Display();

            Console.Read();
        }
    }
}