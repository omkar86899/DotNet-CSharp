using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToeFormApp.Presentaion
{
    public class TicTacToeForm: Form
    {
        private List<Button> buttons;
        private Label _label;
        public TicTacToeForm()
        {
            this.Text = "Tic Tac Toe";
            buttons = new List<Button>();
            _label = new Label();
            ButtonEventHandler buttonEventHandler = new ButtonEventHandler(this, _label);
            for(int i = 0; i < 9; i++)
            {
                Button button = new Button();
                button.Text = Convert.ToString(i+1);
                button.Click += buttonEventHandler.PlayGame;
                buttons.Add(button);
            }
            AddComponents();
        }

        private void AddComponents()
        {
            Label copyrightInfo = new Label();
            copyrightInfo.Text = "© "+ConfigurationManager.AppSettings.Get("ownerName");
            copyrightInfo.Text += "\n"+ConfigurationManager.AppSettings.Get("contactInfo");
            _label.Text = "Result: Processing, Current Player: Omkar(O)";

            copyrightInfo.Location = new Point(10, 200);
            for (int i = 0; i < 3; i++)
            {
                buttons[i * 3].Location = new Point(10, 40 + i * 30);
                buttons[i * 3 + 1].Location = new Point(90, 40 + i * 30);
                buttons[i * 3 + 2].Location = new Point(170, 40 + i * 30);
            }

            _label.Width = 300;
            copyrightInfo.Width = 200;
            copyrightInfo.Height = 500;

            foreach (Button button in buttons)
            {
                Controls.Add(button);
            }
            Controls.Add(_label);
            Controls.Add(copyrightInfo);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // TicTacToeForm
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "TicTacToeForm";
            this.Load += new System.EventHandler(this.TicTacToeForm_Load);
            this.ResumeLayout(false);

        }

        private void TicTacToeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
