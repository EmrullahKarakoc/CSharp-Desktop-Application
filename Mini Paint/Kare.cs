using System.Drawing;
using System.Windows.Forms;

namespace B171210002_proje
{
    class Kare:Form1
    {
        public int x;
        public int y;
        public int width;
        public int height;
        public  Brush renk;
 
        public  void Ciz(Graphics g,int x, int y, int width, int height, string renk)
        {

            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.renk = RenkAyristir(renk);
            g.FillRectangle(this.renk, x, y, width, height);
        }


       
    }
}




