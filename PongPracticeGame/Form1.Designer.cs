namespace PongPracticeGame
{
    partial class Pong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.player1 = new System.Windows.Forms.PictureBox();
            this.cpuPlayer = new System.Windows.Forms.PictureBox();
            this.pongball = new System.Windows.Forms.PictureBox();
            this.scoreboard = new System.Windows.Forms.PictureBox();
            this.playerScoreLabel = new System.Windows.Forms.Label();
            this.cpuScoreLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pongball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreboard)).BeginInit();
            this.SuspendLayout();
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.Color.OrangeRed;
            this.player1.Location = new System.Drawing.Point(12, 350);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(20, 200);
            this.player1.TabIndex = 0;
            this.player1.TabStop = false;
            // 
            // cpuPlayer
            // 
            this.cpuPlayer.BackColor = System.Drawing.Color.OrangeRed;
            this.cpuPlayer.Location = new System.Drawing.Point(1212, 350);
            this.cpuPlayer.Name = "cpuPlayer";
            this.cpuPlayer.Size = new System.Drawing.Size(20, 200);
            this.cpuPlayer.TabIndex = 1;
            this.cpuPlayer.TabStop = false;
            // 
            // pongball
            // 
            this.pongball.BackColor = System.Drawing.Color.DarkCyan;
            this.pongball.Location = new System.Drawing.Point(630, 425);
            this.pongball.Name = "pongball";
            this.pongball.Size = new System.Drawing.Size(25, 25);
            this.pongball.TabIndex = 2;
            this.pongball.TabStop = false;
            // 
            // scoreboard
            // 
            this.scoreboard.BackColor = System.Drawing.Color.Transparent;
            this.scoreboard.Location = new System.Drawing.Point(480, 12);
            this.scoreboard.Name = "scoreboard";
            this.scoreboard.Size = new System.Drawing.Size(300, 50);
            this.scoreboard.TabIndex = 3;
            this.scoreboard.TabStop = false;
            // 
            // playerScoreLabel
            // 
            this.playerScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerScoreLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.playerScoreLabel.Location = new System.Drawing.Point(439, 27);
            this.playerScoreLabel.Name = "playerScoreLabel";
            this.playerScoreLabel.Size = new System.Drawing.Size(35, 35);
            this.playerScoreLabel.TabIndex = 4;
            this.playerScoreLabel.Text = "0";
            this.playerScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cpuScoreLabel
            // 
            this.cpuScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuScoreLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cpuScoreLabel.Location = new System.Drawing.Point(786, 27);
            this.cpuScoreLabel.Name = "cpuScoreLabel";
            this.cpuScoreLabel.Size = new System.Drawing.Size(35, 35);
            this.cpuScoreLabel.TabIndex = 5;
            this.cpuScoreLabel.Text = "0";
            this.cpuScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tag = "";
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Pong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1244, 861);
            this.Controls.Add(this.pongball);
            this.Controls.Add(this.cpuPlayer);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.scoreboard);
            this.Controls.Add(this.playerScoreLabel);
            this.Controls.Add(this.cpuScoreLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Pong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong";
            this.Load += new System.EventHandler(this.Pong_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pong_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Pong_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pongball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreboard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.PictureBox cpuPlayer;
        private System.Windows.Forms.PictureBox scoreboard;
        private System.Windows.Forms.Label playerScoreLabel;
        private System.Windows.Forms.Label cpuScoreLabel;
        public System.Windows.Forms.PictureBox pongball;
        public System.Windows.Forms.Timer timer1;
    }
}

