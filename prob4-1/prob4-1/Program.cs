using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("数：");
            int a,b = int.Parse(Console.ReadLine());
            for (a = 1; a <= b; a++)
            {
                Console.Write("■");
            }
            Console.WriteLine();
        }
    }
}
