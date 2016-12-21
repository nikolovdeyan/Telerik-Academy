using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Enumeration
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
    }
}
