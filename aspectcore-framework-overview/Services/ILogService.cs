﻿namespace aspectcore_framework_overview.Services
{
    public interface ILogService<T>
    {
        void LogInformation(string message, params object[] args);
        void LogWarning(string message, params object[] args);
        void LogError(Exception exception, string message, params object[] args);
    }
}
