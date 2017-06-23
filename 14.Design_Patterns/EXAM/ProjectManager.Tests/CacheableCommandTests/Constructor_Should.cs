using Moq;
using NUnit.Framework;
using ProjectManager.Framework.Core.Commands.Contracts;
using ProjectManager.Framework.Core.Commands.Decorators;
using ProjectManager.Framework.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.Tests.CacheableCommandTests
{
    [TestFixture]
    public class Constructor_Should
    {
        [Test]
        public void CreateNewCacheableCommand_WhenProvidedCorrectParameters_ShouldNotThrow()
        {
            // Arrange
            var commandMock = new Mock<ICacheableCommand>();
            var serviceMock = new Mock<ICachingService>();

            // Act & Assert
            Assert.DoesNotThrow(() => new CacheableCommand(commandMock.Object, serviceMock.Object));
        }

        [Test]
        public void CreateNewCachingService_WhenProvidedNullCommandShouldThrow()
        {
            // Arrange
            ICacheableCommand commandMock = null;
            var serviceMock = new Mock<ICachingService>();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => new CacheableCommand(commandMock, serviceMock.Object));
        }

        [Test]
        public void CreateNewCachingService_WhenProvidedNullServiceShouldThrow()
        {
            // Arrange
            var commandMock = new Mock<ICacheableCommand>();
            ICachingService serviceMock = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => new CacheableCommand(commandMock.Object, serviceMock));
        }
    }
}
