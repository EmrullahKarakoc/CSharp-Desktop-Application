using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.UI;
using Emgu.Util;
using Emgu.CV.Structure;

namespace B171210002_1.odev
{
    public partial class Form1 : Form
    {
        OpenFileDialog yüklemekismi = new OpenFileDialog();
        Image<Bgr, byte> renkli;
        Image<Gray, byte> gri;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            /*******************   Fotograf ekleme   *****************************/

            yüklemekismi.Filter = "Resim Dosyası |*jpg| Resim Dosyası|*.jpeg| Resim Dosyası|*.jpe| Resim Dosyası|*.gif";
            yüklemekismi.FilterIndex = 1;
            yüklemekismi.ShowDialog();
            renkli = new Image<Bgr, byte>(yüklemekismi.FileName);
            pbRenkli.Image = renkli;

            /***************  Gri'ye cevirme  ***************************************************/

            gri = renkli.Convert<Gray, byte>();
            pbGri.Image = gri;

            /**********************  Histogram olusturma ***************************************************/


            DenseHistogram grihistogrami = new DenseHistogram(256, new RangeF(0, 256));
            grihistogrami.Calculate(new Image<Gray, byte>[] { gri }, false, null);
            Mat m = new Mat();
            grihistogrami.CopyTo(m);
            hbHistogram.ClearHistogram();
            hbHistogram.AddHistogram("Gray Histograms", Color.Gray, m, 256, new float[] { 0, 255 });
            hbHistogram.Refresh();


            /***********************  Binary'ye cevirme  **************************************************/

            Image<Gray, byte> binaryfoto = gri.ThresholdBinary(new Gray(70),new Gray(255));
            pbBinary.Image = binaryfoto; 


            
        }
    }
}
