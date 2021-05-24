using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
	class Triangle : Figures // Треугольник
	{
		public Triangle(double a, double h)
		{
			A = a;
			H = h;

		}
		public Triangle(double a, double b, double c)
		{
			A = a;
			B = b;
			C1 = c;

		}
		public void ResultS(double a, double h)
		{
			S = 1 / 2 * a * h;
			Console.WriteLine("Результат " + S);
		}

		public void ResultP(double a, double b, double c)
		{
			P = a + b + c;
			Console.WriteLine("Результат " + P);
		}
	}
}
