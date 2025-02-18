// Indexers : Indexers are used to access the elements of a class. They are similar to properties but are accessed using an index.
// Syntax: <access-specifier> <return-type> this[int index]
// this represents the current class, means indexer is defined in the current class.

namespace DemoProject
{
    class Program
    {
        int Eno;
        string _Ename;
        double Salary;
        string Job;
        string Dept;

        public Program(int eno, string ename, double salary, string job, string dept)
        {
            this.Eno = eno;
            this._Ename = ename;
            this.Salary = salary;
            this.Job = job;
            this.Dept = dept;
        }
        
        // Now let's create indexer
        public object this[string name] // why we are using object? because we don't know the type of value that we are going to get or set
        {
            get
            {
                //if (index == 0)
                //    return Eno;
                //else if (index == 1)
                //    return _Ename;
                //else if (index == 2)
                //    return Salary;
                //else if (index == 3)
                //    return Job;
                //else if (index == 4)
                //    return Dept;
                //else
                //    return null;
                if (name.ToUpper() == "ENO")
                    return Eno;
                else if (name.ToUpper() == "ENAME")
                    return _Ename;
                else if (name.ToUpper() == "SALARY")
                    return Salary;
                else if (name.ToUpper() == "JOB")
                    return Job;
                else if (name.ToUpper() == "DEPT")
                    return Dept;
                else
                    return null;
            }
            set
            {
                //if (index == 0)
                //    Eno = (int)value;
                //else if (index == 1)
                //    _Ename = (string)value;
                //else if (index == 2)
                //    Salary = (double)value;
                //else if (index == 3)
                //    Job = (string)value;
                //else if (index == 4)
                //    Dept = (string)value;
                if (name.ToUpper() == "ENO")
                    Eno = (int)value;
                else if (name.ToUpper() == "ENAME")
                    _Ename = (string)value;
                else if (name.ToUpper() == "SALARY")
                    Salary = (double)value;
                else if (name.ToUpper() == "JOB")
                    Job = (string)value;
                else if (name.ToUpper() == "DEPT")
                    Dept = (string)value;
            }
        }
    }
}