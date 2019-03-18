using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkSequenceDiagram
{
    public partial class mainForm : Form
    {
        Pen blackPen = new Pen(Color.Black);
        SolidBrush brush = new SolidBrush(Color.Ivory);
        SolidBrush drawBrush = new SolidBrush(Color.Black);
        private bool pressed = false;

        Graphics myGraph;
        private Point startPosition, endPosition;

        private String currentOperation = String.Empty;

        public int width;
        public int height;
        private Bitmap bmp;
        private string printText;
        private string fName = "";
        private Point firstPoint = new Point();
        private Font textFont = new Font("Arial", 14);

        public mainForm()
        {
            InitializeComponent();

            //for save
            bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            myGraph = Graphics.FromImage(bmp);
            myGraph.FillRectangle(new SolidBrush(Color.White), 0, 0, bmp.Width, bmp.Height);
            pictureBox.Image = bmp;

            INIT();
        }
        private void btnText_Click(object sender, EventArgs e)
        {
            printText = "";
        }

        private void btnText_KeyPress(object sender, KeyPressEventArgs e)
        {
            Point startP = new Point(startPosition.X, startPosition.Y);
            printText += e.KeyChar;
            myGraph = pictureBox.CreateGraphics();
            myGraph.DrawString(printText, textFont, drawBrush, startP);
        }
        private void btnRectangle_Click(object sender, EventArgs e)
        {
            currentOperation = "Rectangle";
        }
        private void btnFreehand_Click(object sender, EventArgs e)
        {
            currentOperation = "Freehand";
        }
        private void btnActor_Click(object sender, EventArgs e)
        {
            currentOperation = "Actor";
        }
        private void tracker1_Scroll(object sender, EventArgs e)
        {
            blackPen.Width = tracker1.Value;
        }
        private void btnLine_Click(object sender, EventArgs e)
        {
            currentOperation = "Line";
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            //  toolStripStatusLabel3.Text = e.X.ToString() + " x " + e.Y.ToString();

            if (currentOperation == "Freehand" && pressed == true)
            {
                endPosition = e.Location;
                // myGraph = frmPictureBox.CreateGraphics();
                myGraph.DrawLine(blackPen, startPosition, endPosition);
                startPosition = endPosition;
                pictureBox.Invalidate();
            }
        }
        public void INIT()
        {
            objectMove.MouseDown += (ss, ee) =>
            {
                if (ee.Button == MouseButtons.Left) { firstPoint = Control.MousePosition; }
            };
            objectMove.MouseMove += (ss, ee) =>
            {
                if (ee.Button == MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point result = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    objectMove.Location = new Point(objectMove.Location.X - result.X, objectMove.Location.Y - result.Y);

                    firstPoint = temp;
                }
            };
        }
        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            pressed = false;

            endPosition.X = e.X;
            endPosition.Y = e.Y;

            width = Math.Abs(endPosition.X - startPosition.X);
            height = Math.Abs(endPosition.Y - startPosition.Y);

            if (currentOperation == "Actor")
            {
                //  myGraph = frmPictureBox.CreateGraphics();
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

                pictureBox.Invalidate();
            }
            else if (currentOperation == "Rectangle")
            {
                myGraph.FillRectangle(brush, startPosition.X, startPosition.Y, width, height);
                myGraph.DrawRectangle(blackPen, startPosition.X, startPosition.Y, width, height);
                pictureBox.Invalidate();
            }
            else if (currentOperation == "NewRectangle")
            {
                int newRect = (int)Math.Round(width / 2.5);
                myGraph.DrawRectangle(blackPen, startPosition.X, startPosition.Y, newRect, height);
                pictureBox.Invalidate();
            }
            else if (currentOperation == "Arc")
            {
                myGraph.DrawArc(blackPen, startPosition.X, startPosition.Y, width, height, 180, 180);
                pictureBox.Invalidate();
            }
            else if (currentOperation == "Line")
            {
                blackPen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                myGraph.DrawLine(blackPen, startPosition.X, startPosition.Y, endPosition.X, endPosition.Y);
                pictureBox.Invalidate();
                blackPen.EndCap = System.Drawing.Drawing2D.LineCap.Custom;
            }
            else if (currentOperation == "DashLine")
            {
                blackPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                //blackPen.EndCap = LineCap.ArrowAnchor;
                myGraph.DrawLine(blackPen, startPosition.X, startPosition.Y, endPosition.X, endPosition.Y);
                pictureBox.Invalidate();
                blackPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
        }
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            pressed = true;

            startPosition.X = e.X;
            startPosition.Y = e.Y;
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fName = "";
            bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            myGraph = Graphics.FromImage(bmp);
            myGraph.FillRectangle(new SolidBrush(Color.White), 0, 0, pictureBox.Width, pictureBox.Height);
            pictureBox.Image = bmp;
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPEG|*.jpg|Bitmap|*.bmp|PNG|*.png";
            ofd.ShowDialog();

            if (ofd.FileName != "")
            {
                System.IO.FileStream stream = (System.IO.FileStream)ofd.OpenFile();
                fName = ofd.FileName;
                bmp = (Bitmap)Bitmap.FromStream(stream);
                myGraph = Graphics.FromImage(bmp);
                pictureBox.Image = bmp;
                pictureBox.Invalidate();
                stream.Close();

            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is my course work! \n By: Stanislav Dimitrov");
        }

        private void btnArc_Click(object sender, EventArgs e)
        {
            currentOperation = "Arc";
        }

        private void btnNewRect_Click(object sender, EventArgs e)
        {
            currentOperation = "NewRectangle";
        }

        private void btnDashLine_Click(object sender, EventArgs e)
        {
            currentOperation = "DashLine";
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
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JPEG|*.jpg|Bitmap|*.bmp|PNG|*.png";
            sfd.ShowDialog();
            fName = sfd.FileName;
            if (sfd.FileName != "")
            {
                System.IO.FileStream stream = (System.IO.FileStream)sfd.OpenFile();

                var extension = Path.GetExtension(sfd.FileName);
                ImageFormat chosenFormat;
                switch (extension.ToLower())
                {
                    case ".jpg":
                        chosenFormat = ImageFormat.Jpeg;
                        break;
                    case ".png":
                        chosenFormat = ImageFormat.Png;
                        break;
                    case ".bmp":
                        chosenFormat = ImageFormat.Bmp;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(extension);
                }
                using (Bitmap bitmp = new Bitmap(pictureBox.Width, pictureBox.Height))
                {
                    pictureBox.DrawToBitmap(bitmp, new Rectangle(0, 0, pictureBox.Width, pictureBox.Height));
                    bitmp.Save(stream, chosenFormat);
                }
                stream.Close();
            }
        }
    }
}
