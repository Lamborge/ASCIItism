using Terminal.Gui;

namespace ASCIItism;

public class ChatWindow
{
    public static void InitializeChatWindow(Window BasicWindow)
    {
        BasicWindow.ColorScheme = MainWin.DefaultCS;
        Label Chat = new Label()
        {
            Y = 1,
            X = 1,
            Text = "Chat"
        };
        BasicWindow.RemoveAll();
        BasicWindow.Add(Chat);
    }
}