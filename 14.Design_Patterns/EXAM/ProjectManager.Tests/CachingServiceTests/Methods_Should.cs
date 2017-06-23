using Moq;
using NUnit.Framework;
using ProjectManager.Framework.Core.Commands.Contracts;
using ProjectManager.Framework.Services;
using System;

namespace ProjectManager.Tests.CachingServiceTests
{
    [TestFixture]
    public class Methods_Should
    {
        [Test]
        public void AddCacheValue_WhenCalled_ShouldAddObjectToCache()
        {
            // Arrange 
            var sut = new CachingService(new TimeSpan(0, 0, 1));
            var mockObject = new Mock<ICacheableCommand>();
            var className = "testClass";
            var methodName = "methodName";
            sut.AddCacheValue(className, methodName, mockObject);

            // Act
            var result = sut.GetCacheValue(className, methodName);

            // Assert
            Assert.AreSame(mockObject, result);
        }

        [Test]
        public void ResetCache_WhenCalled_ShouldCleanTheCacheDictionary()
        {
            // Arrange 
            var sut = new CachingService(new TimeSpan(0, 0, 1));
            var mockObject = new Mock<ICacheableCommand>();
            var className = "testClass";
            var methodName = "methodName";
            sut.AddCacheValue(className, methodName, mockObject);

            // Act
            sut.ResetCache();

            // Assert
            var sutCache = sut.GetCacheValue(className, methodName);
            Assert.IsNull(sutCache);
        }

        [Test]
        public void GetCacheValue_WhenCalled_ShouldReturnCorrectCachedObject()
        {
            // Arrange 
            var sut = new CachingService(new TimeSpan(0, 0, 1));
            var mockObject = new Mock<ICacheableCommand>();
            var className = "testClass";
            var methodName = "methodName";
            sut.AddCacheValue(className, methodName, mockObject);

            // Act
            var result = sut.GetCacheValue(className, methodName);

            // Assert
            Assert.AreSame(mockObject, result);
        }
    }
}
