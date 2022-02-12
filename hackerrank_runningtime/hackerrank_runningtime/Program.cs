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

                                //https://www.hackerrank.com/challenges/runningtime/problem
class Result
{
    public static int runningTime(List<int> arr)
    {
        int sayac = 0;
        int temp = 0;

        for (int i = 1; i < arr.Count; i++)
        {
            if (arr[i] < arr[i - 1])
            {
                temp = arr[i];
                arr[i] = arr[i - 1];
                arr[i - 1] = temp;
                sayac++;

                if (i > 1) i -= 2;
            }
        }
        return sayac;

    }
}

class Solution
{
    public static void Main(string[] args)
    {
        Console.Write("Dizinin eleman sayısını giriniz: ");
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Console.Write("Dizinin elemanlarını aralarında bir (1) boşluk olacak şekilde giriniz: ");
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.runningTime(arr);

        Console.WriteLine(result);

        Console.ReadKey();
    }
}

