using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseImage
{
    public class Solution
    {
        public int[][] FlipAndInvertImage(int[][] A)
        {
            int[][] result = new int[A.Length][];

            for(int i = 0;i<A.Length;i++)
            {
                var reversed = A[i].Reverse().ToArray();
                for(int k=0;k<reversed.Count();k++)
                {
                    reversed[k] = reversed[k] == 0 ? 1 : 0;
                }
                result[i] = reversed;
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
