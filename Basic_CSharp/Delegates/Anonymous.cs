
namespace Delegates
{
    public delegate string GreetingDelegate(string name);
    class Anonymous
    {
        //public static string Greeting(string name)
        //{
        //    return "Hello " + name;
        //}

        //static void Main(string[] args)
        //{
        //    GreetingDelegate greetingDelegate = delegate (string name)
        //    {
        //        return "Hello " + name;
        //    };
        //    string result = greetingDelegate("Vinay");
        //    Console.WriteLine(result);
        //}
    }
}

// Anonymous method is a method without a name. It is a method that is defined inline using the delegate keyword. It is a method that is defined without a name and is used to pass a method as an argument to another method.

// Lambda Expression is a concise way to represent an anonymous method.

// above anonymous method can be written as lambda expression as below:
// GreetingDelegate greetingDelegate = (string name) => { return "Hello " + name; };