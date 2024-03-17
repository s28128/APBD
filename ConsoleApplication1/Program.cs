using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 10, 5, 20, 15, 30 };
            double avarage = FindAvarageValue(numbers);
            Console.WriteLine("avarage value -> " + avarage);
        }

        public static double FindAvarageValue(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                Console.WriteLine("niepoprawne");
            }

            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }

            return (double)sum / numbers.Length;
        }
        
    }
}