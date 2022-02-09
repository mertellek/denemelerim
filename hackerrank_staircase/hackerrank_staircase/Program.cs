using System;

namespace hackerrank_staircase
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            for (int i = 0; i < n; i++)
            {
                for (int space = n-1; space > i; space--)
                {
                    Console.Write(" ");
                }
                for (int hash = 0; hash <= i; hash++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }                                   
        }
    }
}
