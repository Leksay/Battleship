using System;
using System.Collections.Generic;
using System.Text;

namespace GameLogic
{
    public class Player
    {
        public GameBoard OwnBoard;
        public GameBoard AttackBoard;
        public PlayerNumber PlayerNum;
        public enum PlayerNumber
        {
            PalyerOne, PlayerTwo
        }

        public Player(PlayerNumber num, int height, int width)
        {
            PlayerNum = num;
            OwnBoard = new GameBoard(height, width);
            AttackBoard = new GameBoard(height, width);
        }
    }
}
