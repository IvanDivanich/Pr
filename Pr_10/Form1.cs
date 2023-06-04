using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrabGraphicObjects
{
    public partial class Form1 : Form
    {
        Rectangle Rectangle = new Rectangle(10, 10, 200, 100);
        Rectangle Circle = new Rectangle(220, 10, 150, 150);
        Rectangle Square = new Rectangle(380, 10, 150, 150);

        bool RectangleClicked = false;
        bool CircleClicked = false;
        bool SquareClicked = false;

        int X, Y, dX, dY;
        int LastClicked = 0;

        int RectangleX = 0;
        int RectangleY = 0;
        int CircleX = 0;
        int CircleY = 0;
        int SquareX = 0;
        int SquareY = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Red, Circle);
            e.Graphics.FillRectangle(Brushes.Blue, Square);
            e.Graphics.FillRectangle(Brushes.Yellow, Rectangle);
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.X < Square.X + Square.Width) && (e.X > Square.X))
            {
                if ((e.Y < Square.Y + Square.Height) && (e.Y > Square.Y))
                {
                    SquareClicked = true;
                    LastClicked = 1;
                    SquareX = e.X - Square.X;
                    SquareY = e.Y - Square.Y;
                }
            }
            if ((e.X < Rectangle.X + Rectangle.Width) && (e.X > Rectangle.X))
            {
                if ((e.Y < Rectangle.Y + Rectangle.Height) && (e.Y > Rectangle.Y))
                {
                    RectangleClicked = true;
                    LastClicked = 2;
                    RectangleX = e.X - Rectangle.X;
                    RectangleY = e.Y - Rectangle.Y;
                }
            }
            if ((e.X < Circle.X + Circle.Width) && (e.X > Circle.X))
            {
                if ((e.Y < Circle.Y + Circle.Height) && (e.Y > Circle.Y))
                {
                    CircleClicked = true;
                    LastClicked = 3;
                    CircleX = e.X - Circle.X;
                    CircleY = e.Y - Circle.Y;
                }
            }
            if ((label_Vid.Location.X < Square.X + Square.Width) && (label_Vid.Location.X > Square.X))
            {
                if ((label_Vid.Location.Y < Square.Y + Square.Height) && (label_Vid.Location.Y > Square.Y))
                {
                    label_Info.Text = "Синий квадрат";
                    label_Info.ForeColor = Color.Blue;
                }
            }
            if ((label_Vid.Location.X < Circle.X + Circle.Width) && (label_Vid.Location.X > Circle.X))
            {
                if ((label_Vid.Location.Y < Circle.Y + Circle.Height) && (label_Vid.Location.Y > Circle.Y))
                {
                    label_Info.Text = "Красный эллипс";
                    label_Info.ForeColor = Color.Red;
                }
            }
            if ((label_Vid.Location.X < Rectangle.X + Rectangle.Width) && (label_Vid.Location.X > Rectangle.X))
            {
                if ((label_Vid.Location.Y < Rectangle.Y + Rectangle.Height) && (label_Vid.Location.Y > Rectangle.Y))
                {
                    label_Info.Text = "Желтый прямоугольник";
                    label_Info.ForeColor = Color.Yellow;
                }
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            RectangleClicked = false;
            CircleClicked = false;
            SquareClicked = false;

            if (LastClicked == 1)
            {
                if ((label_Shape.Location.X < Square.X + Square.Width) && (label_Shape.Location.X > Square.X))
                {
                    if ((label_Shape.Location.Y < Square.Y + Square.Height) && label_Shape.Location.Y > Square.Y)
                    {
                        X = Square.X;
                        Y = Square.Y;
                        dX = Square.X;
                        dY = Square.Y;
                        Square.X = Circle.X;
                        Square.Y = Circle.Y;
                        SquareX = dX;
                        SquareY = dY;
                    }
                }
            }
            if (LastClicked == 2)
            {
                if ((label_Shape.Location.X < Rectangle.X + Rectangle.Width) && (label_Shape.Location.X > Rectangle.X))
                {
                    if ((label_Shape.Location.Y < Rectangle.Y + Rectangle.Height) && label_Shape.Location.Y > Rectangle.Y)
                    {
                        X = Rectangle.X;
                        Y = Rectangle.Y;
                        dX = Rectangle.X;
                        dY = Rectangle.Y;
                        Rectangle.X = Square.X;
                        Rectangle.Y = Square.Y;
                        RectangleX = dX;
                        RectangleY = dY;
                    }
                }
            }
            if (LastClicked == 3)
            {
                if ((label_Shape.Location.X < Circle.X + Circle.Width) && (label_Shape.Location.X > Circle.X))
                {
                    if ((label_Shape.Location.Y < Circle.Y + Circle.Height) && label_Shape.Location.Y > Circle.Y)
                    {
                        X = Circle.X;
                        Y = Circle.Y;
                        dX = Circle.X;
                        dY = Circle.Y;
                        Circle.X = Square.X;
                        Circle.Y = Square.Y;
                        CircleX = dX;
                        CircleY = dY;
                    }
                }
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (CircleClicked)
            {
                Circle.X = e.X - CircleX;
                Circle.Y = e.Y - CircleY;
            }
            if (RectangleClicked)
            {
                Rectangle.X = e.X - RectangleX;
                Rectangle.Y = e.Y - RectangleY;
            }
            if (SquareClicked)
            {
                Square.X = e.X - SquareX;
                Square.Y = e.Y - SquareY;
            }
            pictureBox.Invalidate();
        }
    }
}
