using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _07.Timer
{

    public delegate void TimerDelegate();

    public class Timer
    {
        private int timeInterval;
        private byte numberOfExecutions;
        private TimerDelegate timeEvent;

        public Timer(int timeInterval, byte numberOfExecutions, TimerDelegate timeEvent)
        {
            this.TimeInterval = timeInterval;
            this.NumberOfExecutions = numberOfExecutions;
            this.TimeEvent = timeEvent;
        }

        public int TimeInterval
        {
            get { return this.timeInterval; }
            set { this.timeInterval = value; }
        }

        public byte NumberOfExecutions
        {
            get { return this.numberOfExecutions; }
            set { this.numberOfExecutions = value; }
        }

        public TimerDelegate TimeEvent
        {
            get { return this.timeEvent; }
            set { this.timeEvent = value; }
        }

        public void Run()
        {
            while (this.numberOfExecutions > 0)
            {
                Thread.Sleep(this.timeInterval * 1000);
                this.numberOfExecutions--;
                this.TimeEvent();
            }
        }
    }
}
