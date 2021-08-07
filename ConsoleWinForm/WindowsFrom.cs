using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConsoleWinForm
{
    public class WindowsFrom: Form
    {
        public WindowsFrom()
        {
            this.Text = "omkar";

            Button redButton = new Button();
            Button blueButton = new Button();

            redButton.Text = "Red";
            redButton.Location = new Point(20, 40);
            redButton.Click += ChangeBackgroundColor;

            blueButton.Text = "Blue";
            blueButton.Location = new Point(120, 40);
            blueButton.Click += ChangeBackgroundColor;

            Controls.Add(redButton);
            Controls.Add(blueButton);
        }

        private void ChangeBackgroundColor(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if(button.Text == "Red")
            {
                this.BackColor = Color.Red;
            }
            if(button.Text == "Blue")
            {
                this.BackColor = Color.Blue;
            }

            MessageBox.Show("Color Changed");
        }
    }
}
