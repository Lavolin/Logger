namespace Logger.Appenders
{
    using System;
    public interface IAppender
    {
        void Appender(
            DateTime dateTime,
            string errorLevel, // why not Enum
            string message);
    }
}
