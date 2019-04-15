using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class Form1 : Form
    {
        bool playpause;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        Player player1, player2;
        Ball ball;
        
        

        public Form1()
        {
            InitializeComponent();
            player.SoundLocation = "musicmp3.wav";
            

           
            player1 = new Player(aPaddle1,aPlayer1Score);
            player2 = new Player(aPaddle2,aPlayer2Score);
            ball = new Ball(aBall,player1,player2);
            

        }

        private void atimer1_Tick(object sender, EventArgs e)
        {
            
            player1.processMove();
            player2.processMove();
            ball.processmove();
            if(Margins.win == true){        //verificare daca sa terminat jocul.
                atimer1.Enabled = false;
                gameOver.Visible = true;
                player2label.Visible = true;

            }
            if (Margins.win == false)
            {
                atimer1.Enabled = false;
                gameOver.Visible = true;
                player1label.Visible = true;
            }
            

        }

       

       private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           if(e.KeyCode == Keys.R)
           {
               Margins.win = null;
               atimer1.Enabled = true;
               gameOver.Visible = false;
               player2label.Visible = false;
               player1label.Visible = false;


           }
               CheckKeys(e, true); //se verifica daca a fost apasata vreo tasta pentur a putea misca paletele.
           if((e.KeyCode == Keys.F1)||(e.KeyCode == Keys.NumPad1)) //punere/scoatere pauza;
           {
               if(atimer1.Enabled == true)
               {
                   atimer1.Enabled = false;
                   aPauseText.Visible = true;
               }
               else
               {
                   atimer1.Enabled = true;
                   aPauseText.Visible = false;
               }
           }
           if ((e.KeyCode == Keys.F2) || (e.KeyCode == Keys.NumPad2)) //Mute/unmute
           {
               if(playpause == true)
               {player.Stop();
                playpause = false;               
               }else{
                   player.PlayLooping();
                   playpause = true;
               }    
           }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            CheckKeys(e, false);
        }

       private void CheckKeys(KeyEventArgs e, bool isDown)
       {
           switch (e.KeyCode)
           {
               case Keys.Up:
                   player2.isUpPressed = isDown;
                   break;
               case Keys.W:
                   player1.isUpPressed = isDown;
                   break;
               case Keys.Down:
                   player2.isDownPressed = isDown;
                   break;
               case Keys.S:
                   player1.isDownPressed = isDown;
                   break;

           }
       }

       private void Form1_Load(object sender, EventArgs e)
       {
           player.PlayLooping(); //porneste muzica cum se deschide programul;
           playpause = true;
       }

      
      
    }
}
