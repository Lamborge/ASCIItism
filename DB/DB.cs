using Terminal.Gui;
using Attribute = System.Attribute;

namespace ASCIItism;

public static class DB
{

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

    // location && building code here
    
    public enum LocType
    {
        City,
        Paceful,
        PvP
    }

    public enum BuildType {
        Shop,
        Portal, // переход по локациям
        House, // пустышка в которой может находится игрок, без интерактива какого либо
    }
}