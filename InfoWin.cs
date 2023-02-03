namespace ASCIItism
{
    public partial class InfoWin
    {
        public InfoWin()
        {
            InitializeComponent();
        }

        public Player player = new Player()
        {
                Nickname = "TestPlayer",
                PosY = 0,
                PosX = 0
        };

        public Location CurrentLocation = LocationsDB.Map[0,0];
    }
}