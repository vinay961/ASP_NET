namespace Practice
{
    public enum DepartmentTypes { HR, IT, Finance, Marketing };
    public class Employee
    {
        public int Id { get; }
        public string? Name { get; }
        public DepartmentTypes Department { get; }

        public double Salary { get; private set ; }
        public double Experience { get; set; }

        public Employee(int id, string name, DepartmentTypes dept, double salary, double experience)
        {
            if (salary < 0)
            {
                throw new ArgumentException("salary can't be negative.");
            }
            if (experience < 0)
            {
                throw new ArgumentException("Experience can't be negative.");
            }
            this.Id = id;
            this.Name = name;
            this.Department = dept;
            this.Salary = salary;
            this.Experience = experience;
        }

        public void displayInfo()
        {
            Console.WriteLine(this.Name + " of " + this.Department + " department, with " + this.Experience + " of experience and " + this.Salary + " earning potential.");
        }
    }

    public delegate double BonusCalculate(Employee emp);

    class Company
    {
        private List<Employee> employees = new List<Employee>();

        public void AddEmployees(Employee employee)
        {
            employees.Add(employee);
        }

        public void DisplayAllEmployees()
        {
            foreach (Employee employee in employees)
            {
                employee.displayInfo();
            }
        }
    }
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Company company = new Company();

        //    Employee emp1 = new Employee(101, "Alice", DepartmentTypes.IT, 60000, 7);
        //    Employee emp2 = new Employee(102, "Bob", DepartmentTypes.HR, 45000, 3);
        //    Employee emp3 = new Employee(103, "Charlie", DepartmentTypes.Finance, 80000, 10);
        //    Employee emp4 = new Employee(104, "David", DepartmentTypes.IT, 30000, 1);
        //    Employee emp5 = new Employee(105, "Eva", DepartmentTypes.Marketing, 55000, 5);

        //    company.AddEmployees(emp1);
        //    company.AddEmployees(emp2);
        //    company.AddEmployees(emp3);
        //    company.AddEmployees(emp4);
        //    company.AddEmployees(emp5);

            //company.DisplayAllEmployees();

            // let's define delegate for bonus_calculation
            //double calculate(Employee emp)
            //{
            //    if (emp.Experience > 5)
            //    {
            //        return emp.Salary * 0.10;
            //    }
            //    else
            //    {
            //        return emp.Salary * 0.05;
            //    }
            //}

        //    BonusCalculate bonusCalculate = (emp) =>
        //    {
        //        if (emp.Experience > 5)
        //        {
        //            return emp.Salary * 0.10;
        //        }
        //        else
        //        {
        //            return emp.Salary * 0.05;
        //        }
        //    };

        //    var res = bonusCalculate(emp4);
        //    Console.WriteLine("Bonus for " + emp1.Name + " is: " + res);
        //}
    }
}