using System;

namespace _02._Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            string courseName = Console.ReadLine();
            Console.WriteLine($"Здравейте, {studentName}, и добре дошли в {courseName}!");
        }
    }
}
