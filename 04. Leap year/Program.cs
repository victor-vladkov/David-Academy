using System;

namespace _04._Leap_year
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
            if (year % 4 == 0)
                Console.WriteLine("Годината е високосна.");
            else 
                Console.WriteLine("Годината не е високосна.");
        }
    }
}
