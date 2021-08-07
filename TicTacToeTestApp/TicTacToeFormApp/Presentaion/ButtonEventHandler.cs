using System;
using System.Windows.Forms;
using TicTacToeApp.Model;

namespace TicTacToeFormApp.Presentaion
{
    public class ButtonEventHandler
    {
        private Game _game;
        private TicTacToeForm _ticTacToeForm;
        private Label _label;
        public ButtonEventHandler(TicTacToeForm ticTacToeForm, System.Windows.Forms.Label label)
        {
            _ticTacToeForm = ticTacToeForm;
            _label = label;
            SetGame();
        }

        private void SetGame()
        {
            Player p1, p2;
            IBoard board;
            IResultAnalyzer resultAnalyzer;
            p1 = new Player(Mark.O, "omkar");
            p2 = new Player(Mark.X, "sachin");
            board = new Board();
            resultAnalyzer = new ResultAnalyzer(board);
            _game = new Game(p1, p2, resultAnalyzer, board);
        }

        public void PlayGame(object sender, EventArgs e)
        {
            Player turn = _game.Turn;
            Button button = (Button)sender;
            Result result = Result.Processing;

            try
            {
                result = _game.Play(Convert.ToInt32(button.Text) - 1);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                MessageBox.Show("Cell Already Marked", "Error");
                return;
            }
            button.Text = turn.Mark.ToString();
            _label.Text = "Result: Processing, Current Player: " + _game.Turn.Name + "(" + _game.Turn.Mark.ToString() + ")";

            if (result.Equals(Result.Win))
            {
                MessageBox.Show(turn.Name + " Win's", "Result");
                _ticTacToeForm.Close();
                return;
            }
            if (result.Equals(Result.Draw))
            {
                MessageBox.Show("Draw", "Result");
                _ticTacToeForm.Close();
                return;
            }
        }
    }
}
