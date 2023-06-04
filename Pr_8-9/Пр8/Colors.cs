using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Пр8
{
    public partial class Colors : Form
    {
        Color ColorResult;
        public Colors(Color color)
        {
            InitializeComponent();

            RedBar.Tag = numericUpDown_red;
            RedBar.SmallChange = (int)numericUpDown_red.Increment;
            GreenBar.Tag = numericUpDown_green;
            GreenBar.SmallChange = (int)numericUpDown_green.Increment;
            BlueBar.Tag = numericUpDown_blue;
            BlueBar.SmallChange = (int)numericUpDown_blue.Increment;

            numericUpDown_red.Tag = RedBar;
            numericUpDown_green.Tag = GreenBar;
            numericUpDown_blue.Tag = BlueBar;

            numericUpDown_red.Value = color.R;
            numericUpDown_green.Value = color.G;
            numericUpDown_blue.Value = color.B;
        }

        private void UpdateColor()
        {
            ColorResult = Color.FromArgb(RedBar.Value, GreenBar.Value, BlueBar.Value);
            pictureBox1.BackColor = ColorResult;
        }

        private void RedBar_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateColor();
            ScrollBar scrollBar = (ScrollBar)sender;
            NumericUpDown numericUpDown = (NumericUpDown)scrollBar.Tag;
            numericUpDown.Value = scrollBar.Value;
        }

        private void numericUpDown_red_ValueChanged(object sender, EventArgs e)
        {
            UpdateColor();
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            ScrollBar scrollBar = (ScrollBar)numericUpDown.Tag;
            scrollBar.Value = (int)numericUpDown.Value;
        }

        private void GreenBar_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateColor();
            ScrollBar scrollBar = (ScrollBar)sender;
            NumericUpDown numericUpDown = (NumericUpDown)scrollBar.Tag;
            numericUpDown.Value = scrollBar.Value;
        }

        private void numericUpDown_green_ValueChanged(object sender, EventArgs e)
        {
            UpdateColor();
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            ScrollBar scrollBar = (ScrollBar)numericUpDown.Tag;
            scrollBar.Value = (int)numericUpDown.Value;
        }

        private void BlueBar_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateColor();
            ScrollBar scrollBar = (ScrollBar)sender;
            NumericUpDown numericUpDown = (NumericUpDown)scrollBar.Tag;
            numericUpDown.Value = scrollBar.Value;
        }

        private void numericUpDown_blue_ValueChanged(object sender, EventArgs e)
        {
            UpdateColor();
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            ScrollBar scrollBar = (ScrollBar)numericUpDown.Tag;
            scrollBar.Value = (int)numericUpDown.Value;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                RedBar.Value = colorDialog.Color.R;
                GreenBar.Value = colorDialog.Color.G;
                BlueBar.Value = colorDialog.Color.B;

                ColorResult = colorDialog.Color;

                UpdateColor();
            }
        }

        private void Ok_button_Click(object sender, EventArgs e)
        {
            Form1 Main = this.Owner as Form1;

            Main.currentPen.Color = ColorResult;
            
            Close();
            
        }
    }
}
