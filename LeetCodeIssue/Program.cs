using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeIssue
{
    class Program
    {
        static void Main()
        {
            var res = (new Solution().Shuffle(new int[] { 2, 5, 1, 3, 4, 7 },3));
        }
    }

    public class Solution
    {
        public int[] Shuffle(int[] nums, int n)
        {

            List<int> result = new List<int>();
            for (int i = 0; i < n; i++)
            {
                result.Add(nums[i]);
                result.Add(nums[n + i]);
            }
            return result.ToArray();

        }
    }
}
