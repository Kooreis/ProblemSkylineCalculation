# Question: How do you calculate the skyline formed by a list of buildings (Skyline problem)? C# Summary

The C# program calculates the skyline formed by a list of buildings. It uses a divide and conquer strategy to solve the problem. The program first divides the list of buildings into two halves. It then recursively calculates the skyline for each half. After obtaining the skylines for each half, the program merges the two skylines to form the final skyline. The merging process is done in a way that maintains the order of the points in the skyline and ensures that there are no consecutive points with the same height. This is achieved by comparing the x-coordinates of the points in the two skylines and adding the point with the smaller x-coordinate to the merged skyline. If two points have the same x-coordinate, the point with the higher height is added to the merged skyline. The process continues until all points from both skylines have been added to the merged skyline. The program then prints the final skyline to the console.

---

# Python Differences

The Python version of the solution uses a different approach to solve the problem compared to the C# version. While both solutions use a divide and conquer approach, the Python version does not split the problem into two halves and recursively solve each half. Instead, it creates a list of all the building points (both start and end points), sorts this list, and then iterates over it to construct the skyline.

The Python version uses a priority queue (implemented as a list) to keep track of the current highest building. When it encounters a start point, it adds the height of the building to the queue. When it encounters an end point, it removes the height of the building from the queue. The maximum height in the queue is the height of the current highest building, and this is used to determine the height of the skyline at each point.

The Python version also uses a custom class `BuildingPoint` to represent a building point. This class includes a comparison method `__lt__` that defines how to compare two building points. This is used when sorting the list of building points.

In terms of language features, the Python version uses list comprehension to create the list of building points and the built-in `max` function to find the maximum height in the queue. It also uses tuples to represent the buildings and the points on the skyline, which is a feature not available in C#. The C# version, on the other hand, uses a custom `Building` class to represent a building and a two-dimensional list to represent the skyline. It also uses the `List<T>.Add` and `List<T>.Remove` methods to add and remove heights from the queue, and the `Math.Max` method to find the maximum height.

---

# Java Differences

The Java version of the solution uses a different approach to solve the Skyline problem compared to the C# version. Instead of using a divide and conquer approach, the Java version uses a priority queue to keep track of the maximum height at any given point.

In the Java version, the buildings are represented as a 2D array, whereas in the C# version, a list of Building objects is used. The Java version first creates a list of all critical points in the skyline, where a critical point is either the left or right edge of a building. These points are sorted by their x-coordinate, and in case of a tie, by their height. The height of a left edge is stored as a negative number to distinguish it from a right edge.

The Java version then uses a priority queue to keep track of the current maximum height. It iterates over the list of critical points, and for each point, it checks if it is a left or right edge. If it is a left edge, it adds the height to the queue, and if it is a right edge, it removes the height from the queue. Then it checks if the maximum height has changed. If it has, it adds the current point to the result list.

The C# version, on the other hand, uses a recursive function to divide the list of buildings into two halves, solve the problem for each half, and then merge the two solutions. The merging process is done in a way that maintains the order of the points in the skyline and ensures that there are no consecutive points with the same height.

In terms of language features, the Java version uses a lambda expression to define a comparator for sorting the list of critical points and for defining the order of the priority queue. The C# version uses properties to define the Building class and LINQ to get the last element of the merged list. The Java version uses the PriorityQueue class and the Collections.sort method, which do not have direct equivalents in C#.

---
