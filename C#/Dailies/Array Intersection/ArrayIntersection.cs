using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<int> FindCommonElements(int[] arr1, int[] arr2)
    {
        HashSet<int> set1 = new HashSet<int>(arr1);
        HashSet<int> set2 = new HashSet<int>(arr2);

        // Find the intersection of set1 and set2
        set1.IntersectWith(set2);

        return set1.ToList();
    }

    static void Main(string[] args)
    {
        int[] inputArr1 = { 1, 2, 2, 1 };
        int[] inputArr2 = { 2, 2 };
        List<int> output = FindCommonElements(inputArr1, inputArr2);
        Console.WriteLine("Output: [" + string.Join(", ", output) + "]");
    }
}
