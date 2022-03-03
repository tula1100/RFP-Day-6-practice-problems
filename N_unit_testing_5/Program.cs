using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_unit_testing_5
{
    internal class Sqrt_Newton
    {
        public static double c, t, epsilon;
        public static void Sqrt(double c)
        {
            double t = c;
            double epsilon = 1 * Math.Pow(10, -15);
            while (Math.Abs(t - c / t) > epsilon * t)
            {
                t = (t + c / t) / 2;
            }
            Console.WriteLine($"Square root of {c} is : {t} ");

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Sqrt_Newton s = new Sqrt_Newton();
            Console.WriteLine("Enter a number value");
            double c = Convert.ToDouble(Console.ReadLine());
            Sqrt_Newton.Sqrt(c);
        }
    }
}
