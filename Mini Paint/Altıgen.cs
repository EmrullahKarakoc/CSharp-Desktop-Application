using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B171210002_proje
{
    class Altıgen:Form1
    {

        public Point[] dizi = new Point[6];
        public Brush renk;
 
        public  void Ciz(Graphics g, int x1, int y1, int x2, int y2, string renk)
        {
            dizi[0] = new Point(x1, y1);
            dizi[1] = new Point(x1 + (x2 - x1), y1);
            dizi[2] = new Point((x2 + ((x2 - x1) / 2)), (y1 + y2) / 2);
            dizi[3] = new Point(x2, y2);
            dizi[4] = new Point(x1, y2);
            dizi[5] = new Point(x1 - ((x2 - x1) / 2), ((y1 + y2) / 2));
            this.renk = RenkAyristir(renk);
            g.FillPolygon(this.renk, dizi);
        }


    }
}
