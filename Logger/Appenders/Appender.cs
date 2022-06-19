namespace Logger.Appenders
{
    using System;
    using Logger.Layouts;
    using Logger.ReportLevels;

    public abstract class Appender : IAppender
    {
        public Appender(ILayout layout)
        {
            this.Layout = layout;
        }

        public ILayout Layout { get; }

        public ReportLevel ReportLevel { get; set; }

        public abstract void Append(
            DateTime dateTime,
            ReportLevel reportLevel,
            string message);
        
    }
}
