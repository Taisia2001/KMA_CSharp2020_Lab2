using System;

namespace KMA.ProgrammingInCSharp2020.Lab2.Exceptions
{
    internal class InvalidEmailException : Exception
    {
        public InvalidEmailException(string message)
        : base(message)
        {
        }
        
        public InvalidEmailException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
