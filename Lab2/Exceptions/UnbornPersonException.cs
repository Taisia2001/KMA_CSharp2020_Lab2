using System;

namespace KMA.ProgrammingInCSharp2020.Lab2.Exceptions
{
    internal class UnbornPersonException : Exception
    {
        public UnbornPersonException(string message)
        : base(message)
        {
        }
        public UnbornPersonException(string message, Exception inner)
        : base(message,inner)
        {
        }
    }
}
