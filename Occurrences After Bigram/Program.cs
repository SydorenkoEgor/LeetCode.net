using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Occurrences_After_Bigram
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = (new Solution().FindOcurrences("we will we will rock you", "we", "will"));//"alice is a good girl she is a good student", "a", "good"));
        }
    }
    public class Solution
    {
        public string[] FindOcurrences(string text, string first, string second)
        {
            var words = text.Split(' ');
            List<string> result = new List<string>();
            string prev = String.Empty;
            var addNext = false;
            foreach (var word in words)
            {
                if (addNext)
                {
                    result.Add(word);
                }
                addNext = second.Equals(word) && first.Equals(prev);

                prev = word;
            }
            return result.ToArray();
        }
    }
}
