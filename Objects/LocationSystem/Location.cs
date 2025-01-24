using System.Text.Json;
using ASCIItism.Objects.MapBuilding;
using static ASCIItism.Objects.DB;

namespace ASCIItism.Objects.LocationSystem;

public class Location
{
    public int PosX { get; init; }
    public int PosY { get; init; }

    public string Name { get; init; }
    public LocType LocType { get; init; }

    public Building[] Buildings { get; init; }

    //public List<Player> Players = new ();

    public Location(int posX, int posY, LocType locType, string name, Building[] buildings)
    {
        PosX = posX;
        PosY = posY;
        Name = name;
        LocType = locType;
        Buildings = buildings;
    }

    // TODO: move function login into class constructor
    public void LocationInit()
    {

    }
    // не работает
    public static Location LocationDeserialize(string locpath)
    {

        try
        {
            string jsonString = File.ReadAllText(locpath);
            Location location = JsonSerializer.Deserialize<Location>(jsonString)!;
            return location;
        }
        catch (System.Exception)
        {
            throw;
        }
    }

}