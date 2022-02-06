using System;

namespace hackerrank_day6
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string S = Console.ReadLine();
                Cevir(S);
            }
        }

        static void Cevir(string S)
        {
            string tek = "";
            string cift = "";

            for (int i = 0; i < S.Length; i++)
            {
                if (i%2==0)
                {
                    cift = cift + S[i];
                }
                else
                {
                    tek = tek + S[i];
                }
            }

            Console.WriteLine(cift + " " + tek);

            Console.ReadKey();
        }
    }
}
