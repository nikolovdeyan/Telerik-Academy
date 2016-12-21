using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _12.CallHistoryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.UTF8;
            //Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("bg-BG");
            //Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("bg-BG");

            GSMCallHistoryTest.TestGSMCallHistory();

        }
    }
}
