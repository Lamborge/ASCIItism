using Terminal.Gui;

namespace ASCIItism;

public static class MapWin
{
    public static void mapWin(Window bWin)
    {
        bWin.RemoveAll();
        bWin.Title = "Map";

        Label test_label = new Label()
        {
            Y = Pos.Center(),
            X = Pos.Center(),
            Text = "TestLabel"
        };
        
        bWin.Add(test_label);
    }
}