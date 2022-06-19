namespace Logger.Appenders
{
    using System;
    using System.IO;
    using Logger.Layouts;
    using Logger.LogFiles;
    using Logger.ReportLevels;

    public class FileAppender : Appender
    {
        private readonly ILogFile logFile;
        public FileAppender(ILayout layout, ILogFile logFile)
            : base(layout)
        {
            this.logFile = logFile;
        }

        public override void Append(
            DateTime dateTime,
            ReportLevel reportLevel, 
            string message)
        {
            string outputMessage = string.Format(
                this.Layout.Format, 
                dateTime,
                reportLevel, 
                message) 
                +Environment.NewLine;

            this.logFile.Write(outputMessage);

            File.AppendAllText("../../../log.txt", outputMessage);
        }
    }
}
