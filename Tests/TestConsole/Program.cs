using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    static class Program
    {
        static void Main(string[] args)
        {
            //Logger logger = new FileLogger("program.log");
            //logger.LogInformation("start program");

            //Logger logger = new VisualStrudioOutputLogger();
            Logger logger = new TraceLogger();
            Trace.Listeners.Add(new TextWriterTraceListener("trace.log"));
             
            for (int i = 0; i < 10; i++)
            {
                logger.LogInformation($"Do some work {i + 1}");
            }

            logger.LogWarning("Завершение работы приложения");

            //var log_message = ((FileLogger)logger).Messages;

            Trace.Flush();

            Console.WriteLine();

            
        }
    }

   


}
