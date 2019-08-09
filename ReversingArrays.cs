using System;
using System.Collections.Generic;
using System.Text;

namespace ManipulatingArrays
{
    public class ReversingArrays
    {
        //Write a method that accepts an array as an argument and prints the reversed array.For example, if you pass the method Array B, it should print[9, 7, 5, 3, 1]. Print the reverse of all three arrays.

        // Below is my solution with zero assitance. I would like to be able to use a string split and get the same output as the second solution but haven't been able to figure it out. 
        public static int reverseArray (int [] initialArray)
        {
            int newArray = initialArray[initialArray.Length - 1];
            for (int i = initialArray.Length; i > 0; i--)
            {
                Console.Write($"{initialArray[i - 1] },");                
            }
            return newArray;
        }
        // This was a combination of using stack overflow and docs.microsoft.com. I will be analyzing it a little further to see if I can use their method in mine. 
        public static string ReversingArray (int [] initialArray)
        {
            int[] reversedArray = initialArray;
            Array.Reverse(initialArray);
            return string.Join(",", reversedArray);
        }
        //Another solution I found that I thought would be fun to implement
        public static string ReverseArray (int []arr)
        {
            int start = arr[0];
            int end = arr[arr.Length - 1];
            int tempArray;
            if (start >= end)
            {
                tempArray = arr[start];
                arr[start] = arr[end];
                arr[end] = tempArray;
            }
            return string.Join(",", arr);
        }
    }
}
