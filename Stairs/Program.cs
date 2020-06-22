using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stairs
{
    public class Solution
    {
        public int MinCostClimbingStairs(int[] cost)
        {
            int first = cost[0];
            int second = cost[1];
            int result = 0;
            for (int i =2;i<cost.Length;i++)
            {
                result = cost[i] + Math.Min(first , second);
                first = second;
                second = result;
            }
            return Math.Min(first,second);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((new Solution()).MinCostClimbingStairs(new int[] { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 }));
        }
    }
}
