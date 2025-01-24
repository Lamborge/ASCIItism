using ASCIItism.Windows;
using Terminal.Gui;

Application.Init();

try
{
    Application.Run(new MainWin());
}
finally
{
    Application.Shutdown();
}