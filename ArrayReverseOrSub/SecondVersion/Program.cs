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

            for (
                int i = array.Length - 1, j = 0; // init managers variable
                i >= 0 && j < reverse.Length; // block conditions
                i--, j++) // change managers variable
            {
                reverse[j] = array[i];
            }

            return reverse;
        }
    }
}
