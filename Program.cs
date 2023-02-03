using ASCIItism;
using Terminal.Gui;

Application.Init();

try
{
    Application.Run(new InfoWin());
}
finally
{
    Application.Shutdown();
}