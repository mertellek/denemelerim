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
//Çözülmedi!
class Result
{
    public static List<int> icecreamParlor(int m, List<int> arr)
    {
        int secondIndex = 0, firstIndex = 0, first = 0, k = 0;

        while (secondIndex == 0)
        {
            do
            {
                firstIndex = k++;
                first = arr[firstIndex];
            }
            while (first >= m);
            for (int i = 0; i < arr.Count; i++)
            {
                if (i != firstIndex)
                {
                    if (arr[i] + first == m)
                    {
                        secondIndex = i + 1;
                        break;
                    }
                }
            }
        }
        List<int> response = new List<int>();
        response.Add(Math.Min(firstIndex + 1, secondIndex));
        response.Add(Math.Max(firstIndex + 1, secondIndex));
        return response;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        Console.Write("Dondurma dükkanına kaç kez gidildiğini giriniz: ");
        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            Console.Write("Dondurma çeşidi sayısını giriniz: ");
            int m = Convert.ToInt32(Console.ReadLine().Trim());
            Console.Write("Toplam parayı giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            Console.Write("Dondurma çeşitlerinin fiyatlarını aralarında birer boşluk olacak şekilde giriniz: ");
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> result = Result.icecreamParlor(m, arr);

            Console.WriteLine(String.Join(" ", result));
        }
        Console.ReadKey();
    }
}
