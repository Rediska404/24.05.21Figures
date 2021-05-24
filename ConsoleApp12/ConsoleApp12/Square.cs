using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
	class Square : Figures // квадрат
	{
		public Square(double A)
		{
			this.A = A;

		}

		public void ResultS (double a)
		{
			S = Math.Pow(a, 2);
			Console.WriteLine("Результат " + S);
		}

		public void ResultP(double a)
		{
			P = a * 4;
			Console.WriteLine("Результат " + P);
		}

	}
}
