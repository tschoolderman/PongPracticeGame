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
    public partial class Pong : Form
    {
        // Location variables
        int cpuDirection = 5;
        int ballXCoordinate = 5;
        int ballYCoordinate = 5;

        // Score variables
        int playerScore = 0;
        int cpuScore = 0;

        // Size variables
        int bottomBoundary;
        int centerPoint;
        int xMidpoint;
        int yMidpoint;

        // Detection variables
        bool playerDetectedUp;
        bool playerDetectedDown;

        // Special keys
        int spaceBarClicked = 0;

        public Pong()
        {
            InitializeComponent();
            bottomBoundary = ClientSize.Height - player1.Height;
            xMidpoint = ClientSize.Width / 2;
            yMidpoint = ClientSize.Height / 2;
        }


        private void Pong_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random newBallSpot = new Random();
            int newSpot = newBallSpot.Next(100, ClientSize.Height - 100);

            // Adjust where the ball is
            pongball.Top -= ballYCoordinate;
            pongball.Left -= ballXCoordinate;

            // Make the cpu move
            cpuPlayer.Top += cpuDirection;

            // Increase cpu difficulty as player score increases
            if(playerScore > 5)
            {
                cpuPlayer.Top = pongball.Top + 30;
            }

            // Check if cpu has reached top or bottom
            if (cpuPlayer.Top < 0 || cpuPlayer.Top > bottomBoundary)
            {
                cpuDirection = -cpuDirection;
            }

            // Check if ball has exited the left side of the screen
            if (pongball.Left < 0)
            {
                pongball.Left = xMidpoint;
                pongball.Top = newSpot;
                ballXCoordinate = -ballXCoordinate;

                // On cpu score move ball slightly slower
                if (playerScore < 5)
                {
                    ballXCoordinate -= 2;
                }

                cpuScore++;
                cpuScoreLabel.Text = cpuScore.ToString();
            }

            // Check if the ball has exited the right side of the screen
            if (pongball.Left + pongball.Width > ClientSize.Width)
            {
                pongball.Left = xMidpoint;
                pongball.Top = newSpot;
                ballXCoordinate = -ballXCoordinate;

                // On player score increase ball speed slightly
                if (playerScore < 5)
                {
                    ballXCoordinate += 2;
                }

                playerScore++;
                playerScoreLabel.Text = playerScore.ToString();
            }

            // Ensure the ball is within the boundaries of the screen
            if (pongball.Top < 0 || pongball.Top + pongball.Height > ClientSize.Height)
            {
                ballYCoordinate = -ballYCoordinate;
            }

            // Check if the ball hits the player of cpu paddle
            if (pongball.Bounds.IntersectsWith(player1.Bounds) || pongball.Bounds.IntersectsWith(cpuPlayer.Bounds))
            {
                // Send the ball the other direction
                ballXCoordinate = -ballXCoordinate;
            }

            // Move player up
            if (playerDetectedUp == true && player1.Top > 0)
            {
                player1.Top -= 10;
            }

            // Move player down
            if (playerDetectedDown == true && player1.Top < bottomBoundary)
            {
                player1.Top += 10;
            }

            // Check for winner
            if (playerScore >= 10)
            {
                timer1.Stop();
            }
        }
        private void Pong_KeyUp(object sender, KeyEventArgs e)
        {
            // If player presses the up arrow
            if (e.KeyCode == Keys.Up)
            {
                playerDetectedUp = false;
            }

            // If player presses the down arrow
            if (e.KeyCode == Keys.Down)
            {
                playerDetectedDown = false;
            }
        }

        private void Pong_KeyDown(object sender, KeyEventArgs e)
        {
            // If player presses the up arrow
            if (e.KeyCode == Keys.Up)
            {
                playerDetectedUp = true;
            }

            // If player presses the down arrow
            if (e.KeyCode == Keys.Down)
            {
                playerDetectedDown = true;
            }

            // Open character selection on C press
            if (e.KeyCode == Keys.C)
            {
                Form character = new characterForm();
                character.Owner = this;
                timer1.Stop();
                character.Show();
            }

            // If player presses the spacebar, pause
            if (e.KeyCode == Keys.Space)
            {
                if (spaceBarClicked % 2 == 0)
                {
                    timer1.Stop();
                }
                else
                {
                    timer1.Start();
                }
            }
            spaceBarClicked++;
        }
    }
}
