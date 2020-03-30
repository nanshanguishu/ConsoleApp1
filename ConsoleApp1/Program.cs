using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 7.666666;
            string b = "7.665";
            Console.WriteLine(Math.Round(a, 2));
            Console.WriteLine(String.Format("{0:F}", a));
            Console.WriteLine(a.ToString("#0.00 "));
            Console.WriteLine(Math.Round(b, 2));
            Console.WriteLine(String.Format("{0:F}",b));
            Console.WriteLine(b.ToString("#0.00 "));
            Console.Read();
        }
    }
}
