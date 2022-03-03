using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp_5
{
    public class CoupenNumber
    {
        public int N;
        public static void Coupen(int N)
        {
            Random random = new Random();
            for (int i = 0; i <= N; i++)
            {
                Console.WriteLine(random.Next());
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N Value");
            CoupenNumber c = new CoupenNumber();
            int N = int.Parse(Console.ReadLine());
            CoupenNumber.Coupen(N);

        }
    }
}



