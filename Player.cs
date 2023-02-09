namespace ASCIItism;

public class Player
{
    public int PosX;
    public int PosY;

    public string Nickname;

    public Player()
    {
        
    }

    public Player(string nickname, int posX, int posY)
    {
        Nickname = nickname;
        PosX = PosY;
        PosY = posY;
    }
}