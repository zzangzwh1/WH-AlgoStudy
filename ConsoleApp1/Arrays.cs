using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Arrays
    {
        /// <summary>
        /// 
        /// Move All 0 to end
        /// </summary>
        /// <param name="arr"></param>
        public void PushZeroToEnd(int[] arr)
        {
            int[] pushedZeroToEnd = new int[arr.Length];
            int pivotStart = 0;


            // First, add all non-zero elements to the new array.
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    pushedZeroToEnd[pivotStart++] = arr[i];
                }
            }

            // No need to explicitly add zeros since the array is already initialized with zeros.

            foreach (int n in pushedZeroToEnd)
            {
                Console.Write($"{n} ");
            }

        }
        /// <summary>
        /// Input: N = 4, arr[] = {1, 2, 2, 1}
        //        Output: 2 1 2 1
        //Explanation:
        //
        //For i = 1, arr[1] <= arr[0]. So, 1 <= 2.
        //For i = 2, arr[2] >= arr[1]. So, 2 >= 1.
        //For i = 3, arr[3] <= arr[2]. So, 1 <= 2.
        //Input: arr[] = {1, 3, 2}
        //Output: 3 1 2
        //Explanation:
        //
        //For i = 1, arr[1] <= arr[0]. So, 1 <= 3.
        //For i = 2, arr[2] >= arr[1]. So, 2 >= 1.
        /// </summary>
        /// <param name="arr"></param>
        public void Rearrange(int[] arr)
        {
            if (arr.Length < 2)
            {
                Console.WriteLine("Invalid");
                return;
            }
           
            for (int i = 1; i <= arr.Length - 1; i++)
            {
               
                if (i % 2 == 0 && arr[i - 1] > arr[i - 2])
                {
                    int test = arr[i - 2];
                    arr[i - 2] = arr[i - 1];
                    arr[i - 1] = test;

                }

            }
            foreach (int n in arr)
            {
                Console.WriteLine(n);
            }

        }
    }
}
