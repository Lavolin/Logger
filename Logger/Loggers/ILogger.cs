
namespace Logger.Loggers
{
    using Appenders;
    public interface ILogger
    {
        IAppender Appender { get; }

        void Info(string message);

        void Warning(string message);

        void Error(string message);
    }
}
