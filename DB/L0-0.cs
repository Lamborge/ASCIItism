namespace ASCIItism;

using System.Runtime.CompilerServices;
using static DB.LocType;
public class L0_0
{
    private static Location locationSystem = new();
    public static Location l0_0;

    static L0_0()
    {
        l0_0 = locationSystem.LocationDeserialize("Resources/Maps/spawn.json");
    }
}