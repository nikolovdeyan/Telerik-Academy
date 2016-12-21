using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.GSMTest
{
    // Crating the class to test the GSM class
    static public class GSMTest
    {
        // A public method to run the GSM test using a few sample instances of GSM objects
        public static GSM[] CreateGSMTestArray()
        {
            // Create a test array using different constructors
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

        // A method to print the gsm information on the console for a given GSM[]
        public static void RunGSMTest(GSM[] GSMArray)
        {
            foreach (var phone in GSMArray)
            {
                Console.WriteLine(phone.ToString());
            }
        }

        // A method that initializes and tests an IPhone4S instance
        public static void RunGSMTestIPhone4s()
        {
            GSM testIphone4S = GSM.IPhone4S;
            Console.WriteLine(testIphone4S.ToString());
        }

    }
}
