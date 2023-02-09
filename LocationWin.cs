using System;
using Terminal.Gui;

namespace ASCIItism;

public class LocationWin : Terminal.Gui.Window
{
    // Draw elements of Location Window in Basic Window
    public static void InitializeLocationWindow(Window BasicWindow)
    {
        BasicWindow.Title =
            $"Position: {MainWin.player.PosY}-{MainWin.player.PosX}" +
            $"Location: {MainWin.CurrentLocation.Name}" +
            $"Type: {MainWin.CurrentLocation.Type}"; // MainWin.player пока что костыль, тестовый игрок


        Button TestBut = new Button()
        {
            Y = Pos.Center()+3,
            X = Pos.Center(),
            Text = "MainWindowButton"
        };
            
        BasicWindow.RemoveAll();
        BasicWindow.Add(TestBut);
    }
}