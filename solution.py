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