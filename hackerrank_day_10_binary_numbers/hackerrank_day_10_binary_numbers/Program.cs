using System;

namespace hackerrank_day_10_binary_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int toplam = 0, sayac = 0;
            while (n>0)
            {
                
                if (n%2==1)
                {
                    sayac ++;
                    toplam = Math.Max(sayac, toplam);
                }
                else
                {
                    sayac = 0;
                }
                n /= 2;
            }
            Console.WriteLine(toplam);
            Console.ReadKey();
        }
    }
}
