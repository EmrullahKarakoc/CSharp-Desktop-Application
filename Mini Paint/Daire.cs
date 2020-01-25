using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B171210002_proje
{
    class Daire:Form1
    {
        public int x;
        public int y;
        public int width;
        public int height;
        public Brush renk;
 
        public  void Ciz(Graphics g, int x, int y, int width, int height, string renk)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.renk = RenkAyristir(renk);
            g.FillEllipse(this.renk, x, y, width, height);
        }

    }
}
