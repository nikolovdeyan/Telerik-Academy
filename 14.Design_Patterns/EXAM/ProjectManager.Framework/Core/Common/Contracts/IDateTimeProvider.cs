using System;

namespace ProjectManager.Framework.Core.Common.Contracts
{
    public interface IDateTimeProvider
    {
        DateTime GetDateTimeNow();
    }
}