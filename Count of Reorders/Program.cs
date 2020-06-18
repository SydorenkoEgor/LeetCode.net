using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_of_Reorders
{
    public class Solution
    {
        public int HeightChecker(int[] heights)
        {
            var countOfReorders = 0;
            var sortedArray = new List<int>(heights);
            sortedArray.Sort();

            for(int i = 0;i< sortedArray.Count;i++)
                if (sortedArray[i] != heights[i])
                    countOfReorders++;


            return countOfReorders;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Count of reorders: {(new Solution()).HeightChecker(new int[] { 1, 1, 4, 2, 1, 3 })}");
            int x = 0;
        }
    }
}
