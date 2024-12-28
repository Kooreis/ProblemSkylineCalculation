Here is a C# console application that solves the Skyline problem:

```csharp
using System;
using System.Collections.Generic;
using System.Linq;

public class Building
{
    public int Left { get; set; }
    public int Height { get; set; }
    public int Right { get; set; }
}

public class Program
{
    public static void Main()
    {
        List<Building> buildings = new List<Building>()
        {
            new Building() { Left = 1, Height = 11, Right = 5 },
            new Building() { Left = 2, Height = 6, Right = 7 },
            new Building() { Left = 3, Height = 13, Right = 9 },
            new Building() { Left = 12, Height = 7, Right = 16 },
            new Building() { Left = 14, Height = 3, Right = 25 },
            new Building() { Left = 19, Height = 18, Right = 22 },
            new Building() { Left = 23, Height = 13, Right = 29 },
            new Building() { Left = 24, Height = 4, Right = 28 }
        };

        List<int[]> skyline = GetSkyline(buildings, 0, buildings.Count - 1);
        foreach (int[] point in skyline)
        {
            Console.WriteLine("[" + point[0] + ", " + point[1] + "]");
        }
    }

    public static List<int[]> GetSkyline(List<Building> buildings, int low, int high)
    {
        if (low > high)
        {
            return new List<int[]>();
        }
        else if (low == high)
        {
            return new List<int[]>()
            {
                new int[] { buildings[low].Left, buildings[low].Height },
                new int[] { buildings[low].Right, 0 }
            };
        }

        int mid = low + (high - low) / 2;

        List<int[]> skyline1 = GetSkyline(buildings, low, mid);
        List<int[]> skyline2 = GetSkyline(buildings, mid + 1, high);

        return MergeSkylines(skyline1, skyline2);
    }

    public static List<int[]> MergeSkylines(List<int[]> skyline1, List<int[]> skyline2)
    {
        int h1 = 0, h2 = 0, i = 0, j = 0;

        List<int[]> merged = new List<int[]>();

        while (i < skyline1.Count && j < skyline2.Count)
        {
            int x = 0, h = 0;
            if (skyline1[i][0] < skyline2[j][0])
            {
                x = skyline1[i][0];
                h1 = skyline1[i][1];
                i++;
            }
            else if (skyline1[i][0] > skyline2[j][0])
            {
                x = skyline2[j][0];
                h2 = skyline2[j][1];
                j++;
            }
            else
            {
                x = skyline1[i][0];
                h1 = skyline1[i][1];
                h2 = skyline2[j][1];
                i++;
                j++;
            }

            h = Math.Max(h1, h2);

            if (merged.Count == 0 || h != merged.Last()[1])
            {
                merged.Add(new int[] { x, h });
            }
        }

        while (i < skyline1.Count)
        {
            merged.Add(skyline1[i++]);
        }

        while (j < skyline2.Count)
        {
            merged.Add(skyline2[j++]);
        }

        return merged;
    }
}
```

This program uses a divide and conquer approach to solve the problem. It first divides the input list of buildings into two halves, then recursively solves the problem for each half, and finally merges the two solutions to get the final skyline. The merging process is done in a way that maintains the order of the points in the skyline and ensures that there are no consecutive points with the same height.