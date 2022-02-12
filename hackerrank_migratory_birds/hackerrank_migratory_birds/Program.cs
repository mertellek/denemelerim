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
                                //https://www.hackerrank.com/challenges/migratory-birds/problem
class Result
{
    public static int migratoryBirds(List<int> arr)
    {
        int[] xbirds = { 0, 0, 0, 0, 0 };
        int max = 0;
        int sonuc = 0;

        for (int i = 0; i < arr.Count; i++)
        {
            if (arr[i] == 1) xbirds[0]++;
            else if (arr[i] == 2) xbirds[1]++;
            else if (arr[i] == 3) xbirds[2]++;
            else if (arr[i] == 4) xbirds[3]++;
            else if (arr[i] == 5) xbirds[4]++;
        }

        for (int i = 1; i < 6; i++)
        {
            if (xbirds[i - 1] > max)
            {
                max = xbirds[i - 1];
                sonuc = i;
            }
        }
        return sonuc;

    }

}

class Solution
{
    public static void Main(string[] args)
    {

        Console.Write("Dizinin elaman sayısını giriniz: ");
        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());
        Console.Write("Elemanları aralarında birer boşluk olacak şekilde girinzi: ");
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.migratoryBirds(arr);
        Console.WriteLine(result);
        Console.ReadKey();

    }
}
