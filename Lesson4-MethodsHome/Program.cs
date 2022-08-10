namespace Lesson4_MethodsHome 
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Max value: {MaxValue(3, 5.7f, 1, 10, 10.7f)}");
            Console.WriteLine($"Min value: {MinValue(3, 5.7f, 1, 10, 10.7f)}");
            Console.WriteLine($"Sum odd: {TrySumIfOdd(5,1, out int sum)}");
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"String: {Repeat("Hello", 5)}");
        }

        static float MaxValue(params float[] list)
        {
            float max = list[0];
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] > list[0])
                {
                    max = list[i];
                }
            }

            return max;
        }
        static float MinValue(params float[] list)
        {
            float min = list[0];
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] < list[0])
                {
                    min = list[i];
                }
            }

            return min;
        }

        static bool TrySumIfOdd(int left, int right, out int sum)
        {
            int temp = right;
            if (left > right)
            {
                right = left;
                left = temp;
            }

            sum = 0;
            for (int i = left + 1; i < right; i++)
            {
                sum += i;
            }

            if (sum % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static string Repeat(string X, int N)
        {
            if (N > 1)
            {
                return X + Repeat(X, --N);
            }

            return X;
        }
    }
}
//checked
