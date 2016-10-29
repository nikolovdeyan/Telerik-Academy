using System;
class IntDoubleString
{
    static void Main()
    {
        string inputMode = Convert.ToString(Console.ReadLine());
        switch (inputMode)
        {
            case "integer":
                {
                    int inputVar = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("{0}", (inputVar + 1));
                    break;
                }
            case "real":
                {
                    double inputVar = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("{0:F2}", (inputVar + 1));
                    break;
                }
            case "text":
                {
                    string inputVar = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("{0}*", inputVar);
                    break;
                }
            default: break;
        }
    }
}