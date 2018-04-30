using System;
using System.Linq;

namespace Algorithms.Tests
{
    public static class ArrayHelper
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

        public static bool CompareArrays(int[] array1, int[] array2)
        {
            var array2Grouped = array2.GroupBy(x2 => x2);

            return array1
                .GroupBy(x => x)
                .All(x => x.Count() == array2Grouped.First(x2 => x2.Key == x.Key).Count());
        }

        public static void PrintArray(int[] values) => Console.WriteLine(string.Join(", ", values));
    }
}