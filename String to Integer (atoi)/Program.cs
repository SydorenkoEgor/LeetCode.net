using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace String_to_Integer__atoi_
{
    public class Solution
    {                  
        public int MyAtoi(string str)
        {

            int result = 0;
            str = str.Trim();
            Regex rg = new Regex("^[-|+]{0,1}[0-9]*", RegexOptions.Singleline);
            var match = rg.Match(str);
            if(!String.IsNullOrEmpty(match.Value) && !String.IsNullOrWhiteSpace(match.Value) && match.Value.Length > 1)
            {
                int start = 0;
                int sign = 1;
                if(match.Value[0]=='-')
                {
                    start++;
                    sign = -1;
                }
                if (match.Value[0] == '+')
                {
                    start++;
                }

                for (int i = start;i < match.Value.Length; i++)
                {
                    var num = Convert.ToInt32(match.Value[i].ToString());
                    if (result > (Int32.MaxValue - num)/10)
                    {
                        return sign > 0 ? Int32.MaxValue : Int32.MinValue;
                    }
                    result = result * 10 + num;
                }
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
