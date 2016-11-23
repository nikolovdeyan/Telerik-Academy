using System;
using System.Text;

class HiddenMessage
{
    static void Main()
    {
        StringBuilder result = new StringBuilder();

        while (true)
        {
            string subLine = Console.ReadLine();

            if (subLine == "end")
            {
                Console.WriteLine(result);
                break;
            }
            else if (subLine.Length == 0)
            {
                continue;
            }
            else
            {
                int indexStart = int.Parse(subLine);
                int interval = int.Parse(Console.ReadLine());
                subLine = Console.ReadLine();

                if (subLine.Length < indexStart)
                {
                    continue;
                }
                if (indexStart < 0)
                {
                    indexStart = subLine.Length - Math.Abs(indexStart);
                }

                for (int i = indexStart; i < subLine.Length && i >= 0; i = i + interval)
                {
                    result.Append(subLine[i]);
                }
            }
        }
    }
}