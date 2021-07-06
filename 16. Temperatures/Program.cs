using System;
using System.Linq;

namespace _17._Temperatures {
	class Program {
		static void Main(string[] args) {
			int n = 6,
				k = 7;
			double[,] matrix = new double[n, k];
			for (int i = 0; i < n; i++) {
				double[] nums = Console.ReadLine()
					.Split(" ")
					.Select(double.Parse)
					.ToArray();
				for (int j = 0; j < k; j++)
					matrix[i, j] = nums[j];
			}
			double[] tempSums = new double[k];
			for (int i = 0; i < k; i++)
				for (int j = 0; j < n; j++)
					tempSums[k] += matrix[j, i];
			Console.WriteLine(string.Join("; ", tempSums.Select(sum => sum / n)));
			// Console.WriteLine(string.Join("; ", tempSums.Select(AverageOfSix)));
		}

		// static int AverageOfSix(int n) {
		// 	return n / 6;
		// }
	}
}

/*

x => x * x;

(a, b, c) => a + b + c;

(a, b) => {
	double s = a * b;
	return s;
}

*/