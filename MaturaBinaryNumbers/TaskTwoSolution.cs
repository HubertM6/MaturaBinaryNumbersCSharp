namespace MaturaBinaryNumbers
{
    public class TaskTwoSolution
    {
        public (int, int) TaskTwo(string path)
        {
            string[] binaryNumbers = File.ReadAllLines(path);
            int amountOfDivisibleByTwo = 0;
            int amountOfDivisibleByEight = 0;
            foreach (string binaryNumber in binaryNumbers)
            {
                int length = binaryNumber.Length;
                if (binaryNumber[length - 1] == '0') ++amountOfDivisibleByTwo;
                if ((length == 1 && binaryNumber[0] == '0') || (length >= 3 && binaryNumber[length - 1] == '0' && binaryNumber[length - 2] == '0' && binaryNumber[length - 3] == '0')) ++amountOfDivisibleByEight;
            }
            return (amountOfDivisibleByTwo, amountOfDivisibleByEight);
        }
    }
}
