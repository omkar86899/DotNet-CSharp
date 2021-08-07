using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeApp.Model
{
    public class CellAlreadyMarkedException : Exception
    {
        private String _message;

        public CellAlreadyMarkedException(String message)
        {
            _message = message;
        }

        public override string Message
        {
            get { return _message; }
        }
    }
}
