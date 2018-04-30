using System;

namespace Algorithms
{
    public static class InsertingSort
    {
        public static void Sort<T>(T[] values)
            where T: IComparable<T>
        {
            for (int index = 1; index < values.Length; ++index)
            {
                T oldValue = values[index];

                int index2;
                for (index2 = index - 1; index2 >= 0; --index2)
                {
                    if (oldValue.CompareTo(values[index2]) < 0)
                    {
                        values[index2 + 1] = values[index2];
                    }
                    else
                    {
                        values[index2] = oldValue;
                        break;
                    }
                }
            }
        }
    }
}
