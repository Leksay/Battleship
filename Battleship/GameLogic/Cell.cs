namespace GameLogic
{
    public class Cell
    {
        int _xPosition;
        int _yPosition;

        public Cell(CellState state)
        {
            _state = state;
        }

        public enum CellState //перечисление
        {
            Empty,
            Missed,
            Bombed
        }

        private CellState _state; //implements enumered entities => state.empty

        public bool IsAvailable()
        {
            return _state == CellState.Empty; //return true or false corresponding to this sstatement (check)
        }

        //if cell empty or available => change the state to the upcoming one
        public void SetState(CellState newState)
        {
            if (IsAvailable())
            {
                _state = newState;
            }
        }
        
        public CellState GetCellState()
        {
            return _state;
        }
    }
}
