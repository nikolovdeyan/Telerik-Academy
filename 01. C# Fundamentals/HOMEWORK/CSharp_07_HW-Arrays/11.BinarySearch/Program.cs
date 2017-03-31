using System;
class BinarySearch
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] inputArray = new int[n];
        for (int i = 0; i < n; i++)
        {
            inputArray[i] = int.Parse(Console.ReadLine());
        }

        int key = int.Parse(Console.ReadLine());

        Array.Sort(inputArray);

        bool isSuchNumber = false;

        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i] == key)
            {
                isSuchNumber = true;
            }
        }

        if (!isSuchNumber)
        {
            Console.WriteLine("-1");
        }
        else
        {
            int imin = 0;
            int imax = n;

            while (imax >= imin)
            {
                int imid = imin + ((imax - imin) / 2);

                if (inputArray[imid] == key)
                {
                    Console.WriteLine("{0}", imid);
                    break;
                }
                else if (inputArray[imid] < key)
                {
                    imin = imid + 1;
                }
                else
                {
                    imax = imid - 1;
                }
            }
        }
    }
}