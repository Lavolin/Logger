namespace Logger.Appenders
{
    using System;
    using Logger.Layouts;
    public abstract class Appender : IAppender
    {
        public Appender(ILayout layout)
        {
            this.Layout = layout;
        }

        public ILayout Layout { get; }

        public abstract void Append(
            DateTime dateTime,
            string errorLevel,
            string message);
        
    }
}
