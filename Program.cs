using System;

namespace ManipulatingArrays
{
    class Program
    {
        // Fun whiteboarding problem from our mentoring session on Thursday. 
        //static bool Palindrome (string s)
        //{
        //    for (int i = 0; i < s.Length-1; i++)
        //    {
        //        if (s[0] == s[s.Length-1])
        //        {
        //            return true;
        //        }
        //    } return false;

        //}
        static int [] ShowArray (int[] initialArray)
        {
            foreach (var element in initialArray)
            {
                Console.Write(element.ToString()+ " ");
            }
            Console.WriteLine();
            return null;
        }
        static void Main(string[] args)
        {
            // This is all for the Palindrome function. 
            //Console.WriteLine(Palindrome("racecar"));
            //Console.WriteLine(Palindrome("Juan"));

            int[] A = new int[] { 0,2,4,6,8,10 };
            int[] B = new int[] { 1, 3, 5, 7, 9 };
            int[] C = new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

            //Console.WriteLine($"The avg for A is: {CountSumMean.ArrayMean(A)}");
            //Console.WriteLine($"The avg for B is: {CountSumMean.ArrayMean(B)}");
            //Console.WriteLine($"The avg for C is: {CountSumMean.ArrayMean(C)}");

            //Console.WriteLine(ReversingArrays.ReversingArray(A));
            //Console.WriteLine(ReversingArrays.ReversingArray(B));
            //Console.WriteLine(ReversingArrays.ReversingArray(C));

            Console.WriteLine(ShowArray(SortingArrays.SortArray(A)));
            Console.WriteLine(ShowArray(SortingArrays.SortArray(B)));
            Console.WriteLine(ShowArray(SortingArrays.SortArray(C)));


            //this is my original solution for reversing arrays. couldn't figure out how to make the return look more organized so i used stack overflow for a solution. the solution printed on the console is the one found on stack overflow. 
            //Console.WriteLine(ReversingArrays.reverseArray(A));
            //Console.WriteLine(ReversingArrays.reverseArray(B));
            //Console.WriteLine(ReversingArrays.reverseArray(C));

            // This is the output for rotating Arrays A, B, and C.
            //RotatingArray.LeftArrayRotation("left", 2, A);
            //Console.WriteLine();
            //RotatingArray.LeftArrayRotation("right", 2, B); // Having some issues with the Right shift. I was testing for shifts of 1, but when it comes to shifts of 2 or more I just receive the final array element printed however many times. I'm assuming this is because of the for loop. 
            //Console.WriteLine();
            //RotatingArray.LeftArrayRotation("left", 4, C);
            //Console.WriteLine();






        }
    }
}
