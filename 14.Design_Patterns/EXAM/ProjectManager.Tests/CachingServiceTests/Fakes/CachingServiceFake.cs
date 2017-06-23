using ProjectManager.Framework.Services;
using System;
using System.Collections.Generic;

namespace ProjectManager.Tests.CachingServiceTests.Fakes
{
    public class CachingServiceFake : CachingService
    {
        public CachingServiceFake(TimeSpan duration) : base(duration)
        {

        }

        public TimeSpan Duration
        {
            get
            {
                return this.duration;
            }
        }

        public DateTime TimeExpiring
        {
            get
            {
                return this.timeExpiring;
            }
        }

        public IDictionary<string, object> Cache
        {
            get
            {
                return this.cache;
            }
        }
    }
}
