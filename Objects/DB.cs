using Terminal.Gui;
using Attribute = System.Attribute;

namespace ASCIItism.Objects;

public static class DB
{

    public enum PlayerClass
    {
        Human,
        Dwarf,
        Elf,
        Gnome
    }
    
    // TODO: refactor to separate classes in future
    public enum ItemType
    {
        Food,
        Weapon,
        Material
    }

    // location && building code here
    
    public enum LocType
    {
        City,
        Paceful,
        PvP
    }
    
}