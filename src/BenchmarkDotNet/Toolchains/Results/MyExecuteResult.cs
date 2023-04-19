using System.Collections.Generic;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Reports;

namespace BenchmarkDotNet.Toolchains.Results
{
    public class MyExecuteResult : ExecuteResult
    {
        public long Start { get; }
        public long End { get; }

        public MyExecuteResult(bool foundExecutable, int? exitCode, int? processId, IReadOnlyList<string> results, IReadOnlyList<string> prefixedLines,
            IReadOnlyList<string> standardOutput, int launchIndex, long start, long end) : base(foundExecutable, exitCode, processId, results, prefixedLines,
            standardOutput,
            launchIndex)
        {
            Start = start;
            End = end;
        }

        internal MyExecuteResult(List<Measurement> measurements, GcStats gcStats, ThreadingStats threadingStats, double exceptionFrequency) : base(measurements,
            gcStats, threadingStats, exceptionFrequency) { }

        internal MyExecuteResult(List<Measurement> measurements) : base(measurements) { }
    }
}