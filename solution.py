def get_skyline(buildings):
    building_points = []
    for building in buildings:
        building_points.append(BuildingPoint(building[0], True, building[2]))
        building_points.append(BuildingPoint(building[1], False, building[2]))

    building_points.sort()