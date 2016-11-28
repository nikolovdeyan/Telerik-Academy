using System;

namespace _12.ParseURL
{
    class ParseURL
    {
        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();

            URLParser(inputStr);
        }

        static void URLParser (string url)
        {
            int indexOfProtocol = url.IndexOf("://");
            int indexOfServer = url.IndexOf("/", indexOfProtocol + 3);

            string protocol = url.Substring(0, indexOfProtocol);
            string server = url.Substring(indexOfProtocol + 3, indexOfServer - indexOfProtocol - 3);
            string resource = url.Substring(indexOfServer);

            Console.WriteLine("[protocol] = {0}", protocol);
            Console.WriteLine("[server] = {0}", server);
            Console.WriteLine("[resource] = {0}", resource);
        }
    }
}
