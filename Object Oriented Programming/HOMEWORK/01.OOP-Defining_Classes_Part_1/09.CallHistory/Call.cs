using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.CallHistory
{
    public class Call
    {
        // Fields
        private DateTime callTimestamp;
        private string phoneNumber;
        private TimeSpan callDuration;

        // Constructors
        public Call (DateTime timeStamp, string number, TimeSpan duration)
        {
            this.CallTimestamp = timeStamp;
            this.PhoneNumber = number;
            this.CallDuration = duration;
        }
        public Call()
            :this(DateTime.Now, "Unknown", TimeSpan.FromSeconds(30D))
        {
            // this.CallTimestamp = DateTime.Now;
            // this.PhoneNumber = "Unknown";
            // this.CallDuration = TimeSpan.FromSeconds(30D);
        }

        // Properties
        public DateTime CallTimestamp
        {
            get { return this.callTimestamp; }
            set { this.callTimestamp = value; }
        }

        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            set { this.phoneNumber = value; }
        }

        public TimeSpan CallDuration
        {
            get { return this.callDuration; }
            set { this.callDuration = value; }
        }

        // ToString() Override
        public override string ToString()
        {
            return new StringBuilder()
                .AppendLine(string.Format("Call date:     {0:dd/MM/yyyy}", this.CallTimestamp))
                .AppendLine(string.Format("Call time:     {0:HH:mm:ss}", this.CallTimestamp))
                .AppendLine(string.Format("Call duration: {0:c}", this.CallDuration))
                .AppendLine(string.Format("Caller number: {0}", this.PhoneNumber))
                .ToString();
        }
    }
}
