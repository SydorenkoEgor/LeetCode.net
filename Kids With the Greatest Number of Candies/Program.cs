using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kids_With_the_Greatest_Number_of_Candies
{
    public class Solution
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            List<bool> result = new List<bool>();
            var maxValue = candies.Max();

            for (int i = 0; i < candies.Length; i++)
                result.Add((candies[i] + extraCandies >= maxValue));

            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var result = (new Solution().KidsWithCandies(new int[] { 2, 3, 5, 1, 3 }, 3));
        }
    }
}
