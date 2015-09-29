using System;
using System.Collections.Generic;

namespace razor2html
{

    public class LogEventArgs : EventArgs
    {
        public string Logs { get; set; }
    }

    public  delegate void LogHandler(LogEventArgs e);
    public class LogManager
    {
        public static LogManager Inst = new LogManager();

        private List<LogHandler> _handlers = new List<LogHandler>(); 
        private string _logs = "";
        private LogManager()
        {
        }

        internal void Log(string p) {
            _logs += p + "\n";

            foreach (LogHandler handler in _handlers) {

                LogEventArgs e = new LogEventArgs();
                e.Logs = _logs;
                handler(e);
            }
        }

        public void Subscribe(LogHandler handler) {
         _handlers.Add(handler);   
        }
    }
}