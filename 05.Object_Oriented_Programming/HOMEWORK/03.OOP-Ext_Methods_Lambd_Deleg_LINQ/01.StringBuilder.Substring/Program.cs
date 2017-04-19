using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StringBuilderSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a string and a StringBuilder
            string myTestString = "The rain in Spain stays mainly in the plain.";
            StringBuilder myTestSB = new StringBuilder(myTestString);

            // Testing the newly implemented extension by comparing it to original String.Substring()
            var t1String = myTestString.Substring(0, 3);
            var t1SB = myTestSB.Substring(0, 3);

            Console.WriteLine("******************************************");
            Console.WriteLine("Substring of the chars in positions 0-2:");
            Console.WriteLine("String:        <{0}>, Type is: {1}", t1String, t1String.GetType());
            Console.WriteLine("StringBuilder: <{0}>, Type is: {1}", t1SB, t1SB.GetType());
            Console.WriteLine();

            // Test again 
            var t2String = myTestString.Substring(12, 5);
            var t2SB = myTestSB.Substring(12, 5);

            Console.WriteLine("******************************************");
            Console.WriteLine("Substring of the chars in positions 12-16:");
            Console.WriteLine("String:        <{0}>, Type is: {1}", t2String, t2String.GetType());
            Console.WriteLine("StringBuilder: <{0}>, Type is: {1}", t2SB, t2SB.GetType());
            Console.WriteLine();

            // Test again -- Only providing start index this time
            var t3String = myTestString.Substring(24);
            var t3SB = myTestSB.Substring(24);

            Console.WriteLine("******************************************");
            Console.WriteLine("Substring of the chars after the 24th char:");
            Console.WriteLine("String:        <{0}>, Type is: {1}", t3String, t3String.GetType());
            Console.WriteLine("StringBuilder: <{0}>, Type is: {1}", t3SB, t3SB.GetType());
            Console.WriteLine();

        }
    }
}
