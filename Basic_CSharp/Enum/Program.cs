// Enum is a value type data type. It is used to declare a list of named integer constants. It can be defined using the enum keyword directly inside a namespace, class, or structure.
// Enum is used to give a name to each constant so that the constant integer can be referred using its name.

namespace Enum
{
    class Program
    {
        enum Days { Sun, Mon, tue, Wed, thu, Fri, Sat };
        static void Main(string[] args)
        {
            int WeekdayStart = (int)Days.Mon; // typecasting, here we are converting enum to int, value of WeekdayStart will be 1
            int WeekdayEnd = (int)Days.Fri; // value of WeekdayEnd will be 5
            Console.WriteLine("Monday: {0}", WeekdayStart);
            Console.WriteLine("Friday: {0}", WeekdayEnd); // here {0} is a placeholder, it will be replaced by the value of WeekdayEnd
        }
    }
}

// From above code we can observe that we have created an enum named Days and we have assigned some values to it.
// Important points about enum: all the values in enum are of integer type and the default value of first element is 0, and the value of each successive element is increased by 1. Like in above example, value of Sun is 0, Mon is 1, tue is 2, and so on.
// We can also assign values to enum elements explicitly. For example, we can assign value to Sun as 1, Mon as 2, and so on.
