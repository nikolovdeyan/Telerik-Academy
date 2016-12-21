using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ToString
{
    public class GSM
    {
        private string model;
        private string manufacturer;
        private double? price;
        private string owner;
        private Display display;
        private Battery battery;

        public GSM(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = null;
            this.owner = null;
            this.display = null;
            this.battery = null;
        }
        public GSM(string model, string manufacturer, double? price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = null;
            this.display = null;
            this.battery = null;
        }
        public GSM(string model, string manufacturer, double? price, string owner)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.display = null;
            this.battery = null;
        }
        public GSM(string model, string manufacturer, double? price, string owner, Display display, Battery battery)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            // Wrong as it breaks encapsulation
            // Proper implementation in 05.Properties
            this.display = display;
            this.battery = battery;
        }


        // Adding an extension method to check nullable types
        //public static string ToStringNullSafe(this object value)
        //{
        //    return (value ?? string.Empty).ToString();
        //}

        // Adding a method to display information about the GSM class
        // Override .ToString() Method
        public override string ToString()
        {
            return new StringBuilder()
                .AppendLine("************************************************")
                .AppendLine("GSM Device Information:")
                .AppendLine(string.Format("  Model:        {0}", this.model))
                .AppendLine(string.Format("  Manufacturer: {0}", this.manufacturer))
                .AppendLine(string.Format("  Owner:        {0}", this.owner))
                .AppendLine(string.Format("  Price:        {0}", this.price.ToString() ?? "N/A"))
                .AppendLine(this.battery?.ToString() ?? "No display info available")
                .AppendLine(this.display?.ToString() ?? "No display info available")
                .AppendLine("************************************************")
                .ToString();  
        }
    }
}
