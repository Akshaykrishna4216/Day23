using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class StringExtension
    {
        public static string Concatenate(this string a, string b)
        { return a + b; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "hello";
            string b = " world";

            string res = a.Concatenate(b);
            Console.WriteLine(res);
        }
    }
}
