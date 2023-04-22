using Terminal.Gui;
using Attribute = System.Attribute;

namespace ASCIItism;

public static class DB
{
    public enum LocType
    {
        City,
        Paceful,
        PvP
    }

    public enum PlayerClass
    {
        Human,
        Dwarf,
        Elf,
        Gnome
    }
    
    public enum ItemType
    {
        Food,
        Weapon,
        Material
    }
}