using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeWF
{
    public partial class Form1 : Form
    {
        Game oGame;

        public Form1()
        {
            InitializeComponent();

            oGame = new Game(pictureBox1,labelPuntuacionNum);
            this.KeyPreview = true;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            oGame = new Game (pictureBox1,labelPuntuacionNum);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!oGame.GameOver)
            {
                oGame.Next();
                oGame.Show();
                if (oGame.Points == 2)
                {
                    timer1.Interval = 400;
                }
                else if (oGame.Points == 4)
                {
                    timer1.Interval = 300;
                }
                else if (oGame.Points == 6)
                {
                    timer1.Interval = 200;
                }
                else if (oGame.Points == 8)
                {
                    timer1.Interval = 150;
                }
                else if (oGame.Points == 10)
                {
                    timer1.Interval = 100;
                }
                else if (oGame.Points == 12)
                {
                    timer1.Interval = 50;
                }
                else if (oGame.Points == 14)
                {
                    timer1.Interval = 25;
                }
                else if (oGame.Points == 16)
                {
                    timer1.Interval = 15;
                }
                else if (oGame.Points == 18)
                {
                    timer1.Interval = 10;
                }
                else if (oGame.Points == 20)
                {
                    timer1.Interval = 5;
                }
                else if (oGame.Points == 22)
                {
                    timer1.Interval = 3;
                }
                else if (oGame.Points == 24)
                {
                    timer1.Interval = 2;
                }
                else if (oGame.Points == 26)
                {
                    timer1.Interval = 1;
                }
            }
            else
            {
                timer1.Enabled = false;
                MessageBox.Show("Has perdido!!!!");
            }            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.NumPad8) 
                oGame.ActualDirection = Game.Direction.Up;
            if (e.KeyCode == Keys.NumPad6)
                oGame.ActualDirection = Game.Direction.Right;
            if (e.KeyCode == Keys.NumPad2)
                oGame.ActualDirection = Game.Direction.Down;
            if (e.KeyCode == Keys.NumPad4)
                oGame.ActualDirection = Game.Direction.Left;
        }
    }
}
