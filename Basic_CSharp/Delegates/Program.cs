// Delegate : It is a type safe function pointer. It is a reference type that encapsulates a method with a specific signature.
// What is type safe function pointer? It is a pointer that points to a function that has a specific signature.
// Signature: It is the return type and the parameter list of a method. Example : int Add(int a, int b) => a + b; Signature: int Add(int, int)

// Now let's see how to use delegate in C#.
// Step 1 : Create a delegate
// Step 2 : Create a method that has the same signature as the delegate
// Step 3 : Create an instance of the delegate and pass the method as an argument to the delegate

namespace Delegates
{
    // Step 1 : Create a delegate
    public delegate void PrintMessage(string message);
    class Program
    {
        // Step 2 : Create a method that has the same signature as the delegate
        public static void PrintMessageMethod(string message)
        {
            Console.WriteLine(message);
        }
        //static void Main(string[] args)
        //{
        //    // Step 3 : Create an instance of the delegate and pass the method as an argument to the delegate
        //    PrintMessage printMessage = new PrintMessage(PrintMessageMethod);
        //    printMessage("Hello World");
        //}
    }
}

// Above code show that, delegate have to define under namespace.
// In industry, we use delegate to implement callback mechanism.
// Callback mechanism is a mechanism where we pass a method as an argument to another method and that method calls the passed method.
// Real world example of callback mechanism is event handling in C#. In simple words, event handling is a mechanism where we pass a method as an argument to an event and that event calls the passed method.
