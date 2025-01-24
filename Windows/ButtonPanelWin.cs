using Terminal.Gui;

namespace ASCIItism.Windows;

public class ButtonPanelWin : Window
{
    public ButtonPanelWin()
    {
        X = 0;
        Y = 0;
        Width = Dim.Fill();
        Height = 3;
        Border = new Border()
        {
            BorderStyle = BorderStyle.Rounded
        };
        ColorScheme = MainWin.DefaultCS;

        var LocButton = new Button()
        {
            X = 1,
            Y = 0,
            Text = "Location"
        };
        Add(LocButton);
        LocButton.Clicked += () => LocationWin.locationWin(MainWin.basicWin);
        

        var MapButton = new Button()
        {
            X = Pos.Right(LocButton),
            Y = LocButton.Y,
            Text = "Map"
        };
        Add(MapButton);
        MapButton.Clicked += () => MapWin.mapWin(MainWin.basicWin);

        var ChatButton = new Button()
        {
            X = Pos.Right(MapButton),
            Y = MapButton.Y,
            Text = "Chat"
        };
        Add(ChatButton);
        ChatButton.Clicked += () => ChatWin.chatWin(MainWin.basicWin);
    }
}