using MaturaBinaryNumbers;
using System.Diagnostics;

namespace MaturaBinaryNumbersTests
{
    [TestClass]
    public class TaskOneTests
    {
        private static string summaryTestLogFile = "../../../../test_results/task_one/test_summary.txt";
        private static string detailsTestLogFile = "../../../../test_results/task_one/test_details.txt";

        private TaskOneSolution taskOneSolution = new TaskOneSolution();
        private static TestLogger logger = new TestLogger();

        [TestMethod]
        public void TestTaskOneMaturaExample()
        {
            string inputPath = "../../../../tests_input/matura_task_one_example.txt";
            int expected = 3;

            Stopwatch stopwatch = Stopwatch.StartNew();
            int result = taskOneSolution.TaskOne(inputPath);
            stopwatch.Stop();
            logger.LogSingleTestResult("TestTaskOneMaturaExample", expected == result, stopwatch.Elapsed.TotalSeconds);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestTaskOneMaturaOfficial()
        {
            string inputPath = "../../../../tests_input/matura_official_test.txt";
            int expected = 422;

            Stopwatch stopwatch = Stopwatch.StartNew();
            int result = taskOneSolution.TaskOne(inputPath);
            stopwatch.Stop();
            logger.LogSingleTestResult("TestTaskOneMaturaOfficial", expected == result, stopwatch.Elapsed.TotalSeconds);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestTaskOneBig()
        {
            string inputPath = "../../../../tests_input/big_test.txt";
            int expected = 168991;

            Stopwatch stopwatch = Stopwatch.StartNew();
            int result = taskOneSolution.TaskOne(inputPath);
            stopwatch.Stop();
            logger.LogSingleTestResult("TestTaskOneBig", expected == result, stopwatch.Elapsed.TotalSeconds);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestTaskOneMax()
        {
            string inputPath = "../../../../tests_input/max_test.txt";
            int expected = 0;

            Stopwatch stopwatch = Stopwatch.StartNew();
            int result = taskOneSolution.TaskOne(inputPath);
            stopwatch.Stop();
            logger.LogSingleTestResult("TestTaskOneMax", expected == result, stopwatch.Elapsed.TotalSeconds);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestTaskOneOnlyZero()
        {
            string inputPath = "../../../../tests_input/only_zero.txt";
            int expected = 1;

            Stopwatch stopwatch = Stopwatch.StartNew();
            int result = taskOneSolution.TaskOne(inputPath);
            stopwatch.Stop();
            logger.LogSingleTestResult("TestTaskOneOnlyZero", expected == result, stopwatch.Elapsed.TotalSeconds);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestTaskOneOnlyOne()
        {
            string inputPath = "../../../../tests_input/only_one.txt";
            int expected = 0;

            Stopwatch stopwatch = Stopwatch.StartNew();
            int result = taskOneSolution.TaskOne(inputPath);
            stopwatch.Stop();
            logger.LogSingleTestResult("TestTaskOneOnlyOne", expected == result, stopwatch.Elapsed.TotalSeconds);

            Assert.AreEqual(expected, result);
        }

        [ClassCleanup]
        public static void SaveResults()
        {
            logger.SaveResults(summaryTestLogFile, detailsTestLogFile);
        }
    }
}
