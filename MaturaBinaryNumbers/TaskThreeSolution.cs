namespace MaturaBinaryNumbers
{
    public class TaskThreeSolution
    {
        public (int, int) TaskThree(string path)
        {
            string[] binaryNumbers = File.ReadAllLines(path);
            int min = 0;
            int max = 0;
            for (int i = 1; i < binaryNumbers.Length; ++i)
            {
                if (IsBigger(binaryNumbers[i], binaryNumbers[max])) max = i;
                else if (!IsBigger(binaryNumbers[i], binaryNumbers[min])) min = i;
            }
            return (min + 1, max + 1);
        }
        private bool IsBigger(string a, string b)
        {
            int aLength = a.Length;
            int bLength = b.Length;
            if (aLength > bLength) return true;
            if (aLength < bLength) return false;

            for (int i = 0; i < aLength; ++i)
            {
                if (a[i] > b[i]) return true;
                else if (a[i] < b[i]) return false;
            }
            return false;
        }
    }
}
