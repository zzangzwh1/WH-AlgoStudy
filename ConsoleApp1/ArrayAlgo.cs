using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ArrayAlgo
    {
        /// <summary>
        /// Given an array arr[] of size N. The task is to find the sum of the contiguous subarray within a arr[] with the largest sum. 
        /// </summary>
        /// <param name="arr"></param>
        public void LargestSum(int[] arr)
        {
            int sum = 0;
            int currentSum = 0;
            foreach (int n in arr)
            {
                currentSum += n;
                if (currentSum < 0)
                {
                    currentSum = 0;
                }
                else
                {

                    sum = Math.Max(sum, currentSum);
                }
            }
            if(sum == 0)
            {
                sum = int.MaxValue;
                for(int i = 0; i <arr.Length; i++)
                {
                    int makeMinus = arr[i] * -1;
                  
                    sum = Math.Min(makeMinus, sum);
                }
            }
            Console.WriteLine(sum *-1);
        }
        /// <summary>
        /// Given an array arr[] of size N-1 with integers in the range of [1, N], the task is to find the missing number from the first N integers
        /// </summary>
        /// <param name="arr"></param>
        public void FindMissingNumber(int[] arr,int n)
        {
            int currentSum = 0;
            for(int i = 0; i< arr.Length; i++)
            {
                currentSum += arr[i];
            }
            Console.WriteLine(currentSum);
            int maxInArr = FindMaxFromArr(arr);
            Console.WriteLine(maxInArr);
            int total = CalculateMax(maxInArr);
            Console.WriteLine($"CurrentSUM : {currentSum} \n TOTAL : {total}");
            Console.WriteLine(total - currentSum);

        }
        public int CalculateMax(int n)
        {
            int sum = 0;
            for(int i = 0; i<=n; i++)
            {
                sum += i;
            }
            return sum;
        }
        public int FindMaxFromArr(int[] arr)
        {
            int max = 0;
            foreach(int n in arr)
            {
                max = Math.Max(max, n);
            }
            return max;

        }

    }
}
