namespace ASCIItism
{
    public partial class MainWin
    {
        public MainWin()
        {
            InitializeComponent();
        }

        public static Player player = new Player()
        {
                Nickname = "TestPlayer",
                PosY = 0,
                PosX = 0
        };

        public static Location CurrentLocation = LocationsDB.Map[0,0];
    }
}