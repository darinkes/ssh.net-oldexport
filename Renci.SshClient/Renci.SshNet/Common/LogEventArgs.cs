using System;

namespace Renci.SshNet.Common
{
    public class LogEventArgs : EventArgs
    {
        public string Severity { get; private set; }
        public string Message { get; private set; }

        public LogEventArgs(string severity, string message)
        {
            Severity = severity;
            Message = message;
        }
    }
}