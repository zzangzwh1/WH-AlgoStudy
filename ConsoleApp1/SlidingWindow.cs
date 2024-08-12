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
        /// <summary>
<<<<<<< HEAD
        /// Given an array arr[] of size n containing integers. The problem is to find the length of the longest sub-array having sum equal to the given value k.

         //Examples: 

        //Input: arr[] = { 10, 5, 2, 7, 1, 9 }, k = 15
        //Output: 4
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="k"></param>
        public void LongestSubArr(int[] arr, int k)
        {
            int pivotStart = 0;
            int start = 0;
            int currentSum = 0;
            int countSubArr = 0;
            int total = 0;

            while(start < arr.Length)
            {
                currentSum += arr[start];
                countSubArr++;
                start++;
                if(currentSum == k)
                {
                    total = Math.Max(countSubArr, total);
                    countSubArr = 0;
                    currentSum = 0;
                    start = ++pivotStart;
                }
                
            }

            Console.WriteLine($"Total Length : {total}");

        }
      
=======
        /// Example 1:
        //    Input: “ABCDEFGABEF”
        //    Output: 7
        //    Explanation: The longest substring without repeating characters are “ABCDEFG”, “BCDEFGA”, and “CDEFGAB” with lengths of 7
        //
        //    Example 2:
        //    Input: “GEEKSFORGEEKS”
        //    Output: 7
        //    Explanation: The longest substrings without repeating characters are “EKSFORG” and “KSFORGE”, with lengths of 7
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string longestUniqueSubsttrBruceForce(string str)
        {

            // Result to store the maximum length of substring without repeating characters
            int result = 0;

            // Starting index of the longest substring
            int start = 0;

            // End index of the longest substring
            int end = 0;

            for (int i = 0; i < str.Length; i++)
            {
                // Boolean array to mark visited characters in the current window
                bool[] visited = new bool[256];

                // Inner loop to extend the window
                for (int j = i; j < str.Length; j++)
                {
                    // If the current character is already visited, break the loop
                    if (visited[str[j]] == true)
                        break;

                    // If not, update the result if the current window is larger
                    // and mark the current character as visited
                    else
                    {
                        if (j - i + 1 > result)
                        {
                            result = j - i + 1;
                            start = i;
                            end = j;
                        }
                        visited[str[j]] = true;
                    }
                }

                // Remove the first character of the previous window
                visited[str[i]] = false;
            }

            // Return the longest substring
            return str.Substring(start, result);
        }

        public  int LongestSubStr(string sArr)
        {
            if (sArr.Length < 1)
                return -1;
            if (sArr.Length == 1)
                return sArr.Length;

            int start = 0;
            int pivotStart = 0;

            string result = "";
            int max = 0;

            List<string> resultStrings = new List<string>();

            while (start < sArr.Length)
            {
                if (!result.Contains(sArr[start]))
                {
                    result += sArr[start];
                    max = Math.Max(result.Length, max);
                }
                else
                {
                    resultStrings.Add(result);
                    ++pivotStart;
                    start = pivotStart;
                    result = "";
                }
                start++;
            }

            for (int i = 0; i < resultStrings.Count; i++)
            {
                Console.WriteLine($"Result {i}: {resultStrings[i]}");

            }

            return max;
        }
        /// <summary>
        /// Input : X = “GeeksforGeeks”, y = “GeeksQuiz” 
        //Output : 5 
        //Explanation:
        //The longest common substring is “Geeks” and is of length 5.
        //
        //Input : X = “abcdxyz”, y = “xyzabcd” 
        //Output : 4 
        //Explanation:
        //The longest common substring is “abcd” and is of length 4.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int LongestCommonStr(string x, string y)
        {
            if (x.Length == 0 || y.Length == 0)
                return -1;
            int[,] dp = new int[x.Length + 1, y.Length + 1];
            int maxLength = 0;
            for(int i =1; i<=x.Length; i++)
            {
                for(int j = 1; j<=y.Length; j++)
                {
                    if (x[i - 1] == y[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1] + 1;

                        maxLength = Math.Max(maxLength, dp[i, j]);
                    }
                    else
                    {
                        dp[i, j] = 0;
                    }
                    
                }
            }
            return maxLength;

        }
        /// <summary>
        /// Given an array of integers of size ‘n’, Our aim is to calculate the maximum sum of ‘k’ consecutive elements in the array.
        /// //100,200,300,400,700,800,10000,200,100,50
        /// </summary>
        /// <param name="n">2</param>
        /// <returns></returns>
        public int FindMaxSubArr(int[] arr,int n)
        {
            if (arr.Length < n || n<=0)
            {
                return -1;
            }
            int currentSum = 0;
           
            for(int i =0; i<n; i++)
            {
                currentSum += arr[i];
            }

            int maxSum = currentSum;
            for (int i = n; i<arr.Length; i++)
            {
                currentSum += arr[i] - arr[i - n];
                maxSum = Math.Max(maxSum, currentSum);
            }

            return maxSum;

        }
        public void FindIndexOfSumArr(int[] arr,int sum)
        {
            int currentSum = 0;
            int currentIndex = 0;
            int firstIndex = 0;
            int count = 1;
            while (currentIndex <=arr.Length-1)
            {
               
               
                currentSum += arr[currentIndex];
                currentIndex++;
                firstIndex = count;
                if(currentSum == sum)
                {
                    Console.WriteLine($"Sum of elements between indices {firstIndex} to {currentIndex}");
                    break;
                }
                else if(currentSum > sum)
                {
                    count++;
                    currentIndex = count-1;
                    currentSum = 0;

                }
               
                

            }

        }
        public void MaxOfSubArrays(int[] arr, int k)
        {
            if (arr.Length < k)
                return;

            int currentMax = 0;
            int count = 0;
            int currentIndex = 0;
            int trackIndex = 0;
            int test = 0;

            List<int> maxCollections = new List<int>();      
            while(currentIndex <arr.Length)
            {
                ++test;
                currentMax = Math.Max(arr[currentIndex], currentMax);
                currentIndex++;
           
                if (k == currentIndex)
                {
                   
                    maxCollections.Add(currentMax);
                    currentMax = 0;
                    currentIndex = ++count;

                }
                if (count > 3)
                    count = 0;
               
               

            }
            Console.WriteLine($"TEST : {test}");
            foreach(int i in maxCollections)
            {
                Console.WriteLine(i);
            }
           
        }


>>>>>>> MikeTest2
    }
}
