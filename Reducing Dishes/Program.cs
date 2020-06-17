using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reducing_Dishes
{
    public class Solution
    {
        public int MaxSatisfaction(int[] satisfaction)
        {
            var orderedList = satisfaction.OrderBy(x => x).ToList();
            int result = 0;
            int tmpResult = 0;
            for (int i = orderedList.Count - 1; i >= 0; i--)
            {
                tmpResult += orderedList[i];
                if (tmpResult <= 0) break;
                result += tmpResult;
            }
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
