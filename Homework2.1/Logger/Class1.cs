using System.Collections.Generic;
namespace Logger
{
    public sealed class Logger
    {
        private static readonly Logger instance = new Logger();
        private List<string> logs = new List<string>();

        private Logger() { }

        public static Logger Instance
        {
            get { return instance; }
        }

        public void Log(string logType, string message)
        {
            string log = $"{DateTime.Now}: {logType}: {message}";
            logs.Add(log);
            Console.WriteLine(log);
        }

        public void PrintLogsToFile(string filePath)
        {
            string allLogs = string.Join(Environment.NewLine, logs);
            System.IO.File.WriteAllText(filePath, allLogs);
        }
    }
}