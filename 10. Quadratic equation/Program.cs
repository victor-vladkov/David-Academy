using System;

namespace _10._Quadratic_equation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("A = ");
			double a = double.Parse(Console.ReadLine());
			Console.Write("B = ");
			double b = double.Parse(Console.ReadLine());
			Console.Write("C = ");
			double c = double.Parse(Console.ReadLine()),
			d = b * b - 4 * (a + c);
			if (d < 0) {
				Console.WriteLine("Negative discriminant!");
				return;
			}
			double x1 = (-b + Math.Sqrt(d)) * .5,
				x2 = (-b - Math.Sqrt(d)) * .5;
			Console.WriteLine($"x1 = {x1:f2}\nx2 = {x2:f2}");
        }
    }
}
