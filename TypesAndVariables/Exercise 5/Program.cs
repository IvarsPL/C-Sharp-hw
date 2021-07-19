using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] courses = {"English III", "Precalculus", "Music Theory", "Biotechnology", "Principles of Technology I", "Latin II", "AP US History", "Business Computer Information Systems"};
            string[] teachers = { "Ms. Lapan", "Mrs. Gideon", "Mr. Davis", "Ms. Palmer", "Ms. Garcia", "Mrs. Barnett", "Ms. Johannessen", "Mr. James"};

          Console.WriteLine("+------------------------------------------------------------+");
            for (int i = 0; i < courses.Length; i++)
            {
                Console.Write($"| {i+1} |");
                Console.Write("{0,38}", courses[i]);
                Console.Write(" | ");
                Console.Write("{0,15}", teachers[i]);
                Console.WriteLine(" |");

            }
            Console.WriteLine("+------------------------------------------------------------+");
            Console.ReadKey();
        }
    }
}
