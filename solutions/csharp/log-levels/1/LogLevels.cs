static class LogLine
{
    public static string Message(string logLine)
    {
        var parts = logLine.Split(':');
        return parts[1].Trim();
        throw new NotImplementedException("Please implement the (static) LogLine.Message() method");
    }

    public static string LogLevel(string logLine)
    {
        var parts = logLine.Split(':');
        return parts[0].Trim('[', ']').ToLower();
        throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");
    }

    public static string Reformat(string logLine)
    {
        return $"{Message(logLine)} ({LogLevel(logLine)})";
        throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
    }
}
