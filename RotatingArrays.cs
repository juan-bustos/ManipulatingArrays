using System;
using System.Collections.Generic;
using System.Text;

namespace ManipulatingArrays
{
    //Write a method that accepts three parameters, a direction(right or left), a number of places, and an array, which prints the appropriate rotation.Call the method on all three arrays. Rotate array A two places to the left. Rotate array B two places to the right. Rotate array C four places to the left.
    public class RotatingArray
    {
        public static int[] LeftArrayRotation(string direction, int shift, int[] initialArray)
        {
            int[] newArray = new int[initialArray.Length];
            shift = shift % initialArray.Length;
            //int temp;
            if (shift == 0)
            {
                foreach (var item in initialArray)
                {
                    Console.Write($"{item},");
                }
                return initialArray;
            }
            if (direction == "left")
            {
                for (int i = shift; i < initialArray.Length; i++)
                {
                    //temp = initialArray[initialArray.Length - shift];
                    Console.Write($"{initialArray[i]},");
                }
                for (int i = 0; i < shift; i++)
                {
                    Console.Write($"{initialArray[i]},");
                }
            }
            if (direction == "right")
            {
                for (int i = 0 ; i < shift; i++)
                {
                    Console.Write($"{initialArray[initialArray.Length - 1]},");
                }
                for (int i = 1; i < initialArray.Length; i++)
                {

                    newArray[i] = initialArray[i - 1];
                    Console.Write($"{newArray[i]},");
                }
            }newArray[0] = initialArray[initialArray.Length - 1];
            return newArray;
        }            
    }
}
