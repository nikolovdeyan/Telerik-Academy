using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StaticField
{
    class Program
    {
        static void Main(string[] args)
        {

            // Adding some test GSM instances
            GSM tstFirst = new GSM("Galaxy J5 (2016)", "Samsung", 789.00, "Pesho Peshev",
                                   new Display(720, 1280, 16000000),
                                   new Battery("KuchaMarka", BatteryType.LiIon, 68, 8));

            GSM tstSecond = new GSM("HTC 10", "HTC", 1020.90, "Pesho Peshev");

            GSM tstThird = new GSM("Predator 8", "Acer", 690.50);

            GSM tstFourth = new GSM("Lumia 630", "Nokia");

            GSM tstIPhone = GSM.IPhone4S;
            tstIPhone.Owner = "Joey Tribbiani";

            Console.WriteLine(tstFirst.ToString());
            Console.WriteLine();
            Console.WriteLine(tstSecond.ToString());
            Console.WriteLine();
            Console.WriteLine(tstThird.ToString());
            Console.WriteLine();
            Console.WriteLine(tstFourth.ToString());
            Console.WriteLine();
            Console.WriteLine(tstIPhone.ToString());
            Console.WriteLine();
        }
    }
}
