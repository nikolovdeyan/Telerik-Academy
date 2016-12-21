using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.GSMTest
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

        public string Model
        {
            get { return this.batteryModel; }
            set { this.batteryModel = value; }
        }

        public BatteryType Type
        {
            get { return this.batteryType; }
            set { this.batteryType = value; }
        }

        public double? HoursIdle
        {
            get
            {
                if (this.hoursIdle == null) return null;
                else return this.hoursIdle;
            }
            set
            {
                if (value == null) this.hoursIdle = null;
                else this.hoursIdle = value;
            }
        }

        public double? HoursTalk
        {
            get
            {
                if (this.hoursTalk == null) return null;
                else return this.hoursTalk;
            }
            set
            {
                if (value == null) this.hoursTalk = null;
                else this.hoursTalk = value;
            }
        }

        public Battery(string batteryModel, BatteryType batteryType)
        {
            this.Model = batteryModel;
            this.Type = batteryType;
            this.HoursIdle = null;
            this.HoursTalk = null;
        }
        public Battery(string batteryModel, BatteryType batteryType, double hoursIdle, double hoursTalk)
        {
            this.Model = batteryModel;
            this.Type = batteryType;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        public override string ToString()
        {
            return new StringBuilder()
                .AppendLine("---Battery Information:")
                .AppendLine(string.Format("    Model:        {0}", this.Model))
                .AppendLine(string.Format("    Type:         {0}", this.Type))
                .AppendLine(string.Format("    Hours idle:   {0}", this.HoursIdle.ToString() ?? "N/A"))
                .AppendLine(string.Format("    Hours talk:   {0}", this.HoursTalk.ToString() ?? "N/A"))
                .ToString();
        }
    }
}














