namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 11, 21, 13, 15, 24, 31, 17 };
            // Now we have to return a array that contains all the elements greater than 20.

            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 20)
                {
                    count++;
                }
            }

            int index = 0;
            int[] arr2 = new int[count];
            for(int i = 0;i < arr.Length; i++)
            {
                if (arr[i] >= 20)
                {
                    arr2[index] = arr[i];
                    index++;
                }
            }

            foreach (int i in arr2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // we can see that there is a lot of works, To overcome this problem i am going to use LINQ
            int[] newArr = { 10,20,30,40,50,60,70,80,90,21,31,41,51,61,71,81,91};
            var res = from i in newArr where i>40 orderby i descending select i;
            foreach (int i in res)
            {
                Console.Write(i + " ");
            }

            // So from here we can say that LINQ is a query language designed by Microsoft using which we can write query on wide variety of data sources.
        }
    }
}

// LINQ is divided into multiple parts:

// LINQ to Objects: using this we can write queries for Arrays,Collections,etc.
// LINQ to Databases: Data-Tables, Relational Database Tables
        // LINQ to ADO.NET
        // LINQ to SQL --> its query language for working with relational database. i.e., SQL Server.
        // LINQ to Entities

// LINQ to XML: we can write queries for XML files.
