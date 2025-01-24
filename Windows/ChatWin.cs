using Terminal.Gui;

namespace ASCIItism.Windows;

public static class ChatWin
{
    public static void chatWin(Window bWin)
    {
        bWin.RemoveAll();
        
        bWin.Title = "Chat";
        
        Label Chat = new()
        {
            Y = 1,
            X = 1,
            Text = "Chat"
        };
        bWin.Add(Chat);
    }
}