using System.IO.Enumeration;
using static Terminal.Gui.Pos;

namespace ASCIItism
{
    using System;
    using Terminal.Gui;
    public partial class InfoWin : Terminal.Gui.Window
    {
        private Button MenuMainButton;
        private Button MenuMapButton;
        private Button MenuChatButton;

        private Window BasicWindow;
        
        private Window ButtonPanelWindow;

        private void InitializeComponent()
        {
            Title = "ASCIItism";
            
            InitializeButtonPanelWindow();
            InitializeBasicWindow();
            InitializeMainWindow();
        }

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
            Add(BasicWindow);
        }

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

            MenuMainButton = new Button()
            {
                X = 1,
                Y = 0,
                Text = "Location"
            };
            ButtonPanelWindow.Add(MenuMainButton);
            MenuMainButton.Clicked += () => InitializeMainWindow();

            MenuMapButton = new Button()
            {
                X = Pos.Right(MenuMainButton),
                Y = MenuMainButton.Y,
                Text = "Map"
            };
            ButtonPanelWindow.Add(MenuMapButton);
            MenuMapButton.Clicked += () => InitializeMapWindow();

            MenuChatButton = new Button()
            {
                X = Pos.Right(MenuMapButton),
                Y = MenuMapButton.Y,
                Text = "Chat"
            };
            MenuChatButton.Clicked += () => InitializeChatWindow();
            ButtonPanelWindow.Add(MenuChatButton);

            this.Add(ButtonPanelWindow);
        }

        private void InitializeMainWindow()
        {
            Label MainLabel = new Label()
            {
                Text = $"Position: {player.PosY}-{player.PosX} Location: {CurrentLocation.Name} Type: {CurrentLocation.Type}",
                X = Pos.Center(),
                Y = Pos.Bottom(ButtonPanelWindow)-2
            };

            Button TestBut = new Button()
            {
                Y = Pos.Center()+3,
                X = Pos.Center(),
                Text = "MainWindowButton"
            };
            
            BasicWindow.RemoveAll();
            BasicWindow.Add(TestBut,MainLabel);
        }

        private void InitializeMapWindow()
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

        private void InitializeChatWindow()
        {
            Label Chat = new Label()
            {
                Y = 1,
                X = 1,
                Text = LocationsDB.Map[0,0].Name
            };
            BasicWindow.RemoveAll();
            BasicWindow.Add(Chat);
        }
    }
}