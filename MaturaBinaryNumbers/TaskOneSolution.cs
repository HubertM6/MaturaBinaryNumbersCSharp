namespace MaturaBinaryNumbers
{
    public class TaskOneSolution
    {
        public int TaskOne(string path)
        {
            string[] binaryNumbers = File.ReadAllLines(path);
            int amount = 0;
            foreach (string binaryNumber in binaryNumbers)
            {
                if (HasMoreZeros(binaryNumber)) ++amount;
            }
            return amount;
        }
        private bool HasMoreZeros(string binaryNumber)
        {
            int zeros = 0;
            int ones = 0;
            foreach (char digit in binaryNumber)
            {
                if (digit == '0') ++zeros;
                else ++ones;
            }
            return zeros > ones;
        }
    }
}
