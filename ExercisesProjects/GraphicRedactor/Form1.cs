using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// texta da se zadava ot Font i da moje da se iztriva

namespace GraphicRedactor
{
    public partial class formMain : Form
    {
        Pen blackPen = new Pen(Color.Black);
        SolidBrush brush = new SolidBrush(Color.White);
        SolidBrush drawBrush = new SolidBrush(Color.Black);
        private bool pressed = false;

        Graphics myGraph;
        private Point startPosition, endPosition;

        private String currentOperation = String.Empty;

        public int width;
        public int height;
        private Font textFont = new Font("Arial", 14);
        private string printText;

        public formMain()
        {
            InitializeComponent();
        }

        private void frmPanel_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel3.Text = e.X.ToString() + " x " + e.Y.ToString();

            if (currentOperation == "Freehand" && pressed == true)
            {
                endPosition = e.Location;
                myGraph = frmPanel.CreateGraphics();
                myGraph.DrawLine(blackPen, startPosition, endPosition);
                startPosition = endPosition;
            }
            if (currentOperation == "Erase" && pressed == true)
            {
                endPosition = e.Location;
                myGraph = frmPanel.CreateGraphics();
                Pen eraserPen = new Pen(Color.White, 5);
                myGraph.DrawLine(eraserPen, startPosition, endPosition);
                startPosition = endPosition;
            }


        }
        private void btnEllipse_Click(object sender, EventArgs e)
        {
            currentOperation = "Ellipse";
        }
        private void btnFreeHandTool_Click(object sender, EventArgs e)
        {
            currentOperation = "Freehand";
        }
        private void btnRectangle_Click(object sender, EventArgs e)
        {
            currentOperation = "Rectangle";
        }
        private void btnLine_Click(object sender, EventArgs e)
        {
            currentOperation = "Line";
        }
        private void btnStickman_Click(object sender, EventArgs e)
        {
            currentOperation = "Stickman";
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            frmPanel.Refresh();
        }
        private void frmPanel_MouseDown(object sender, MouseEventArgs e)
        {
            pressed = true;
            toolStripStatusLabel1.Text = e.X.ToString() + " x " + e.Y.ToString();

            startPosition.X = e.X;
            startPosition.Y = e.Y;
        }

        private void panelConturColor_DoubleClick(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                blackPen.Color = colorDialog1.Color;
                panelConturColor.BackColor = colorDialog1.Color;
            }
        }
        private void panelBackColor_DoubleClick(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                brush.Color = colorDialog1.Color;
                drawBrush.Color = colorDialog1.Color;
                panelBackColor.BackColor = colorDialog1.Color;
            }
        }

        private void tracker1_Scroll(object sender, EventArgs e)
        {
            blackPen.Width = tracker1.Value;
        }

        private void btnTextFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                textFont = fontDialog.Font;
                printText = " ";
            }
        }
        private void btnText_Click(object sender, EventArgs e)
        {
            printText = " ";
        }
        private void btnText_KeyPress(object sender, KeyPressEventArgs e)
        {
            Point startP = new Point(startPosition.X, startPosition.Y);
            printText += e.KeyChar;
            myGraph = frmPanel.CreateGraphics();
            myGraph.DrawString(printText, textFont, drawBrush, startP);
        }
        private void btnErase_Click(object sender, EventArgs e)
        {
            currentOperation = "Erase";
        }


        private void frmPanel_MouseUp(object sender, MouseEventArgs e)
        {
            pressed = false;
            toolStripStatusLabel2.Text = e.X.ToString() + " x " + e.Y.ToString();

            endPosition.X = e.X;
            endPosition.Y = e.Y;

            width = Math.Abs(endPosition.X - startPosition.X);
            height = Math.Abs(endPosition.Y - startPosition.Y);
            myGraph = frmPanel.CreateGraphics();

            //with switch case 

            if (currentOperation == "Ellipse")
            {
                myGraph.DrawEllipse(blackPen, startPosition.X, startPosition.Y, width, height);
                myGraph.FillEllipse(brush, startPosition.X, startPosition.Y, width, height);
            }
            else if (currentOperation == "Rectangle")
            {
                myGraph.FillRectangle(brush, startPosition.X, startPosition.Y, width, height);
                myGraph.DrawRectangle(blackPen, startPosition.X, startPosition.Y, width, height);
            }
            else if (currentOperation == "Line")
            {
                myGraph.DrawLine(blackPen, startPosition.X, startPosition.Y, endPosition.X, endPosition.Y);
            }
            else if (currentOperation == "Stickman")
            {
                // head
                int headHeight = (int)Math.Round(1.0 / 4.0 * height);
                int headWidth = (int)Math.Round(2.0 / 3.0 * width) - (int)Math.Round((1.0 / 3.0) * width);
                myGraph.DrawEllipse(blackPen, startPosition.X + (int)Math.Round((1.0 / 3.0) * width),
                      startPosition.Y, headWidth, headHeight);

                //body
                myGraph.DrawLine(blackPen, startPosition.X + width / 2, startPosition.Y + headHeight,
                      startPosition.X + width / 2, endPosition.Y - (int)Math.Round(3.0 / 8.0 * height));

                //arms
                myGraph.DrawLine(blackPen, startPosition.X, startPosition.Y + (int)Math.Round(3.0 / 8.0 * height),
                    endPosition.X - width / 2, endPosition.Y - (int)Math.Round(5.0 / 8.0 * height));
                myGraph.DrawLine(blackPen, startPosition.X + width / 2, startPosition.Y + (int)Math.Round(3.0 / 8.0 * height),
                    endPosition.X, endPosition.Y - (int)Math.Round(5.0 / 8.0 * height));

                //legs
                myGraph.DrawLine(blackPen, startPosition.X + width / 2, endPosition.Y - (int)Math.Round(3.0 / 8.0 * height),
                    startPosition.X + (int)Math.Round(1.0 / 5.0 * width), endPosition.Y);
                myGraph.DrawLine(blackPen, startPosition.X + width / 2, endPosition.Y - (int)Math.Round(3.0 / 8.0 * height),
                     startPosition.X + (int)Math.Round(4.0 / 5.0 * width), endPosition.Y);

            }
        }
    }
}
