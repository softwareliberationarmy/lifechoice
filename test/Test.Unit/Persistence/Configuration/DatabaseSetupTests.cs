using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
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
            //var mockContext = mocker.GetMock<DataContext>();
            //var mockDatabase = mocker.GetMock<DatabaseFacade>();
            //mockContext.SetupGet(x => x.Database).Returns(mockDatabase.Object);
            //mockDatabase.Setup(x => x.MigrateAsync(It.IsAny<CancellationToken>()))
            //    .Throws(new TimeoutException("Time's up"));

            //mocker.GetMock<IServiceProvider>().Setup(x => x.GetService(typeof(DataContext)))
            //    .Returns(mockContext.Object);

            var sut = mocker.GetMock<IServiceProvider>();
            var logger = mocker.GetMock<ILogger<DataContext>>();
            sut.Setup(x => x.GetService(typeof(ILogger<DataContext>))).Returns(logger.Object);

            await sut.Object.UpdateDatabase();

            logger.Verify(x => x.Log(
                               LogLevel.Error,
                                              It.IsAny<EventId>(),
                                              It.Is<It.IsAnyType>((v, t) => true),
                                              It.IsAny<Exception>(),
                                              It.Is<Func<It.IsAnyType, Exception, string>>((v, t) => true)), Times.Once);
        }
    }
}
