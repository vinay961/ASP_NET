// Method Overloading : Method overloading is a feature that allows a class to have more than one method having the same name, if their argument lists are different. It is similar to constructor overloading in Java, that allows a class to have more than one constructor having different argument lists.

// It is compile-time polymorphism because the method that is to be called is determined at compile-time. It is also known as Static Method Dispatch. It is a process in which a function call is resolved during compile-time.

namespace Polymorphism
{
    class Overloading
    {
        public void Display()
        {
            Console.WriteLine("Method without parameter");
        }
        public void Display(int a)
        {
            Console.WriteLine("Method with single parameter : " + a);
        }
        public void Display(int a, int b)
        {
            Console.WriteLine("Method with two parameters : " + a + " " + b);
        }
        public void Display(string a)
        {
            Console.WriteLine("Method with string parameter : " + a);
        }
        //static void Main(string[] args)
        //{
        //    Overloading obj = new Overloading();
        //    obj.Display();
        //    obj.Display(10);
        //    obj.Display(10, 20);
        //    obj.Display("Method Overloading");
        //}
    }
}

// Suppose if someone think that what if we keep the function name same but change the return type of the function. Will it be considered as method overloading? The answer is No. It will not be considered as method overloading. The return type of the function does not play any role in method overloading. The following code will give a compile-time error.