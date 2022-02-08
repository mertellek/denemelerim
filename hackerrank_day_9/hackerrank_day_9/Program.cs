using System;

namespace hackerrank_day_9
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());
            factorial(n);


            Console.WriteLine(factorial(n));
            Console.ReadKey();
        }
        public static int factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * factorial(n - 1);
            }
        }
    }
}
