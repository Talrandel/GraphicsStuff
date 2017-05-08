using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Numerics;

namespace MandelbrotSet
{
    public partial class MainForm : Form
    {
        struct FastBitmap
        {
            public Bitmap Bitmap
            {
                get;
                set;
            }

            private BitmapData data;

            public unsafe void SetPixel(int x, int y, Color color)
            {
                data = this.Bitmap.LockBits(new Rectangle(0, 0, this.Bitmap.Width, this.Bitmap.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                IntPtr scan0 = data.Scan0;

                byte* imagePointer = (byte*)scan0.ToPointer(); // Pointer to first pixel of image
                int offset = (y * data.Stride) + (3 * x); // 3x because we have 24bits/px = 3bytes/px
                byte* px = (imagePointer + offset); // pointer to the pixel we want
                px[0] = color.B; // Red component
                px[1] = color.G; // Green component
                px[2] = color.R; // Blue component

                this.Bitmap.UnlockBits(data); // Set the data again
            }

            public FastBitmap(int width, int height)
            {
                this.Bitmap = new Bitmap(width, height, PixelFormat.Format24bppRgb);
                this.data = null;
            }
        }

        private int iterations;
        private int height, width;
        private FastBitmap bmp;
        private int r, g, b;
        private double rMin, rMax, iMin, iMax;
        private List<Color> Palette;
        private double zoom;

        public MainForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            zoom = 1;
            //moveX = 0;
            //moveY = 0;
            iterations = 300;
            height = pictureBoxMain.Height;
            width = pictureBoxMain.Width;
            r = 1;
            g = 1;
            b = 1;
            rMin = -2.5;
            rMax = 1.0;
            iMin = -1.0;
            iMax = 1.0;
            Palette = GenerateColorPalette();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxiMin.Text = iMin.ToString();
            textBoxiMax.Text = iMax.ToString();
            textBoxrMin.Text = rMin.ToString();
            textBoxrMax.Text = rMax.ToString();
            //textBoxIterations.Text = iterations.ToString();
            textBoxWidth.Text = width.ToString();
            textBoxHeight.Text = height.ToString();
            textBoxr.Text = r.ToString();
            textBoxg.Text = g.ToString();
            textBoxb.Text = b.ToString();
            textBoxZoom.Text = zoom.ToString();
            //textBoxMoveX.Text = moveX.ToString();
            //textBoxMoveY.Text = moveY.ToString();
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            //moveX += 0.02;
            //textBoxMoveX.Text = moveX.ToString();
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            //moveY += 0.02;
            //textBoxMoveY.Text = moveY.ToString();
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            //moveX += -0.02;
            //textBoxMoveX.Text = moveX.ToString();
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            //moveY += -0.02;
            //textBoxMoveY.Text = moveY.ToString();
        }

        private void textBoxcRe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            buttonDraw.Enabled = false;
            //c.Re = double.Parse(textBoxcRe.Text);
            //c.Im = double.Parse(textBoxcIm.Text);
            iMin = double.Parse(textBoxiMin.Text);
            iMax = double.Parse(textBoxiMax.Text);
            rMin = double.Parse(textBoxrMin.Text);
            rMax = double.Parse(textBoxrMax.Text);
            //iterations = int.Parse(textBoxIterations.Text);
            width = int.Parse(textBoxWidth.Text);
            height = int.Parse(textBoxHeight.Text);
            r = int.Parse(textBoxr.Text);
            g = int.Parse(textBoxg.Text);
            b = int.Parse(textBoxb.Text);
            Palette = GenerateColorPalette();
            zoom = double.Parse(textBoxZoom.Text);
            MandelbrotSetDraw();
            buttonDraw.Enabled = true;
        }

        private void MandelbrotSetDraw()
        {
            bmp = new FastBitmap(width, height);

            double rScale = (Math.Abs(rMin) + Math.Abs(rMax)) / width; // Amount to move each pixel in the real numbers
            double iScale = (Math.Abs(iMin) + Math.Abs(iMax)) / height; // Amount to move each pixel in the imaginary numbers
            Complex c = default(Complex), z = default(Complex);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    c = new Complex((x * rScale + rMin) * zoom, (y * iScale + iMin) * zoom); // Scaled complex number
                    z = c;
                    for (int i = 0; i < Palette.Count; i++) // 255 iterations with the method we already wrote
                    {
                        if (z.Magnitude >= 2.0)
                        {
                            bmp.SetPixel(x, y, Palette[i]); // Set the pixel if the magnitude is greater than two
                            break; // We're done with this loop
                        }
                        else
                        {
                            z = c + Complex.Pow(z, 2); // Z = Zlast^2 + C
                        }
                    }
                    
                }
            }
            pictureBoxMain.Image = bmp.Bitmap;
            bmp.Bitmap.Save("MandelbrotSet.jpg");
        }

        private List<Color> GenerateColorPalette()
        {
            List<Color> retVal = new List<Color>();
            for (int i = 0; i <= 255; i++)
            {
                retVal.Add(Color.FromArgb(255, (r * i) % 256, (g * i) % 256, (b * i) % 256));
            }
            return retVal;
        }
    }
}