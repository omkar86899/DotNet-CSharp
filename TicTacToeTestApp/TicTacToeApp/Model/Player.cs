using System;

namespace TicTacToeApp.Model
{
    public class Player
    {
        private String _name;
        private Mark _playerMark;
        public Player(Mark mark, String name)
        {
            _name = name;
            _playerMark = mark;
        }

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public Mark Mark
        {
            get { return _playerMark; }
        }
    }
}
