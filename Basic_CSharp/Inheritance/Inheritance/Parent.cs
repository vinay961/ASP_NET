
namespace Inheritance
{
    class Parent
    {
        public Parent(int x, int y)
        {
            Console.WriteLine("Parent constructor");
            Console.WriteLine($"Sum: {x+y}");
        }
        public virtual void method1()
        {
            Console.WriteLine("Parent method1");
        }
        public void method2()
        {
            Console.WriteLine("Parent method2");
        }
    }
}

// Types of Inheritance:
// 1. Single Inheritance: In single inheritance, a class is allowed to inherit from only one class.
// 2. Multiple Inheritance: In multiple inheritance, a class is allowed to inherit from more than one class.
// 3. Multilevel Inheritance: In multilevel inheritance, a class is derived from a class which is also derived from another class.
// 4. Hierarchical Inheritance: In hierarchical inheritance, one class serves as a superclass (base class) for more than one subclass.
// 5. Hybrid Inheritance: Hybrid inheritance is a combination of two or more types of inheritance.

// Note: In C#, multiple inheritance is not supported. However, it can be achieved using interfaces.