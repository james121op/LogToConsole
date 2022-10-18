using BrokeProtocol.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace _LogToConsole
{
    public class LogToConsole : Plugin
    {
        public LogToConsole()
        {
            Info = new PluginInfo("LogToConsole", "LogToConsole");
            Application.logMessageReceived += Application_logMessageReceived;
        }

        private void Application_logMessageReceived(string logContents, string stackTrace, LogType type)
        {
            System.IO.File.AppendAllText("InternalConsole", String.IsNullOrWhiteSpace(stackTrace) ? $"{logContents}\n" : $"{logContents}\n{stackTrace}\n");
        }
    }
}
