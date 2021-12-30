using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] nums = { 5, 4, 3 };
            Array.Reverse(nums, 0, 3);
            Console.Write("Array: [{0}]", string.Join(",", nums));
        }
    }
}
