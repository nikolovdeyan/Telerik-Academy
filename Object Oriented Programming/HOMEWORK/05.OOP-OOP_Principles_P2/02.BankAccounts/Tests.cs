using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    class Tests
    {
        // A method to display details for the test accounts
        public static void DisplayAccount(Account account)
        {
            Console.WriteLine(new String('#', 71));
            Console.WriteLine(String.Format("#  Current account holder: {0,10:C2}", account.Owner.Name));
            Console.WriteLine(String.Format("#  Current account balance: {0,10:C2}" ,account.Balance));
            Console.WriteLine("#{0}", new String('_', 70));
            Console.WriteLine(String.Format("# {0,-6}|{1,-20}|{2,-20}|{3,-20}|", "Month", "  Monthly Interest", "  Monthly Interest", "  Total Cumulative"));
            Console.WriteLine(String.Format("# {0,-6}|{1,-20}|{2,-20}|{3,-20}|", " ", "     (percent)", "     (currency)", "       Amount"));
            for (int i = 1; i <= 24; i++)
            {
                Console.WriteLine(String.Format("# {0,-6}|{1,19:F4} |{2,19:C2} |{3, 19:C2} |", 
                                                                        i, 
                                                                        account.CalculateInterestAmount(i),
                                                                        // In reality those would be cumulative:
                                                                        account.CalculateInterestAmount(i) /100 * account.Balance,
                                                                        account.CalculateInterestAmount(i)/100*account.Balance + account.Balance));
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.SetWindowSize(75, 45);
            // Testing the implemented model

            // Create a few customers
            IndividualCustomer privateCustomer1 = new IndividualCustomer("Thorin Oakenshield");
            IndividualCustomer privateCustomer2 = new IndividualCustomer("Samwise Gamgee");
            CompanyCustomer companyCustomer1 = new CompanyCustomer("Wizard's Pipeweed Inc.");
            CompanyCustomer companyCustomer2 = new CompanyCustomer("Rivendell Parks and Recreation");

            // *** TEST 1 ***
            // This customer opens a new Deposit Account
            DepositAccount testAccout1 = new DepositAccount(privateCustomer1, 0.08M, 5000);

            // See calculated deposit earnings after the account opening
            Console.WriteLine("\nTest 1.1: Estimated earnings for new deposit account:");
            DisplayAccount(testAccout1);
            Console.Write("Press any key for next test...");
            Console.ReadKey();
            Console.Clear();

            // This type of account can draw money. Lets draw 2500, and recalculate:
            testAccout1.DrawMoney(2500);
            Console.WriteLine("\nTest 1.2: Estimated earnings after taking 2500 out:");
            DisplayAccount(testAccout1);
            Console.ReadKey();
            Console.Clear();

            // *** TEST 2 ***
            // This customer opens a new Loan Account
            LoanAccount testAccount2 = new LoanAccount(privateCustomer2, 0.06M, 12750);

            // See calculated deposit earnings after the account opening
            Console.WriteLine("\nTest 1.1: Estimated earnings for new loan account:");
            DisplayAccount(testAccount2);
            Console.Write("Press any key for next test...");
            Console.ReadKey();
            Console.Clear();

            // This type of account can deposit money. Lets deposit 850 more, and recalculate:
            testAccount2.DepositMoney(850);
            Console.WriteLine("\nTest 2.2: Estimated earnings after adding 850:");
            DisplayAccount(testAccount2);
            Console.ReadKey();
            Console.Clear();

            // *** TEST 3 ***
            // This customer opens a new Mortgage Account
            MortgageAccount testAccount3 = new MortgageAccount(companyCustomer1, 0.12M, 45000);

            // See calculated deposit earnings after the account opening
            Console.WriteLine("\nTest 3.1: Estimated earnings for new mortgage account:");
            DisplayAccount(testAccount3);
            Console.Write("Press any key for next test...");
            Console.ReadKey();
            Console.Clear();

            // *** TEST 4 ***
            // This customer opens a new Deposit Account
            DepositAccount testAccount4 = new DepositAccount(companyCustomer2, 0.09M, 60000);

            // See calculated deposit earnings after the account opening
            Console.WriteLine("\nTest4.1: Estimated earnings for new deposit account:");
            DisplayAccount(testAccount4);
            Console.Write("Press any key for next test...");
            Console.ReadKey();
            Console.Clear();

            // Try to withdraw most of the money
            testAccount4.DrawMoney(59500);
            Console.WriteLine("\nTest4.2: No earnings if the deposit account has less than 1000 units of currency");
            DisplayAccount(testAccount4);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
