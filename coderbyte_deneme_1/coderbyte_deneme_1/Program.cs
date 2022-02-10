using System;

namespace coderbyte_deneme_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //12 saatlik sistemde örnekteki gibi yazılan iki saat arasındaki dakika farkını veren program.
            //Örnek: 12:00am-11:00am
            
            string str =Console.ReadLine();
            
            string[] tire = str.Split('-');

            DateTime tire0 = DateTime.Parse(tire[0]);

            DateTime tire1 = DateTime.Parse(tire[1]);

            if (tire1 < tire0)
            {
                TimeSpan ts = tire0 - tire1;
                Console.WriteLine(1440 - ts.TotalMinutes);
            }
            else
            {
                TimeSpan ts = tire1 - tire0;
                Console.WriteLine(1440 - ts.TotalMinutes);
            }


            Console.ReadKey();
        }
    }
}
