using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.GSMTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize the test array
            GSM[] testGSMArr = GSMTest.CreateGSMTestArray();
            // Run the tests
            GSMTest.RunGSMTest(testGSMArr);
            GSMTest.RunGSMTestIPhone4s();

        }
    }
}

