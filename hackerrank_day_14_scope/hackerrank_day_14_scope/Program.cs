using System;
using System.Linq;

class Difference
{
    private int[] elements;
    public int maximumDifference;

    // Add your code here
    public Difference(int[] arr)
    {
        elements = arr;

    }

    public void computeDifference()
    {
        var max = int.MinValue;
        var min = int.MaxValue;

        for (var i = 0; i < elements.Length; i++)
        {
            max = Math.Max(max, elements[i]);
            min = Math.Min(min, elements[i]);
        }
        maximumDifference = max-min;
    }

} // End of Difference Class

class Solution
{
    static void Main(string[] args)
    {
        Console.Write("Dizinin eleman sayısını giriniz: ");
        Convert.ToInt32(Console.ReadLine());
        Console.Write("Dizinin elemanlarını aralarında birer boşluk olacak şekilde giriniz: ");
        int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

        Difference d = new Difference(a);

        d.computeDifference();

        Console.Write(d.maximumDifference);
        Console.ReadKey();
    }
}