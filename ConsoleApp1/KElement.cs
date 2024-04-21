using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Leetcode 347 Top K Frequent Elements
    /// Q> Given a non empty array of integer, return the K most Frequent elements
    /// Ex1  intput : num = [1,1,1,2,2,3]  k = 2
    ///         output : [1,2]
    /// 
    /// Ex2 input nums = [1] , k =1
    ///  output = [1]
    ///  
    /// Note You may assume k is always vaild 1<=k <= number of unique element
    /// algo time complexty must be better than O(n log n) in the array of size
    /// 
    /// </summary>
    internal class KElement
    {
        //111 22 3 
        // key 1 ->3 ,2 ->2 ,3 ->1
        public int[] TopKElement(int[] nums, int k)
        {
            var topKDic = new Dictionary<int, int>();

            foreach (int n in nums)
            {
                if (!topKDic.ContainsKey(n))
                {
                    topKDic.Add(n, 1);
                }
                else
                {
                    topKDic[n]++;
                }
            }

            // Sort the dictionary by values in descending order
            var sortedDict = topKDic.OrderByDescending(i => i.Value).ToDictionary(i => i.Key, i => i.Value);

            // Take the top 'k' keys
            int[] arr = sortedDict.Keys.Take(k).ToArray();

            return arr;
        }

    }
}
