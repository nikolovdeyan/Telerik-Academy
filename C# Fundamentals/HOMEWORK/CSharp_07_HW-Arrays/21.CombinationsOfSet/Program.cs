using System;
using System.Linq;
namespace _21.CombinationsOfSet
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter end of the set N=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter how many element will be variations K=");
            int k = int.Parse(Console.ReadLine());
            int[] array = Enumerable.Repeat(1, k).ToArray();
            int count;

            do
            {
                count = 1;
                if (Combnation(array)) Print(array);
                for (int i = 0; i < k; i++)
                {
                    array[i] += count;
                    if (array[i] <= n)
                    {
                        count = 0;
                        break;
                    }
                    else
                    {
                        array[i] = count = 1;
                    }
                }
            }
            while (count != 1);
        }

        static bool Combnation(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                for (int j = i + 1; j < array.Length; j++)
                    if (array[i] <= array[j])
                        return false;
            return true;
        }

        static void Print(int[] array)
        {
            Console.Write("{");

            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(i > 0 ? array[i] + ", " : array[i] + "}\n");
            }
        }
    }
}
