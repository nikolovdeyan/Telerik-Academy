using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.CallHistoryTest
{
    class GSMCallHistoryTest
    {

        static public void TestGSMCallHistory()
        {
            // Creating a test GSM instance with a full constructor
            GSM testInstanceGSM = new GSM("Placeholder Model", "Placeholder Company", 1500.00, "Test User",
                                           new Display(680, 2038, 900000000),
                                           new Battery("Placeholder Battery Model", BatteryType.NiCd, 250, 20));

            // Adding some calls
            testInstanceGSM.AddCall(new Call());
            testInstanceGSM.AddCall(new Call(new DateTime(2016, 12, 16, 21, 32, 15), "08889999999", new TimeSpan(0, 12, 50)));
            testInstanceGSM.AddCall(new Call(new DateTime(2016, 12, 17, 08, 12, 00), "08881111111", new TimeSpan(0, 0, 12)));

            // Display the information of the calls
            foreach (var call in testInstanceGSM.CallHistory)
            {
                Console.WriteLine(call);
            }

            // Calculating the total price of the calls based on a price per minute of 0.37
            var totalPriceBefore = testInstanceGSM.CalculateCosts(0.37M);
            Console.WriteLine("Total price of the calls is: {0:C2}", totalPriceBefore);

            // Remove the longest call  and calculate the total price again
            Call longestCall = null;
            TimeSpan longestDur = new TimeSpan(0);

            foreach (var call in testInstanceGSM.CallHistory)
            {
                if (call.CallDuration > longestDur)
                {
                    longestDur = call.CallDuration;
                    longestCall = call;
                }
            }
            testInstanceGSM.DeleteCall(longestCall);
            var totalPriceAfter = testInstanceGSM.CalculateCosts(0.37M);
            Console.WriteLine("Total price of the calls after the deletion: {0:C2}", totalPriceAfter);

            // Clear the call history and print it.
            testInstanceGSM.ClearCallHistory();
            foreach (var item in testInstanceGSM.CallHistory)
            {
                Console.WriteLine(item);
            }

        }
    }
}
