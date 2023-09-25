using Microsoft.Extensions.Logging;

namespace Persistence.Logging;

public static class LoggerMessages
{
    private static readonly Action<ILogger<DataContext>, Exception> _migrationFailure = 
        LoggerMessage.Define(LogLevel.Error, new EventId(100, nameof(LogMigrationFailure)), 
        "Error applying migrations to database");
    
    public static void LogMigrationFailure(this ILogger<DataContext> logger, Exception ex)
    {
        _migrationFailure(logger, ex);
    }
}