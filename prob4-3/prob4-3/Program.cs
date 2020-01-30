using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("数：");
            int a, b = int.Parse(Console.ReadLine());
            a = 1;
            do
            {
                Console.Write("■");
                a++;
            } while (a <= b);
            Console.WriteLine();
        }
    }
}
