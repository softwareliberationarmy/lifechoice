using Microsoft.Extensions.Logging;
using Moq;
using Moq.AutoMock;
using Persistence;
using Persistence.Configuration;

namespace Test.Unit.Persistence.Configuration
{
    public class DatabaseSetupTests
    {

        [Fact]
        public async Task UpdateDatabase_Should_Log_Error()
        {
            var mocker = new AutoMocker();

            var sut = mocker.GetMock<IServiceProvider>();
            var logger = mocker.GetMock<ILogger<DataContext>>();
            sut.Setup(x => x.GetService(typeof(ILogger<DataContext>))).Returns(logger.Object);

            await sut.Object.UpdateDatabase();

            logger.Verify(x => x.Log(
                               LogLevel.Error,
                                              It.IsAny<EventId>(),
                                              It.Is<It.IsAnyType>((v, t) => true),
                                              It.IsAny<Exception>(),
                                              It.Is<Func<It.IsAnyType, Exception, string>>((v, t) => true)!), Times.Once);
        }
    }
}
