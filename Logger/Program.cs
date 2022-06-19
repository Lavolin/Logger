namespace Logger
{
    using System;
    using Logger.Appenders;
    using Logger.Layouts;
    using Logger.LogFiles;
    using Logger.Loggers;
    using Logger.ReportLevels;

    public class Program
    {
        public static void Main(string[] args)
        {
            //ILayout simpleLayout = new XmlLayout(); // XML Layout

            ////Console.WriteLine(string.Format(simpleLayout.Format, "12", "23", "34" )); //check

            //IAppender consoleAppender = new ConsoleAppender(simpleLayout); // Console, file

            ////consoleAppender.Append(DateTime.Now, "Error", "Hello there"); // check

            //ILogger logger = new Logger(consoleAppender); // Error, info

            //logger.Error("Error parsing JSON.");
            //logger.Info("User Pesho successfully registered.");



            ILayout simpleLayout = new XmlLayout();
            IAppender consoleAppender = new ConsoleAppender(simpleLayout);
            consoleAppender.ReportLevel = ReportLevel.Info;

            ILogFile file = new LogFile();
            IAppender fileAppender = new FileAppender(simpleLayout, file);

            var logger = new Logger(consoleAppender, fileAppender);
            logger.Error("Error parsing JSON.");
            logger.Info("User Pesho successfully registered.");

        }
    }
}
