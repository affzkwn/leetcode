public static class LogAnalysis 
{
    
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str, string delimiter) => str.Split(delimiter)[1];

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str, string startDelimiter, string endDelimiter) => str.Split(startDelimiter)[1].Split(endDelimiter)[0];

    public static string Message(this string logLine)
    {
        return logLine.SubstringAfter(": ");
    }

    public static string LogLevel(this string logLine)
    {
        return logLine.SubstringBetween("[", "]");
    }
}