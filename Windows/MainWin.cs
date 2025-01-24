using Terminal.Gui;
using Attribute = Terminal.Gui.Attribute;
using Color = Terminal.Gui.Color;
using ASCIItism.Objects;
using ASCIItism.Objects.LocationSystem;

namespace ASCIItism.Windows;

public partial class MainWin
{
    public static ColorScheme WhiteBlack = new ColorScheme()
    {
        Normal = new Attribute(Color.White, Color.Black), 
        HotNormal = new Attribute(Color.White, Color.Black),
        Focus = new  Attribute(Color.Black, Color.White),
        HotFocus = new  Attribute(Color.Black, Color.White),
        Disabled = new Attribute(Color.Red, Color.Red)
    };

    public static ColorScheme DefaultCS = WhiteBlack;

    public MainWin()
    {
        InitializeComponent();
        ColorScheme = DefaultCS;
    }

    public static Player player = new ("TestPlayer", LocationsDB.Map[0, 0]);

}
