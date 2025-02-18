
// Method Overriding : It's an approach of re-implementing a parent class method in a child class. It is used to provide the specific implementation of a method that is already provided by its super class. It is used for runtime polymorphism and to provide the specific implementation of the method that is already provided by its superclass.

// It is runtime polymorphism because the method that is to be called is determined at runtime. It is also known as Dynamic Method Dispatch. It is a process in which a function call to the overridden method is resolved at runtime rather than compile-time.

namespace Polymorphism
{
    class Parent
    {
        public void Display()
        {
            Console.WriteLine("Parent class method");
        }
        public virtual void Show() { Console.WriteLine("Parent class show method"); }
        class Overriding : Parent
        {
            public void Display()
            {
                Console.WriteLine("Child class method");
            }
            public override void Show()
            {
                Console.WriteLine("Child class show method");
            }

            //public static void Main()
            //{
            //    Overriding obj = new Overriding();
            //    obj.Display();
            //    obj.Show();
            //}
        }
    }
}

// difference between overriding and overloading is:
// 1. In Method Overloading, there is a relationship between methods available in the same class whereas, in Method Overriding, there is a       relationship between a superclass method and subclass method.
// 2. Method Overloading is an example of compile time polymorphism whereas Method Overriding is an example of runtime polymorphism.
// 3. In Method Overloading, parameter must be different whereas, in Method Overriding, parameter must be same.
// 4. Method Overloading doesn't need permission from the superclass to be overloaded whereas, Method Overriding requires permission from the     superclass to be overridden.To override a method, the superclass must declare the method as virtual or abstract.

