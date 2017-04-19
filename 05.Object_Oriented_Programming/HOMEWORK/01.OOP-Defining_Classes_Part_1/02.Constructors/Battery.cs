using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Constructors
{
    public class Battery
    {
        private string batteryModel;
        private double? hoursIdle;
        private double? hoursTalk;

        // Adding constructors
        // This implementation is wrong as it breaks encapsulation.
        // Private fields should be accessed through public properties only.
        // Proper implementation in 05.Properties
        public Battery(string batteryModel)
        {
            this.batteryModel = batteryModel;

            // Unknown data filled with null
            this.hoursIdle = null;
            this.hoursTalk = null;
        }
        public Battery(string batteryModel, double hoursIdle, double hoursTalk)
        {
            this.batteryModel = batteryModel;
            this.hoursIdle = hoursIdle;
        }
    }
}


