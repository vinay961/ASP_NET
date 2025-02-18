
// What is Properties in C#? Properties are members of a class that provide a flexible mechanism to read, write, or compute the values of private fields. Properties can be used as if they are public data members, but they are actually special methods called accessors. This enables data to be accessed easily and still helps promote the safety and flexibility of methods.
// To define property in C# class, we use get and set accessors. The get accessor returns the value of the property, and the set accessor assigns the value to the property

namespace DemoProject
{
    class BankAccount
    {
        public enum Cities { Delhi, Mumbai, Kolkata, Chennai, Bangalore }

        int _accountNumber;
        string _accountHolder;
        double _balance;
        bool _status;
        Cities _city;

        public BankAccount(int accountNumber, string accountHolder, double balance, bool status, Cities city)
        {
            this._accountNumber = accountNumber;
            this._accountHolder = accountHolder;
            this._balance = balance;
            _status = status;
            this._city = city;
        }
        public int accountNumber
        {
            get
            {
                return _accountNumber;
            }
            protected set
            {
                if (status == true)
                {
                    _accountNumber = value;
                }
                else
                {
                    Console.WriteLine("Account is inactive");
                }
            }
        }

        public string accountHolder
        {
            get
            {
                return _accountHolder;
            }
            protected set
            {
                if (status == true)
                {
                    _accountHolder = value;
                }
                else
                {
                    Console.WriteLine("Account is inactive, name can't set. Contact your bank!");
                }
            }
        }

        public bool status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }

        public double balance
        {
            get
            {
                return _balance;
            }
            protected set
            {
                if(status == true)
                {
                    _balance = value;
                }
                else
                {
                    Console.WriteLine("Account is inactive, can't set balance.");
                }
            }
        }

        public Cities city
        {
            get
            {   
                return _city;
            }
            set
            {
                if (status == true)
                {
                    _city = value;
                }
                else
                {
                    Console.WriteLine("Account is inactive, So you can't modify cityName.");
                }
            }
        }
        //Auto Implemented Properties
        public string IFSC { get; set; }

        public void Deposit(double amount)
        {
            if (status == true)
            {
                balance += amount;
            }
            else
            {
                Console.WriteLine("Account is inactive, So money can't deposited");
            }
        }

        public void Withdraw(double amount)
        {
            if (status == true)
            {
                if (balance >= amount)
                {
                    balance -= amount;
                }
                else
                {
                    Console.WriteLine("Insufficient balance");
                }
            }
            else
            {
                Console.WriteLine("Account is inactive, So money can't withdraw.");
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(123456, "John Doe", 1000, true, BankAccount.Cities.Kolkata); 
            Console.WriteLine("Account Balance: " + account.balance);
            account.Deposit(500);
            Console.WriteLine("Account Balance: " + account.balance);
            Console.WriteLine("Account Holder City: " + account.city);
            account.status = false;
            account.city = BankAccount.Cities.Mumbai;

            account.IFSC = "SBIN000123"; // we can set the value of IFSC property
            Console.WriteLine("Account IFSC: " + account.IFSC); // we can get the value of IFSC property
        }
    }
}

// In above code we can see that how enum is used in C# to define a set of named constants.
// Above we also discuss about auto implemented properties in C#, where we don't need to define private variable and get and set accessors.It implicitly creates a private variable and get and set accessors.

// Important Points: 
// Properties are used to control the access to the class variables.
