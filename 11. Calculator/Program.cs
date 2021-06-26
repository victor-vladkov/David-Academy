using System;

namespace _11._Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Commands: add, sub, mul, div, exit");
			string command = Console.ReadLine().ToLower();
			while (command != "exit") {
				switch (command) {
					case "add":
						Console.Write("A = ");
						double a = double.Parse(Console.ReadLine());
						Console.Write("B = ");
						double b = double.Parse(Console.ReadLine());
						Console.WriteLine("A + B = " + (a + b));
						break;
					case "sub":
						Console.Write("A = ");
						a = double.Parse(Console.ReadLine());
						Console.Write("B = ");
						b = double.Parse(Console.ReadLine());
						Console.WriteLine("A - B = " + (a - b));
						break;
					case "mul":
						Console.Write("A = ");
						a = double.Parse(Console.ReadLine());
						Console.Write("B = ");
						b = double.Parse(Console.ReadLine());
						Console.WriteLine("A * B = " + (a * b));
						break;
					case "div":
						Console.Write("A = ");
						a = double.Parse(Console.ReadLine());
						Console.Write("B = ");
						b = double.Parse(Console.ReadLine());
						Console.WriteLine("A / B = " + (a / b));
						break;
				}
				command = Console.ReadLine().ToLower();
            }
        }
    }
}
