using System;

namespace Algorythms
{
    public static class SelectingSort
    {
        public static void Sort<T>(T[] values)
            where T : IComparable<T>
        {
            for (int index = 0; index < values.Length; ++index)
            {
                int minValueIndex = index;
                for (int index2 = index + 1; index2 < values.Length; ++index2)
                {
                    int compareResult = values[index2].CompareTo(values[minValueIndex]);
                    if (compareResult < 0)
                    {
                        minValueIndex = index2;
                    }
                }

                if (minValueIndex != index)
                {
                    T value = values[index];
                    values[index] = values[minValueIndex];
                    values[minValueIndex] = value;
                }
            }
        }
    }
}