﻿using Logger.Layouts;
using Logger.ReportLevels;
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
            ReportLevel reportLevel, 
            string message)
        {

            string output = string.Format(
                this.Layout.Format,
                dateTime,
                reportLevel, 
                message);

            Console.WriteLine(output);
        }
    }
}
