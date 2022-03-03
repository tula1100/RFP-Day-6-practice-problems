using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_unit_testing_3
{
    internal class Util
    {
        public static double fahrenhiet = 0, celsius = 0;
        public static void temparatureConversion_F(double fahrenhiet)
        {
            Console.WriteLine("Converting Fahrenhiet to Celsius");
            celsius = (fahrenhiet - 32) * 5 / 9;
            Console.WriteLine($"Fahrenhiet Temparature : {fahrenhiet} Converted to Celsius :{celsius} ");

        }
        public static void temparatureConversion_C(double celsius)
        {
            Console.WriteLine("Converting Celsius to Fahrenhiet");
            fahrenhiet = (celsius * 9 / 5) + 32;
            Console.WriteLine($"Celsius Temparatue : {celsius} Converted to Fahrenhiet : {fahrenhiet}");

        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Temperature in Fahrenhiet ");
            Util.fahrenhiet = Convert.ToDouble(Console.ReadLine());
            Util.temparatureConversion_F(Util.fahrenhiet);
            Console.WriteLine("Enter Temperature in Celsius");
            Util.celsius = Convert.ToDouble(Console.ReadLine());
            Util.temparatureConversion_C(Util.celsius);
        }
    }
}
