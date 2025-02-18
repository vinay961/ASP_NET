
// Generic Collections: Those collections that is used to store specific type of data.Example list which is used to store integer type of data.

namespace Collections
{
    class Generic
    {
        public void Compare<T>(T a, T b) // if i take int instead of object then i can only compare int type of data, but if i take object then i can compare any type of data.
        {
            if (a.Equals(b))
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }
        // static void Main(string[] args)
        // {
            //Generic generic = new Generic();
            //// generic.Comapre(1, "ram"); // it is not type-safe, as it compare a int and string type of data.
            //generic.Compare<int>(1, 1); // it is type-safe, as it compare a int and int type of data.
            //generic.Compare<string>("ram", "ram"); // it is type-safe, as it compare a string and string type of data.
            // generic.Compare<double>(1.2, "Tom"); // error, as it compare a double and string type of data. 



            //List<int> list = new List<int>();
            //Console.WriteLine("Capacity: " + list.Capacity);
            //list.Add(1);
            //list.Add(2);
            //foreach(int item in list)
            //{
            //    Console.Write(item + ", ");
            //}
            //list.Insert(1, 3); // insert 3 at index 1
            //Console.WriteLine();
            //list.Clear();
            //Console.WriteLine("Capacity: " + list.Capacity); // here we can see that capacity is not changed, the reason is that it is not shrinked is because it is expensive to shrink the array.
        // }
    }
}
