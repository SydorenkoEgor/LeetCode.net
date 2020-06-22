using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leaf_Similar_Trees
{

public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

    public class Solution
    {
        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            var leavs1 = new List<int>();
            var leavs2 = new List<int>();

            dfs(root1,leavs1);
            dfs(root2, leavs2);

           return leavs1.SequenceEqual(leavs2);
        }

        void dfs(TreeNode root, List<int> values)
        {
            if (root == null)
                return;
            if (root.left == null && root.right == null)
                values.Add(root.val);
            dfs(root.left, values);
            dfs(root.right, values);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
