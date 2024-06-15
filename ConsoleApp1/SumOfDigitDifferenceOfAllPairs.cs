using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class SumOfDigitDifferenceOfAllPairs
    {
        /* You are given an array nums consisting of positive integers where all integers have the same number of digits.

   The digit difference between two integers is the count of different digits that are in the same position in the two integers.

   Return the sum of the digit differences between all pairs of integers in nums.
        Example 1:

 Input: nums = [13,23,12]

 Output: 4

 Explanation:
 We have the following:
 - The digit difference between 13 and 23 is 1.
 - The digit difference between 13 and 12 is 1.
 - The digit difference between 23 and 12 is 2.
 So the total sum of digit differences between all pairs of integers is 1 + 1 + 2 = 4.

 Example 2:

 Input: nums = [10,10,10,10]

 Output: 0

 Explanation:
 All the integers in the array are the same. So the total sum of digit differences between all pairs of integers will be 0.



 Constraints:

 2 <= nums.length <= 105
 1 <= nums[i] < 109
 All integers in nums have the same number of digits.
         */
        public long SumDigitDifferences(int[] nums)
        {
            long total = 0;
            int firstCompareDigit = 0;
            int secondCompareDigit = 0;
       
            int count = 0;
            int j = nums.Length - 1;
     
            for(int i =0; i<nums.Length; i++)
            {
                if (i+1 <= j)
                {
                    firstCompareDigit = nums[i] / 10;
                    secondCompareDigit = nums[i + 1] / 10;
                    int secondCompare = nums[i] % 10;
                    int secondCompares = nums[i + 1] % 10;
                    if(firstCompareDigit - secondCompareDigit != 0)
                    {
                        count++;
                    }
                    if(secondCompare- secondCompares != 0)
                    {
                        count++;
                    }
                    total += count;
                   

                }

            }

            return total;
        }
    }
}
