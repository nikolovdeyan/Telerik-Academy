using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MinAndMax
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testing the Min() and Max() methods with a list of strings:
            GenericList<string> myTestStrings = new GenericList<string>();
            myTestStrings.Add("I");
            myTestStrings.Add("am");
            myTestStrings.Add("a");
            myTestStrings.Add("List");

            Console.WriteLine("*****************************************************");
            Console.WriteLine("Current list elements:");
            Console.WriteLine(myTestStrings);
            Console.WriteLine("Testing the Min() and Max():");
            Console.WriteLine("Min<string>(): {0}", myTestStrings.Min<string>());
            Console.WriteLine("Max<string>(): {0}", myTestStrings.Max<string>());
            Console.WriteLine();

            // Testing the Min() and Max() methods with a list of doubles:
            double[] arr = { 1.554, 2.19, 3.14, 42, 5.666, 6.01, 0.12, -5, 103.519 };
            GenericList<double> myTestDoubles = new GenericList<double>(10, arr);

            Console.WriteLine("*****************************************************");
            Console.WriteLine("Current list elements:");
            Console.WriteLine(myTestDoubles);
            Console.WriteLine("Testing the Min() and Max():");
            Console.WriteLine("Min<double>(): {0}", myTestDoubles.Min<double>());
            Console.WriteLine("Max<double>(): {0}", myTestDoubles.Max<double>());
            Console.WriteLine();
        }
    }
}
