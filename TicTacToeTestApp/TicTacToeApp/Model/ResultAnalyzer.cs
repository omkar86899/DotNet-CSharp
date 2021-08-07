using System.Collections.Generic;

namespace TicTacToeApp.Model
{
    public class ResultAnalyzer: IResultAnalyzer
    {
        public IBoard _board;

        public ResultAnalyzer(IBoard board)
        {
            _board = board;
        }

        public Result GameResult
        {
            get
            {
                List<Cell> gameBoard = _board.Board;
                if (HorizontalCheck(gameBoard) || VerticalCheck(gameBoard) || DiagonalCheck(gameBoard))
                {
                    return Result.Win;
                }
                if (IsBoardFull(gameBoard))
                {
                    return Result.Draw;
                }
                return Result.Processing;
            }
        }

        private bool DiagonalCheck(List<Cell> gameBoard)
        {
            if(gameBoard[0].CellMark == gameBoard[4].CellMark && gameBoard[4].CellMark == gameBoard[8].CellMark && gameBoard[4].CellMark != Mark.EMPTY)
            {
                return true;
            }
            if (gameBoard[2].CellMark == gameBoard[4].CellMark && gameBoard[4].CellMark == gameBoard[6].CellMark && gameBoard[4].CellMark != Mark.EMPTY)
            {
                return true;
            }
            return false;
        }

        private bool VerticalCheck(List<Cell> gameBoard)
        {
            for(int i = 0; i < _board.Size; i++)
            {
                if(gameBoard[i].CellMark == gameBoard[i + 3].CellMark && gameBoard[i + 3].CellMark == gameBoard[i + 6].CellMark && gameBoard[i].CellMark != Mark.EMPTY)
                {
                    return true;
                }
            }
            return false;
        }

        private bool HorizontalCheck(List<Cell> gameBoard)
        {
            for(int i=0; i<gameBoard.Count; i += _board.Size)
            {
                if (gameBoard[i].CellMark == gameBoard[i + 1].CellMark && gameBoard[i + 1].CellMark == gameBoard[i + 2].CellMark && gameBoard[i].CellMark != Mark.EMPTY)
                {
                    return true;
                }
            }
            return false;
        }

        private bool IsBoardFull(List<Cell> gameBoard)
        {
            foreach(Cell cell in gameBoard)
            {
                if(cell.CellMark == Mark.EMPTY)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
