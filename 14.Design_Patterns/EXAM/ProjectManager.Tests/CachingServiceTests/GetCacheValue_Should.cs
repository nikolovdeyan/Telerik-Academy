using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectManager.Tests.CachingServiceTests.Fakes;
using System;

namespace ProjectManager.Tests.CachingServiceTests
{
    [TestClass]
    public class GetCacheValue_Should
    {
        [TestMethod]
        public void ReturnProperValue_WhenInvoked()
        {
            // Arrange
            var className = "className";
            var methodName = "methodName";
            var value = "someValue";

            var service = new CachingServiceFake(TimeSpan.Zero);
            service.Cache.Add($"{className}.{methodName}", value);

            // Act
            var result = service.GetCacheValue(className, methodName);

            // Assert
            Assert.AreEqual(value, result);
        }
    }
}
