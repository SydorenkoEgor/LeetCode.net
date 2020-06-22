using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace rEVERSiNT
{
    public class Solution
    {
        public int Reverse(int x)
        {
            if (x == Int32.MinValue) return 0;
            int mult = x > 0 ? 1 : -1;
            int moduleX = Math.Abs(x);
            int prev = 0;
            while (moduleX > 0)
            {
                var next = moduleX % 10;
                if (prev > (int.MaxValue - next) / 10)
                    return 0;
                prev = prev * 10 + next;
                moduleX /= 10;
            }
            return prev * mult;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
  
            var s = "`l;`` 1o1 ??;l`".ToLower();
            var result = true;
           // if (String.IsNullOrEmpty(s))
               // return result;
            s = s.ToLower();
            s = System.Text.RegularExpressions.Regex.Replace(s, "[ &\\/\\#,+()$~%.`'\":;*?<>{ }@-]", "");

            for (int i = 0, k = s.Length - 1; i < s.Length / 2; i++, k--)
            {
                if (s[i] != s[k])
                {
                    result = false;
                    break;
                }
            }
            //Regex regex = new Regex("", RegexOptions.Singleline);
            //s = regex.Replace(s, "");
            Console.WriteLine((new Solution()).Reverse(-2147483648));
        }
    }
}
