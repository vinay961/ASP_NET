namespace DemoProject
{
    class TestClass
    {
        static void Main(string[] args)
        {
            Program p = new Program(101, "Rohan", 50000, "Manager", "IT");
            Console.WriteLine("Employee Name: " + p["ename"]); // Ename is inaccessible due to its protection level, so we can access this using public properties, methods, Properties or indexers.
            Console.WriteLine("Employee Salary: " + p["salary"]);

            p["dept"] = "Sr. Manager";
            Console.WriteLine("Employee Job: " + p["dept"]);
        }
    }
}