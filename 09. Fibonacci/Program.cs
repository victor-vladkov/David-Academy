using System;

namespace _09._Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()),
				c = 3;
			int[] nums = new int[] { 1, 1, 2 };
			while (c < n) {
				nums[0] = nums[1];
				nums[1] = nums[2];
				nums[2] = nums[0] + nums[1];
				c++;
			}
			Console.WriteLine(nums[2]);
        }
    }
}
