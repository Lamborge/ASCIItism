namespace ASCIItism;

public static class LocationsDB
{
    public static Location[,] Map =
    {
        {
            new Location()
            {
                Name = "Spawn",
                Type = "Friendly",
                PosX = 0,
                PosY = 0,
                Objects = new []{new Object(){Name = "TestObject"}}
            }
        },
        {
            new Location(){Name = "Null"}
        }
    };
}
