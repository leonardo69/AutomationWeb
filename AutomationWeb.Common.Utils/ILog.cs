using System;

namespace AutomationWeb.Common.Utils
{
    public interface ILog
    {
        void Info(string message);
        void Info(string message, params object[] propertyValues);
        void Info(Exception exception, string message);
        void Info(Exception exception, string message, params object[] propertyValues);

        void Warn(string message);
        void Warn(string message, params object[] propertyValues);
        void Warn(Exception exception, string message);
        void Warn(Exception exception, string message, params object[] propertyValues);

        void Debug(string message);
        void Debug(string message, params object[] propertyValues);
        void Debug(Exception exception, string message);
        void Debug(Exception exception, string message, params object[] propertyValues);

        void Error(string message);
        void Error(string message, params object[] propertyValues);
        void Error(Exception exception, string message);
        void Error(Exception exception, string message, params object[] propertyValues);
    }
}
