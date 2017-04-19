using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.CallHistoryTest
{
    public class GSM
    {
        private string model;
        private string manufacturer;
        private double? price;
        private string owner;
        private Display display;
        private Battery battery;
        private List<Call> callHistory;

        private static GSM iPhone4S = new GSM("iPhone 4S", "Apple", 2999, null,
                                               new Display(640, 960, 16000000),
                                               new Battery("Non-removable 1432mAh", BatteryType.LiPo, 200, 14));

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }

        public double? Price
        {
            get
            {
                if (this.price == null) return null;
                else return this.price;
            }
            set
            {
                if (value == null) this.price = null;
                else this.price = value;
            }
        }

        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        public Display Display
        {
            get
            {
                if (this.display == null) return null;
                else return this.display;
            }
            set
            {
                if (value == null) this.display = null;
                else this.display = value;
            }
        }

        public Battery Battery
        {
            get
            {
                if (this.battery == null) return null;
                else return this.battery;
            }
            set
            {
                if (value == null) this.battery = null;
                else this.battery = value;
            }
        }

        public List<Call> CallHistory
        {
            get { return this.callHistory; }
            set { this.callHistory = value; }
        }

        public static GSM IPhone4S
        {
            get
            {
                return GSM.iPhone4S;
            }
        }

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = null;
            this.Owner = null;
            this.Display = null;
            this.Battery = null;
            this.callHistory = new List<Call>();
        }
        public GSM(string model, string manufacturer, double? price)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = null;
            this.Display = null;
            this.Battery = null;
            this.callHistory = new List<Call>();
        }
        public GSM(string model, string manufacturer, double? price, string owner)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Display = null;
            this.Battery = null;
            this.callHistory = new List<Call>();
        }
        public GSM(string model, string manufacturer, double? price, string owner, Display display, Battery battery)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Display = display;
            this.Battery = battery;
            this.callHistory = new List<Call>();
        }

        public void AddCall(Call call)
        {
            this.CallHistory.Add(call);
        }

        public void DeleteCall(Call call)
        {
            this.CallHistory.Remove(call);
        }

        public void ClearCallHistory()
        {
            this.CallHistory.Clear();
        }

        // Adding CalculateCosts Method
        public decimal CalculateCosts(decimal price)
        {
            if (this.CallHistory == null || this.CallHistory.Count == 0)
            {
                return 0M;
            }
            else
            {
                decimal totalCosts = 0;
                foreach (var item in this.CallHistory)
                {
                    var callDurationSec = item.CallDuration.TotalMinutes;
                    totalCosts += (decimal)callDurationSec * price;
                }
                return totalCosts;
            }
        }
        public override string ToString()
        {
            return new StringBuilder()
                .AppendLine("************************************************")
                .AppendLine("GSM Device Information:")
                .AppendLine(string.Format("  Model:        {0}", this.Model))
                .AppendLine(string.Format("  Manufacturer: {0}", this.Manufacturer))
                .AppendLine(string.Format("  Owner:        {0}", this.Owner))
                .AppendLine(string.Format("  Price:        {0}", this.Price.ToString() ?? "N/A"))
                .AppendLine(this.Battery?.ToString() ?? "No display info available")
                .AppendLine(this.Display?.ToString() ?? "No display info available")
                .AppendLine("************************************************")
                .ToString();
        }
    }
}
