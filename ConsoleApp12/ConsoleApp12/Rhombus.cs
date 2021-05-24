using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
	class Rhombus : Figures // ромб
	{
		public double d1;
		public double d2;

		public Rhombus(double d1, double d2)
		{
			this.d1 = d1;
			this.d2 = d2;
			
		}

		public Rhombus(double a)
		{
			A = a;
		}

		public void ResultS(double d1, double d2)
		{
			S = 1 / 2 * d1 * d2;
			Console.WriteLine("Результат " + S);
		}

		public void ResultP(double a)
		{
			P = 4 * a;
			Console.WriteLine("Результат " + P);
		}
	}
}
