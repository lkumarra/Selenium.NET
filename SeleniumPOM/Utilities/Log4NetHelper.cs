using log4net;
using log4net.Appender;
using log4net.Config;
using log4net.Core;
using log4net.Layout;
using System;

namespace SeleniumPOM.Utilities
{
    public class Log4NetHelper
    {
        #region Field

        private static ILog _logger;
        private static ConsoleAppender _consoleAppender;
        private static FileAppender _fileAppender;
        private static RollingFileAppender _rollingFileAppender;
        private static string layout = "%date{dd-MMM-yyyy-HH:mm:ss} [%Class] [%level] [%method] - %message%newline";

        #endregion

        #region Property

        private static string Layout
        {
            set { layout = value; }
        }

        #endregion

        #region Private

        private static PatternLayout GetPatternLayout()
        {
            var patternLayout = new PatternLayout()
            {
                ConversionPattern = layout
            };
            patternLayout.ActivateOptions();
            return patternLayout;
        }

        private static ConsoleAppender GetConsoleAppender()
        {
            var consoleAppender = new ConsoleAppender()
            {
                Name = "ConsoleAppender",
                Layout = GetPatternLayout(),
                Threshold = Level.All
            };
            consoleAppender.ActivateOptions();
            return consoleAppender;
        }

        private static FileAppender GetFileAppender()
        {
            var fileAppender = new FileAppender()
            {
                Name = "fileAppender",
                Layout = GetPatternLayout(),
                Threshold = Level.All,
                AppendToFile = false,
                File = "../../Logs/FileLogger.log"
            };
            fileAppender.ActivateOptions();
            return fileAppender;
        }

        private static RollingFileAppender GetRollingFileAppender()
        {
            var rollingFileAppender = new RollingFileAppender()
            {
                Name = "Rolling File Appender",
                AppendToFile = false,
                File = "../../Logs/RollingFileLogger.log",
                Layout = GetPatternLayout(),
                Threshold = Level.All,
                MaxSizeRollBackups = 15,
            };
            rollingFileAppender.ActivateOptions();
            return rollingFileAppender;
        }

        #endregion

        #region Public
        public static ILog GetLogger(Type type)
        {
            if (_consoleAppender == null)
            {
                _consoleAppender = GetConsoleAppender();
            }

            if (_fileAppender == null)
            {
                _fileAppender = GetFileAppender();
            }

            if (_rollingFileAppender == null)
            {
                _rollingFileAppender = GetRollingFileAppender();
            }

            if (_logger != null)
                return _logger;

            BasicConfigurator.Configure(_consoleAppender, _fileAppender, _rollingFileAppender);
            _logger = LogManager.GetLogger(type);
            return _logger;
        }
        #endregion

    }
}
