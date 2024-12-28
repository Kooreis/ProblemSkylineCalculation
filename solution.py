Here is a Python solution for the Skyline problem using a divide and conquer approach:

```python
class BuildingPoint(object):
    def __init__(self, point, is_start, height):
        self.point = point
        self.is_start = is_start
        self.height = height

    def __lt__(self, other):
        if self.point != other.point:
            return self.point < other.point
        else:
            if self.is_start:
                h1 = -self.height
            else:
                h1 = self.height

            if other.is_start:
                h2 = -other.height
            else:
                h2 = other.height

            return h1 < h2


def get_skyline(buildings):
    building_points = []
    for building in buildings:
        building_points.append(BuildingPoint(building[0], True, building[2]))
        building_points.append(BuildingPoint(building[1], False, building[2]))

    building_points.sort()

    queue = []
    queue.append(0)
    prev_max_height = 0
    points = []

    for building_point in building_points:
        if building_point.is_start:
            queue.append(building_point.height)
        else:
            queue.remove(building_point.height)

        max_height = max(queue)

        if prev_max_height != max_height:
            points.append((building_point.point, max_height))
            prev_max_height = max_height

    return points


if __name__ == "__main__":
    buildings = [[1, 3, 4], [2, 4, 6], [5, 8, 2], [6, 7, 4], [8, 9, 4]]
    print(get_skyline(buildings))
```

This Python program calculates the skyline formed by a list of buildings. The buildings are represented as a list of tuples, where each tuple contains the x-coordinate of the left edge, the x-coordinate of the right edge, and the height of the building. The program uses a divide and conquer approach to solve the problem. It first sorts the buildings by their x-coordinates and then uses a priority queue to keep track of the current highest building. The skyline is represented as a list of tuples, where each tuple contains the x-coordinate and the height of a point on the skyline.