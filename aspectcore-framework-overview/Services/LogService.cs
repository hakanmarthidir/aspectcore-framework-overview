namespace aspectcore_framework_overview.Services
{
    public class LogService<T> : ILogService<T>
    {

        private readonly ILogger<T> _logger;

        public LogService(ILoggerFactory factory)
        {
            this._logger = factory.CreateLogger<T>();
        }

        public void LogError(Exception exception, string message, params object[] args)
        {
            this._logger.LogError(exception, message, args);
        }

        public void LogInformation(string message, params object[] args)
        {
            this._logger.LogInformation(message, args);
        }

        public void LogWarning(string message, params object[] args)
        {
            this._logger.LogWarning(message, args);
        }
    }
}
