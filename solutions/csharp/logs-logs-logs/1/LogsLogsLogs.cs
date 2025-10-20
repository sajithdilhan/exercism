public enum LogLevel 
        {
           Unknown = 0,
           Trace = 1,
           Debug = 2,
           Info = 4,
           Warning = 5,
           Error = 6,
           Fatal = 42
        };

static class LogLine
{
    public static LogLevel ParseLogLevel(string logLine)
    {
        if (logLine.Contains("[TRC]"))
            return LogLevel.Trace;
        else if(logLine.Contains("[DBG]"))
            return LogLevel.Debug;
        else if(logLine.Contains("[INF]"))
            return LogLevel.Info;
        else if(logLine.Contains("[WRN]"))
            return LogLevel.Warning;
        else if(logLine.Contains("[ERR]"))
            return LogLevel.Error;
        else if(logLine.Contains("[FTL]"))
            return LogLevel.Fatal;
        else
            return LogLevel.Unknown;
    }

    public static string OutputForShortLog(LogLevel logLevel, string message) => $"{(int)logLevel}:{message}";
}
