using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ProjectManager.Framework.Core.Commands.Contracts;
using ProjectManager.Framework.Core.Commands.Decorators;
using ProjectManager.Framework.Services;
using System.Collections.Generic;

namespace ProjectManager.Tests.CacheableCommandTests
{
    [TestClass]
    public class Execute_Should
    {
        [TestMethod]
        public void ReturnProperValue_WhenInvoked()
        {
            // Arrange
            var commandMockExecuteReturnValue = "someValue";
            var serviceMockCacheValue = "someCacheValue";

            var commandMock = new Mock<ICommand>();
            var serviceMock = new Mock<ICachingService>();
            var sut = new CacheableCommand(commandMock.Object, serviceMock.Object);

            var parameters = new List<string>();

            commandMock.Setup(x => x.Execute(It.IsAny<List<string>>())).Returns(commandMockExecuteReturnValue);
            serviceMock.Setup(x => x.GetCacheValue(It.IsAny<string>(), It.IsAny<string>())).Returns(serviceMockCacheValue);

            // Act
            var result = sut.Execute(parameters);

            // Assert
            Assert.AreEqual(serviceMockCacheValue, result);
        }
    }
}
