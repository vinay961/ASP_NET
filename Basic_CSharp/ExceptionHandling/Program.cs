// Compile Time Error: Error that occurs due to syntax or semantic mistakes in the code.
// Run Time Error: Error that occurs during the execution of the program. It occurs due to logical mistakes in the code, wrong input, etc.

// Exception - Logic for abnormal termination of the program. Now what is abnormal termination? It is a situation where the program is terminated unexpectedly due to some error.
// It contains a readonly property called Message that returns a detailed message of the exception. which is declared as virtual in the Exception class.
// All the exceptions are derived from the 'System.Exception', which is the base class for all exceptions in C#.

//Exception Handling - It is a mechanism to handle runtime errors. Process of stopping the abnormal termination of the program and resuming the program execution is called exception handling.

// To handle exceptions, we use the try-catch block. The try block contains the code that may throw an exception, and the catch block contains the code that handles the exception.

class Program
{
    public class DivideByOddNumberException : ApplicationException
    {
        public override string Message
        {
            get
            {
                return "Denominator can't be an odd number";
            }
        }
    }
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter 1st number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if(num2 == 1)
            {
                throw new ApplicationException("Denominator can't be 1");
            }
            if ( num2%2 != 0)
            {
                throw new DivideByOddNumberException();
            }
            int result = num1 / num2;
            Console.WriteLine("Result is: " + result);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally 
        {
            Console.WriteLine("Finally block is executed!"); 
        }

        Console.WriteLine("End of Code...");
    }
}

// when return is executed, the finally block is executed but the code after the finally block is not executed.

// Exception is divided into two categories: System Exception and Application Exception.
// System Exception: It is thrown by the CLR. Like DivideByZeroException, NullReferenceException, etc.
// Application Exception: It is thrown by the programmer and application developers. Like FileNotFoundException, etc.

// Now the question is, how to create a custom exception? To create a custom exception, we need to create a class that inherits from the Exception class.
// Like throw new ApplicationException("Error Message"); or throw new ApplicationException("Error Message", ex); where ex is the inner exception.