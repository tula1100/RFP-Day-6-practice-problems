using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_unit_testing_1
{
    internal class Program
    {
		// function to count and
		// print currency notes
		public static void countCurrency(int amount)
		{
			int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };
			int[] Counter = new int[8];

			// count notes 
			for (int i = 0; i < 8; i++)
			{
				if (amount >= notes[i])
				{
					Counter[i] = amount / notes[i];
					amount = amount - Counter[i] * notes[i];
				}
			}

			// Print notes
			Console.WriteLine("Currency Count ->");
			for (int i = 0; i < 8; i++)
			{
				if (Counter[i] != 0)
				{
					Console.WriteLine(notes[i] + " : "
						+ Counter[i]);
				}
			}
		}

		public static void Main()
		{
			Console.WriteLine("Enter Amount");
			int amount = Convert.ToInt32(Console.ReadLine());
			countCurrency(amount);
		}


	}
}

      
