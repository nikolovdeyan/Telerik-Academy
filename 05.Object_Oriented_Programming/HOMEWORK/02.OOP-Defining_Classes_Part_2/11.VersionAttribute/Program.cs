using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _11.VersionAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
            var typesArray = Assembly.GetExecutingAssembly().GetTypes();
            foreach (var type in typesArray)
            {
                Object[] attirbutes = type.GetCustomAttributes(false);

                foreach (var attr in attirbutes)
                {
                    if (attr is Version)
                    {
                        Console.WriteLine("{0} v.{1}.{2}", type.Name, ((Version)attr).MajorVersion, ((Version)attr).MinorVersion);
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
