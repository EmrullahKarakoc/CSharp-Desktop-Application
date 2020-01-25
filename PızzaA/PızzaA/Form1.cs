using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PızzaA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnekle_Click(object sender, EventArgs e)
        {
            if (txtNakit.Text !="" && txtPos.Text != "")
            {
                StreamWriter yazmaislemi = File.AppendText("veriler.txt");
                StreamWriter genelyazma = File.AppendText("genelveriler.txt");

                yazmaislemi.WriteLine(DateTime.Now.ToShortDateString() + "\t" + txtNakit.Text + "\t" + txtPos.Text);
                genelyazma.WriteLine(DateTime.Now.ToShortDateString() + "\t" + txtNakit.Text + "\t" + txtPos.Text);
                genelyazma.Close();
                yazmaislemi.Close();
                /* En baştaki haline döndürdüm */
                txtNakit.Clear();
                txtPos.Clear();
                MessageBox.Show("Kayıt Başarıyla Gerçekleşti");
            }
            else
                MessageBox.Show("Lütfen Boş Olan Kısımları Doldurunuz");


        }

        private void TxtNakit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void TxtPos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void BtnIstatıstık_Click(object sender, EventArgs e)
        {
            int nakittoplam = 0;
            int postoplam = 0;
            int geneltoplam = 0;

            FileStream okuma = new FileStream("veriler.txt", FileMode.Open, FileAccess.Read);
            StreamReader satırokuma = new StreamReader(okuma);
            string yazi = satırokuma.ReadLine();
            while (yazi != null)
            {
                string[] ayrilmisdizi = yazi.Split('\t');
                nakittoplam += Convert.ToInt32(ayrilmisdizi[1]);
                postoplam += Convert.ToInt32(ayrilmisdizi[2]);
                geneltoplam += Convert.ToInt32(ayrilmisdizi[1])+ Convert.ToInt32(ayrilmisdizi[2]);
                yazi = satırokuma.ReadLine();
            }
            satırokuma.Close();
            okuma.Close();
            MessageBox.Show("Şu Ana Kadar Ayın İstatistikleri\n" + "Nakit..:" + nakittoplam + "\nPos Makinesi..:" + postoplam + "\nGenel Toplam...:" + geneltoplam);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbltarih.Text = DateTime.Now.ToShortDateString();

            if(DateTime.Now.Day == 1)
            {
                int nakittoplam = 0;
                int postoplam = 0;
                int geneltoplam = 0;

                FileStream okuma = new FileStream("veriler.txt", FileMode.Open, FileAccess.Read);
                StreamReader satırokuma = new StreamReader(okuma);
                string yazi = satırokuma.ReadLine();
                while (yazi != null)
                {
                    string[] ayrilmisdizi = yazi.Split('\t');
                    nakittoplam += Convert.ToInt32(ayrilmisdizi[1]);
                    postoplam += Convert.ToInt32(ayrilmisdizi[2]);
                    geneltoplam += Convert.ToInt32(ayrilmisdizi[1]) + Convert.ToInt32(ayrilmisdizi[2]);
                    yazi = satırokuma.ReadLine();
                }
                satırokuma.Close();
                okuma.Close();
                MessageBox.Show("Geçen Ayın İstatistikleri\n"+"Nakit..:"+nakittoplam+"\nPos Makinesi..:"+postoplam+"\nGenel Toplam...:"+geneltoplam);
                TextWriter tw = new StreamWriter("veriler.txt");
                tw.Write("");
                tw.Close();
            }
        }
    }
}
