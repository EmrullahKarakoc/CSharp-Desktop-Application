using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace B171210002
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            rtxtlistelenmis.Clear();
            btnlistele.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form1 anasayfa = new Form1();
            anasayfa.Show();
            this.Hide();
        }


        public void btnlistele_Click(object sender, EventArgs e)
        {

            FileStream okuma = new FileStream("veriler.txt", FileMode.Open, FileAccess.Read);
            StreamReader satırokuma = new StreamReader(okuma);
            string yazi = satırokuma.ReadLine();
            int sayac = 2;

            while (yazi != null)
            {
                    
                string[] ayrilmisdizi = yazi.Split(' ');

                /***** Tek Tek ad soyad ve telefon numaralarını yazdırdım  ******/
                for (int i = 0; i < 3; i++)
                {
                   
                    if (ayrilmisdizi[0].Substring(i, 1) == "K")
                    {
                        if (sayac % 2 == 0)
                            rtxtlistelenmis.SelectionFont = new Font("Arial", 12, FontStyle.Bold);
                        else
                            rtxtlistelenmis.SelectionFont = new Font("Arial", 12, FontStyle.Regular);

                        rtxtlistelenmis.SelectionColor = Color.Red;
                        rtxtlistelenmis.AppendText(ayrilmisdizi[i + 1]);

                        this.Refresh();

                    }
                    else if (ayrilmisdizi[0].Substring(i, 1) == "M")
                    {
                        if (sayac % 2 == 0)
                            rtxtlistelenmis.SelectionFont = new Font("Arial", 12, FontStyle.Bold);
                        else
                            rtxtlistelenmis.SelectionFont = new Font("Arial", 12, FontStyle.Regular);

                        rtxtlistelenmis.SelectionColor = Color.Blue;
                        rtxtlistelenmis.AppendText(ayrilmisdizi[i + 1]);

                        this.Refresh();

                    }
                    else if (ayrilmisdizi[0].Substring(i, 1) == "Y")
                    {

                        if (sayac % 2 == 0)
                            rtxtlistelenmis.SelectionFont = new Font("Arial", 12, FontStyle.Bold);
                        else
                            rtxtlistelenmis.SelectionFont = new Font("Arial", 12, FontStyle.Regular);
                        rtxtlistelenmis.SelectionColor = Color.Green;
                        rtxtlistelenmis.AppendText(ayrilmisdizi[i + 1]);

                        this.Refresh();

                    }

                    rtxtlistelenmis.AppendText(" ");

                }

                sayac++;
                rtxtlistelenmis.AppendText("\n\n");
                yazi = satırokuma.ReadLine();
            }

            satırokuma.Close();
            okuma.Close();
            btnlistele.Hide();

        }


    }
}