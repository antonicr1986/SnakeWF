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
        public int Points = 0;

        PictureBox oPictureBox;
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

        public bool GameOver
        {
            get 
            {
                foreach (var Square in Snake)
                {
                    if (Snake.Where(d => d.Y== Square.Y  &&  d.X==Square.X  &&  Square != d ).Count()>0)
                        return true;
                }
                return false;
            }
        }

        public Game(PictureBox oPictureBox, Label labelPuntuacionNum)
        {
            this.oPictureBox = oPictureBox;
            this.labelPuntuacionNum = labelPuntuacionNum; 
            Reset();
        }

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

            Points = 0;
        }

        public void Show()
        {
            Bitmap bmp = new Bitmap(oPictureBox.Width, oPictureBox.Height);
            for(int j = 0;j < longitudMapa; j++)
            {
                for (int i = 0; i < longitudMapa; i++)
                {
                    if (Snake.Where(d => d.X == i && d.Y == j).Count() > 0)
                        PaintPixel(bmp, i, j, Color.Black);
                    else
                        PaintPixel(bmp, i, j, Color.White);
                }
            }
            //mostrar comestibles
            if (Food!=null)
                PaintPixel(bmp,Food.X,Food.Y, Color.Red);


            oPictureBox.Image = bmp;

            labelPuntuacionNum.Text = Points.ToString();
        }

        public void Next()
        {
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
                Points++;
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
