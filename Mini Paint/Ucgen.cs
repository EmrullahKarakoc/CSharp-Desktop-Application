using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B171210002_proje
{
    class Ucgen:Form1
    {
        public Point[] dizi = new Point[3];
        public Brush renk;
        public int h;
 
        public  void Ciz(Graphics g, int x1, int y1, int x2, int y2, string renk)
        {
            h = y2 - y1;
            dizi[0] = new Point(x1, y1);
            dizi[1] = new Point(x1 + (h / 2), y2);
            dizi[2] = new Point(x1 - (h / 2), y2);
            this.renk = RenkAyristir(renk);
            g.FillPolygon(this.renk, dizi);
        }
    }
}
