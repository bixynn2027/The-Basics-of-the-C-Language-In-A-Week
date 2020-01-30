using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("数：");
            int a, b = int.Parse(Console.ReadLine());
            a = 1;
            while (a <= b)
            {
                Console.Write("■");
                a++;
            }
            Console.WriteLine();
        }
    }
}
