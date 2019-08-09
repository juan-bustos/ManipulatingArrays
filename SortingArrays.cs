using System;
using System.Collections.Generic;
using System.Text;

namespace ManipulatingArrays
{
    class SortingArrays
    {
        public static int [] SortArray (int [] initArr)
        {
            int sortedArr = initArr.Length;
            int temp, small;

            for (int i = 0; i < sortedArr; i++)
            {
                small = i;
                for (int j = i + 1; j < initArr.Length; j++)
                {
                    if (initArr[j] < initArr[small])
                    {
                        small = j;
                    }
                }
                temp = initArr[small];
                initArr[small] = initArr[i];
                initArr[i] = temp;
            }
            return initArr;
        }
    }
}
