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



class Solution
{
    public static void Main(string[] args)
    {
        Console.Write("Dizinin eleman sayısını giriniz: ");
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        Console.Write("Elemanları aralarında birer boşluk olacak şekilde giriniz: ");
        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int temp = 0, sayac = 0;
        for (int i = 0; i < a.Count; i++)
        {
            for (int j = i; j < a.Count; j++)
            {
                if (a[i] > a[j])
                {
                    temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                    sayac++;
                }
            }
        }
        Console.WriteLine("Array is sorted in " + sayac + " swaps.");
        Console.WriteLine("First Element: " + a[0]);
        Console.WriteLine("Last Element: " + a[a.Count - 1]);

        Console.ReadKey();
    }
}

