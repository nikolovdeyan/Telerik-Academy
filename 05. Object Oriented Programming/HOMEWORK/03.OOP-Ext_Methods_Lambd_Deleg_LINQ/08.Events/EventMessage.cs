using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Events
{
    public class EventMessage
    {
        private string message;

        public EventMessage(string message)
        {
            this.Message = message;
        }

        public string Message { get; set; }
    }
}
