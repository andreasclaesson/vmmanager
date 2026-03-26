using System;
using System.Collections.Generic;
using System.Text;

namespace VModManager.Services
{
    public static class LoggerService
    {
        private static readonly string logPath = "log.txt";

        public static void Log(string message)
        {
            File.AppendAllText(logPath, $"[{DateTime.Now}] {message}\n");
        }
    }
}
