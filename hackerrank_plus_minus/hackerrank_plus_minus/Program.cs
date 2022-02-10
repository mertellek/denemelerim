using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace hackerrank_plus_minus
{
    class Program
    {
        static void Main(string[] args)
        {
            //Girdiğimiz dizideki ayrı ayrı sıfırdan büyük, sıfırdan küçük ve sıfır olan elamanların adet ortalamasını veren program.
            Console.Write("Dizi kaç elemanlı olsun?: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Dizinin elemanlarını aralarında bir boşluk olacak şekilde giriniz: ");
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            decimal eksi = 0, arti = 0, sifir = 0;
            decimal toplam = arr.Count;
            foreach (var sayi in arr)
            {
                if (sayi > 0) arti++;
                else if (sayi < 0) eksi++;
                else sifir++;
            }
            decimal bir = arti / toplam, iki = eksi / toplam, uc = sifir / toplam;
            Console.WriteLine(bir);
            Console.WriteLine(iki);
            Console.WriteLine(uc);

            Console.ReadKey();
        }
    }
}
