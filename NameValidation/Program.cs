using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameValidation
{
    public class Solution
    {
        public bool IsLongPressedName(string name, string typed)
        {
            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(typed))
                return false;
            Dictionary<char, int> characters = new Dictionary<char, int>();
            for(int i = 0; i < typed.Length; i++)
            {
                var c = typed[i];
                if (characters.ContainsKey(c))
                {
                    characters[c]++;
                }
                else
                {
                    characters.Add(c, 1);
                }
            }

            var isPossible = true;

            for(int k = 0; k < name.Length; k++)
            {
                var c = name[k];
                if(!characters.ContainsKey(c))
                {
                    isPossible = false;
                    break;
                }

                characters[c] -= 1;
                if (characters[c] < 0)
                {
                    isPossible = false;
                    break;
                }
            }

            return isPossible;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((new Solution()).IsLongPressedName("kikcxmvzi", "kiikcxxmmvvzz"));
        }
    }
}
