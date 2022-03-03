using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp_2
{
    internal class Program
    {
        static bool isperfect(int n)
        {
            // To store sum of divisors
            int sum = 1;

            // Find all divisors and add them
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    if (i * i != n)
                        sum = sum + i + n / i;
                    else
                        sum = sum + i;
                }
            }
            // If sum of divisors is equal to
            // n, then n is a perfect number
            if (sum == n && n != 1)
                return true;

            return false;
        }

        // Driver program
        static void Main()
        {
            System.Console.WriteLine("Below are all perfect" +
                                        "numbers till 10000");
            for (int n = 2; n < 10000; n++)
                if (isperfect(n))
                    System.Console.WriteLine(n +
                            " is a perfect number");
        }
    }
}
    

