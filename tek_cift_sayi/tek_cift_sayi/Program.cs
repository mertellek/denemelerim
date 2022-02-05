using System;

namespace tek_cift_sayi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N Sayısı giriniz: ");
            int N = Convert.ToInt32(Console.ReadLine().Trim());
            bool weirdCheck = false;

            if (N > 20)
            {
                weirdCheck = false;
            }
            else if (N >= 6 && N <= 20)
            {
                weirdCheck = true;
            }
            else if (N >= 2 && N <= 5 )
            {
                weirdCheck = false;
            }
            else if (N % 2 == 1)
            {
                weirdCheck = true;
            }
            else { Console.WriteLine("???"); }
        
               
            
            if (weirdCheck == true) { Console.WriteLine("Weird"); }
            else { Console.WriteLine("Not Weird"); }

            Console.ReadKey();
        
        }
    }
}
