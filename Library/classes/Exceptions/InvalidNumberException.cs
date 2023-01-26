using System;
namespace Library.classes.Exceptions
{
    public class InvalidNumberException : Exception
    {
        public InvalidNumberException(){}

        public InvalidNumberException(string message)
        : base(message)
        {
        }
    }
}