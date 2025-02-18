
namespace Practice
{
    class Student
    {
        public string? Name { get; }
        public int Roll_Number { get; }
        public double Marks { get; }

        public Student(string? name, int roll_Number, double marks)
        {
            Name = name;
            Roll_Number = roll_Number;
            Marks = marks;
        }
    }

    public class Repository<T> where T : class
    {
        private readonly List<T> records = new List<T>();

        public void Add(T record)
        {
            records.Add(record);
        }
        public void Remove(T record)
        {
            records.Remove(record);
        }
        public List<T> GetAll()
        {
            return records.ToList();
        }
    }
    class CURD
    {
        //static void Main(string[] args)
        //{
        //    Repository<Student> repository = new Repository<Student>();
        //    Student stud1 = new Student("Vinay", 129, 89.5);
        //    Student stud2 = new Student("Janhavi", 145, 88.4);
        //    Student stud3 = new Student("Ram", 001, 98.6);
        //    repository.Add(stud1);
        //    repository.Add(stud2);
        //    repository.Add(stud3);

        //    Console.WriteLine("All Students:");
        //    foreach (var stud in repository.GetAll())
        //    {
        //        Console.WriteLine(stud.Name + ", Roll_Number: " + stud.Roll_Number);
        //    }

        //    repository.Remove(stud1);
        //    Console.WriteLine();
        //    Console.WriteLine("Now All Students:");
        //    foreach (var stud in repository.GetAll())
        //    {
        //        Console.WriteLine(stud.Name + ", Roll_Number: " + stud.Roll_Number);
        //    }
        //}
    }
}
