using ASCIItism;
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