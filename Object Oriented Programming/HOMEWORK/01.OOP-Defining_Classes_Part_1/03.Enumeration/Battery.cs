using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Enumeration
{
    // Adding the BatteryType enumeration
    public enum BatteryType
    {
        LiIon, NiMH, NiCd, NiOOH, LiPo
    }

    public class Battery
    {
        private string batteryModel;
        // Adding the batteryType field using the enumeration
        private BatteryType batteryType;
        private double? hoursIdle;
        private double? hoursTalk;

        // Adding batteryType to the constructors as well
        public Battery(string batteryModel, BatteryType batteryType)
        {
            this.batteryModel = batteryModel;
            this.batteryType = batteryType;
            this.hoursIdle = null;
            this.hoursTalk = null;
        }
        public Battery(string batteryModel, BatteryType batteryType, double hoursIdle, double hoursTalk)
        {
            this.batteryModel = batteryModel;
            this.batteryType = batteryType;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }
    }
}


