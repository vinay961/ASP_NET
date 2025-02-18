
namespace Delegates
{
    //public delegate double delegateAdd( double x, double y, double z );
    //public delegate void delegateAdd1( double x, double y, double z );
    //public delegate bool delegateCheckLength(string name);
    // Note - We can use Func, Action, Predicate instead of defining custom delegate.
    class GenericDelegate
    {
        //public static double Add(double a, double b) => a + b;
        // public static double Add(double a, double b, double c) { return a + b + c; }
        // public static void Add1(double a, double b, double c) { Console.WriteLine(a + b + c); }
        // public static bool CheckLength(string name) => name.Length > 5;

        static void Main(string[] args)
        {
            Func<double, double, double, double> obj1 = (x, y, z) => { return (x + y + z); };
            double res1 = obj1.Invoke(2.1, 1, 3);
            Console.WriteLine(res1);

            Action<double, double, double> obj2 = (double x, double y, double z) => { Console.WriteLine(x + y + z); };
            obj2.Invoke(2.1, 2, 3);

            Predicate<string> obj3 = (string name) => { return name.Length > 5; };
            bool res3 = obj3.Invoke("Vinay");
            Console.WriteLine(res3);
        }
    }
}

// Three pre-defined generic delegates in C# are: Func, Action, Predicate.
// Func: It is a generic delegate that can take up to 16 input parameters and returns a value. Used when a method have to return something.
// Action: It is a generic delegate that can take up to 16 input parameters and does not return a value. Used when a method does not have to return.
// Predicate: It is a generic delegate that takes one input parameter and returns a boolean value. Used when a method has to return a boolean value.
