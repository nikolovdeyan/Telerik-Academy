using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _08.Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();
            Subscriber mySubscriber1 = new Subscriber("My Subscriber 1 ", publisher);

            publisher.PublishMessage();
        }
    }
}
