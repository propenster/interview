using System;

namespace Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] inputArray = { 1, 2, 3, 4, 5, 6 };
            int search = BinarySearch(inputArray, 5);
            Console.WriteLine($"Binary Search of the array => {search}");
        }

        private static int BinarySearch(int[] inputArray, int key)
        {
            int left = 0;
            int right = inputArray.Length;
            while (left < right)
            {
                int mid = (left + right) / 2;
                if (inputArray[mid] == key) return mid;
                else if (inputArray[mid] > key)
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return -1;
        }
    }
}
