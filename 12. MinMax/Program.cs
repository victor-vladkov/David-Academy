using System;
using System.Linq;

namespace _13._MinMax {
	class Program {
		static void Main(string[] args) {
			int[] nums = Console.ReadLine()
				.Split(" ")
				.Select(int.Parse)
				.ToArray();
			int min = int.MaxValue,
				max = int.MinValue;
			double sum = 0;
			for (int i = 0; i < nums.Length; i++) {
				if (min > nums[i])
					min = nums[i];
				if (max < nums[i])
					max = nums[i];
				sum += nums[i];
			}
			Console.WriteLine($"Min: {min}\nMax: {max}\nAvg: {sum / nums.Length}");
		}
	}
}