using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnhancedPainter
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        bool cursorMoving = false;
        Pen cursorPen;
        int cursorX = -1;
        int cursorY = -1;

        public Form1()
        {
            InitializeComponent();
            graphics = canvasPanel.CreateGraphics();
            cursorPen = new Pen(Color.Black, 7);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            cursorPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            cursorPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void blackRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton color = (RadioButton)sender;
            cursorPen.Color = color.ForeColor;
        }

        private void canvasPanel_MouseDown(object sender, MouseEventArgs e)
        {
            cursorMoving = true;
            cursorX = e.X;
            cursorY = e.Y;
        }

        private void canvasPanel_MouseUp(object sender, MouseEventArgs e)
        {
            cursorMoving = false;
            cursorX = -1;
            cursorY = -1;
        }

        private void canvasPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (cursorX != -1 && cursorY != -1 && cursorMoving == true)
            {
                graphics.DrawLine(cursorPen, new Point(cursorX, cursorY), e.Location);
                cursorX = e.X;
                cursorY = e.Y;
            }
        }

        private void smallRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton size = (RadioButton)sender;
            cursorPen.Width = size.Font.Size;
        }
    }
}
