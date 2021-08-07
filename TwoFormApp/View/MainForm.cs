using System;
using System.Drawing;
using System.Windows.Forms;

namespace TwoFormApp.View
{
    public class MainForm : Form
    {
        private TextBox _textBox;
        public MainForm()
        {
            this.Text = "Main Form";

            _textBox = new TextBox();
            Button submitButton = new Button();

            _textBox.Location = new Point(20,40);

            submitButton.Location = new Point(20, 60);
            submitButton.Text = "Submit";
            submitButton.Click += RunSecondForm;

            Controls.Add(_textBox);
            Controls.Add(submitButton);
        }

        private void RunSecondForm(object sender, EventArgs e)
        {
            SecondForm secondForm = new SecondForm(_textBox);
            secondForm.Show();
        }
    }
}
