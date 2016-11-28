using System;

class CompanyInfo
{
    static void Main()
    {
        string compName = Convert.ToString(Console.ReadLine());
        string compAddr = Convert.ToString(Console.ReadLine());
        string compPhone = Convert.ToString(Console.ReadLine());
        string faxNum = Convert.ToString(Console.ReadLine());
        string webSite = Convert.ToString(Console.ReadLine());
        string mngFirstName = Convert.ToString(Console.ReadLine());
        string mngLastName = Convert.ToString(Console.ReadLine());
        string mngAge = Convert.ToString(Console.ReadLine());
        string mngPhone = Convert.ToString(Console.ReadLine());

        faxNum = (faxNum == "") ? "(no fax)" : faxNum;

        Console.WriteLine(compName);
        Console.WriteLine("Address: {0}", compAddr);
        Console.WriteLine("Tel. {0}", compPhone);
        Console.WriteLine("Fax: {0}", faxNum);
        Console.WriteLine("Web site: {0}", webSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", mngFirstName, mngLastName, mngAge, mngPhone);
    }
}