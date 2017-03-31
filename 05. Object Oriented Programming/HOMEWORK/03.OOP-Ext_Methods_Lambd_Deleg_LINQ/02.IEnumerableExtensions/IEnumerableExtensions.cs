using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.IEnumerableExtensions
{
    public static class IEnumerableExtensions
    {
        public static T Sum<T>(this IEnumerable<T> collection)
            where T : IComparable<T>
        {
            dynamic result = 0;

            foreach (var item in collection)
            {
                result += (dynamic)item;
            }

            return result;
        }

        public static T Product<T>(this IEnumerable<T> collection)
            where T : IComparable<T>
        {
            dynamic result = 1;

            foreach (var item in collection)
            {
                result *= (dynamic)item;
            }

            return result;
        }

        public static T Min<T>(this IEnumerable<T> collection)
            where T : IComparable<T>
        {
            dynamic min = collection.First();

            foreach (var item in collection)
            {
                if ((dynamic)item < min)
                {
                    min = item;
                }
            }

            return min;
        }

        public static T Max<T>(this IEnumerable<T> collection)
            where T : IComparable<T>
        {
            dynamic max = collection.First();

            foreach (var item in collection)
            {
                if ((dynamic)item > max)
                {
                    max = item;
                }
            }

            return max;
        }

        public static T Average<T>(this IEnumerable<T> collection)
            where T : IComparable<T>
        {
            dynamic result = collection.Sum() / (dynamic)collection.Count();

            return result;            
        }
    }
}
