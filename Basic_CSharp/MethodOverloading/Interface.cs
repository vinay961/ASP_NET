namespace Polymorphism
{
    interface IShape1
    {
        void Add(int a,int b);
    }
    interface IShape3 
    { 
        void Add(int a,int b);
        void multiply(int a,int b);
    }
    interface IShape2 : IShape1
    {
        void Sub(int a, int b);
    }
    class Sample1 : IShape1,IShape3  // multiple Interface, as both have a common method add(int a, int b)
    {
        public void Add(int a , int b)
        {
            Console.WriteLine(a + b);
        }
        //public void Add(int a , int b)
        //{ 
        //    Console.WriteLine(a + b); 
        //}
        void IShape3.multiply(int a, int b)
        {
            Console.WriteLine(a*b);
        }
    }
    class Sample2 : IShape2
    {
        public void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public void Sub(int x, int y)
        {
            Console.WriteLine(x - y);
        }
    }

    class Interface
    {
        static void Main(string[] args)
        {
            Sample1 sample1 = new Sample1();
            IShape1 i1 = sample1;
            i1.Add(1, 2);

            IShape3 i3 = sample1;
            i3 .Add(3, 4);

            Sample2 sample2 = new Sample2();
            sample2.Add(3, 4);
            sample2.Sub(5, 6);
        }
    }
}

// Class contains Non-Abstract Methods (method with method body), while abstract class contain both non-abstract as well as abstract methods.
// If we discuss about Interface, it contains only abstract methods (methods without method body).
// Note - Every abstract method of interface should be implemented by child class of the interface.

// The default scope for members of interface is 'public' whereas it's private in case of class.
// By default every member of an interface is abstract so we don't require to use abstract modifier on it again just like we do in case of abstract class.

// We can't declare any fields/variables under an interface.
// If required an interface can inherit from another interface.
// Every member of an interface should be implemented under the child class of interface without fail, but while implementing we don't require to use override modifier just like we have done in case of abstract class.

// A class can have one and only one immediate parent class, whereas the same class can have any number of interfaces as it's parent.
// i.e., multiple inheritance is supported through interface in C#.
// Now question is that how it happen?
// So, interface ask child class to implement there methods whereas in normal parent classes methods are consume by child class which cause ambiguity. 