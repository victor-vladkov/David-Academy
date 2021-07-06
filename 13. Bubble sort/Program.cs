using System;

namespace _14._Bubble_sort {
	class Program {
		static void Main(string[] args) {
			Console.Write("Array length: ");
			int n = int.Parse(Console.ReadLine());
			double[] nums = new double[n];
			for (int i = 0; i < n; i++)
				nums[i] = double.Parse(Console.ReadLine());
			Console.Write("Order - [A]scending / [D]escending: ");
			char c = Console.ReadLine().ToLower()[0];
			if (c == 'a')
				for (int i = 0; i < n - 1; i++)
					for (int j = 0; j < n - i - 1; j++)
						if (nums[j] > nums[j + 1]) {
							double x = nums[j];
							nums[j] = nums[j + 1];
							nums[j + 1] = x;
						}
			if (c == 'd')
				for (int i = 0; i < n - 1; i++)
					for (int j = 0; j < n - i - 1; j++)
						if (nums[j] < nums[j + 1]) {
							double x = nums[j];
							nums[j] = nums[j + 1];
							nums[j + 1] = x;
						}
			Console.WriteLine(string.Join("; ", nums));
		}
	}
}
