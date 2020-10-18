namespace GameLogic
{
    public class GameState
    {
        // Save file
        public bool NextMoveByPlayerOne { get; set; }
        public Player PlayerOne { get; set; }
        public Player PlayerTwo { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }
}