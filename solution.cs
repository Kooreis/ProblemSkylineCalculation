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