using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StaticField
{
    public class GSM
    {
        private string model;
        private string manufacturer;
        private double? price;
        private string owner;
        private Display display;
        private Battery battery;
        // Adding the private field to hold the information for IPhone4S
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
        // Adding a private property for the IPhone4S
        public static GSM IPhone4S
        {
            get
            {
                return new GSM ("iPhone 4S", "Apple", 2999, null, 
                                  new Display (640, 960, 16000000),
                                  new Battery ("Non-removable 1432mAh", BatteryType.LiPo, 200, 14));
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
        }
        public GSM(string model, string manufacturer, double? price)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = null;
            this.Display = null;
            this.Battery = null;
        }
        public GSM(string model, string manufacturer, double? price, string owner)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Display = null;
            this.Battery = null;
        }
        public GSM(string model, string manufacturer, double? price, string owner, Display display, Battery battery)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Display = display;
            this.Battery = battery;
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
