using System;
namespace DemoProject
{
    struct MyStruct
    {
        int i;
        public MyStruct(int i)
        {
            this.i = i;
        }
        public void Display() 
        {
            Console.WriteLine("Display method of MyStruct class: " + i); // default constructor set the value of i to 0
        }
        public static void Main(string[] args)
        {
            // MyStruct s = new MyStruct(10);
            MyStruct myStruct;
            myStruct.i = 10;
            myStruct.Display();
        }
    }
}

// As we can see that structure is looking same as class, Now question arises is that what is the difference between struct and class?
// Class is a reference type whereas struct is a value type.
// Memory allocation for struct is done on stack whereas memory allocation for class is done on heap.
// We use class for representing an entity with larger volumes of data whereas struct is used for representing a small group of related data.
// Pre-defined data types are of two types: value type and reference type. Value type is stored in stack memory whereas reference type is stored in heap memory.
// Example of value type is int, float, char, double, etc. whereas example of reference type is class, string, array, etc. 
// Struct can't be null whereas class can be null.
// Struct can't be inherited whereas class can be inherited.
// Struct can't have parameter less constructor, we need to pass at least one parameter in struct constructor. Otherwise they have default constructor.