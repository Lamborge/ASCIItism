using Terminal.Gui;
using static ASCIItism.Windows.MainWin;

namespace ASCIItism.Windows;

public static class LocationWin
{
    // Draw elements of Location Window in Basic Window
    public static void locationWin(Window bWin)
    {
        bWin.RemoveAll();
        
        bWin.Title =
            $"Position: {player.CurrentLocation.PosX}-{player.CurrentLocation.PosY} " +
            $"Location: {player.CurrentLocation.Name} " +
            $"Type: {Enum.GetName(player.CurrentLocation.LocType)}"; // MainWin.player пока что костыль, тестовый игрок

        Button TestBut = new Button()
        {
            Y = Pos.Center()+3,
            X = Pos.Center(),
            Text = "MainWindowButton"
        };
        bWin.Add(TestBut);
    }
}