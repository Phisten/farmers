using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s0829
{
    class Program
    {
        /* output: 
         * 1+
         * 2+
         * 3+
         * 4+
         * 5+
         * 6+
         * 7+
         * 8+
         * 9+
         * 10+
         * =55
         */
        static void Main(string[] args)
        {
            int num = 10;
            int sum = 0;
            for (int i = 0; i < num; i++);
            {
                sum = sum + i
            Console.WriteLine(i + "+");  }

            Console.WriteLine("=" + sum);
            Console.ReadLine();
        }
    }
}
