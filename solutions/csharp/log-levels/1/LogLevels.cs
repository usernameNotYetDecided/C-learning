static class LogLine
{
    public static string Message(string logLine)
    {
        if (logLine[1] == 'I')
            return logLine[7..].Trim();
        else if (logLine[1] == 'W')
            return logLine[10..].Trim();
        else
            return logLine[9..].Trim();
    }

    public static string LogLevel(string logLine)
    {
        if (logLine[1] == 'I')
            return logLine[1..5].ToLower();
        else if (logLine[1] == 'W')
            return logLine[1..8].ToLower();
        else
            return logLine[1..6].ToLower();
    }

    public static string Reformat(string logLine)
    {
        return $"{Message(logLine)} ({LogLevel(logLine)})";
    }
}
