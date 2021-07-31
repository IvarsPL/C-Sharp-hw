using System;

namespace Exercise_8
{
    public class EmployeeException : Exception
    {
        public EmployeeException()
        {
        }

        public EmployeeException(string message)
            : base(message)
        {
        }

        public EmployeeException(string message, Exception inner)
           : base(message, inner)
        {
        }
    }
}
