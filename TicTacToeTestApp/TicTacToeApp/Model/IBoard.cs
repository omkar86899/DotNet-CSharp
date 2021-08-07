using System.Collections.Generic;

namespace TicTacToeApp.Model
{
    public interface IBoard
    {
        void MarkCell(int index, Mark mark);

        List<Cell> Board
        {
            get;
        }

        int Size
        {
            get;
        }
    }
}
