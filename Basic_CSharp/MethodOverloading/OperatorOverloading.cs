
namespace Polymorphism
{
    class OperatorOverloading
    {
        int num1, num2;
        public OperatorOverloading(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        public static OperatorOverloading operator +(OperatorOverloading obj1, OperatorOverloading obj2)
        {
            OperatorOverloading obj = new OperatorOverloading(0, 0);
            obj.num1 = obj1.num1 + obj2.num1;
            obj.num2 = obj1.num2 + obj2.num2;
            return obj;
        }
        public void Display()
        {
            Console.WriteLine("num1: " + num1);
            Console.WriteLine("num2: " + num2);
        }
        // public static void Main(string[] args)
        //{
        //    OperatorOverloading obj1 = new OperatorOverloading(10, 20);
        //    OperatorOverloading obj2 = new OperatorOverloading(30, 40);
        //    OperatorOverloading obj3 = obj1 + obj2;
        //    obj3.Display();
        //}

    }
}

// Operator Overloading is an approach of defining multiple behaviours of an operator in a class. It is a type of compile time polymorphism. It is also known as Operator Ad-hoc Polymorphism
// operator like '+' which is used to add two numbers, can be used to concatenate two strings. So, the operator + has multiple behaviours. This is known as Operator Overloading.