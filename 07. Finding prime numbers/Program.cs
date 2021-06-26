using System;

namespace Finding_prime_numbers
{
    class Program
    {
        static void Main(string[] args) {
			int n = int.Parse(Console.ReadLine());
			for (int i = 1; i <= n; i++) {
				bool isPrime = true;
				for (int j = 2; j <= i / 2; j++)
					if (i % j == 0) {
						isPrime = false;
						break;
					}
				if (isPrime)
					Console.WriteLine(i);
            }
		}
    }
}
