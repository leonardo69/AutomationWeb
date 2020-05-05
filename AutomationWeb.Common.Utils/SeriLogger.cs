using System;

namespace AutomationWeb.Common.Utils
{
    public class SeriLogger: ILog
    {
        public void Info(string message)
        {
            Serilog.Log.Information(message);
        }

        public void Info(string message, params object[] propertyValues)
        {
            Serilog.Log.Information(message, propertyValues);
        }

        public void Info(Exception exception, string message)
        {
            Serilog.Log.Information(exception, message);
        }

        public void Info(Exception exception, string message, params object[] propertyValues)
        {
            Serilog.Log.Information(exception, message, propertyValues);
        }


        public void Warn(string message)
        {
            Serilog.Log.Warning(message);
        }

        public void Warn(string message, params object[] propertyValues)
        {
            Serilog.Log.Warning(message, propertyValues);
        }

        public void Warn(Exception exception, string message)
        {
            Serilog.Log.Warning(exception, message);
        }

        public void Warn(Exception exception, string message, params object[] propertyValues)
        {
            Serilog.Log.Warning(exception, message, propertyValues);
        }


        public void Debug(string message)
        {
            Serilog.Log.Debug(message);
        }

        public void Debug(string message, params object[] propertyValues)
        {
            Serilog.Log.Debug(message, propertyValues);
        }

        public void Debug(Exception exception, string message)
        {
            Serilog.Log.Debug(exception, message);
        }

        public void Debug(Exception exception, string message, params object[] propertyValues)
        {
            Serilog.Log.Debug(exception, message, propertyValues);
        }


        public void Error(string message)
        {
            Serilog.Log.Error(message);
        }

        public void Error(string message, params object[] propertyValues)
        {
            Serilog.Log.Error(message, propertyValues);
        }

        public void Error(Exception exception, string message)
        {
            Serilog.Log.Error(exception, message);
        }

        public void Error(Exception exception, string message, params object[] propertyValues)
        {
            Serilog.Log.Error(exception, message, propertyValues);
        }
    }
}
