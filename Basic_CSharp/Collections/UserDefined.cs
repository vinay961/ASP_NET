using System;
using System.Collections.Generic;
namespace Collections
{
    class UserDefined : IComparable<UserDefined>
    {
        public string Name { get; set; } // here get and set
        public int age { get; set; }
        public double salary { get; set; }
        public string job {  get; set; }

        public UserDefined(string name, int age, double salary, string job)
        {
            this.Name = name;
            this.age = age;
            this.salary = salary;
            this.job = job;
        }
        public int CompareTo(UserDefined? other)
        {
            if(this.salary > other.salary) return -1;
            else if(this.salary < other.salary) { return 1; } else { return 0; }
        }

        class CompareUser : IComparer<UserDefined>
        {
            public int Compare(UserDefined? x, UserDefined? y)
            {
                if (x.age > y.age) return -1;
                else if (x.age < y.age) { return 1; } else { return 0; }
            }
        }

        //static void Main(string[] args)
        //{
        //    UserDefined obj = new UserDefined("Vinay", 22, 15000.00, "SDE");
        //    UserDefined obj1 = new UserDefined("Janhavi", 20, 30000.00, "Teacher");
        //    UserDefined obj2 = new UserDefined("Nihal", 18, 20000.00, "Quality Checker");
        //    UserDefined obj3 = new UserDefined("Ram", 28, 70000.00, "SDE-2");



        //    List<UserDefined> list = new List<UserDefined>() { obj, obj1, obj2, obj3 };
        //    // if i want to sort the list? To do it we need to use two interfaces 1. IComparable 2.IComparer
        //    // list.Sort(); // it gives error, get confused that on what bases the sorting need to perform.
        //    list.Sort(); // after inheriting the IComparable and implementing the CompareTo() method it works.

        //    // now the question is that if someone define that it get sorted with help of salary, if i want to sort it on the bases of age than what i have to do and the source code of above class is not with me? 
        //    // In such scenario write a new class and inherit from IComparer<type>.
        //    CompareUser compareUser = new CompareUser();
        //    list.Sort(1,3, compareUser);

        //    foreach (UserDefined o in list)
        //    {
        //        Console.WriteLine(o.Name + "," + o.age + " years old" + " is " + o.job + " with salary of " + o.salary);
        //    }
        //}
    }
}
