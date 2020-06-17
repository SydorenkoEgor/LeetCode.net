using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_of_Steps_to_Reduce_a_Number_to_Zero
{
    class Program
    {
        public class Solution
        {
            public int NumberOfSteps(int num)
            {
                int counter = 0;
                while(num > 0 )
                {
                    if (num % 2 == 0)
                        num /= 2;
                    else
                        num -= 1;
                    counter++;
                }
                return counter;
            }
        }
        static void Main(string[] args)
        {
            var result = (new Solution()).NumberOfSteps(0);
        }
    }
}
