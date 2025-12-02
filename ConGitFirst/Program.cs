namespace ConGitFirst
{
    public class Program
    {
        static void Main(string[] args) 
        {
        }
        public static int SumRange(int from, int to)
        {
            if (from > to)
                throw new ArgumentException("Начало диапазона не может быть больше конца.");

            int sum = 0;

            for (int i = from; i <= to; i++)
            {
                sum += i;
            }

            return sum;
        }
        public static bool HasName(List<string> items, string name)
        {
            if (items == null)
                throw new ArgumentNullException(nameof(items));

            return items.Contains(name);
        }
        public static int CountWords(string s)
        {
            if (s == null)
                throw new ArgumentNullException(nameof(s));

            return s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        }
        public static List<int> GetEvens(int n)
        {
            var result = new List<int>();

            if (n < 2)
                return result;

            for (int i = 2; i <= n; i += 2)
            {
                result.Add(i);
            }

            return result;
        }
    }
}