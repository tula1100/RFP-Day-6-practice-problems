using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_unit_testing_6
{
    internal class Binary
    {
        public static string result;
        public static void toBinary(int num)
        {
            result = "";
            while (num != 0)
            {
                int remainder = num % 2;
                Binary.result = Convert.ToString(remainder) + Binary.result;
                num /= 2;
            }
            Binary.result = Convert.ToString(num) + Binary.result;
            Console.WriteLine("Binary: {0}", Binary.result);

        }
    }
    public class Program
    {
        public static void Main()
        {
            Binary b = new Binary();
            Console.Write("Input a Number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Binary.toBinary(num);

        }
    }
}
