import java.util.*;

public class Main {
    public static void main(String[] args) {
        int[][] buildings = {{2, 9, 10}, {3, 7, 15}, {5, 12, 12}, {15, 20, 10}, {19, 24, 8}};
        List<int[]> result = getSkyline(buildings);
        for (int[] point : result) {
            System.out.println(Arrays.toString(point));
        }
    }