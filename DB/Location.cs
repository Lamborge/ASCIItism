namespace ASCIItism;

using static DB;

public class Location
{
    public int PosX;
    public int PosY;
    
    public string Name;
    public LocType Type;

    public Object[] Objects = new Object[] { };

    public List<Player> Players;
}