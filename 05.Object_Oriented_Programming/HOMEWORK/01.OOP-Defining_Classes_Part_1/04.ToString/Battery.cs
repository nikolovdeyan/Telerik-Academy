using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ToString
{
    public enum BatteryType
    {
        LiIon, NiMH, NiCd, NiOOH, LiPo
    }

    public class Battery
    {
        private string batteryModel;
        private BatteryType batteryType;
        private double? hoursIdle;
        private double? hoursTalk;

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

        // Override .ToString() Method
        public override string ToString()
        {
            return new StringBuilder()
                .AppendLine("---Battery Information:")
                .AppendLine(string.Format("    Model:        {0}", this.batteryModel))
                .AppendLine(string.Format("    Type:         {0}", this.batteryType))
                .AppendLine(string.Format("    Hours idle:   {0}", this.hoursIdle.ToString() ?? "N/A"))
                .AppendLine(string.Format("    Hours talk:   {0}", this.hoursTalk.ToString() ?? "N/A"))
                .ToString();
        }
    }
}


