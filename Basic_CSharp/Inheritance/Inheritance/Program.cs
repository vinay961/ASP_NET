// let's see the inheritance in action
namespace Inheritance
{
    public class School
    {
        public int id;
        protected string name;
        protected readonly string address;
        protected string phone;

        public School(int id, string name, string address, string phone)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
        }
    }

    class Student : School
    {
        int marks;
        int standard;
        int fees;
        public Student(int id, string name, string address, string phone, int marks, int standard, int fees) : base(id, name, address, phone)
        {
            this.marks = marks;
            this.standard = standard;
            this.fees = fees;
        }

        public void Display()
        {
            Console.WriteLine("Student ID: " + id);
            Console.WriteLine("Student Name: " + name);
            Console.WriteLine("Student Address: " + address);
            Console.WriteLine("Student Phone: " + phone);
            Console.WriteLine("Student Marks: " + marks);
            Console.WriteLine("Student Standard: " + standard);
            Console.WriteLine("Student Fees: " + fees);
        }
    }

    class  Staff : School
    {
        protected string designation;
        protected int salary;
        public Staff(int id,string name,string address,string phone,string designation,int salary) : base(id, name, address, phone)
        {
            this.designation = designation;
            this.salary = salary;
        }
    }

    class Teaching : Staff
    {
        string qualification;
        string subject;
        public Teaching(int id, string name, string address, string phone, string designation, int salary, string qualification, string subject) : base(id, name, address, phone, designation, salary)
        {
            this.qualification = qualification;
            this.subject = subject;
        }

        public void Display()
        {
            Console.WriteLine("Staff ID: " + id);
            Console.WriteLine("Staff Name: " + name);
            Console.WriteLine("Staff Address: " + address);
            Console.WriteLine("Staff Phone: " + phone);
            Console.WriteLine("Staff Designation: " + designation);
            Console.WriteLine("Staff Salary: " + salary);
            Console.WriteLine("Staff Qualification: " + qualification);
            Console.WriteLine("Staff Subject: " + subject);
        }
    }

    class NonTeaching : Staff
    {
        string work;
        public NonTeaching(int id, string name, string address, string phone, string designation, int salary, string work) : base(id, name, address, phone, designation, salary)
        {
            this.work = work;
        }
        public void Display()
        {
            Console.WriteLine("Staff ID: " + id);
            Console.WriteLine("Staff Name: " + name);
            Console.WriteLine("Staff Address: " + address);
            Console.WriteLine("Staff Phone: " + phone);
            Console.WriteLine("Staff Designation: " + designation);
            Console.WriteLine("Staff Salary: " + salary);
            Console.WriteLine("Staff Work: " + work);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student(1, "John", "New York", "1234567890", 90, 10, 1000);
            s.Display();
            Teaching t = new Teaching(2, "Smith", "New York", "1234567890", "Teacher", 50000, "Masters", "Maths");
            t.Display();
            NonTeaching nt = new NonTeaching(3, "David", "New York", "1234567890", "Clerk", 20000, "Clerk");
            nt.Display();
        }
    }
}

