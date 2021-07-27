using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    class Students : Person
    {
        private double _gpa;

        public double GPA { get; private set; }

        public Students(double gpa)
        {
            _gpa = gpa;
        }
        
        public override void Display()
        {
            Console.WriteLine(this.FirstName);
            Console.WriteLine(this.LastName);
            Console.WriteLine(this.Address);
            Console.WriteLine(this.Id);
            Console.WriteLine(this._gpa);
        }

    }
}
