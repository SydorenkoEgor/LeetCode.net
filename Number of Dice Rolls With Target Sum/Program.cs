using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_of_Dice_Rolls_With_Target_Sum
{
    /**
     *      1 2 3 4 5 6
     *      4
     *      1 3
     *      2 2
     *      3 1
     * 
     */
    public class Solution
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 0, 0, 0, 1, 1, 2, 3, 4, 4, 4, 5, 6, 7 };
            var prev = nums[0];
            var count = 1;
            var index = 1;
            (new List<int>()).In
            nums.ToList().GroupBy(x => x).Any(g => g.Count() > 1);
            for (int i=1;i< nums.Length;i++)
            {
                if(nums[i] != prev)
                {
                    nums[index] = nums[i];
                    index++;
                    prev = nums[i];
                    count++;
                }
            }
            int t = 0;
            Int32.MaxValue
            //return count;
        }
    }
}
