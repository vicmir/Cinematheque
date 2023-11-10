using System;

namespace HelloWebApi.Exceptions
{
    public class BadOperationException : Exception
    {
        public BadOperationException(string message)
            : base(message)
        {
        }
    }
}
