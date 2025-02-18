
namespace Inheritance
{
    class Child : Parent
    {
        public Child() : base(10, 20)
        {
            Console.WriteLine("Child constructor");
        }
        public override void method1()
        {
            Console.WriteLine("Child method1");
        }
        public void method3()
        {
            Console.WriteLine("Child method3");
        }
        // static void Main(string[] args)
        // {
            // Object obj = new Object();
            // Note - Every class has a default parent class called Object, and they have these 4 methods.
            // obj contains 4 methods: Equals, GetHashCode, GetType, ToString
            // Equals: Determines whether the specified object is equal to the current object.
            // GetHashCode: Serves as the default hash function.
            // GetType: Gets the Type of the current instance.
            // ToString: Returns a string that represents the current object.


            //Parent p = new Child();
            //Console.WriteLine(p.GetType());
            //p.ToString();
            //p.method1();
            //p.method2();
            //p.method3();
        // }
    }
}
// If the parent class constructor is private, the child class will not be able to access it and hence inheritance is not possible.
// In inheritance, the child class inherits the properties and behavior of the parent class, but parent class can not inherit the properties and behavior of the child class.
// We can initialize a parent class variable using a child class object, but the reverse is not possible. ( Parent p = new Child(); )
// In the above code, the output for p.method3() will be an error because the parent class does not have a method3() method.
// For accessing the method3() method, we need to create an object of the child class. ( Child c = new Child(); c.method3(); )
// Note - In the first point we learn that whenever child class instance is created, child class constructor will implicitly call parent class constructor
//        but only if the constructor is parameterless. If the parent class constructor is parameterized, then we need to call it explicitly using base keyword. example: base(10, 20);
