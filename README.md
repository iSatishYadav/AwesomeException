# AwesomeException
Awesome Exception Extensions for C# (.NET Core, .NET Standard, and .NET Full Framework)

## GetExceptionStack
Get literally the stack of Inner `Exceptions` from an Exception.

Let's say you have an Exception with 4 level deep Inner `Exceptions`:
````csharp
var exception = new Exception("This is #1", new Exception("This is #2", new Exception("This is #3", new Exception("This is #4"))));
````
Now get the `Stack` of `Exception` with the Extension method"
````csharp
Stack<Exception> exceptionStack = exception.GetExceptionStack();
````
