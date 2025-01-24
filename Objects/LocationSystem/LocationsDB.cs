using ASCIItism.Objects.MapBuilding;
using ASCIItism.Objects.LocationSystem.Locations;

namespace ASCIItism.Objects.LocationSystem;

public static class LocationsDB
{
    public static Location[,] Map =
    {
        {
            L0_0.l0_0
        },
        {
            new Location(0,
                1,
                DB.LocType.City,
                "Null",
                new Building[]{new House("Null", "Null")}
            ),
        }
    };
}
