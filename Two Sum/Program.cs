using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Two_Sum
{
    class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int,int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i };
                }
                map.Add(nums[i], i);
            }
            int x = 10;
            x /= 2;
            return null;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var RES = int.MaxValue;
            Console.WriteLine((new Solution()).TwoSum(new int[] {0,4,4,3,0}, 0));
        }
    }
}
