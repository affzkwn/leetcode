public static class LogAnalysis 
{
    
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str, string delimiter)
    {

        var index = str.IndexOf(delimiter);
        return index >= 0 ? str.Substring(index + delimiter.Length) : string.Empty;
    }

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str, string startDelimiter, string endDelimiter)
    {
        var startIndex = str.IndexOf(startDelimiter);
        if (startIndex < 0) return string.Empty;

        startIndex += startDelimiter.Length;
        var endIndex = str.IndexOf(endDelimiter, startIndex);
        return endIndex >= 0 ? str.Substring(startIndex, endIndex - startIndex) : string.Empty;
    }

    public static string Message(this string logLine)
    {
        return logLine.SubstringAfter(": ");
    }

    public static string LogLevel(this string logLine)
    {
        return logLine.SubstringBetween("[", "]");
    }
}