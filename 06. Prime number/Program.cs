using System;

namespace _06._Prime_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i < n / 2; i++)
                if (n % i == 0) 
                {
                    Console.WriteLine("Числото не е просто.");
                    return;
                }
            Console.WriteLine("Числото е просто.");
        }
    }
}
