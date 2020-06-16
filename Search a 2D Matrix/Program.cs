using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_a_2D_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[][]
            {
                new int[] { 2, 3, 5, 7 },
               new int[] { 10, 11, 16, 20 },
               new int[] { 23, 30, 34, 50 },
               new int[] { 51, 62, 64, 70 },
               new int[] { 73, 78, 84, 90 },
               new int[] { 93, 100, 104, 110 }
            };
            var result = (new Solution()).SearchMatrix(matrix, 2);
        }
    }

    public class Solution
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            if (matrix == null || matrix.Length == 0) return false;
            var left = 0;
            var right = matrix.Length - 1;
            var index = 0;
            var prevStart = Int32.MaxValue;
            var prevEnd = Int32.MaxValue;
            List<int> checkedIndeces = new List<int>();
            while (true)
            {
                index = left + (right - left) / 2;
                if (index < 0 || index >= matrix.Length || matrix[index].Length < 1)
                    return false;

                var startPos = matrix[index][0];
                var endPos = matrix[index][Math.Max(matrix[index].Length - 1, 0)];
                if (checkedIndeces.Contains(index))
                    return false;

                if (startPos <= target && endPos >= target)
                    break;
                else if (target < startPos)
                {
                    right = index;
                }
                else if (target > endPos)
                {
                    left = index + 1;
                }
                prevStart = startPos;
                prevEnd = endPos;
                checkedIndeces.Add(index);
            }

            return matrix[index].Contains(target);
            
        }
    }
}
