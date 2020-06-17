using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_Strings
{
    public class Solution
    {
        public string AddStrings(string num1, string num2)
        {
            num1 = num1 ?? String.Empty;
            num2 = num2 ?? String.Empty;
            num1 = new string(num1.Reverse().ToArray());
            num2 = new string(num2.Reverse().ToArray());
            int index = 0;
            int tens = 0;
            StringBuilder builder = new StringBuilder();
            while(true)
            {
                if (index >= num1.Length && index >= num2.Length)
                    break;
                int val1 = 0;
                if(index < num1.Length)
                {
                    val1 = Convert.ToInt32(num1[index].ToString());
                }

                int val2 = 0;

                if(index < num2.Length)
                {
                    val2 = Convert.ToInt32(num2[index].ToString());
                }
                var res = val1 + val2 + tens;
                tens = res / 10;
                res = res % 10;
                builder.Append(res);
                index++;
            }
            if(tens > 0)
            {
                builder.Append(tens);
            }

            return new string(builder.ToString().Reverse().ToArray());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var result = (new Solution()).AddStrings("123", "45");
        }
    }
}
