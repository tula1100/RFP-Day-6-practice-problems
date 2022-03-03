using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp_1
{
    internal class Program
    {
        static void Main(int num,int first,int sec)
        {
            Console.Write(first + " "
                    + sec + " ");
            int counter = 0, sum;

            // find next (num - 2) terms
            // of series as first two
            // terms are already given
            while (counter < num - 2)
            {
                sum = first + sec;
                Console.Write(sum + " ");
                first = sec;
                sec = sum;
                counter++;
            }
        }

        // Drivers code
        public static void Main()
        {
            int n = 5, first = 2, sec = 4;

            Main(n, first, sec);
        }
    }
}
    

