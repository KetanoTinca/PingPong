namespace PingPong
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.atimer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.aPlayer2Score = new System.Windows.Forms.Label();
            this.aPlayer1Score = new System.Windows.Forms.Label();
            this.gameOver = new System.Windows.Forms.Label();
            this.player1label = new System.Windows.Forms.Label();
            this.aBall = new System.Windows.Forms.PictureBox();
            this.aPaddle2 = new System.Windows.Forms.PictureBox();
            this.aPaddle1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.player2label = new System.Windows.Forms.Label();
            this.Name1 = new System.Windows.Forms.Label();
            this.Name2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.aPauseText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPaddle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPaddle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // atimer1
            // 
            this.atimer1.Enabled = true;
            this.atimer1.Interval = 1;
            this.atimer1.Tick += new System.EventHandler(this.atimer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(451, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Score";
            // 
            // aPlayer2Score
            // 
            this.aPlayer2Score.AutoSize = true;
            this.aPlayer2Score.BackColor = System.Drawing.Color.Transparent;
            this.aPlayer2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aPlayer2Score.ForeColor = System.Drawing.Color.Black;
            this.aPlayer2Score.Location = new System.Drawing.Point(416, 0);
            this.aPlayer2Score.Name = "aPlayer2Score";
            this.aPlayer2Score.Size = new System.Drawing.Size(31, 33);
            this.aPlayer2Score.TabIndex = 4;
            this.aPlayer2Score.Text = "0";
            // 
            // aPlayer1Score
            // 
            this.aPlayer1Score.AutoSize = true;
            this.aPlayer1Score.BackColor = System.Drawing.Color.Transparent;
            this.aPlayer1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aPlayer1Score.ForeColor = System.Drawing.Color.Black;
            this.aPlayer1Score.Location = new System.Drawing.Point(538, 0);
            this.aPlayer1Score.Name = "aPlayer1Score";
            this.aPlayer1Score.Size = new System.Drawing.Size(31, 33);
            this.aPlayer1Score.TabIndex = 6;
            this.aPlayer1Score.Text = "0";
            // 
            // gameOver
            // 
            this.gameOver.AutoSize = true;
            this.gameOver.BackColor = System.Drawing.Color.Transparent;
            this.gameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOver.ForeColor = System.Drawing.Color.Red;
            this.gameOver.Location = new System.Drawing.Point(299, 218);
            this.gameOver.Name = "gameOver";
            this.gameOver.Size = new System.Drawing.Size(420, 73);
            this.gameOver.TabIndex = 7;
            this.gameOver.Text = "GAME OVER";
            this.gameOver.Visible = false;
            // 
            // player1label
            // 
            this.player1label.AutoSize = true;
            this.player1label.BackColor = System.Drawing.Color.Transparent;
            this.player1label.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1label.ForeColor = System.Drawing.Color.Red;
            this.player1label.Location = new System.Drawing.Point(280, 295);
            this.player1label.Name = "player1label";
            this.player1label.Size = new System.Drawing.Size(462, 73);
            this.player1label.TabIndex = 8;
            this.player1label.Text = "Player 1 Wins!!";
            this.player1label.Visible = false;
            // 
            // aBall
            // 
            this.aBall.BackColor = System.Drawing.Color.Transparent;
            this.aBall.Image = global::PingPong.Properties.Resources.Ball2;
            this.aBall.Location = new System.Drawing.Point(495, 462);
            this.aBall.Name = "aBall";
            this.aBall.Size = new System.Drawing.Size(22, 22);
            this.aBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.aBall.TabIndex = 2;
            this.aBall.TabStop = false;
            // 
            // aPaddle2
            // 
            this.aPaddle2.BackColor = System.Drawing.Color.Transparent;
            this.aPaddle2.Image = global::PingPong.Properties.Resources.paddle1;
            this.aPaddle2.Location = new System.Drawing.Point(960, 68);
            this.aPaddle2.Name = "aPaddle2";
            this.aPaddle2.Size = new System.Drawing.Size(12, 150);
            this.aPaddle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.aPaddle2.TabIndex = 1;
            this.aPaddle2.TabStop = false;
            // 
            // aPaddle1
            // 
            this.aPaddle1.BackColor = System.Drawing.Color.Transparent;
            this.aPaddle1.Image = global::PingPong.Properties.Resources.paddle2;
            this.aPaddle1.Location = new System.Drawing.Point(12, 410);
            this.aPaddle1.Name = "aPaddle1";
            this.aPaddle1.Size = new System.Drawing.Size(12, 150);
            this.aPaddle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.aPaddle1.TabIndex = 0;
            this.aPaddle1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(988, 602);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // player2label
            // 
            this.player2label.AutoSize = true;
            this.player2label.BackColor = System.Drawing.Color.Transparent;
            this.player2label.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2label.ForeColor = System.Drawing.Color.Red;
            this.player2label.Location = new System.Drawing.Point(272, 295);
            this.player2label.Name = "player2label";
            this.player2label.Size = new System.Drawing.Size(462, 73);
            this.player2label.TabIndex = 10;
            this.player2label.Text = "Player 2 Wins!!";
            this.player2label.Visible = false;
            // 
            // Name1
            // 
            this.Name1.AutoSize = true;
            this.Name1.BackColor = System.Drawing.Color.Transparent;
            this.Name1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name1.ForeColor = System.Drawing.Color.Black;
            this.Name1.Location = new System.Drawing.Point(242, 0);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(114, 33);
            this.Name1.TabIndex = 11;
            this.Name1.Text = "Player1";
            // 
            // Name2
            // 
            this.Name2.AutoSize = true;
            this.Name2.BackColor = System.Drawing.Color.Transparent;
            this.Name2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name2.ForeColor = System.Drawing.Color.Black;
            this.Name2.Location = new System.Drawing.Point(637, 0);
            this.Name2.Name = "Name2";
            this.Name2.Size = new System.Drawing.Size(114, 33);
            this.Name2.TabIndex = 12;
            this.Name2.Text = "Player2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "F1- Pause";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Options:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "F2- Mute";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(758, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Options:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(845, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Num1- Pause";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(846, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Num2- Mute";
            // 
            // aPauseText
            // 
            this.aPauseText.AutoSize = true;
            this.aPauseText.BackColor = System.Drawing.Color.Transparent;
            this.aPauseText.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aPauseText.ForeColor = System.Drawing.Color.Red;
            this.aPauseText.Location = new System.Drawing.Point(299, 259);
            this.aPauseText.Name = "aPauseText";
            this.aPauseText.Size = new System.Drawing.Size(461, 73);
            this.aPauseText.TabIndex = 19;
            this.aPauseText.Text = "Game Paused.";
            this.aPauseText.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::PingPong.Properties.Resources.table1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 601);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.aPauseText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.player1label);
            this.Controls.Add(this.player2label);
            this.Controls.Add(this.aBall);
            this.Controls.Add(this.Name2);
            this.Controls.Add(this.Name1);
            this.Controls.Add(this.gameOver);
            this.Controls.Add(this.aPlayer1Score);
            this.Controls.Add(this.aPlayer2Score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aPaddle2);
            this.Controls.Add(this.aPaddle1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ping Pong";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.aBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPaddle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPaddle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox aPaddle1;
        private System.Windows.Forms.PictureBox aPaddle2;
        private System.Windows.Forms.PictureBox aBall;
        private System.Windows.Forms.Timer atimer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label aPlayer2Score;
        private System.Windows.Forms.Label aPlayer1Score;
        private System.Windows.Forms.Label gameOver;
        private System.Windows.Forms.Label player1label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label player2label;
        private System.Windows.Forms.Label Name1;
        private System.Windows.Forms.Label Name2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label aPauseText;
    }
}

