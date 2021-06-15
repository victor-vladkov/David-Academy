using System;

namespace _01._Discriminant
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double discriminant = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine(discriminant);
        }
    }
}
