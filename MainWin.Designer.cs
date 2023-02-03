using System.IO.Enumeration;
using static Terminal.Gui.Pos;

namespace ASCIItism
{
    using System;
    using Terminal.Gui;
    public partial class MainWin : Terminal.Gui.Window
    {
        private Window BasicWindow;
        
        private Window ButtonPanelWindow;

        private void InitializeComponent()
        {
            Title = "ASCIItism";
            
            InitializeButtonPanelWindow();
            InitializeBasicWindow();
        }

        // Draw and add basic window under button panel, 
        private void InitializeBasicWindow()
        {
            BasicWindow = new Window()
            {
                X = 0,
                Y = Pos.Bottom(ButtonPanelWindow),
                Width = Dim.Fill(),
                Height = Dim.Fill(),
                Border = new Border(){BorderStyle = BorderStyle.Double},
                
            };

            Label GreetingsLaber = new Label()
            {
                Text = "Wellcome to ASCIItism!",
                Y = Pos.Center(),
                X = Pos.Center()
            }; 
            BasicWindow.Add(GreetingsLaber);
            Add(BasicWindow);
        }
        
        // Draw on top of screen panel with menu buttons
        private void InitializeButtonPanelWindow()
        {
            ButtonPanelWindow = new Window()
            {
                X = 0,
                Y = 0,
                Width = Dim.Fill() - 1,
                Height = 3,
                Border = new Border()
                {
                    BorderStyle = BorderStyle.Rounded
                }
            };

            Button MenuMainButton = new Button()
            {
                X = 1,
                Y = 0,
                Text = "Location"
            };
            ButtonPanelWindow.Add(MenuMainButton);
            MenuMainButton.Clicked += () => LocationWin.InitializeLocationWindow(BasicWindow);

            Button MenuMapButton = new Button()
            {
                X = Pos.Right(MenuMainButton),
                Y = MenuMainButton.Y,
                Text = "Map"
            };
            ButtonPanelWindow.Add(MenuMapButton);
            MenuMapButton.Clicked += () => MapWindow.InitializeMapWindow(BasicWindow);

            Button MenuChatButton = new Button()
            {
                X = Pos.Right(MenuMapButton),
                Y = MenuMapButton.Y,
                Text = "Chat"
            };
            MenuChatButton.Clicked += () => ChatWindow.InitializeChatWindow(BasicWindow);
            ButtonPanelWindow.Add(MenuChatButton);

            Add(ButtonPanelWindow);
        }
    }
}