using Logger.Layouts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Appenders
{
    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout) 
            : base(layout)
        {
        }

        public override void Append(
            DateTime dateTime, 
            string errorLevel, 
            string message)
        {

            string output = string.Format(
                this.Layout.Format,
                dateTime, 
                errorLevel, 
                message);

            Console.WriteLine(output);
        }
    }
}
