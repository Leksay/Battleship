namespace GameLogic
{
    public class GameHandler
    {

        private bool _nextMoveByPlayerOne = true;
        public bool NextMoveByPlayerOne => _nextMoveByPlayerOne;
        private static Player player1;
        private static Player player2;
        public static void StartGame(int height = 10, int width = 10, bool nextMoveByPlayerOne = true) //TODO пользователь должен сам указывать height and width
        {
            nextMoveByPlayerOne = nextMoveByPlayerOne;
            player1 = new Player(Player.PlayerNumber.PalyerOne, height, width);
            player2 = new Player(Player.PlayerNumber.PlayerTwo, height, width);
            // Запустить процесс игры
            
        }
    }
}