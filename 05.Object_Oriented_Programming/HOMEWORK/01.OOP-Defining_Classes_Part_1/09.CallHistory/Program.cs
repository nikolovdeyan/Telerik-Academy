using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.CallHistory
{
    class Program
    {
        static void Main(string[] args)
        {

            // Old tests from previous task
            //GSM[] testGSMArr = GSMTest.CreateGSMTestArray();
            //GSMTest.RunGSMTest(testGSMArr);
            //GSMTest.RunGSMTestIPhone4s();

            //Call testCallFull = new Call(new DateTime(2016, 12, 15, 15, 30, 00),
            //                         "0888123456",
            //                         new TimeSpan(0, 14, 25));
            //Console.WriteLine("Test call with full constructor:");
            //Console.WriteLine(testCallFull);

            //Call testCallDefault = new Call();
            //Console.WriteLine("Test call with default constructor (no given params):");
            //Console.WriteLine(testCallDefault);

            // Testing the Call history list
            GSM myTestIphone = GSM.IPhone4S;
            myTestIphone.CallHistory.Add(new Call());

            Console.WriteLine(myTestIphone.CallHistory[0]);
        }
    }
}
