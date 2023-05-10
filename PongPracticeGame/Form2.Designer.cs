namespace PongPracticeGame
{
    partial class characterForm
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.charGreen = new System.Windows.Forms.PictureBox();
            this.charBlue = new System.Windows.Forms.PictureBox();
            this.charPink = new System.Windows.Forms.PictureBox();
            this.defaultColor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.charGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charPink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultColor)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(12, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(1220, 102);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Click a character";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // charGreen
            // 
            this.charGreen.BackColor = System.Drawing.Color.Green;
            this.charGreen.Location = new System.Drawing.Point(62, 281);
            this.charGreen.Name = "charGreen";
            this.charGreen.Size = new System.Drawing.Size(225, 225);
            this.charGreen.TabIndex = 1;
            this.charGreen.TabStop = false;
            this.charGreen.Click += new System.EventHandler(this.charGreen_Click);
            // 
            // charBlue
            // 
            this.charBlue.BackColor = System.Drawing.Color.Blue;
            this.charBlue.Location = new System.Drawing.Point(492, 281);
            this.charBlue.Name = "charBlue";
            this.charBlue.Size = new System.Drawing.Size(225, 225);
            this.charBlue.TabIndex = 2;
            this.charBlue.TabStop = false;
            this.charBlue.Click += new System.EventHandler(this.charBlue_Click);
            // 
            // charPink
            // 
            this.charPink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.charPink.Location = new System.Drawing.Point(935, 281);
            this.charPink.Name = "charPink";
            this.charPink.Size = new System.Drawing.Size(225, 225);
            this.charPink.TabIndex = 3;
            this.charPink.TabStop = false;
            this.charPink.Click += new System.EventHandler(this.charPink_Click);
            // 
            // defaultColor
            // 
            this.defaultColor.BackColor = System.Drawing.Color.DarkCyan;
            this.defaultColor.Location = new System.Drawing.Point(492, 577);
            this.defaultColor.Name = "defaultColor";
            this.defaultColor.Size = new System.Drawing.Size(225, 225);
            this.defaultColor.TabIndex = 4;
            this.defaultColor.TabStop = false;
            this.defaultColor.Click += new System.EventHandler(this.defaultColor_Click);
            // 
            // characterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1244, 861);
            this.Controls.Add(this.defaultColor);
            this.Controls.Add(this.charPink);
            this.Controls.Add(this.charBlue);
            this.Controls.Add(this.charGreen);
            this.Controls.Add(this.TitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "characterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose Character";
            ((System.ComponentModel.ISupportInitialize)(this.charGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charPink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultColor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox charGreen;
        private System.Windows.Forms.PictureBox charBlue;
        private System.Windows.Forms.PictureBox charPink;
        private System.Windows.Forms.PictureBox defaultColor;
    }
}