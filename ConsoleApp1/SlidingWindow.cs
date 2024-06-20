using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Leetcode 209. Min Size subarray sum
    /// givien an array of positive integers nums and a postive interger target,
    /// return the minimal length of a contiguous subarray 
    /// of which the sum is greater than or equal to target if there is no such subarray
    /// return 0
    /// Ex 1) 
    ///input : target = 7 , nums = [2,3,1,2,4,3]
    ///output : 2
    ///the sub array[4,3] has the min length under the problem constraint
    ///
    /// EX 2)
    /// input target :4 nums [1,4,4]
    /// output 1
    /// 
    /// Ex 3)
    /// input target = 11 , nums [1,1,1,1,1,1,1,1,1,1,1]
    /// output 0
    /// </summary>
    internal class SlidingWindow
    {
        public int MinSubArrary(int target, int[] nums)
        {
            int lengthOfArr = int.MaxValue;
            int sum = 0;
            int left = 0;

            for (int right = 0; right < nums.Length; right++)
            {
                sum += nums[right];

                while (sum >= target)
                {
                    lengthOfArr = Math.Min(lengthOfArr, right - left + 1);
                    sum -= nums[left];
                    left++;
                }
            }

            return lengthOfArr == int.MaxValue ? 0 : lengthOfArr;
        }

        /// <summary>
        ///  Set 1: Sliding Window Maximum (Maximum of all subarrays of size k).
        //  Given an array arr of size N and an integer K, the task is to find the maximum for each and every contiguous subarray of size K.
        //
        //   Examples: 
        //
        //   Input: arr[] = {1, 2, 3, 1, 4, 5, 2, 3, 6}, K = 3 
        //   Output: 3 3 4 5 5 5 6 
        //   All contiguous subarrays of size k are 
        //   {1, 2, 3} => 3 
        //   {2, 3, 1} => 3 
        //   {3, 1, 4} => 4 
        //   {1, 4, 5} => 5 
        //   {4, 5, 2} => 5 
        //   {5, 2, 3} => 5 
        //   {2, 3, 6} => 6
        //
        //   Input: arr[] = {8, 5, 10, 7, 9, 4, 15, 12, 90, 13}, K = 4 
        //   Output: 10 10 10 15 15 90 90  
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="k"></param>
        public  void MaxOfAllSubArrary(int[] arr, int k)
        {
            if (k == 0)
                return;
            if(k == 1)
            {
                foreach(int index in arr)
                {
                    Console.WriteLine($"Max Index : {index}");
                }
            }
            int start = 0;
            int pivotStart = 0;
            int end = k - 1;
            int maxSum = arr[k - 1];

            List<int> maxSubArrCollections = new List<int>();

            while(end <= arr.Length-1)
            {
                if (arr[start] > maxSum)
                    maxSum = arr[start];

                start++;
                if(start == end && end != arr.Length)
                {
                    maxSubArrCollections.Add(maxSum);
                    end++;
                    pivotStart++;
                    start = pivotStart;
                    if (end < arr.Length)
                        maxSum = arr[end];

                }

            }
            foreach(int n in maxSubArrCollections)
            {
                Console.WriteLine($"maxsum : {n}");
            }


        }
    }
}
