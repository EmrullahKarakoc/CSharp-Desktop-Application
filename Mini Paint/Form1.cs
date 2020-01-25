using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B171210002_proje
{
    public partial class Form1 : Form
    {

        bool karebasildimi = false;
        bool dairebasildimi = false;
        bool ucgenbasildimi = false;
        bool altıgenbasildimi = false;
        bool cizimbasladimi = false;

        Graphics g;
        string renk = "[Red]";
        int x;
        int y;
        int width;
        int height;

        ArrayList liste = new ArrayList();

        Kare k1;
        Daire d1;
        Ucgen u1;
        Altıgen a1;

        int ksayisi = 0;
        int dsayisi = 0;
        int usayisi=0;
        int asayisi = 0;

        Kare[] kareler = new Kare[100];
        Daire[] daireler = new Daire[100];
        Ucgen[] ucgenler = new Ucgen[100];
        Altıgen[] altıgenler = new Altıgen[100];



        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            Paint += Sekilciz;
        }


        public Brush RenkAyristir(string renk)
        {
            Brush b;
            if (renk == "[Red]")
                b = new SolidBrush(Color.Red);
            else if (renk == "[Blue]")
                 b = new SolidBrush(Color.Blue);
            else if (renk == "[Green]")
                 b = new SolidBrush(Color.Green);
            else if (renk == "[Orange]")
                 b = new SolidBrush(Color.Orange);
            else if (renk == "[Black]")
                 b = new SolidBrush(Color.Black);
            else if (renk == "[Yellow]")
                 b = new SolidBrush(Color.Yellow);
            else if (renk == "[Purple]")
                 b = new SolidBrush(Color.Purple);
            else if (renk == "[Brown]")
                 b = new SolidBrush(Color.Brown);        
            else 
                b = new SolidBrush(Color.White);

            return b;
        }

        /****************************************************/
        private void btnKare_Click(object sender, EventArgs e)
        {
            karebasildimi = true;
            dairebasildimi = false;
            ucgenbasildimi = false;
            altıgenbasildimi = false;
        }

        private void btnDaire_Click(object sender, EventArgs e)
        {
            dairebasildimi = true;
            ucgenbasildimi = false;
            altıgenbasildimi = false;
            karebasildimi = false;
        }

        private void btnUcgen_Click(object sender, EventArgs e)
        {
            ucgenbasildimi = true;
            altıgenbasildimi = false;
            karebasildimi = false;
            dairebasildimi = false;
        }

        private void btnAltıgen_Click(object sender, EventArgs e)
        {
            altıgenbasildimi = true;
            karebasildimi = false;
            dairebasildimi = false;
            ucgenbasildimi = false;
        }
        /****************************************************/    
        private void btnkirmizi_Click(object sender, EventArgs e)
        {
            renk = "[Red]";
            renkbelirlemebutonu.BackColor = Color.Red;
        }

        private void btnmavi_Click(object sender, EventArgs e)
        {
            renk = "[Blue]";
            renkbelirlemebutonu.BackColor = Color.Blue;
        }

        private void btnyesil_Click(object sender, EventArgs e)
        {
            renk = "[Green]";
            renkbelirlemebutonu.BackColor = Color.Green;
        }

        private void btnturuncu_Click(object sender, EventArgs e)
        {
            renk = "[Orange]";
            renkbelirlemebutonu.BackColor = Color.Orange;
        }

        private void btnsiyah_Click(object sender, EventArgs e)
        {
            renk = "[Black]";
            renkbelirlemebutonu.BackColor = Color.Black;
        }

        private void btnsari_Click(object sender, EventArgs e)
        {
            renk = "[Yellow]";
            renkbelirlemebutonu.BackColor = Color.Yellow;
        }

        private void btnmor_Click(object sender, EventArgs e)
        {
            renk = "[Purple]";
            renkbelirlemebutonu.BackColor = Color.Purple;
        }

        private void btnkahverengi_Click(object sender, EventArgs e)
        {
            renk = "[Brown]";
            renkbelirlemebutonu.BackColor = Color.Brown;
        }

        private void btnbeyaz_Click(object sender, EventArgs e)
        {
            renk = "[White]";
            renkbelirlemebutonu.BackColor = Color.White;
        }
        /****************************************************/

        private void btnSec_Click(object sender, EventArgs e)
        {
            ucgenbasildimi = false;
            altıgenbasildimi = false;
            karebasildimi = false;
            dairebasildimi = false;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ucgenbasildimi = false;
            altıgenbasildimi = false;
            karebasildimi = false;
            dairebasildimi = false;
        }

        /****************************************************/

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            ucgenbasildimi = false;
            altıgenbasildimi = false;
            karebasildimi = false;
            dairebasildimi = false;

            SaveFileDialog Kaydet = new SaveFileDialog();
            Kaydet.Filter = "Metin Dosyası|*.txt";
            Kaydet.OverwritePrompt = true;

            if (Kaydet.ShowDialog() == DialogResult.OK)
            {
                StreamWriter kayittxtsi = new StreamWriter(Kaydet.FileName);
                foreach (var deger in liste)
                    kayittxtsi.WriteLine(deger);

                kayittxtsi.Close();
            }

        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            ucgenbasildimi = false;
            altıgenbasildimi = false;
            karebasildimi = false;
            dairebasildimi = false;

            OpenFileDialog Ac = new OpenFileDialog();
            Ac.Filter = "Metin Dosyası|*.txt";
            Ac.ShowDialog();
            string dosyayolu = Ac.FileName;

            FileStream fs = new FileStream(dosyayolu, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            string yazi = sw.ReadLine();
            string[] stringdizisi;

            while (yazi != null)
            {

                stringdizisi = yazi.Split(' ');


                if (stringdizisi[0] == "K")
                {
                    k1 = new Kare();
                    k1.Ciz(g, int.Parse(stringdizisi[1]), int.Parse(stringdizisi[2]), int.Parse(stringdizisi[3]), int.Parse(stringdizisi[4]), stringdizisi[6]);
                }

                else if (stringdizisi[0] == "D")
                {
                    d1 = new Daire();
                    d1.Ciz(g, int.Parse(stringdizisi[1]), int.Parse(stringdizisi[2]), int.Parse(stringdizisi[3]), int.Parse(stringdizisi[4]), stringdizisi[6]);
                }


                else if (stringdizisi[0] == "U")
                {
                    u1 = new Ucgen();
                    u1.Ciz(g, int.Parse(stringdizisi[1]), int.Parse(stringdizisi[2]), int.Parse(stringdizisi[3]), int.Parse(stringdizisi[4]), stringdizisi[6]);

                }


                else if (stringdizisi[0] == "A")
                {
                    a1 = new Altıgen();
                    a1.Ciz(g, int.Parse(stringdizisi[1]), int.Parse(stringdizisi[2]), int.Parse(stringdizisi[3]), int.Parse(stringdizisi[4]), stringdizisi[6]);

                }
                yazi = sw.ReadLine();

            }
            sw.Close();
            fs.Close();

        }

        /****************************************************/
        private void Sekilciz(object sender, PaintEventArgs e)
        {
            g = e.Graphics;

            if (karebasildimi == true)
            {
                k1 = new Kare();
                k1.Ciz(g, x, y, width, height, renk);
            }
            else if (dairebasildimi == true)
            {
                d1 = new Daire();
                d1.Ciz(g, x, y, width, height, renk);
            }
            else if (ucgenbasildimi == true)
            {
                u1 = new Ucgen();
                u1.Ciz(g, x, y, width + x, height + y, renk);
            }
            else if (altıgenbasildimi == true)
            {
                a1 = new Altıgen();
                a1.Ciz(g, x, y, width + x, height + y, renk);
            }

            //for (int i = 0; i < ksayisi; i++)
            //{
            //    kareler[i].Ciz(g, x, y, width, height, renk);
            //}

            //for (int i = 0; i < dsayisi; i++)
            //{
            //    daireler[i].Ciz(g, x, y, width, height, renk);
            //}

            //for (int i = 0; i < usayisi; i++)
            //{
            //    ucgenler[i].Ciz(g, x, y, width + x, height + y, renk);
            //}

            //for (int i = 0; i < ksayisi; i++)
            //{
            //    altıgenler[i].Ciz(g, x, y, width + x, height + y, renk);
            //}

        }
        /****************************************************/
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

            cizimbasladimi = true;
            x = e.X;
            y = e.Y;
            Invalidate();
            if (karebasildimi == true)
            {
                k1 = new Kare();
            }
            else if (dairebasildimi == true)
            {
                d1 = new Daire();
            }
            else if (ucgenbasildimi == true)
            {
                u1 = new Ucgen();
            }
            else if (altıgenbasildimi == true)
            {
                a1 = new Altıgen();
            }

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (cizimbasladimi)
            {
                width = e.X - x;
                height = e.Y - y;
                Invalidate();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            cizimbasladimi = false;
            if (karebasildimi == true)
            {
                liste.Add("K" + " " + k1.x + " " + k1.y + " " + k1.width + " " + k1.height + " " + renkbelirlemebutonu.BackColor);
                k1 = new Kare();
            }
            else if (dairebasildimi == true)
            {
                liste.Add("D" + " " + d1.x + " " + d1.y + " " + d1.width + " " + d1.height + " " + renkbelirlemebutonu.BackColor);
                d1 = new Daire();
            }
            else if (ucgenbasildimi == true)
            {
                liste.Add("U" + " " + x + " " + y + " " + (width + x) + " " + (y + height) + " " + renkbelirlemebutonu.BackColor);
                u1 = new Ucgen();
            }
            else if (altıgenbasildimi == true)
            {
                liste.Add("A" + " " + x + " " + y + " " + (width + x) + " " + (y + height) + " " + renkbelirlemebutonu.BackColor);
                a1 = new Altıgen();
            }

        }

    }
}
