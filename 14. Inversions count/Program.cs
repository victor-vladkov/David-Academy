using System;
using System.Linq;

namespace _15._Inversions_count {
	class Program {
		static void Main(string[] args) {
			int[] nums = Console.ReadLine()
				.Split(" ")
				.Select(int.Parse)
				.ToArray();
			int c = 0;
			for (int i = 0; i < nums.Length - 1; i++)
				for (int j = i + 1; j < nums.Length; j++)
					if (i < j && nums[i] > nums[j])
						c++;
			Console.WriteLine(c);
		}
	}
}
