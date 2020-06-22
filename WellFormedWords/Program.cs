using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WellFormedWords
{
    public class Solution
    {
        public int CountCharacters(string[] words, string chars)
        {
            var allowedChars = HasTableFromWord(chars);
            // List<string> wellDoneStrings = new List<string>();
            int sum = 0;
            foreach (var word in words)
            {
                var wordChars = HasTableFromWord(word);
                bool wordCanBeAdded = true;
                foreach (var item in wordChars)
                {
                    if(!allowedChars.ContainsKey(item.Key) || allowedChars[item.Key]<item.Value)
                    {
                        wordCanBeAdded = false;
                        break;
                    }
                }

                if (wordCanBeAdded)
                {
                    sum += word.Length;
                }
            }
            return sum;
        }
        Dictionary<char,int> HasTableFromWord(string word)
        {
            var charDict = new Dictionary<char, int>();
            for (int i = 0; i < word.Length; i++)
            {
                if (charDict.ContainsKey(word[i]))
                {
                    charDict[word[i]]++;
                }
                else
                {
                    charDict.Add(word[i], 1);
                }
            }
            return charDict;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((new Solution()).CountCharacters(new string[] { "cat", "bt", "hat", "tree" }, "atach"));
        }
    }
}
