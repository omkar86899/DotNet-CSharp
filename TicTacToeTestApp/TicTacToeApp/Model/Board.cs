using System.Collections.Generic;

namespace TicTacToeApp.Model
{
    public class Board: IBoard
    {
        private List<Cell> _board;
        private int _size = 3;

        public Board()
        {
            _board = new List<Cell>();
            for(int i = 0; i < _size*_size; i++)
            {
                _board.Add(new Cell());
            }
        }

        public int Size
        {
            get { return _size; }
        }

        List<Cell> IBoard.Board
        {
            get { return _board; }
        }

        public void MarkCell(int index, Mark mark)
        {
            _board[index].CellMark = mark;
        }
    }
}
