using System;
using System.Collections.Generic;


namespace Collections
{
    class ComparisionDelegate
    {
        public int id {  get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public double marks { get; set;}

        public ComparisionDelegate(int id, string name, int age, double marks) 
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.marks = marks;
        }

        static void Main(string[] args)
        {
            int compare(ComparisionDelegate s1, ComparisionDelegate s2)
            {
                return s1.name.CompareTo(s2.name);
            }
            ComparisionDelegate s1 = new ComparisionDelegate(1, "Sample1", 12, 8.15);
            ComparisionDelegate s2 = new ComparisionDelegate(2, "Tample2", 14, 6.15);
            ComparisionDelegate s3 = new ComparisionDelegate(3, "Svmple3", 16, 8.00);
            ComparisionDelegate s4 = new ComparisionDelegate(4, "Sample4", 22, 6.5);
            ComparisionDelegate s5 = new ComparisionDelegate(5, "Samplr5", 52, 5.15);

            List<ComparisionDelegate> list = new List<ComparisionDelegate>() { s1,s2,s3,s4 };
            // method-1: creating comparison delegate 
            // Comparison<ComparisionDelegate> obj = new Comparison<ComparisionDelegate>(compare);
            // method-2: list.Sort(compare); // but how this happen, we have studied that we can't pass the method inside another method. but here we can do it because it internally create delegate and than pass the instance of that delegate.
            //method-3: list.Sort(delegate (ComparisionDelegate s1, ComparisionDelegate s2)
            //{
            //    return s1.name.CompareTo(s2.name);
            //});
            list.Sort((s1,s2) => s1.name.CompareTo(s2.name));

            foreach (ComparisionDelegate a in list)
            {
                Console.WriteLine("Name: " + a.name + " Age: " + a.age + " Marks: " + a.marks);
            }
        }
    }
}
