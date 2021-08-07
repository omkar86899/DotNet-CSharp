

namespace TicTacToeApp.Model
{
    public class Game
    {
        private Player _p1, _p2;
        private IResultAnalyzer _resultAnalyzer;
        private IBoard _board;
        private Player _turn;

        public Game(Player p1, Player p2, IResultAnalyzer resultAnalyzer, IBoard board)
        {
            _p1 = p1;
            _p2 = p2;
            _resultAnalyzer = resultAnalyzer;
            _board = board;
            _turn = p1;
        }

        public Player Turn
        {
            get { return _turn; }
        }

        private void ChangeTurn()
        {
            if(_turn.Mark == _p1.Mark)
            {
                _turn = _p2;
                return;
            }
            if(_turn.Mark == _p2.Mark)
            {
                _turn = _p1;
            }
        }

        public Result Play(int index)
        {
            Result result;
            _board.MarkCell(index, _turn.Mark);
            result = _resultAnalyzer.GameResult;
            if (result.Equals(Result.Processing))
            {
                ChangeTurn();
            }
            return result;
        }
    }
}
