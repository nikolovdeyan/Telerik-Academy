using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testing the GenericList
            // First initialize a GenericList of type string
            GenericList<string> myTestStrings = new GenericList<string>();

            // Add a couple of strings for the GenericList to hold and print
            myTestStrings.Add("Winter");
            myTestStrings.Add("is");
            myTestStrings.Add("coming!");

            Console.WriteLine("*****************************************************");
            Console.WriteLine("GenericList after Add()s:");
            Console.WriteLine(myTestStrings);
            Console.WriteLine("GenericList Size: {0}, Last Element Position: {1}", myTestStrings.Size, myTestStrings.LastElement);
            Console.WriteLine();

            // Remove the item at position 0 and print again
            myTestStrings.RemoveAt(0);

            Console.WriteLine("*****************************************************");
            Console.WriteLine("GenericList after Remove()-ing an item:");
            Console.WriteLine(myTestStrings);
            Console.WriteLine("GenericList Size: {0}, Last Element Position: {1}", myTestStrings.Size, myTestStrings.LastElement);
            Console.WriteLine();

            // Insert a new item at position 0 and print again
            myTestStrings.Insert("TodorHodor", 0);

            Console.WriteLine("*****************************************************");
            Console.WriteLine("GenericList after Insert()-ing an item at position 0:");
            Console.WriteLine(myTestStrings);
            Console.WriteLine("GenericList Size: {0}, Last Element Position: {1}", myTestStrings.Size, myTestStrings.LastElement);
            Console.WriteLine();

            // Lets try to resize the array by inserting some more items
            myTestStrings.Insert("I", 0);
            myTestStrings.Insert("guess", 1);
            myTestStrings.Insert("really", 3);

            Console.WriteLine("*****************************************************");
            Console.WriteLine("GenericList after increasing its size:");
            Console.WriteLine(myTestStrings);
            Console.WriteLine("GenericList Size: {0}, Last Element Position: {1}", myTestStrings.Size, myTestStrings.LastElement);
            Console.WriteLine();

            // Now the list is cleared. The size will return to the default const value
            myTestStrings.Clear();

            Console.WriteLine("*****************************************************");
            Console.WriteLine("GenericList after using .Clear():");
            Console.WriteLine(myTestStrings);
            Console.WriteLine("GenericList Size: {0}, Last Element Position: {1}", myTestStrings.Size, myTestStrings.LastElement);
            Console.WriteLine();

            // Creating a new list with some numbers
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            GenericList<int> myTestNums = new GenericList<int>(10, arr);

            Console.WriteLine("*****************************************************");
            Console.WriteLine("GenericList is now using integers:");
            Console.WriteLine(myTestNums);
            Console.WriteLine("GenericList Size: {0}, Last Element Position: {1}", myTestNums.Size, myTestNums.LastElement);
            Console.WriteLine();

            // Testing the Find() method now
            Console.WriteLine("*****************************************************");
            Console.WriteLine("GenericList testing Find(): Where is 8?");
            Console.WriteLine("Element '8' found at position {0}", myTestNums.Find(8));



        }
    }
}
