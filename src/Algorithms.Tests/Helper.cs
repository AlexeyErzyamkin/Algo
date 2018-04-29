using System;

namespace Algorythms.Tests
{
    static class Helper
    {
        public static int[] InitArray(int size, int minValue, int maxValue)
        {
            var random = new Random();
            
            var values = new int[size];
            for (int index = 0; index < values.Length; ++index)
            {
                values[index] = random.Next(minValue, maxValue);
            }

            return values;
        }

        public static bool CheckArraySorted(int[] values)
        {
            for (int index = 0; index < values.Length; ++index)
            {
                if (index > 0)
                {
                    if (values[index] < values[index - 1])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static void PrintArray(int[] values) => Console.WriteLine(string.Join(", ", values));
    }
}