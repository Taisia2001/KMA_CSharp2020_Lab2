using System;

namespace KMA.ProgrammingInCSharp2020.Lab2.Exceptions
{
    internal class TooOldPersonException : Exception
    {
        public TooOldPersonException(string message)
        : base(message)
        {
        }
        
        public TooOldPersonException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
