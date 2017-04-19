using System.Security.Policy;
using System;


namespace _08.Events
{
    public class Subscriber
    {
        private string id;

        public Subscriber(string id, Publisher publisher)
        {
            this.id = id;
            publisher.RaiseCustomEvent += this.HandleCustomEvent;
        }

        public void HandleCustomEvent(object sender, EventMessage e)
        {
            Console.WriteLine(this.id + " has read this message {0}", e.Message);
        }
    }
}