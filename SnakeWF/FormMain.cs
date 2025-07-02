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
using System.Xml.Linq;

namespace SnakeWF
{
    public partial class FormMain : Form
    {
        //CONSTANTES
        private const int NumVidas = 2;
        private const int lowestSpeedInterval = 250;
        private const int fase2Interval = 210;
        private const int fase3Interval = 180;
        private const int fase4Interval = 150;
        private const int fase5Interval = 126;
        private const int fase6Interval = 100;
        private const int fase7Interval = 76;
        private const int fase8Interval = 50;
        private const int fase9Interval = 36;
        private const int fase10Interval = 26;
        private const int fase11Interval = 16;
        private const int fase12Interval = 10;
        private const int fase13Interval = 8;
        private const int fase14Interval = 6;
        private const int fase15Interval = 4;
        private const int fase16Interval = 2;


        public static readonly int turboSpeedInterval = 40;

        Game snakeGame;
        public static List<Puntuacion> records = new List<Puntuacion>();
        private Dictionary<int, int> puntuacionIntervaloMap = new Dictionary<int, int>
        {
            { 0, lowestSpeedInterval },
            { 5, fase2Interval },
            { 10, fase3Interval },
            { 15, fase4Interval },
            { 20, fase5Interval },
            { 25, fase6Interval },
            { 30, fase7Interval },
            { 35, fase8Interval },
            { 40, fase9Interval },
            { 45, fase10Interval },
            { 50, fase11Interval },
            { 60, fase12Interval },
            { 70, fase13Interval },
            { 80, fase14Interval },
            { 90, fase15Interval },
            { 100, fase16Interval }
        };

        public static int Vidas = NumVidas;
        public static int Puntuacion = 0;
        public static int ultimaVelocidad = 1;
        private bool keyIsPressed = false;

        public FormMain()
        {
            InitializeComponent();

            snakeGame = new Game(pictureBoxSnake, pictureBox2, labelPuntuacionNum);
            labelNumVidas.Text = NumVidas.ToString();
            this.KeyPreview = true;
        }

        #region eventos Click botones
        private void buttonStart_Click(object sender, EventArgs e)
        {
            snakeGame.Reset();  
            timer1.Enabled = true;
            if (Vidas <= 0)
            {
                Vidas = NumVidas;
                labelNumVidas.Text = Vidas.ToString();
                Puntuacion = 0;
                labelPuntuacionNum.Text = Puntuacion.ToString();
            }                      
        }

        private void buttonStart_KeyUp(object sender, KeyEventArgs e)
        {
            keyIsPressed = false;
        }

        private void buttonVerRecords_Click(object sender, EventArgs e)
        {
            try
            {
                FormRecords ventanaRecords = new FormRecords();
                ventanaRecords.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha sucedido un error: " + ex.Message);
            }
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Vidas > 0)
            {
                if (!snakeGame.Muerto)
                {
                    snakeGame.Next();
                    snakeGame.Show();
                    if (puntuacionIntervaloMap.ContainsKey(Puntuacion))
                    {
                        timer1.Interval = puntuacionIntervaloMap[Puntuacion];
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

        #region Movimiento serpiente
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!keyIsPressed)
            {
                keyIsPressed = true;

                if (e.KeyCode == Keys.NumPad8|| e.KeyCode == Keys.Up)
                {
                    MoveUp();
                    /*if (timer1.Interval >= 50 && timer1.Interval <= lowestSpeedInterval)
                        timer1.Interval = turboSpeedInterval;*/
                }
                if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.Right)
                {
                    MoveRight();
                }
                if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.Down)
                {
                    MoveDown();
                }
                if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.Left)
                {
                    MoveLeft();
                }
            }
        }

        private void MoveUp()
        {
            if (snakeGame.ActualDirection != Game.Direction.Down)
            {
                snakeGame.ActualDirection = Game.Direction.Up;
            }
        }

        private void MoveRight()
        {
            if (snakeGame.ActualDirection != Game.Direction.Left)
            {
                snakeGame.ActualDirection = Game.Direction.Right;

            }
        }

        private void MoveDown()
        {
            if (snakeGame.ActualDirection != Game.Direction.Up)
            {
                snakeGame.ActualDirection = Game.Direction.Down;

            }
        }

        private void MoveLeft()
        {
            if (snakeGame.ActualDirection != Game.Direction.Right)
            {
                snakeGame.ActualDirection = Game.Direction.Left;

            }
        }
        #endregion
    
    }
}
