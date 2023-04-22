namespace ASCIItism;

public class Player
{
    public int PosX;
    public int PosY;

    public string Nickname;

    public Player()
    {
        
    }

    public Player(string nickname, Location currentLocation)
    {
        Nickname = nickname;
        CurrentLocation = currentLocation;
    }

    private Location currentLocation;
    public Location CurrentLocation
    {
        get { return currentLocation; }
        set
        {
            PosX = value.PosX;
            PosY = value.PosY;
            currentLocation = value;
        }
    }
}