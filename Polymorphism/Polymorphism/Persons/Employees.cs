using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    class Employees : Person
    {
        private readonly string _jobTitle;

        public string GPA { get; private set; }

        public Employees(string jobTitle)
        {
            _jobTitle = jobTitle;
        }
        public override void Display()
        {
           Console.WriteLine(FirstName);
           Console.WriteLine(LastName);
           Console.WriteLine(Address);
           Console.WriteLine(Id);
           Console.WriteLine(_jobTitle);
        }
    }
}
