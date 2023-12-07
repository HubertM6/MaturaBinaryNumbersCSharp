using MaturaBinaryNumbers;
using System.Diagnostics;

namespace MaturaBinaryNumbersTests
{
    [TestClass]
    public class TaskThreeTests
    {
        private static string summaryTestLogFile = "../../../../test_results/task_three/test_summary.txt";
        private static string detailsTestLogFile = "../../../../test_results/task_three/test_details.txt";

        private TaskThreeSolution taskThreeSolution = new TaskThreeSolution();
        private static TestLogger logger = new TestLogger();

        [TestMethod]
        public void TestTaskThreeMaturaExample()
        {
            string inputPath = "../../../../tests_input/matura_task_three_example.txt";
            (int, int) expected = (5, 1);

            Stopwatch stopwatch = Stopwatch.StartNew();
            (int, int) result = taskThreeSolution.TaskThree(inputPath);
            stopwatch.Stop();
            logger.LogSingleTestResult("TestTaskThreeMaturaExample", expected == result, stopwatch.Elapsed.TotalSeconds);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestTaskThreeMaturaOfficial()
        {
            string inputPath = "../../../../tests_input/matura_official_test.txt";
            (int, int) expected = (859, 925);

            Stopwatch stopwatch = Stopwatch.StartNew();
            (int, int) result = taskThreeSolution.TaskThree(inputPath);
            stopwatch.Stop();
            logger.LogSingleTestResult("TestTaskThreeMaturaOfficial", expected == result, stopwatch.Elapsed.TotalSeconds);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestTaskThreeBig()
        {
            string inputPath = "../../../../tests_input/big_test.txt";
            (int, int) expected = (274, 346281);

            Stopwatch stopwatch = Stopwatch.StartNew();
            (int, int) result = taskThreeSolution.TaskThree(inputPath);
            stopwatch.Stop();
            logger.LogSingleTestResult("TestTaskThreeBig", expected == result, stopwatch.Elapsed.TotalSeconds);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestTaskThreeMax()
        {
            string inputPath = "../../../../tests_input/max_test.txt";
            (int, int) expected = (123457, 123459);

            Stopwatch stopwatch = Stopwatch.StartNew();
            (int, int) result = taskThreeSolution.TaskThree(inputPath);
            stopwatch.Stop();
            logger.LogSingleTestResult("TestTaskThreeMax", expected == result, stopwatch.Elapsed.TotalSeconds);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestTaskThreeOnlyZero()
        {
            string inputPath = "../../../../tests_input/only_zero.txt";
            (int, int) expected = (1, 1);

            Stopwatch stopwatch = Stopwatch.StartNew();
            (int, int) result = taskThreeSolution.TaskThree(inputPath);
            stopwatch.Stop();
            logger.LogSingleTestResult("TestTaskThreeOnlyZero", expected == result, stopwatch.Elapsed.TotalSeconds);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestTaskThreeOnlyOne()
        {
            string inputPath = "../../../../tests_input/only_one.txt";
            (int, int) expected = (1, 1);

            Stopwatch stopwatch = Stopwatch.StartNew();
            (int, int) result = taskThreeSolution.TaskThree(inputPath);
            stopwatch.Stop();
            logger.LogSingleTestResult("TestTaskThreeOnlyOne", expected == result, stopwatch.Elapsed.TotalSeconds);

            Assert.AreEqual(expected, result);
        }

        [ClassCleanup]
        public static void SaveResults()
        {
            logger.SaveResults(summaryTestLogFile, detailsTestLogFile);
        }
    }
}
