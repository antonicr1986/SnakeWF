using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeWF
{
    public partial class Form1 : Form
    {
        public static readonly int numVidas = 1;

        Game oGame;
        public static List<Puntuacion> records = new List<Puntuacion>();


        public  static int Vidas = numVidas;
        public static int Puntuacion = 0;
        public static int ultimaVelocidad = 1;
        private bool keyIsPressed = false;

        public Form1()
        {
            InitializeComponent();

            oGame = new Game(pictureBox1,labelPuntuacionNum);
            labelNumVidas.Text = numVidas.ToString();
            this.KeyPreview = true;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            oGame = new Game(pictureBox1, labelPuntuacionNum);
            timer1.Enabled = true;
            if (Vidas <= 0)
            {
                Vidas = numVidas;
                labelNumVidas.Text = Vidas.ToString();
                Puntuacion = 0;
                labelPuntuacionNum.Text = Puntuacion.ToString();
            }                      
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Vidas > 0)
            {
                if (!oGame.Muerto)
                {
                    oGame.Next();
                    oGame.Show();
                    switch (Puntuacion)
                    {
                        case 0:
                            timer1.Interval = 270;
                            break;
                        case 2:
                            timer1.Interval = 220;
                            break;
                        case 4:
                            timer1.Interval = 180;
                            break;
                        case 6:
                            timer1.Interval = 150;
                            break;
                        case 8:
                            timer1.Interval = 126;
                            break;
                        case 10:
                            timer1.Interval = 100;
                            break;
                        case 12:
                            timer1.Interval = 76;
                            break;
                        case 14:
                            timer1.Interval = 50;
                            break;
                        case 16:
                            timer1.Interval = 26;
                            break;
                        case 18:
                            timer1.Interval = 16;
                            break;
                        case 20:
                            timer1.Interval = 10;
                            break;
                        case 22:
                            timer1.Interval = 8;
                            break;
                        case 24:
                            timer1.Interval = 6;
                            break;
                        case 26:
                            timer1.Interval = 4;
                            break;
                        case 28:
                            timer1.Interval = 2;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    timer1.Enabled = false;                 
                    Vidas--;
                    labelNumVidas.Text = Vidas.ToString();
                    if (Vidas <= 0)
                    {
                        MessageBox.Show("GAME OVER TE HAS QUEDADO SIN VIDAS!!!!\n\n\tPUNTUACION FINAL: "+Puntuacion);
                        FormPuntuacionAGuardar formPuntuacionAGuardar = new FormPuntuacionAGuardar(Puntuacion);
                        formPuntuacionAGuardar.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Muerto, has perdido una vida!!!!");
                    }
                }
            }    
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!keyIsPressed)
            {
                keyIsPressed = true;

                if (e.KeyCode == Keys.NumPad8)
                {
                    oGame.ActualDirection = Game.Direction.Up;
                    /*if (timer1.Interval >= 4)
                        timer1.Interval = timer1.Interval / 2;*/
                }

                if (e.KeyCode == Keys.NumPad6)
                {
                    oGame.ActualDirection = Game.Direction.Right;
                    /*if (timer1.Interval >= 4)
                        timer1.Interval = timer1.Interval / 2;*/
                }

                if (e.KeyCode == Keys.NumPad2)
                {
                    oGame.ActualDirection = Game.Direction.Down;
                    /*if (timer1.Interval >= 4)
                        timer1.Interval = timer1.Interval / 2;*/
                }

                if (e.KeyCode == Keys.NumPad4)
                {
                    oGame.ActualDirection = Game.Direction.Left;
                    /*if (timer1.Interval >= 4)
                        timer1.Interval = timer1.Interval / 2;*/
                }
            }
        }

        private void buttonStart_KeyUp(object sender, KeyEventArgs e)
        {
            keyIsPressed = false;
        }

        private void buttonVerRecords_Click(object sender, EventArgs e)
        {
            string message = "";
            for (int i = 0; i < records.Count; i++)
            {
                message += $"Nombre:  {records[i].Nombre} Puntuacion: {records[i].Puntos}\n";
            }
            MessageBox.Show(message);
        }
    }
}
