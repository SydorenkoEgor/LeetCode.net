using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Item_From_List
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            List<int> values = new List<int>();
            var iter = head;
            while (iter != null)
            {
                values.Add(iter.val);
                iter = iter.next;
            }
            values.RemoveAt(values.Count - n);
            ListNode result = null;
            iter = null;
            for (int i = 0; i < values.Count; i++)
            {
                if(result == null)
                {
                    result = new ListNode(values[i]);
                    iter = result;
                }
                else
                {
                    iter.next = new ListNode(values[i]);
                    iter = iter.next;
                }
            }
            return result;
        }
        public ListNode RecursiveSearch(ListNode node,ListNode prev)
        {
            if (node.next == null)
            {
                node.next = prev;
                return node;
            }
            else
            {
                var next = node.next;
                node.next = prev;
                return RecursiveSearch(next, node);
            }
        }
        public ListNode ReverseList(ListNode head)
        {
            ListNode result = null;
            if (head != null)
            {
                result = RecursiveSearch(head, null);
            }
            return result;
        }

        public ListNode Iterative(ListNode node)
        {
            ListNode result = null;
            if(node != null)
            {

                result = node.next;
                node.next = null;
                while(result.next != null)
                {
                    var tmp = result.next;
                    result.next = node;
                    result = tmp;
                }
            }
            return result;
        }

        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode result = null;
            ListNode iter = null;

            while(true)
            {
                if (l1 == null && l2 == null)
                    break;
                int toAppend = 0;
                if(l1 != null && l2 != null)
                {
                    if(l1.val < l2.val)
                    {
                        toAppend = l1.val;
                        l1 = l1.next;
                    }
                    else
                    {
                        toAppend = l2.val;
                        l2 = l2.next;
                    }
                }
                else
                {
                    if(l1 != null)
                    {
                        toAppend = l1.val;
                        l1 = l1.next;
                    }
                    else
                    {
                        toAppend = l2.val;
                        l2 = l2.next;
                    }
                }

                if(result == null)
                {
                    result = new ListNode(toAppend);
                    iter = result;
                }
                else
                {
                    iter.next = new ListNode(toAppend);
                    iter = iter.next;
                }
            }

            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ListNode f = new ListNode(1, new ListNode(2, new ListNode(4)));
            ListNode s = new ListNode(1, new ListNode(3, new ListNode(4)));
            (new Solution()).MergeTwoLists(f,s);
        }
    }
}
