using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Numerics;
using System.Linq;

namespace JuliaSet
{
    public partial class MainForm : Form
    {
        struct ComplexNumber
        {
            public double Re;
            public double Im;
            public int i;
        }

        private const string ImageName = "JuliaSet.jpg";
        private string ImagePath;
        private ComplexNumber c, newCN, oldCN;
        private double zoom;
        private double moveX, moveY;
        private Color color;
        private int iterations;
        private int height, width;
        private Bitmap bmp;
        private int r, g, b;
        private double reFactor, imFactor;
        private Complex z, z2;

        public MainForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            zoom = 1;
            moveX = 0;
            moveY = 0;
            iterations = 300;
            height = pictureBoxMain.Height;
            width = pictureBoxMain.Width;
            c.Re = -0.7;
            c.Im = 0.25015;
            r = 1;
            g = 1;
            b = 1;
            reFactor = 1;
            imFactor = 2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxcRe.Text = c.Re.ToString();
            textBoxcIm.Text = c.Im.ToString();
            textBoxIterations.Text = iterations.ToString();
            textBoxWidth.Text = width.ToString();
            textBoxHeight.Text = height.ToString();
            textBoxr.Text = r.ToString();
            textBoxg.Text = g.ToString();
            textBoxb.Text = b.ToString();
            textBoxZoom.Text = zoom.ToString();
            textBoxMoveX.Text = moveX.ToString();
            textBoxMoveY.Text = moveY.ToString();
            textBoxreFactor.Text = reFactor.ToString();
            textBoximFactor.Text = imFactor.ToString();
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            moveX += 0.005;
            textBoxMoveX.Text = moveX.ToString();
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            moveY += 0.005;
            textBoxMoveY.Text = moveY.ToString();
        }

        private void buttonOpenImage_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ImagePath))
                Process.Start(ImagePath);
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            moveX += -0.005;
            textBoxMoveX.Text = moveX.ToString();
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            moveY += -0.005;
            textBoxMoveY.Text = moveY.ToString();
        }

        private void textBoxcRe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void buttonGetPBSize_Click(object sender, EventArgs e)
        {
            textBoxWidth.Text = pictureBoxMain.Width.ToString();
            textBoxHeight.Text = pictureBoxMain.Height.ToString();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            c.Re = double.Parse(textBoxcRe.Text);
            c.Im = double.Parse(textBoxcIm.Text);
            iterations = int.Parse(textBoxIterations.Text);
            width = int.Parse(textBoxWidth.Text);
            height = int.Parse(textBoxHeight.Text);
            r = int.Parse(textBoxr.Text);
            g = int.Parse(textBoxg.Text);
            b = int.Parse(textBoxb.Text);
            zoom = double.Parse(textBoxZoom.Text);
            moveX = double.Parse(textBoxMoveX.Text);
            moveY = double.Parse(textBoxMoveY.Text);
            reFactor = double.Parse(textBoxreFactor.Text);
            imFactor = double.Parse(textBoximFactor.Text);
            buttonDraw.Enabled = false;
            JuliaSetDraw();
            ImagePath = Path.Combine(Environment.CurrentDirectory, ImageName);
            //labelImagePath.Text = ImagePath;
            buttonDraw.Enabled = true;
        }

        private void JuliaSetDraw()
        {
            var colors = (from c in Enumerable.Range(0, 256)
                          select Color.FromArgb((c & 3) * 85, (c >> 5) * 36, (c >> 3 & 7) * 36)).ToArray();
            var sw = new Stopwatch();
            bmp = new Bitmap(width, height);
            sw.Start();
            #region old and slow method
            //for (int y = 0; y < height; y++)
            //{
            //    for (int x = 0; x < width; x++)
            //    {
            //        newCN.Re = 1.5 * (x - width / 2) / (0.5 * zoom * width) + moveX;
            //        newCN.Im = (y - height / 2) / (0.5 * zoom * height) + moveY;
            //        int i;
            //        for (i = 0; i < iterations; i++)
            //        {
            //            oldCN.Re = newCN.Re;
            //            oldCN.Im = newCN.Im;
            //            newCN.Re = reFactor * Math.Pow(oldCN.Re, 2) - (Math.Pow(oldCN.Im, 2)) + c.Re;
            //            newCN.Im = imFactor * oldCN.Re * oldCN.Im + c.Im;
            //            //if the point is outside the circle with radius 2: stop
            //            if ((newCN.Re * newCN.Re + newCN.Im * newCN.Im) > 4) break;
            //        }
            //        //color = Color.FromArgb(((r * i) % 256) * Convert.ToInt32((i < iterations)), (g * i % 256) * Convert.ToInt32((i < iterations)), (b * i % 256) * Convert.ToInt32((i < iterations)));
            //        //color = Color.FromArgb((r * i % 256), (g * i % 256), (b * i % 256));
            //        color = Color.FromArgb((r + i) % 256, (g + i) % 256, (b + i) % 256);
            //        bmp.SetPixel(x, y, color);
            //    }
            //}
            #endregion
            var calculatedPoints = Enumerable.Range(0, width * height).AsParallel().Select(xy =>
            {
            double zx, zy, tmp;
            int x, y;
            int i = 256;
            double p;
            y = xy / width;
            x = xy % width;
            zx = 1.5 * (x - width / 2) / (0.5 * zoom * width) + moveX;
            zy = 1.0 * (y - height / 2) / (0.5 * zoom * height) + moveY;
            while (zx * zx + zy * zy < 4 && i > 1)
            {
                    p = Math.Sqrt(Math.Sqrt(zx) + Math.Sqrt(zy));
                    //tmp = zx * zx - zy * zy + c.Re;
                    tmp = 2 / 3 * zx + (Math.Sqrt(zx) - Math.Sqrt(zy)) / 3 * p;
                    zy = 2 / 3 * zy * (1 - zx / p);
                    //zy = 2.0 * zx * zy + c.Im;
                    zx = tmp;
                    i -= 1;
                }
                return new ComplexNumber { Re = x, Im = y, i = i };
            });

            sw.Stop();
            labelImagePath.Text = sw.ElapsedMilliseconds.ToString();
            foreach (ComplexNumber cp in calculatedPoints)
                bmp.SetPixel((int)cp.Re, (int)cp.Im, colors[cp.i]);
            //sw.Stop();
            pictureBoxMain.Image = bmp;            
            bmp.Save(ImageName);
        }
    }
}