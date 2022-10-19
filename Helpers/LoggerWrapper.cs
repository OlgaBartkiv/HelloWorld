using log4net;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Helpers
{
    public class LoggerWrapper
    {
        public ILog Log4Net;

        public LoggerWrapper(ILog iLog)
        {
            Log4Net = iLog;
        }

        public void Info(string message)
        {
            Log4Net.Info(message);
        }

        public void Warn(string message)
        {
            Log4Net.Warn($"\n\t\t\t\t!!! {message} !!!\n");
        }

        public void Error(string message)
        {
            Log4Net.Error($"******* {message} *******");
        }
    }
}
