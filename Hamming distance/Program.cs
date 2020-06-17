using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamming_distance
{
    class Program
    {
        public class Solution
        {
            public int HammingDistance(int x, int y)
            {
                var num1Builder = ConverToBin(x);
                var num2Builder = ConverToBin(y);

                var toAppend = Math.Abs(num1Builder.Length - num2Builder.Length);
                var builderToAppend = num2Builder.Length > num1Builder.Length ? num1Builder : num2Builder;
                for (int i = 0; i < toAppend; i++)
                {
                    builderToAppend.Append(0);
                }
                int counter = 0;
                for(int i=0;i<num1Builder.Length;i++)
                {
                    if (num1Builder[i] != num2Builder[i])
                        counter++;
                }
                return counter;
            }

            public StringBuilder ConverToBin(int num)
            {
                StringBuilder builder = new StringBuilder();
                while(num > 0)
                {
                    builder.Append(num % 2);
                    num /= 2;
                }
                return builder;
            }
        }
        static void Main(string[] args)
        {
            var result = (new Solution()).HammingDistance(4,1);
        }
    }
}
