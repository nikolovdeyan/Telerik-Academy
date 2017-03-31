using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.VersionAttribute
{
    [AttributeUsage(AttributeTargets.Struct |
                    AttributeTargets.Class |
                    AttributeTargets.Interface |
                    AttributeTargets.Enum |
                    AttributeTargets.Method,
                    AllowMultiple = false)]

    [Version(0, 06)]
    public class Version : System.Attribute
    {
        // Fields
        private int majorVersion;
        private int minorVersion;

        // Constructor
        public Version(int major, int minor)
        {
            this.MajorVersion = major;
            this.MinorVersion = minor;
        }

        // Properties
        public int MajorVersion
        {
            get { return this.majorVersion; }
            set { this.majorVersion = value; }
        }
        public int MinorVersion
        {
            get { return this.minorVersion; }
            set { this.minorVersion = value; }
        }
    }
}
