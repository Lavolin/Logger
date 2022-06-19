namespace Logger.Appenders
{
    using System;
    using Logger.Layouts;
    public interface IAppender
    {
        ILayout Layout { get;}

        void Append(
            DateTime dateTime,
            string errorLevel, // why not Enum
            string message);
    }
}
