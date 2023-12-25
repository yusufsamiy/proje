using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int pipespeed = 8;
        int gravity = 15;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GameTimer(object sender, EventArgs e)
        {
            pictureBox_bird.Top += gravity;
            pictureBox_bottom.Left -= pipespeed;
            pictureBox_top.Left -= pipespeed;
            label1.Text = "SCORE:" + score;

            if (pictureBox_bottom.Left < -150)
            {
                pictureBox_bottom.Left = 800;
                score++;
            }
            if (pictureBox_top.Left < -180)
            {
                pictureBox_top.Left = 950;
                score++;
            }
            if(pictureBox_bird.Bounds.IntersectsWith(pictureBox_bottom.Bounds)||
               pictureBox_bird.Bounds.IntersectsWith(pictureBox_top.Bounds)||
               pictureBox_bird.Bounds.IntersectsWith(pictureBox_ground.Bounds)|| pictureBox_bird.Top < -25)
            {
                EndGame();
            }
        }
        public void EndGame()
        {
            timer_gAMEcONTROL.Stop();
            label1.Text = "GAME OVER!";
        }

        private void game_down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }

        }

        private void game_Up(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }
    }
}
