using ASCIItism.Objects.LocationSystem;

namespace ASCIItism.Objects;

public class Player
{
    public int PosX;
    public int PosY;

    public string Nickname;
    
    private Location currentLocation {get; set;}
    
    public Location CurrentLocation
    {
        get => currentLocation;
        set
        {
            PosX = value.PosX;
            PosY = value.PosY;
            currentLocation = value;
        }
    }

    public Player(string nickname, Location currentLocation)
    {
        Nickname = nickname;
        CurrentLocation = currentLocation;
    }
    
    
}