using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_Leavs_Sum
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    public class Solution
    {
        public int SumOfLeftLeaves(TreeNode root)
        {
            List<int> leftValues = new List<int>();
            dfs(root, leftValues, false);
            return leftValues.Sum();
        }

        public void dfs(TreeNode root, List<int> values, bool isLeft)
        {
            if (root == null)
                return;
            if (root.left == null && root.right == null && isLeft)
                values.Add(root.val);

            dfs(root.left, values, true);
            dfs(root.right, values, false);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
