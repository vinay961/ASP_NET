// As we know that Method Overriding is an approach of re-implementing a parent class method in a child class with the same name. In the same way Method Hiding is an approach of re-implementing a parent class method in a child class with the same name. So the question arises that what is the difference between Method Overriding and Method Hiding?
// In Overriding, child class re-implement those methods which are declared virtual, whereas in Hiding, child class can re-implement all methods which are declared in parent class.

namespace Polymorphism
{
    class Tom
    {
        public void Display()
        {
            Console.WriteLine("Parent Display");
        }
    }
    class MethodHiding : Tom
    {
        public new void Display()
        {
            Console.WriteLine("Child Display");
        }
        //static void Main(string[] args)
        //{
        //    MethodHiding obj = new MethodHiding();
        //    obj.Display();
        //}
    }
}

// Now question arises that what is "new" keyword that is used above, what if we remove new keyword from the above code?
// The answer is that it will give a warning message
// The warning message will be like this: 'MethodHiding.Display()' hides inherited member 'Tom.Display()'. Use the new keyword if hiding was intended. So, it is always recommended to use new keyword while hiding a method. The new keyword is used to hide the base class method. It is used to declare a member that hides a member of the base class. It is used to resolve the ambiguity between the base class method and derived class method. It is used to hide the base class method with the same name.
