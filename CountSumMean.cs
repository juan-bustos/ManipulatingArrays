using System;


namespace ManipulatingArrays
{
    public class CountSumMean
    {
        public static int ArrayLength(int[] arr)
        {
            int count = 0;
            foreach (var number in arr) 
            {
                count++;
            }
            return count;
        }
        public static int ArrayCount (int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < ArrayLength(arr); i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        public static int ArrayMean (int[] arr)
        {
            return ArrayCount(arr) / ArrayLength(arr);
        }

    }
}
