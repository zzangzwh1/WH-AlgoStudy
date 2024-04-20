using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Example
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            HashSet<int> uniqueNumbers = new HashSet<int>();
            HashSet<int> uniqueNumberSecond = new HashSet<int>();

            var returnDic = new Dictionary<int, int>();
            foreach (var num in uniqueNumbers)
            {
                if (!returnDic.ContainsKey(num))
                {
                    returnDic.Add(num,1);
                }

                else
                {
                    returnDic[num]++;
                }
            }
            if(returnDic.Values.Count >1)
            {
                return returnDic.Keys.ToArray();
            }

            return new int[0];
        }
    }
}
