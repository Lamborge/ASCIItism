namespace ASCIItism;

using System.Text.Json;
using static DB;


public class Location
{
    public int PosX { get; set; }
    public int PosY { get; set; }

    public string Name { get; set; } = "локация";
    public LocType Type { get; set; }

    public Building[] Buildings { get; set; } = new Building[] { };

    public List<Player> Players { get; set; } = new() { };


    public void LocationInit()
    {

    }
    // не работает
    public Location LocationDeserialize(string locpath)
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