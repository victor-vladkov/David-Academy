using System;

namespace _05._Real_number_formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            int f = int.Parse(Console.ReadLine());
            Console.WriteLine(n.ToString("F" + f));
        }
    }
}
