using System;

namespace AnalyzerFailRepro
{
    public class Class1
    {
        public static void DiagnosticReportedAsExpected(string s)
        {
            Console.WriteLine(Double.Parse(s));
        }

        public static void DiagnosticNotReportedButShould(ReadOnlySpan<char> s)
        {
            Console.WriteLine(Double.Parse(s));
        }
    }
}
