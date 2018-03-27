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
    public partial class Hit : Form
    {
        private Bitmap f_image;
        public Hit(Bitmap a)
        {
            f_image = a;
            InitializeComponent();
        }
        private void Hit_Load(object sender, EventArgs e)
        {
            OriginalR();            
            OriginalG();
            OriginalB();
        }
        public void OriginalR()
        {
            int[] arrCo = new int[255];
            int[] arrNco = new int[255];

            for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {

                    Color PixelColor = f_image.GetPixel(i, j);
                    int C_gray = (int)(PixelColor.R);
                    if (C_gray >= 254)
                        C_gray = 254;
                    arrCo[C_gray] += 1;

                }
            }
            for (int i = 0; i < arrCo.Length; i++)
            {
                this.R.Series["R"].Points.AddXY(i, arrCo[i]);
            }

        }
        public void OriginalG()
        {
            int[] arrCo = new int[255];
            int[] arrNco = new int[255];

            for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {

                    Color PixelColor = f_image.GetPixel(i, j);
                    int C_gray = (int)(PixelColor.G);
                    if (C_gray >= 254)
                        C_gray = 254;
                    arrCo[C_gray] += 1;

                }
            }
            for (int i = 0; i < arrCo.Length; i++)
            {
                this.G.Series["G"].Points.AddXY(i, arrCo[i]);
            }

        }
        public void OriginalB()
        {
            int[] arrCo = new int[255];
            int[] arrNco = new int[255];

            for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {

                    Color PixelColor = f_image.GetPixel(i, j);
                    int C_gray = (int)(PixelColor.B);
                    if (C_gray >= 254)
                        C_gray = 254;
                    arrCo[C_gray] += 1;

                }
            }
            for (int i = 0; i < arrCo.Length; i++)
            {
                this.B.Series["B"].Points.AddXY(i, arrCo[i]);
            }

        }
    }
}
