using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_unit_testing_4
{
    internal class MonthlyPayment
    {
        public static double P, Y, R, r, n, payment, x, y;
        public static void monthlypayment(double P, double Y, double R)
        {
            n = 12 * Y;
            r = R / (12 * 100);
            x = (1 + r);
            y = Math.Pow(x, -n);
            payment = (P * r) / 1 - y;

            Console.WriteLine($"Payment for given values is : {payment}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MonthlyPayment mp = new MonthlyPayment();
            Console.WriteLine("Enter P , Y ,R values ");
            MonthlyPayment.P = Convert.ToDouble(Console.ReadLine());
            MonthlyPayment.Y = Convert.ToDouble(Console.ReadLine());
            MonthlyPayment.R = Convert.ToDouble(Console.ReadLine());
            MonthlyPayment.monthlypayment(MonthlyPayment.P, MonthlyPayment.Y, MonthlyPayment.R);
        }
    }
}
