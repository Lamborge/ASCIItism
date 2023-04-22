namespace ASCIItism;
using static DB.LocType;
public class L0_0
{
    public static Location l0_0 = new Location()
    {
        Name = "Spawn",
        Type = Paceful,
        PosX = 0,
        PosY = 0,
        Objects = new[]
        {
            new Object(name: "TestObject")
        }
    };
}