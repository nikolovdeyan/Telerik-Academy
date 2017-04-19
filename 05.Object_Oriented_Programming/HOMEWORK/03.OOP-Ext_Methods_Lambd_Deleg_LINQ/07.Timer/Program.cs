using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _07.Timer
{
    class Program
    {
        static void Main(string[] args)
        {
            // The timer will execute 5 ticks -- one every second
            Timer chronometer = new Timer(1, 5, delegate () { Console.WriteLine("tick"); });
            Thread timerThread = new Thread(new ThreadStart(chronometer.Run));
            timerThread.Start();
        }
    }
}
