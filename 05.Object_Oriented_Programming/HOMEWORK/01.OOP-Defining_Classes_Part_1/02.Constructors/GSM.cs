using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Constructors
{
    public class GSM
    {
        private string model;
        private string manufacturer;
        private double? price;
        private string owner;
        private Display display;
        private Battery battery;

        // Adding constructors
        // This implementation is wrong as it breaks encapsulation.
        // Private fields should be accessed through public properties only.
        // Proper implementation in 05.Properties
        public GSM(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;

            // Unknown data filled with null
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

            // Unknown data filled with null
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

            // Unknown data filled with null
            this.display = null;
            this.battery = null;
        }
        public GSM(string model, string manufacturer, double? price, string owner, Display display, Battery battery)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.display = display;
            this.battery = battery;  
        }
    }
}
