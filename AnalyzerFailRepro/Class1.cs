using System;

namespace AnalyzerFailRepro
{
    public class Class1
    {
        public static void DiagnosticReported(string s)
        {
            Console.WriteLine(Double.Parse(s));
        }

        public static void DiagnosticNotReportedButShould(string s)
        {
            Console.WriteLine(Double.Parse(s.AsSpan()));
        }
    }
}
