using System;
using System.Linq;

namespace _16._Matrix_sum {
	class Program {
		static void Main(string[] args) {
			Console.Write("Size: ");
			int n = int.Parse(Console.ReadLine());
			double[,] matrix = new double[n, n];
			for (int i = 0; i < n; i++) {
				double[] nums = Console.ReadLine()
					.Split(" ")
					.Select(double.Parse)
					.ToArray();
				for (int j = 0; j < n; j++)
					matrix[i, j] = nums[j];
			}
			double diagonalSum = 0,
				upperSum = 0,
				lowerSum = 0;
			for (int i = 0; i < n; i++) {
				diagonalSum += matrix[i, i];
				for (int j = 0; j < i; j++)
					lowerSum += matrix[i, j];
				for (int j = i + 1; j < n; j++)
					upperSum += matrix[i, j];
			}
			Console.WriteLine($"Diagonal: {diagonalSum}\nUpper sum: {upperSum}\nLower sum: {lowerSum}");
		}
	}
}
