using Terminal.Gui;

namespace ASCIItism;

public class MapWindow
{
    public static void InitializeMapWindow(Window BasicWindow)
    {
        Label test_label = new Label()
        {
            Y = Pos.Center(),
            X = Pos.Center(),
            Text = "TestLabel"
        };
            
        BasicWindow.RemoveAll();
        BasicWindow.Add(test_label);
    }
}