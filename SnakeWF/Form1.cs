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
        public static readonly int lowestSpeedInterval = 250;
        public static readonly int turboSpeedInterval = 40;

        Game oGame;
        public static List<Puntuacion> records = new List<Puntuacion>();


        public  static int Vidas = numVidas;
        public static int Puntuacion = 0;
        public static int ultimaVelocidad = 1;
        private bool keyIsPressed = false;

        public Form1()
        {
            InitializeComponent();

            oGame = new Game(pictureBoxSnake, pictureBox2, labelPuntuacionNum);
            labelNumVidas.Text = numVidas.ToString();
            this.KeyPreview = true;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            oGame = new Game(pictureBoxSnake, pictureBox2, labelPuntuacionNum);
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
                            timer1.Interval = lowestSpeedInterval;
                            break;
                        case 5:
                            timer1.Interval = 210;
                            break;
                        case 10:
                            timer1.Interval = 180;
                            break;
                        case 15:
                            timer1.Interval = 150;
                            break;
                        case 20:
                            timer1.Interval = 126;
                            break;
                        case 25:
                            timer1.Interval = 100;
                            break;
                        case 30:
                            timer1.Interval = 76;
                            break;
                        case 35:
                            timer1.Interval = 50;
                            break;
                        case 40:
                            timer1.Interval = 26;
                            break;
                        case 45:
                            timer1.Interval = 16;
                            break;
                        case 50:
                            timer1.Interval = 10;
                            break;
                        case 55:
                            timer1.Interval = 8;
                            break;
                        case 60:
                            timer1.Interval = 6;
                            break;
                        case 65:
                            timer1.Interval = 4;
                            break;
                        case 70:
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

                if (e.KeyCode == Keys.NumPad8 && oGame.ActualDirection != Game.Direction.Down)
                {
                    oGame.ActualDirection = Game.Direction.Up;
                    if (timer1.Interval >= 50 && timer1.Interval <= lowestSpeedInterval)
                        timer1.Interval = turboSpeedInterval;
                }

                if (e.KeyCode == Keys.NumPad6 && oGame.ActualDirection != Game.Direction.Left)
                {
                    oGame.ActualDirection = Game.Direction.Right;
                    if (timer1.Interval >= 50 && timer1.Interval <= lowestSpeedInterval)
                        timer1.Interval = turboSpeedInterval;
                }

                if (e.KeyCode == Keys.NumPad2 && oGame.ActualDirection != Game.Direction.Up)
                {
                    oGame.ActualDirection = Game.Direction.Down;
                    if (timer1.Interval >= 50 && timer1.Interval <= lowestSpeedInterval)
                        timer1.Interval = turboSpeedInterval;
                }

                if (e.KeyCode == Keys.NumPad4 && oGame.ActualDirection != Game.Direction.Right)
                {
                    oGame.ActualDirection = Game.Direction.Left;
                    if (timer1.Interval >= 50 && timer1.Interval <= lowestSpeedInterval)
                        timer1.Interval = turboSpeedInterval;
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

            using (WF_SnakeEntities contexto = new WF_SnakeEntities())
            {
                var records = contexto.Records
                    .OrderByDescending(record => record.Puntuacion)
                    .ToList();

                foreach (var record in records)
                {
                    string mensajeTabulado = $"Nombre: {record.Nombre}\t\tPuntuación: {record.Puntuacion.ToString().PadRight(50)}\n";
                    message += mensajeTabulado;
                }
                MessageBox.Show(message, "PUNTUACION GENERAL");
            }

        }
    }
}
