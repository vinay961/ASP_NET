
// Collection is a group of objects. In C#, collections are used to store, retrieve, manipulate, and organize data.
// Example of collections are List, Dictionary, Queue, Stack, etc.

// Array is a fixed-size collection. It is used to store elements of the same data type.
// We can't do three things with arrays: increase or decrease the size of the array, insert an element into middle, and delete an element from the middle.

// To overcome the limitations of arrays, we use collections.
// Collections is of two types: non-generic collections and generic collections.
// Non-generic collections store elements as objects. Example: ArrayList, HashTable, Stack, Queue, etc.
// Generic collections store elements of a specific type. Example: List, Dictionary, Stack, Queue, etc.
// Generic collections are type-safe and provide better performance than non-generic collections.
// How generic collections are type-safe? Because we can specify the type of elements that a generic collection can store.

using System.Collections;

namespace Collections
{
    class Intro
    {
        //static void Main(string[] args)
        //{
        //    ArrayList list = new ArrayList();
        //    list.Add(1);
        //    list.Add("Two");
        //    list.Add(3.0);
        //    list.Add(true);
        //    //list.Remove("Two"); // Removes the first occurrence of the specified object.
        //    //list.RemoveAt(1); // Removes the element at the specified index.
        //    //list.RemoveRange(1, 2); // Removes a range of elements starting from the specified index, both are inclusive.
        //    // How to add multiple elements to the list at once?
        //    list.AddRange(new object[] { 4, "Five", 6.1, false });
        //    Console.WriteLine("ArrayList:");
        //    foreach (object item in list)
        //    {
        //        Console.Write(item + ", ");
        //    }
        //    Console.WriteLine();
        //    Console.WriteLine("Capacity: " + list.Capacity);


        //    Hashtable table = new Hashtable();
        //    // Key and value can be of any type.
        //    table.Add("Boy_Name", "Vinay");
        //    table.Add("Girl_Name", "Janhavi");

        //    Console.WriteLine("Hashtable:");
        //    foreach (object key in table.Keys)
        //    {
        //        Console.WriteLine(key + ": " + table[key]);
        //    }
        //    foreach (object key in table.Keys)
        //    {
        //        Console.WriteLine(key + ": " + key.GetHashCode());
        //    }
        //    // Every value contains three parts: key, value, and hash code.
        //    // Due to hash code, we can access the value quickly, even if the table contains a large number of items.
        //    // In hash table, the order of items is not guaranteed.
        //}
    }
}