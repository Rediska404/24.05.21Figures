using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Выберите фигуру, площадь которой нужно найти:");
			Console.WriteLine("1. Круг");
			Console.WriteLine("2. Квадрат");
			Console.WriteLine("3. Ромб");
			Console.WriteLine("4. Треугольник\n");
			int number1 = int.Parse(Console.ReadLine());
			Console.WriteLine();
			switch(number1) 
			{
				case 1: // круг
					Console.WriteLine("Выберите, что необходимо найти:");
					Console.WriteLine("1. Площадь окружности");
					Console.WriteLine("2. Длина окружности\n");
					int number2 = int.Parse(Console.ReadLine());
					Console.WriteLine();
					switch(number2)
					{
						case 1:  // Нахождение площади
							Console.WriteLine("Введите радиус");
							double R1 = double.Parse(Console.ReadLine());
							Console.WriteLine();
							Circle newCircle1 = new Circle(R1);
							newCircle1.ResultS(R1);
							break;
						case 2: // Нахождение длины
							Console.WriteLine("Введите радиус");
							double R2 = double.Parse(Console.ReadLine());
							Console.WriteLine();
							Circle newCircle2 = new Circle(R2);
							newCircle2.ResultC(R2);
							break;
						default: Console.WriteLine("Ошибка.");
							break;
					}
					break;
				case 2: // Квадрат
					Console.WriteLine("Выберите, что необходимо найти:");
					Console.WriteLine("1. Площадь квадрата");
					Console.WriteLine("2. Периметр квадрата\n");
					int number3 = int.Parse(Console.ReadLine());
					Console.WriteLine();
					switch (number3)
					{
						case 1:  // Нахождение площади
							Console.WriteLine("Введите сторону");
							int R3 = int.Parse(Console.ReadLine());
							Console.WriteLine();
							Square newSquare1 = new Square(R3);
							newSquare1.ResultS(R3);
							break;
						case 2: // Нахождение периметра
							Console.WriteLine("Введите сторону");
							int R4 = int.Parse(Console.ReadLine());
							Console.WriteLine();
							Square newSquare2 = new Square(R4);
							newSquare2.ResultP(R4);
							break;
						default:
							Console.WriteLine("Ошибка.");
							break;
					}
					break;
				case 3: // Ромб
					Console.WriteLine("Выберите, что необходимо найти:");
					Console.WriteLine("1. Площадь ромба");
					Console.WriteLine("2. Периметр ромба\n");
					int number4 = int.Parse(Console.ReadLine());
					Console.WriteLine();
					switch (number4)
					{
						case 1:  // Нахождение площади
							Console.WriteLine("Введите диагональ 1:\n");
							double R5 = double.Parse(Console.ReadLine());
							Console.WriteLine("Введите диагональ 2:\n");
							double R6 = double.Parse(Console.ReadLine());
							Console.WriteLine();
							Rhombus newRhombus1 = new Rhombus(R5, R6);
							newRhombus1.ResultS(R5,R6);
							break;
						case 2: // Нахождение периметра
							Console.WriteLine("Введите сторону:\n");
							int R7 = int.Parse(Console.ReadLine());
							Console.WriteLine();
							Rhombus newRhombus2 = new Rhombus(R7);
							newRhombus2.ResultP(R7);
							break;
						default:
							Console.WriteLine("Ошибка.");
							break;
					}
					break;
				case 4: // Треугольник
					Console.WriteLine("Выберите, что необходимо найти:");
					Console.WriteLine("1. Площадь треугольника");
					Console.WriteLine("2. Периметр треугольника\n");
					int number5 = int.Parse(Console.ReadLine());
					Console.WriteLine();
					switch (number5)
					{
						case 1:  // Нахождение площади
							Console.WriteLine("Введите диагональ 1:");
							double R8 = double.Parse(Console.ReadLine());
							Console.WriteLine("Введите диагональ 2:");
							double R9 = double.Parse(Console.ReadLine());
							Console.WriteLine();
							Triangle newTriangle1 = new Triangle(R8, R9);
							newTriangle1.ResultS(R8, R9);
							break;
						case 2: // Нахождение периметра
							Console.WriteLine("Введите сторону 1:");
							int R10 = int.Parse(Console.ReadLine());
							Console.WriteLine("Введите сторону 2:");
							int R11= int.Parse(Console.ReadLine());
							Console.WriteLine("Введите сторону 3:");
							int R12= int.Parse(Console.ReadLine());
							Console.WriteLine();
							Triangle newTriangle2 = new Triangle(R10, R11, R12);
							newTriangle2.ResultP(R10, R11,R12);
							break;
						default:
							Console.WriteLine("Ошибка.");
							break;
					}
					break;
				default:
					Console.WriteLine("Ошибка");
					break;
			}
			Console.ReadKey();
		}
	}
}
