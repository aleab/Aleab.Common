using Aleab.Common.Logging.Interfaces;

namespace Aleab.Common.Logging
{
    internal class NullLogger : ILogger
    {
        public void Log(LogEntry entry)
        {
        }
    }
}