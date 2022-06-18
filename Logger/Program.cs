namespace Logger
{
    using Logger.Layouts;
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            ILayout simpleLayout = new SimpleLayout(); // XML Layout

            //Console.WriteLine(string.Format(simpleLayout.Format, "12", "23", "34" ));

            IAppender consoleAppender = new ConsoleAppender(simpleLayout); // Console, file
            //ILogger logger = new Logger(consoleAppender); / Error, info

            //logger.Error("3/26/2015 2:08:11 PM", "Error parsing JSON.");
            //logger.Info("3/26/2015 2:08:11 PM", "User Pesho successfully registered.");



            //var simpleLayout = new SimpleLayout();
            //var consoleAppender = new ConsoleAppender(simpleLayout);

            //var file = new LogFile();
            //var fileAppender = new FileAppender(simpleLayout, file);

            //var logger = new Logger(consoleAppender, fileAppender);
            //logger.Error("3/26/2015 2:08:11 PM", "Error parsing JSON.");
            //logger.Info("3/26/2015 2:08:11 PM", "User Pesho successfully registered.");

        }
    }
}
