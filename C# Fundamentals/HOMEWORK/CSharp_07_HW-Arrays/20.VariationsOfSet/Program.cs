using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.VariationsOfSet
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter N");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter K");
            int k = int.Parse(Console.ReadLine());


            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = i + 1;
            }

            Variations(arr, new int[k], 0);
        }

        private static void Variations(int[] nums, int[] arr, int index)
        {
            if (index == arr.Length)
            {
                Console.WriteLine(string.Join(", ", arr));
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                arr[index] = nums[i];
                Variations(nums, arr, index + 1);
            }
        }
    }
}
