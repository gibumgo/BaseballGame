namespace BaseballGame
{
    public class Application
    {
        private static GameManager Gm = new GameManager();

        public static void Main(string[] args)
        {
            Gm.Init();
        }
    }
}