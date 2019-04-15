using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace PingPong
{
    public class Player
    {
        const int movementSpeed = 1;   //viteza de miscare

        public bool isUpPressed, isDownPressed;
        
        public PictureBox paddle;
        Label score;
        bool? wasGoingUpLastTick;
        int numberOfTicksGoingInTheSameDirection;
        int _scoreNumber;
        public int scoreNumber  
        {   
            get
            {
                return _scoreNumber;
            }
            set
            {
                _scoreNumber = value;
                score.Text = scoreNumber.ToString();
            }


        }



        public Player(PictureBox aPaddle1, Label aScoreForPlayer1)
        {
            this.paddle = aPaddle1;
            this.score = aScoreForPlayer1;
        }

        




        internal void processMove()  //miscare si accelerare a paletelor
        {
            bool? goingUp = null;

            if (isUpPressed)
            {
                goingUp = true;
            }

            if (isDownPressed)
            {
                if (goingUp.HasValue)
                {
                    goingUp = null;
                }
                else
                {
                    goingUp = false;
                }
            }
            if (wasGoingUpLastTick.HasValue)
            {
                if (!goingUp.HasValue)
                {
                    wasGoingUpLastTick = null;
                    numberOfTicksGoingInTheSameDirection = 0;
                }
                else if (wasGoingUpLastTick.Value == goingUp.Value)
                {
                    numberOfTicksGoingInTheSameDirection++;
                }
                else
                {
                    wasGoingUpLastTick = goingUp;
                    numberOfTicksGoingInTheSameDirection = 1;
                }
            }
            else if (goingUp.HasValue)
            {
                wasGoingUpLastTick = goingUp;
                numberOfTicksGoingInTheSameDirection = 1;
            }
            DoMove(goingUp);
        }

        private void DoMove(bool? goingUp) //verificare daca se misca
        {
            if (goingUp.HasValue)
            {
                var speed = (int)Math.Round(movementSpeed * ((float)numberOfTicksGoingInTheSameDirection / 20));
                if (goingUp.Value)
                {
                    speed *= -1;
                }
                paddle.Location = new Point(paddle.Location.X, Math.Max(Margins.topOfWorld, Math.Min(Margins.bottomOfWorld-paddle.Height, paddle.Location.Y + speed)));
            }

        }

    }
}
