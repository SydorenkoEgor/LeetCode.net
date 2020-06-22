using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Trees
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

        public bool dfs(TreeNode node, int? min, int? max)
        {
            if (node == null)
                return true;
            if (min.HasValue && node.val <= min.Value) return false;
            if (max.HasValue && node.val >= max.Value) return false;
            
            if(!dfs(node.left, min,node.val)) return false;
            if(!dfs(node.right,node.val,max)) return false;
            return true;
        }
        public bool IsValidBST(TreeNode root)
        {
            var stack = new Stack<int>();
            dfs(root, null,null);
            return false;
        }
        public bool IsMirror(TreeNode  lNode, TreeNode rNode)
        {
            if (lNode == null && rNode == null) return true;
            if (lNode == null || rNode == null) return false;
            return lNode.val == rNode.val && IsMirror(lNode.right, rNode.left) && IsMirror(lNode.left, rNode.right);
        }

        public bool IsSymmetric(TreeNode root)
        {
            return IsMirror(root, root);
        }

        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            List<IList<int>> result = new List<IList<int>>();
            if(root == null)
            {
                return result;
            }
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while(queue.Any())
            {
                int size = queue.Count;
                List<int> currentLevel = new List<int>();
                for(int i = 0;i < size;i++)
                {
                    var item = queue.Dequeue();
                    currentLevel.Add(item.val);
                    if(item.left != null)
                        queue.Enqueue(item.left);
                    if(item.right != null)
                        queue.Enqueue(item.right);
                }
                result.Add(currentLevel);
            }

            return result;
        }
        // 0 -> -10 
        public TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums.Length < 1) return null;
            var result =  BuildBST(nums, 0, nums.Length - 1);
            return result;
        }

        public TreeNode BuildBST(int[] array,int left, int right)
        {
            if (left > right) return null;

            int midIndex = left + (right - left) / 2;
            int value = array[midIndex];
            TreeNode node = new TreeNode(value);
            node.left = BuildBST(array, left, midIndex -1);
            node.right = BuildBST(array, midIndex + 1, right);

            return node;
        }

        public bool IsBadVersion(int n)
        {
            return n >= 8;
        }
        public int FirstBadVersion(int n)
        {
            var result =  BinarySearch(0, n);
            return result;
        }

        public int BinarySearch(int left, int right)
        {
            var mid = left + (right - left) / 2;
            if (IsBadVersion(mid))
            {
                if (!IsBadVersion(mid - 1))
                    return mid;

                return BinarySearch(left, mid - 1);
            }
            else
            {
                if (IsBadVersion(mid + 1))
                    return mid + 1;

                return BinarySearch(mid + 1, right);
            }

        }
        public int MaxSubArray(int[] nums)
        {
            List<int> sums = new List<int>();
            sums.Add(nums[0]);
            for (int i = 1; i < nums.Length; i++)
            {
                sums.Add(Math.Max(nums[i], nums[i] + sums[i - 1]));
            }
            return sums.Max();
        }
    }
    public class MinStack
    {
        List<int> stack;
        /** initialize your data structure here. */
        public MinStack()
        {
            stack = new List<int>();
        }

        public void Push(int x)
        {
            stack.Add(x);
        }

        public void Pop()
        {
            //var val = stack.LastOrDefault();
            stack.RemoveAt(stack.Count -1);
        }

        public int Top()
        {
            return stack.LastOrDefault();
        }

        public int GetMin()
        {
            return stack.Min();
        }

        bool IsPrime(int n)
        {
            for (int i = 2; i <= (n / 2); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        public int CountPrimes(int n)
        {
            int counter = 0;
            for (int i = 2; i < n; i++)
            {
                if (IsPrime(i))
                {
                    counter++;
                }
            }
            return counter;
        }
    }
    class Program
    {
        public class Solution1
        {
            Dictionary<string, int> cash = new Dictionary<string, int>();
            int MOD = 1000000007;
            public int NumRollsToTarget(int d, int f, int target)
            {
                if (d > target)
                    return 0;
                if (d == 1)
                {
                    return f >= target ? 1: 0;
                }
                string key = $"{d + f + target}";
                if (!cash.ContainsKey(key))
                {
                    int sum = 0;
                    for (int i = 1; i <= f; i++)
                    {
                        sum += NumRollsToTarget(d - 1, f, target - i);
                        sum %= MOD;
                    }
                    cash.Add(key, sum);
                }
                return cash[key];
            }
        }
        static void Main(string[] args)
        {
            var maxVal = Int32.MaxValue;
           var result = (new Solution1()).NumRollsToTarget(30, 30, 500);
            int x = 0;
        }
    }
}
