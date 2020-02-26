using System;
using System.Collections.Generic;

namespace TestConsole.Loggers
{
    public class ListLogger : Logger
    {
        private readonly List<string> _Message = new List<string>();

        //public string[] Messages => _Message.ToArray();

        public string[] Messages
        {
            get
            {
                return _Message.ToArray();
            }
        }

        public override void Log(string Message)
        {
            _Message.Add($"{DateTime.Now}: {Message}");
        }
    }

}
