using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.CallPrice
{
    static public class GSMTest
    {
        public static GSM[] CreateGSMTestArray()
        {
            return new GSM[]
            {
                new GSM("Test Model", "Test Manufacturer"),
                new GSM("Test Model", "Test Manufacturer", 0.20),
                new GSM("Test Model", "Test Manufacturer", 0.20, "Test Owner"),
                new GSM("Test Model", "Test Manufacturer", 0.20, "Test Owner",
                        new Display(900, 1980, 19860000),
                        new Battery("Test Battery Model", BatteryType.NiOOH))
            };
        }

        public static void RunGSMTest(GSM[] GSMArray)
        {
            foreach (var phone in GSMArray)
            {
                Console.WriteLine(phone.ToString());
            }
        }

        public static void RunGSMTestIPhone4s()
        {
            GSM testIphone4S = GSM.IPhone4S;
            Console.WriteLine(testIphone4S.ToString());
        }

    }
}
