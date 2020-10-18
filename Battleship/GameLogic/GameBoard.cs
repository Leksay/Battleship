using System;
using System.Collections.Generic;
namespace GameLogic
{
    public class GameBoard
    {
        private int _height;
        private int _width;
        private Cell[,] _board;
        private List<ShipLocator> _shipsOnBoard= new List<ShipLocator>();

        public GameBoard(int height, int width)
        {
            this._height = height;
            this._width = width;
            _board = new Cell[this._height, this._width]; //create board as an array of cells
            for(int i=0; i < height; i++)
            {
                for(int j=0;j<width;j++)
                {
                    _board[i, j] = new Cell(Cell.CellState.Empty);
                }
            }
        }
        public void PlaceShip(int x, int y, Ship.ShipType shipType, bool isVertical) 
        {
            int shipSize = Ship.GetShipSizeByShipType(shipType);
            int startPosition = (isVertical)?y:x;
            for(int i = startPosition; i < (startPosition+shipSize); i++)
            {
                if(isVertical) //y
                {
                    if(_board[x,i].IsAvailable() == false) //if unavailable
                    {
                        Console.WriteLine("Ship placement is not available, choose different coordinate, tupitsa :)");
                    }
                }
                else //x
                {
                    if(_board[i,y].IsAvailable() == false) //if unavailable
                    {
                        Console.WriteLine("Ship placement is not available, choose different coordinate, tupitsa :)");
                    }
                }
            }
        }

        public Cell[,] GetCells()
        {
            return _board;
        }
    }
}