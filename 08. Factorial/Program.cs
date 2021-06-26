using System;

namespace _08._Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
			Console.WriteLine(RecursiveFactorial(n));
			Console.WriteLine(IterativeFactorial(n));
		}

		static int IterativeFactorial(int n) {
			int p = 1;
			while (n > 1)
				p *= n--;
			return p;
		}

		static int RecursiveFactorial(int n) {
			if (n == 1)
				return 1;
			return n * RecursiveFactorial(n - 1);
	
        }
    }
}
