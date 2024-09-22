using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SnakeWF
{
    public class Game
    {
        public int scale = 10;
        public int longitudMapa = 30;
        private int[,] cuadros;
        private List<Square> Snake;

        public enum Direction { Right,Down,Left,Up }
        public Direction ActualDirection = Direction.Right;
        private Square Food = null;
        private Random oRandom = new Random();

        PictureBox oPictureBox;
        PictureBox pictureBoxNokia;
        Label labelPuntuacionNum;

        private int InitialPositionX
        {
            get 
            {
                return longitudMapa / 2;
            }
        }
        private int InitialPositionY
        {
            get
            {
                return longitudMapa / 2;
            }
        }

        public bool Muerto
        {
            get 
            {
                foreach (var Square in Snake)
                {
                    if (Snake.Where(d => d.Y== Square.Y  &&  d.X==Square.X  &&  Square != d).Count() > 0)
                    {
                        return true;
                    }                   
                }
                return false;
            }
        }
        public bool GameOver()
        {
            if (FormMain.Vidas == 0 )
            return true;

            else
            return false;
        }

        public Game(PictureBox oPictureBox,PictureBox oPictureBox2, Label labelPuntuacionNum)
        {
            this.oPictureBox = oPictureBox;
            this.pictureBoxNokia = oPictureBox2;
            this.labelPuntuacionNum = labelPuntuacionNum; 
            Reset();
        }

        //Método que resetea la partida 
        public void Reset()
        {
            Snake = new List<Square>();
            Square oSquareInitial = new Square(InitialPositionX, InitialPositionY);
            Snake.Add(oSquareInitial);

            cuadros = new int[longitudMapa,longitudMapa];
            for (int i = 0; i < longitudMapa; i++)
            {
                for (int j = 0; j < longitudMapa; j++)
                {
                    cuadros[i, j] = 0;
                }
            }

            if (FormMain.Vidas <=0) 
            {
               FormMain. Puntuacion = 0;
            }
            
        }

        #region Metodos principales que se accionan con el timer
        public void Show()
        {
            //Bitmap bmp = new Bitmap(oPictureBox.Width -(2*margenIzquierdo), oPictureBox.Height - (2 * margenSuperior));
            Bitmap bmp = new Bitmap(oPictureBox.Width, oPictureBox.Height);

            for (int j = 0;j < longitudMapa; j++)
            {
                for (int i = 0; i < longitudMapa; i++)
                {
                    if (Snake.Where(d => d.X == i && d.Y == j).Count() > 0)
                        PaintPixel(bmp, i, j, Color.Black);
                    else
                        PaintPixel(bmp, i, j, Color.GreenYellow);
                }
            }

            // Crear una copia del Bitmap original para no modificarlo directamente
            Bitmap bmpWithBorder = new Bitmap(bmp);
            int borderWidth = 1;
            Color borderColor = Color.Black;
            int width = bmpWithBorder.Width;
            int height = bmpWithBorder.Height;

            // Borde superior e inferior
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < borderWidth; y++)
                {
                    bmpWithBorder.SetPixel(x, y, borderColor); // Borde superior
                    bmpWithBorder.SetPixel(x, height - 1 - y, borderColor); // Borde inferior
                }
            }

            // Borde izquierdo y derecho
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < borderWidth; x++)
                {
                    bmpWithBorder.SetPixel(x, y, borderColor); // Borde izquierdo
                    bmpWithBorder.SetPixel(width - 1 - x, y, borderColor); // Borde derecho
                }
            }

            //mostrar comestibles
            if (Food!=null)
                PaintPixel(bmpWithBorder,Food.X,Food.Y, Color.Red);

            oPictureBox.Image = bmpWithBorder;

            //oPictureBox.Padding = new Padding(margenIzquierdo, margenSuperior, margenIzquierdo, margenSuperior);

            labelPuntuacionNum.Text = FormMain.Puntuacion.ToString();
        }

        public void Next()
        {
            if (FormMain.Vidas == 0)
            {
                Reset();
            }
            if (Food == null) 
                GetFood();

            GetHistorySnake();
            switch (ActualDirection)
            {
                case Direction.Right:
                    {
                        if (Snake[0].X == (longitudMapa - 1))
                            Snake[0].X = 0;
                        else
                            Snake[0].X++;
                        break;
                    }
                case Direction.Left: 
                    {
                        if (Snake[0].X == (0))
                            Snake[0].X = longitudMapa-1;
                        else
                            Snake[0].X--;
                        break;
                    }
                case Direction.Down:
                    {
                        if (Snake[0].Y == (longitudMapa - 1))
                            Snake[0].Y = 0;
                        else
                            Snake[0].Y++;
                        break;
                    }
                case Direction.Up:
                    {
                        if (Snake[0].Y == 0)
                            Snake[0].Y = (longitudMapa - 1);
                        else
                            Snake[0].Y--;
                        break;
                    }
            }
            GetNextMoveSnake();
            SnakeEating();
        }
        #endregion

        #region Métodos auxiliares
        private void GetNextMoveSnake()
        {
            if (Snake.Count > 1)
            {
                for (int i = 1; i < Snake.Count; i++) 
                {
                    Snake[i].X = Snake[i - 1].XOld;
                    Snake[i].Y = Snake[i - 1].YOld;
                }
            }
        }

        private void GetHistorySnake()
        {
            foreach (var snake in Snake) 
            {
                snake.XOld = snake.X;
                snake.YOld = snake.Y;
            }
        }

        private void SnakeEating()
        {
            if (Snake[0].X==Food.X && Snake[0].Y == Food.Y)
            {
                Food = null;
                FormMain.Puntuacion++;
                //alargamos el snake
                Square LastSquare = Snake[Snake.Count - 1];
                Square oSquare = new Square(LastSquare.XOld, LastSquare.YOld);
                Snake.Add(oSquare);
            }          
        }

        private void GetFood()
        {
            int X = oRandom.Next(0, longitudMapa - 1);
            int Y = oRandom.Next(0, longitudMapa - 1);

            Food = new Square(X, Y);
        }
        
        private void PaintPixel (Bitmap bmp, int x, int y, Color color)
        {
            for(int j = 0;j < scale; j++)
            {
                for (int i = 0; i < scale; i++)
                {
                    bmp.SetPixel(i + (x * scale),j + (y * scale), color);
                }
            }
        }
        #endregion
    }

    public class Square
    {
        public int X, Y, XOld, YOld;
        public Square(int X, int Y)
        {
            this.X = X; 
            this.Y = Y;
            this.XOld = X;
            this.YOld = Y;
        }
    }
}
