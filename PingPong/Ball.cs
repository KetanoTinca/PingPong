using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace PingPong
{
     public class Ball
    {
         
         private PictureBox ball;
         Random rand= new Random();
         Player leftSidePlayer, rightSidePlayer;

         int xSpeed, ySpeed;

         public Ball(PictureBox aBall, Player leftSidePlayer, Player rightSidePlayer)
         {   
             
             this.ball = aBall;
             this.leftSidePlayer = leftSidePlayer;
             this.rightSidePlayer = rightSidePlayer;
             xSpeed = 1;
             ySpeed = 2;
             resetBall();
         } 

         internal void processmove()
         {
             var bottom = Margins.bottomOfWorld - ball.Height;
             DoMove();
        
             if(ball.Location.Y >= bottom || ball.Location.Y <= Margins.topOfWorld)
             {
                 ySpeed *= -1;
             }

             if (ball.Location.X <= Margins.leftOfWorld)
             {
                Score(leftSidePlayer); //daca mingea a trecut de partea stanga creste scorul pentru jucatorul 2.
             }
             else if (ball.Location.X >= Margins.rightOfWorld - ball.Width) 
             {
                 Score(rightSidePlayer); //daca mingea a trecut de partea dreapta creste scorul pentru jucatorul 1.
             }

             if ((leftSidePlayer.paddle.Bounds.IntersectsWith(ball.Bounds)) || (rightSidePlayer.paddle.Bounds.IntersectsWith(ball.Bounds)))
             {
                 Random rand1 = new Random();
                 xSpeed *= -1; //daca mingea sa intersecteaza cu paleta se schimba directia de mers pe axa x si se creste viteza bilei.
                 if(xSpeed < 0)
                 { xSpeed = rand1.Next(-6, -1); }
                 else
                 { xSpeed = rand1.Next(1, 6); }
                 if (ySpeed < 0)
                     ySpeed = rand1.Next(-6, -1);
                 else
                     ySpeed = rand1.Next(1, 6);
                 if ((ySpeed <= 6 && ySpeed >= -6) && (xSpeed <= 5 && xSpeed >= -5))
                 {
                     if (ySpeed < 0)
                     {
                         ySpeed -= 1;
                     }
                     else
                     {
                         ySpeed += 1;
                     }

                     if (xSpeed < 0)
                     {
                         xSpeed -= 1;

                     }
                     else
                     {
                         xSpeed += 1;
                     }
                 }
             }

             while ((leftSidePlayer.paddle.Bounds.IntersectsWith(ball.Bounds)) || (rightSidePlayer.paddle.Bounds.IntersectsWith(ball.Bounds)))
             {
                 DoMove();
             }


           
         }

         private int DoMove()
         {
             var bottom = Margins.bottomOfWorld - ball.Height;
             ball.Location = new Point(ball.Location.X + xSpeed, Math.Max(Margins.topOfWorld, Math.Min(bottom, ball.Location.Y + ySpeed)));
             return bottom;
         }

         private void Score(Player winningPlayer)   //se verifica daca s-a ajus la scorul tinta, daca sa ajuns se va opri jocul iar un mesaj corespunzator va aparea.
         {
             winningPlayer.scoreNumber++;
             
             if(winningPlayer.scoreNumber == 7)
             {
                 if(winningPlayer == leftSidePlayer  )
                 {
                     Margins.win = true;
                 }else if(winningPlayer == rightSidePlayer)
                 {
                     Margins.win = false;
                 }
                 

             }
            

             resetBall();
         }

         private void resetBall() // se reseteaza mingea si porneste intr-o directie random;
         {
             ball.Location = new Point((Margins.leftOfWorld + Margins.rightOfWorld) / 2, (Margins.bottomOfWorld + Margins.topOfWorld) / 2);
             do
             {
                 xSpeed = rand.Next(-3, 3);
                 ySpeed = rand.Next(-3, 3);
             } while(Math.Abs(xSpeed) + Math.Abs(ySpeed) <= 3);
            
        }

    }
}
