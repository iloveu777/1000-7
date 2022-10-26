using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1000_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Title = "zxc ghoul";
            int a, i,b;
            a = 1000;
            
            for (i = 1; i <= 1000; i++ )
            {
                b = a;
                a = a - 7;
                Console.WriteLine(b);
                if(a <= 0)
                { break; }
            }
            ReadKey();
        }
    }
}
