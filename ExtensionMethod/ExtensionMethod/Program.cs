using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public static class IntExtension
    {
        public static bool IsGreaterthan(this int i,int value)
        {
            return i > value;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            bool result=i.IsGreaterthan(5);
            Console.WriteLine(result);
        }
    }
}
