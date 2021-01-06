using System;
using System.Collections.Generic;

namespace AwesomeException
{
    public static class ExceptionExtensions
    {
        public static Stack<Exception> GetExceptionStack(this Exception exception)
        {
            var exceptionStack = new Stack<Exception>();
            do
            {
                exceptionStack.Push(exception);
                exception = exception.InnerException;
            } while (exception != null);
            return exceptionStack;
        }
    }
}
