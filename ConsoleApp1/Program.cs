using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number or a string");
            string s = Console.ReadLine();
            Program p = new Program();
            string t = p.Reverse(s);
            Console.WriteLine("The reverse of {0} is {1}", s, t);

        }

        public string Reverse(string str)
        {
            char[] cArray = str.ToCharArray();
            string reverse = "";
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;

        }
    }
}
