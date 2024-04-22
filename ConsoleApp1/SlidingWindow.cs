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
    }
}
