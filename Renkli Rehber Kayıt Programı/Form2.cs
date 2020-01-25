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
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            
        }

        public void btnGeri_Click(object sender, EventArgs e)
        {
            Form1 anasayfa = new Form1();
            anasayfa.Show();
            this.Hide();

        }


        public void btnKaydet_Click(object sender, EventArgs e)
        {
            string adrenk;
            string soyadrenk;
            string telrenk;

            ////////////////////////////////////
            if (rbAdk.Checked)
                adrenk = "K";
            else if (rbAdm.Checked)
                adrenk = "M";
            else  
                adrenk = "Y";
            ////////////////////////////////////
            if (rbSoyadk.Checked)
                soyadrenk = "K";
            else if (rbSoyadm.Checked)
                soyadrenk = "M";
            else
                soyadrenk = "Y";
            ////////////////////////////////////
            if (rbTelefonk.Checked)
                telrenk = "K";
            else if (rbTelefonm.Checked)
                telrenk = "M";
            else
                telrenk = "Y";
            ////////////////////////////////////

            

            if (txtAd.Text != "" && txtSoyad.Text != "" && txtTelefon.Text != "") 
            {

                StreamWriter yazmaislemi = File.AppendText("veriler.txt");
                yazmaislemi.WriteLine("{0}{1}{2} {3} {4} {5}", adrenk, soyadrenk, telrenk, txtAd.Text.ToUpper(), txtSoyad.Text.ToUpper(), txtTelefon.Text);
                yazmaislemi.Close();

                /* En baştaki haline döndürdüm */
                txtAd.Clear();
                txtSoyad.Clear();
                txtTelefon.Clear();
                rbSoyadk.Checked=true;
                rbAdk.Checked = true;
                rbTelefonk.Checked = true;
                MessageBox.Show("Kayıt Başarıyla Gerçekleşti");
            } 
            else
                MessageBox.Show(" *** LUTFEN BOS YERLERI DOLDURUNUZ *** ");
       

        }


        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)  // Ad kutusuna sadece harf girişi yapmak için
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }


        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)  // Soyad kutusuna sadece harf girişi yapmak için
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }


        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)  // Telefon kutusuna sadece rakam girişi yapmak için
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            txtTelefon.MaxLength = 11;
        }
    }
}
