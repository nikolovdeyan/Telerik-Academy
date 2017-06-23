using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectManager.Tests.CachingServiceTests.Fakes;
using System;
using System.Collections.Generic;

namespace ProjectManager.Tests.CachingServiceTests
{
    [TestClass]
    public class ResetCache_Should
    {
        [TestMethod]
        public void ResetCacheSuccessefully_WhenInvoked()
        {
            // Arrange
            var className = "className";
            var methodName = "methodName";
            var value = "someValue";

            var service = new CachingServiceFake(TimeSpan.Zero);
            service.AddCacheValue(className, methodName, value);

            // Act
            service.ResetCache();

            // Assert
            Assert.ThrowsException<KeyNotFoundException>(() => service.Cache[$"{className}.{methodName}"]);
        }
    }
}
