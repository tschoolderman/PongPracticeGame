using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PongPracticeGame
{
    public partial class characterForm : Form
    {
        public characterForm()
        {
            InitializeComponent();
        }

        private void charGreen_Click(object sender, EventArgs e)
        {
            (this.Owner as Pong).pongball.BackColor = Color.Green;
            (this.Owner as Pong).timer1.Start();
            this.Hide();
        }

        private void charBlue_Click(object sender, EventArgs e)
        {
            (this.Owner as Pong).pongball.BackColor = Color.Blue;
            (this.Owner as Pong).timer1.Start();
            this.Hide();
        }

        private void charPink_Click(object sender, EventArgs e)
        {
            (this.Owner as Pong).pongball.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            (this.Owner as Pong).timer1.Start();
            this.Hide();
        }

        private void defaultColor_Click(object sender, EventArgs e)
        {
            (this.Owner as Pong).pongball.BackColor = Color.DarkCyan;
            (this.Owner as Pong).timer1.Start();
            this.Hide();
        }
    }
}
