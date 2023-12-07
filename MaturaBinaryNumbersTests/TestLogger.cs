namespace MaturaBinaryNumbersTests
{
    internal class TestLogger
    {
        private Dictionary<string, (bool passed, double time)> results = new Dictionary<string, (bool, double)>();

        internal void LogSingleTestResult(string testName, bool passed, double time)
        {
            results.TryAdd(testName, (passed, time));
        }
        internal void SaveResults(string summaryTestLogFile, string detailsTestLogFile)
        {
            SaveSummaryResult(summaryTestLogFile);
            SaveDetailedResults(detailsTestLogFile);
        }
        private void SaveSummaryResult(string filePath)
        {
            using (var file = File.CreateText(filePath))
            {
                bool overallTestResult = results.Values.All(result => result.passed);
                file.WriteLine($"TASK COMPLETED: {overallTestResult}");
                int passedTestsCount = results.Values.Count(result => result.passed);
                file.WriteLine($"PASSED TESTS: {passedTestsCount} OF {results.Count}");
            }
        }
        private void SaveDetailedResults(string filePath)
        {
            using (var file = File.CreateText(filePath))
            {
                foreach (var item in results)
                {
                    file.WriteLine($"{DateTime.Now};{item.Key};{item.Value.passed};{Math.Round(item.Value.time, 3)}");
                }
            }
        }
    }
}
