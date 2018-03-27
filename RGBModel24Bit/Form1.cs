using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGBModel24Bit
{
    public partial class Form1 : Form
    {
        private Bitmap f_image = null;  //input image
        public Bitmap image;
        public Bitmap hit;
        public Form1()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileImage = new OpenFileDialog();
            OpenFileImage.Filter = "bitmap (*.bmp)|*.bmp";
            OpenFileImage.FilterIndex = 1;
            if (OpenFileImage.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (f_image != null)
                        f_image.Dispose();
                    f_image = (Bitmap)Bitmap.FromFile(OpenFileImage.FileName, false);

                }
                catch (Exception)
                {
                    MessageBox.Show("Can not open file”, “File Error");
                }
            }
            image = new Bitmap(f_image.Width, f_image.Height);
            hit = f_image;
            PicInput.Image = f_image;
        }

        private void Histogram_Click(object sender, EventArgs e)
        {
            Hit a = new Hit(hit);
            a.Show();
        }

        private void Brightness_Click(object sender, EventArgs e)
        {
            int[] r = new int[f_image.Width* f_image.Height];
            int[] g = new int[f_image.Width * f_image.Height];
            int[] b = new int[f_image.Width * f_image.Height];
            double a;
            int s;
            double d = Convert.ToDouble(textBox1.Text);
            int y = 0;
            for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {

                    Color PixelColor = f_image.GetPixel(i, j);
                    int R = (int)(PixelColor.R);
                    int G = (int)(PixelColor.G);
                    int B = (int)(PixelColor.B);

                    if(d >= 0)
                    {
                        a = d / 100;
                        r[y] = (int)(R * a);
                        g[y] = (int)(G * a);
                        b[y] = (int)(B * a);
                    }
                    else
                    {
                        a = (d / 100) * -1;
                        r[y] = (int)(255 - R * a);
                        g[y] = (int)(255 - G * a);
                        b[y] = (int)(255 - B * a);
                    }                                       
                                                        
                    y++;
                }
            }
             y = 0;
            for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {
                    image.SetPixel(i, j, Color.FromArgb(r[y], g[y], b[y]));
                    y++;
                }
            }
            PicOutput.Image = image;
            hit = image;
        }

        private void Negative_Click(object sender, EventArgs e)
        {
            int[] r = new int[f_image.Width * f_image.Height];
            int[] g = new int[f_image.Width * f_image.Height];
            int[] b = new int[f_image.Width * f_image.Height];
            double a;
            int s;
            double d = Convert.ToDouble(textBox1.Text);
            int y = 0;
            for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {

                    Color PixelColor = f_image.GetPixel(i, j);
                    int R = (int)(PixelColor.R);
                    int G = (int)(PixelColor.G);
                    int B = (int)(PixelColor.B);

                    if (d >= 0)
                    {
                        a = d / 100;
                        r[y] = (int)(R * a + (255 - R));
                        g[y] = (int)(G * a + (255 - G));
                        b[y] = (int)(B * a + (255 - B));
                    }
                    else
                    {
                        a = (d / 100) * -1;
                        r[y] = (int)(255 - (R * a + (255 - R)));
                        g[y] = (int)(255 - (G * a + (255 - G)));
                        b[y] = (int)(255 - (B * a + (255 - B)));
                    }

                    y++;
                }
            }
            y = 0;
            for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {
                    image.SetPixel(i, j, Color.FromArgb(r[y], g[y], b[y]));
                    y++;
                }
            }
            PicOutput.Image = image;
            hit = image;
        }
    }
}
