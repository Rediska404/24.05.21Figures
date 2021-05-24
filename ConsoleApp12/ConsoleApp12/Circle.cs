using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
	class Circle : Figures// круг
	{
		public Circle(double R) 
		{
			this.R = R;

		}

		public void ResultC(double R) // Длина окружности
		{
			C = 2 * (Math.PI * R);
			Console.WriteLine("Результат "+C);
		}


		public void ResultS(double R) // Площадь
		{
			S = Math.PI * Math.Pow(R, 2);
			Console.WriteLine("Результат " + S);
		}
	}
}
