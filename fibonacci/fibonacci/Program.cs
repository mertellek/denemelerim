using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = int.Parse(Console.ReadLine());
            for (int i = 0; i < sayi+1; i++)
            {
                Console.WriteLine(i+". Fibonacci sayısı: "+ fib(i));
            }
            Console.ReadKey();
        }

        public static int fib(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return fib(n - 1) + fib(n - 2);
            }
        }
    }
}
