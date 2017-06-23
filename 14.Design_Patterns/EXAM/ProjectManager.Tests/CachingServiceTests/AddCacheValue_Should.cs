using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectManager.Tests.CachingServiceTests.Fakes;
using System;

namespace ProjectManager.Tests.CachingServiceTests
{
    [TestClass]
    public class AddCacheValue_Should
    {
        [TestMethod]
        public void SetProperValueToCache_WhenInvoked()
        {
            // Arrange
            var className = "className";
            var methodName = "methodName";
            var value = "someValue";

            var service = new CachingServiceFake(TimeSpan.Zero);

            // Act
            service.AddCacheValue(className, methodName, value);

            // Assert
            Assert.AreEqual(value, service.Cache[$"{className}.{methodName}"]);
        }
    }
}
