using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.IEnumerableExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define different types of collections
            List<double> myListCollection = new List<double> { 2.5, 4, 12.55, 0.175, 12, 5.01 };
            HashSet<double> myHashSet = new HashSet<double> { 2.5, 4, 12.55, 0.175, 12, 5.01 };
            IEnumerable<double> myIEnumerableCollection = new double[] { 2.5, 4, 12.55, 0.175, 12, 5.01 };

            // Testing the SUM method
            var listSum = myListCollection.Sum<double>();
            var hashSetSum = myHashSet.Sum<double>();
            var iEnumSum = myIEnumerableCollection.Sum<double>();

            Console.WriteLine("******************************************");
            Console.WriteLine("Sum of the items in the various collections:");
            Console.WriteLine("List Collection:          {0}", listSum);
            Console.WriteLine("HashSet Collection:       {0}", hashSetSum);
            Console.WriteLine("Array Collection:         {0}", iEnumSum);
            Console.WriteLine();

            // Testing the PRODUCT method
            var listProd = myListCollection.Product<double>();
            var hashSetProd = myHashSet.Product<double>();
            var iEnumProd = myIEnumerableCollection.Product<double>();

            Console.WriteLine("******************************************");
            Console.WriteLine("Product of the items in the various collections:");
            Console.WriteLine("List Collection:          {0}", listProd);
            Console.WriteLine("HashSet Collection:       {0}", hashSetProd);
            Console.WriteLine("Array Collection:         {0}", iEnumProd);
            Console.WriteLine();

            // Testing the MIN method
            var listMin = myListCollection.Min<double>();
            var hashSetMin = myHashSet.Min<double>();
            var iEnumMin = myIEnumerableCollection.Min<double>();

            Console.WriteLine("******************************************");
            Console.WriteLine("Min of the items in the various collections:");
            Console.WriteLine("List Collection:          {0}", listMin);
            Console.WriteLine("HashSet Collection:       {0}", hashSetMin);
            Console.WriteLine("Array Collection:         {0}", iEnumMin);
            Console.WriteLine();

            // Testing the MAX method
            var listMax = myListCollection.Max<double>();
            var hashSetMax = myHashSet.Max<double>();
            var iEnumMax = myIEnumerableCollection.Max<double>();

            Console.WriteLine("******************************************");
            Console.WriteLine("Max of the items in the various collections:");
            Console.WriteLine("List Collection:          {0}", listMax);
            Console.WriteLine("HashSet Collection:       {0}", hashSetMax);
            Console.WriteLine("Array Collection:         {0}", iEnumMax);
            Console.WriteLine();

            // Testing the AVERAGE method
            var listAvg = myListCollection.Average<double>();
            var hashSetAvg = myHashSet.Average<double>();
            var iEnumAvg = myIEnumerableCollection.Average<double>();

            Console.WriteLine("******************************************");
            Console.WriteLine("Average of the items in the various collections:");
            Console.WriteLine("List Collection:          {0:F2}", listAvg);
            Console.WriteLine("HashSet Collection:       {0:F2}", hashSetAvg);
            Console.WriteLine("Array Collection:         {0:F2}", iEnumAvg);
            Console.WriteLine();

        }
    }
}
