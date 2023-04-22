using System.IO.Enumeration;
using static Terminal.Gui.Pos;

namespace ASCIItism
{
    using System;
    using Terminal.Gui;
    public partial class MainWin : Terminal.Gui.Window
    {
        public static Window basicWin;
        
        public Window buttonPanelWin;
        
        private void InitializeComponent()
        {
            Title = "ASCIItism";

            buttonPanelWin = new ButtonPanelWin();
            Add(buttonPanelWin);
            InitializeBasicWindow();
        }

        // Draw and add basic window under button panel, 
        private void InitializeBasicWindow()
        {
            basicWin = new Window()
            {
                X = 0,
                Y = Pos.Bottom(buttonPanelWin),
                Width = Dim.Fill(),
                Height = Dim.Fill(),
                ColorScheme = MainWin.DefaultCS
            };

            Label GreetingsLaber = new Label()
            {
                Text = "Wellcome to ASCIItism!",
                Y = Pos.Center(),
                X = Pos.Center()
            }; 
            basicWin.Add(GreetingsLaber);
            Add(basicWin);
        }
        
    }
}