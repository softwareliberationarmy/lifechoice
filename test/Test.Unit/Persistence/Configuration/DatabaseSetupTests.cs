using FluentAssertions;
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
            logger.Setup(x => x.IsEnabled(It.IsAny<LogLevel>())).Returns(true);
            sut.Setup(x => x.GetService(typeof(ILogger<DataContext>))).Returns(logger.Object);


            Func<Task> act = () => sut.Object.UpdateDatabase();
            await act.Should().ThrowAsync<Exception>();

            logger.Verify(x => x.Log(
                               LogLevel.Error,
                                              It.IsAny<EventId>(),
                                              It.Is<It.IsAnyType>((v, t) => true),
                                              It.IsAny<Exception>(),
                                              It.Is<Func<It.IsAnyType, Exception, string>>((v, t) => true)!), Times.Once);
        }
    }
}
