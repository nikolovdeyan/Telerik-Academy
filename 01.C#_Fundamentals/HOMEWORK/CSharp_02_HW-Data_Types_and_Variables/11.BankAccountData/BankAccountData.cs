using System;

class BankAccountData
{
    static void Main(string[] args)
    {
        string accountFirstName = "Tsetska";
        string accountMiddleName = "Drundeva";
        string accountLastName = "Mundeva";
        decimal accountBalance = 750000.15M;
        string accountBankName = "State Dubious Bank of High Yields";
        string accountIBAN = "BG39 DUB1 0346 2366 6954 23";
        ulong accountCreditCard1 = 4000123456781000;
        ulong accountCreditCard2 = 4000123456781001;
        ulong accountCreditCard3 = 4000123456781115;

        Console.WriteLine("Account associated with: {0} {1} {2}\n", accountFirstName, accountMiddleName, accountLastName);
        Console.WriteLine("Balance in USD: {0}\n", accountBalance);

        Console.WriteLine("------------------------------------------------");
        Console.WriteLine("Principal Bank Account Information:");
        Console.WriteLine("IBAN: {0} -- {1}\n", accountIBAN, accountBankName);
        Console.WriteLine("Credit cards associated with this account: \n{0}\n{1}\n{2}", accountCreditCard1, accountCreditCard2, accountCreditCard3);
    }
}