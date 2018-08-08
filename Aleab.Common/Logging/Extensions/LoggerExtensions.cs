using System;
using Aleab.Common.Logging.Interfaces;

namespace Aleab.Common.Logging.Extensions
{
    public static class LoggerExtensions
    {
        #region Static members

        public static void Debug(this ILogger logger, string message, Exception exception = null)
        {
            logger.Log(new LogEntry(LoggingEventType.Debug, message, exception));
        }

        public static void Info(this ILogger logger, string message, Exception exception = null)
        {
            logger.Log(new LogEntry(LoggingEventType.Information, message, exception));
        }

        public static void Warn(this ILogger logger, string message, Exception exception = null)
        {
            logger.Log(new LogEntry(LoggingEventType.Warning, message, exception));
        }

        public static void Error(this ILogger logger, string message, Exception exception = null)
        {
            logger.Log(new LogEntry(LoggingEventType.Error, message, exception));
        }

        public static void Fatal(this ILogger logger, string message, Exception exception = null)
        {
            logger.Log(new LogEntry(LoggingEventType.Fatal, message, exception));
        }

        #endregion
    }
}