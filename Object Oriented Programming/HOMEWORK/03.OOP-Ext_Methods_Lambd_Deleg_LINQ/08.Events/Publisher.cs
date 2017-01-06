using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Events
{
    public class Publisher
    {
        public event EventHandler<EventMessage> RaiseCustomEvent;

        public void PublishMessage()
        {
            Console.WriteLine("We are currently experiencing technical difficulties. Please try again later.");
            this.OnRaisedCustomEvent(new EventMessage("-"));
        }


        protected virtual void OnRaisedCustomEvent(EventMessage e)
        {
            EventHandler<EventMessage> handler = this.RaiseCustomEvent;
            if (handler != null)
            {
                e.Message += string.Format(" at {0}.", DateTime.Now.ToString());
                handler(this, e);
            }
        }
    }
}
