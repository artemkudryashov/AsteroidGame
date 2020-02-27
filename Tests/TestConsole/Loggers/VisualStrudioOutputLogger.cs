namespace TestConsole.Loggers
{
    public class VisualStrudioOutputLogger : DebugLogger
    {

        public override void Log(string Message)
        {
            System.Diagnostics.Debug.WriteLine($">>>>>> {Message}");
        }

        public override void Log(string Message, string Category)
        {
            System.Diagnostics.Debug.WriteLine($">>>>>> {Message}", Category);
        }
    }

}
