using MaturaBinaryNumbers;
using System.Diagnostics;

namespace MaturaBinaryNumbersTests
{
    [TestClass]
    public class TaskTwoTests
    {
        private static string summaryTestLogFile = "../../../../test_results/task_two/test_summary.txt";
        private static string detailsTestLogFile = "../../../../test_results/task_two/test_details.txt";

        private TaskTwoSolution taskTwoSolution = new TaskTwoSolution();
        private static TestLogger logger = new TestLogger();

        [TestMethod]
        public void TestTaskTwoMaturaExample()
        {
            string inputPath = "../../../../tests_input/matura_task_two_example.txt";
            (int, int) expected = (3, 2);

            Stopwatch stopwatch = Stopwatch.StartNew();
            (int, int) result = taskTwoSolution.TaskTwo(inputPath);
            stopwatch.Stop();
            logger.LogSingleTestResult("TestTaskTwoMaturaExample", expected == result, stopwatch.Elapsed.TotalSeconds);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestTaskTwoMaturaOfficial()
        {
            string inputPath = "../../../../tests_input/matura_official_test.txt";
            (int, int) expected = (500, 123);

            Stopwatch stopwatch = Stopwatch.StartNew();
            (int, int) result = taskTwoSolution.TaskTwo(inputPath);
            stopwatch.Stop();
            logger.LogSingleTestResult("TestTaskTwoMaturaOfficial", expected == result, stopwatch.Elapsed.TotalSeconds);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestTaskTwoBig()
        {
            string inputPath = "../../../../tests_input/big_test.txt";
            (int, int) expected = (193243, 48399);

            Stopwatch stopwatch = Stopwatch.StartNew();
            (int, int) result = taskTwoSolution.TaskTwo(inputPath);
            stopwatch.Stop();
            logger.LogSingleTestResult("TestTaskTwoBig", expected == result, stopwatch.Elapsed.TotalSeconds);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestTaskTwoMax()
        {
            string inputPath = "../../../../tests_input/max_test.txt";
            (int, int) expected = (400001, 0);

            Stopwatch stopwatch = Stopwatch.StartNew();
            (int, int) result = taskTwoSolution.TaskTwo(inputPath);
            stopwatch.Stop();
            logger.LogSingleTestResult("TestTaskTwoMax", expected == result, stopwatch.Elapsed.TotalSeconds);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestTaskTwoOnlyZero()
        {
            string inputPath = "../../../../tests_input/only_zero.txt";
            (int, int) expected = (1, 1);

            Stopwatch stopwatch = Stopwatch.StartNew();
            (int, int) result = taskTwoSolution.TaskTwo(inputPath);
            stopwatch.Stop();
            logger.LogSingleTestResult("TestTaskTwoOnlyZero", expected == result, stopwatch.Elapsed.TotalSeconds);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestTaskTwoOnlyOne()
        {
            string inputPath = "../../../../tests_input/only_one.txt";
            (int, int) expected = (0, 0);

            Stopwatch stopwatch = Stopwatch.StartNew();
            (int, int) result = taskTwoSolution.TaskTwo(inputPath);
            stopwatch.Stop();
            logger.LogSingleTestResult("TestTaskTwoOnlyOne", expected == result, stopwatch.Elapsed.TotalSeconds);

            Assert.AreEqual(expected, result);
        }

        [ClassCleanup]
        public static void SaveResults()
        {
            logger.SaveResults(summaryTestLogFile, detailsTestLogFile);
        }
    }
}
