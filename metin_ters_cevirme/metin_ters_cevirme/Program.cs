using System;

namespace metin_ters_cevirme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metin Giriniz: ");
            string metin = Console.ReadLine();

            Console.WriteLine("Metnin ters hali: ");

            for (int i = metin.Length-1; i >=0; i--)
            {
                Console.WriteLine(metin[i]);
            }

            Console.ReadKey();
       }
    }
}
