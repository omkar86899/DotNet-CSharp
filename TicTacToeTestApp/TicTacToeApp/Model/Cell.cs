
namespace TicTacToeApp.Model
{
    public class Cell
    {
        private Mark _cellMark;
        public Cell()
        {
            _cellMark = Mark.EMPTY;
        }

        public Mark CellMark
        {
            get { return _cellMark; }
            set
            {
                if(_cellMark != Mark.EMPTY)
                {
                    throw new CellAlreadyMarkedException("Cell Already Marked");
                }
                _cellMark = value;
            }
        }
    }
}