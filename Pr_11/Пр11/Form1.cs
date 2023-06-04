using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Пр11
{
    public partial class Form1 : Form
    {
        private Bitmap[] Frames;
        private int FrameNum;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Frames = new Bitmap[18];

            for (int i = 0; i < 18; i++)
            {
                Frames[i] = new Bitmap("Frame" + i + ".png");
            }

            pictureBox1.Image = Frames[FrameNum];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (trackBar1.Value == 0)
            {
                timer1.Interval = 500;
                FrameNum = ++FrameNum % Frames.Length;
                pictureBox1.Image = Frames[FrameNum];
            }
            else if (trackBar1.Value == 1)
            {
                timer1.Interval = 450;
                FrameNum = ++FrameNum % Frames.Length;
                pictureBox1.Image = Frames[FrameNum];
            }
            else if (trackBar1.Value == 2)
            {
                timer1.Interval = 400;
                FrameNum = ++FrameNum % Frames.Length;
                pictureBox1.Image = Frames[FrameNum];
            }
            else if (trackBar1.Value == 3)
            {
                timer1.Interval = 350;
                FrameNum = ++FrameNum % Frames.Length;
                pictureBox1.Image = Frames[FrameNum];
            }
            else if (trackBar1.Value == 4)
            {
                timer1.Interval = 300;
                FrameNum = ++FrameNum % Frames.Length;
                pictureBox1.Image = Frames[FrameNum];
            }
            else if (trackBar1.Value == 5)
            {
                timer1.Interval = 250;
                FrameNum = ++FrameNum % Frames.Length;
                pictureBox1.Image = Frames[FrameNum];
            }
            else if (trackBar1.Value == 6)
            {
                timer1.Interval = 200;
                FrameNum = ++FrameNum % Frames.Length;
                pictureBox1.Image = Frames[FrameNum];
            }
            else if (trackBar1.Value == 7)
            {
                timer1.Interval = 150;
                FrameNum = ++FrameNum % Frames.Length;
                pictureBox1.Image = Frames[FrameNum];
            }
            else if (trackBar1.Value == 8)
            {
                timer1.Interval = 100;
                FrameNum = ++FrameNum % Frames.Length;
                pictureBox1.Image = Frames[FrameNum];
            }
            else if (trackBar1.Value == 9)
            {
                timer1.Interval = 50;
                FrameNum = ++FrameNum % Frames.Length;
                pictureBox1.Image = Frames[FrameNum];
            }
            else if (trackBar1.Value == 10)
            {
                timer1.Interval = 5;
                FrameNum = ++FrameNum % Frames.Length;
                pictureBox1.Image = Frames[FrameNum];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            if (timer1.Enabled)
            {
                button1.Text = "Стоп";
            }
            else
            {
                button1.Text = "Старт";
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }
    }
}
