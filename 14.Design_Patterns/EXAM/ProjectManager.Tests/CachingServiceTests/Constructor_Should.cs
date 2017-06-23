using NUnit.Framework;
using ProjectManager.Framework.Services;
using System;

namespace ProjectManager.Tests.CachingServiceTests
{
    [TestFixture]
    public class Constructor_Should
    {
        [Test]
        public void CreateNewCachingService_WhenProvidedCorrectParameters_ShouldNotThrow()
        {
            // Arrange
            TimeSpan validTimeSpan = new TimeSpan(0, 0, 1);

            // Act & Assert
            Assert.DoesNotThrow(() => new CachingService(validTimeSpan));
        }

        [Test]
        public void CreateNewCachingService_WhenProvidedIncorrectParameters_ShouldThrow()
        {
            // Arrange
            TimeSpan invalidTimeSpan = new TimeSpan(0, 0, -1);

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new CachingService(invalidTimeSpan));

        }
    }
}
