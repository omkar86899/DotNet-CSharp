using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoFormApp.View
{
    public class SecondForm: Form
    {
        public SecondForm(TextBox textBox)
        {
            this.Text = textBox.Text;
        }
    }
}
