using System;

namespace Defanging_an_IP_Address
{
    class Program
    {
        public class Solution
        {
            public string DefangIPaddr(string address)
            {
                return address.Replace(".", "[.]");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine((new Solution().DefangIPaddr("1.1.1.1")));
        }
    }
}
