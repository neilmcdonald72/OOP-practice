using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//   Welcome
//   This is BREAK BREAKER V1 BY Neil McDonald
//   HOW TO PLAY
//   1. USE LEFT AND RIGHT KEYS TO CONTROL PADDLE
//   2. DEFLECT THE YELLOW BALL TO DESTROY ALL THE COLORFUL BRICKS
//   3. DO NOT LET THE BALL REACH THE BOTTOM OF THE FORM OR YOU LOSE!

//      Q1: What is GDI+?
//      Graphics Device Interface + (GDI+) is a graphical subsystem of Windows
//      that consists of an application programming interface (API) to display graphics and
//      formatted text on both video display and printer

//      Q2: What is double buffering?
//      Double buffering is a term used to describe a device with two buffers.
//      The usage of multiple buffers increases the overall throughput of a device and helps prevents bottlenecks.
//      For example, with graphics, double buffering can show one image or frame while a separate frame is being buffered to be shown next.
//      This method makes animations and games look more realistic than the same done in a single buffer mode.

namespace Assignment4
{

    public partial class Form1 : Form
    {
        bool goRight;
        bool goLeft;
        int speed = 10;

        int ballx = 5;
        int bally = 5;

        int score = 0;

        private Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();


            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "block")
                {
                    Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                    x.BackColor = randomColor;
                }
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            //if the player pressed the left key AND the player is inside the panel
            // then we set the car left boolean to true
            if (e.KeyCode == Keys.Left && player.Left > 0)
            {
                goLeft = true;
            }
            // if player pressed the right key and the player left plus player width is less then the panel1 width
            // then we set the player right to true
            if (e.KeyCode == Keys.Right && player.Left + player.Width < 920)
            {
                goRight = true;
            }


        }

        private void keyisup(object sender, KeyEventArgs e)
        {

            // if the LEFT key is up we set the car left to false
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            // if the RIGHT key is up we set the car right to false
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ball.Left += ballx;
            ball.Top += bally;


            label1.Text = "Score: " + score;

            if (goLeft) { player.Left -= speed; } // move left
            if (goRight) { player.Left += speed; } // move right

            if (player.Left < 1)
            {
                goLeft = false; // stop the paddle from going off screen
            }
            else if (player.Left + player.Width > 920)
            {
                goRight = false;
            }
            if (ball.Left + ball.Width > ClientSize.Width || ball.Left < 0)
            {
                ballx = -ballx; // this will bounce the object from the left or right border
            }

            if (ball.Top < 0 || ball.Bounds.IntersectsWith(player.Bounds))
            {
                bally = -bally; // this will bounce the object from top and bottom border
            }

            if (ball.Top + ball.Height > ClientSize.Height)
            {
                gameOver();
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "block")
                {
                    if (ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        bally = -bally;
                        score++;
                    }
                }
            }

            if (score > 34)
            {
                gameOver();
                MessageBox.Show("You Win");
            }

        }

        private void gameOver()
        {
            timer1.Stop();

            

            string message = "Do you want to play again?";
            string title = "Game over";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                ball.Location = new Point(399, 480);
                score = 0;


                while (Controls.Count > 0)
                {
                    Controls[0].Dispose();
                }

                InitializeComponent();

                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && x.Tag == "block")
                    {
                        Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                        x.BackColor = randomColor;
                    }
                }

                timer1.Start();
                
            }
            else
            {
                this.Close();
            }

            
        }
    }


}
