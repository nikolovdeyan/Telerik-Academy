using ProjectManager.Framework.Core.Common.Contracts;
using System;

namespace ProjectManager.Framework.Core.Common.Providers
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime GetDateTimeNow()
        {
            return DateTime.Now;
        }
    }
}
