using System;

namespace SecondVersion
{
    class Program
    {
        static void Main()
        {
            int [] arr = MyReverse(new[] {1, 3, 5});
        }

        private static int[] MyReverse(int[] array)
        {
            var reverse = new int[array.Length];

            for (int i = array.Length - 1, j = 0; i >= 0 && j < reverse.Length; i--, j++)
            {
                reverse[j] = array[i];
            }

            return reverse;
        }
    }
}
