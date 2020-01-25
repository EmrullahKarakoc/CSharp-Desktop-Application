using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VeriTabaniBaglantisi
{
    public partial class Control_MusteriEkle : UserControl
    {
        public Control_MusteriEkle()
        {
            InitializeComponent();
            GridYukle();
        }


        private void Btn_ControlMusteriEkle_Click(object sender, EventArgs e)
        {
            if(txt_ControlMusteriAdi.Text != "" && txt_ControlMusteriSoyAdi.Text != "" && txt_ControlMusteriTC.Text != "" && txt_ControlMusteriAdres.Text != "" && txt_ControlMusteriTelefon.Text != "" && (rb_ControlMusteriErkek.Checked || rb_ControlMusteriKadin.Checked))
            {
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-56EF49F;Initial Catalog=Kullanicilar;Integrated Security=True");
                SqlCommand komut = new SqlCommand();
                SqlCommand komut2 = new SqlCommand();
                komut.Connection = connection;
                komut2.Connection = connection;
                connection.Open();
                komut2.CommandText = "SELECT * FROM Musteriler WHERE MusteriTc='" + Convert.ToInt64(txt_ControlMusteriTC.Text) + "'";
                int kosulumuz = (int)komut2.ExecuteNonQuery();
                if (kosulumuz == 1)      // Daha Once Bu Koda Sahip Bir Urun Varsa Güncelleme Yapmak İcin Once Olup Olmadıgının Kontrol Etttim    
                {
                    komut.CommandText = "UPDATE Musteriler SET MusteriAdres='" + txt_ControlMusteriAdres.Text + "', MusteriTelefon='" + txt_ControlMusteriTelefon.Text + "' WHERE MusteriTc='" + txt_ControlMusteriTC.Text + "'";
                    komut.ExecuteNonQuery();
                    MessageBox.Show(txt_ControlMusteriAdi.Text + " İsimli Musterimiz Başarılı Bir Şekilde Sistemde Güncellenmiştir ..");
                }
                else
                {
                    if(rb_ControlMusteriErkek.Checked)
                    {
                        komut.CommandText = "INSERT INTO Musteriler (MusteriAd, MusteriSoyad, MusteriTc,MusteriAdres,MusteriTelefon,MusteriCinsiyet) VALUES ('" + txt_ControlMusteriAdi.Text + "','" + txt_ControlMusteriSoyAdi.Text + "','" + txt_ControlMusteriTC.Text + "','" + txt_ControlMusteriAdres.Text + "','" + txt_ControlMusteriTelefon.Text + "', 'ERKEK')";
                        komut.ExecuteNonQuery();
                    }
                    else if(rb_ControlMusteriKadin.Checked)
                    {
                        komut.CommandText = "INSERT INTO Musteriler (MusteriAd, MusteriSoyad, MusteriTc,MusteriAdres,MusteriTelefon,MusteriCinsiyet) VALUES ('" + txt_ControlMusteriAdi.Text + "','" + txt_ControlMusteriSoyAdi.Text + "','" + txt_ControlMusteriTC.Text + "','" + txt_ControlMusteriAdres.Text + "','" + txt_ControlMusteriTelefon.Text + "', 'KADIN')";
                        komut.ExecuteNonQuery();
                    }

                    MessageBox.Show(txt_ControlMusteriAdi.Text + " İsimli Müsteri Başarılı Bir Şekilde Sisteme Eklenmiştir ..");
                }

                connection.Close();


            }
            else
                MessageBox.Show("Lütfen Tüm Alanları Boş Bırakmadan Doldurunuz ... !");
        }

        public void GridYukle()
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-56EF49F;Initial Catalog=Kullanicilar;Integrated Security=True");
            connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Musteriler", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "AD";
            dataGridView1.Columns[2].HeaderText = "SOYAD";
            dataGridView1.Columns[3].HeaderText = "ADRES";
            dataGridView1.Columns[4].HeaderText = "CİNSİYET";
            dataGridView1.Columns[5].HeaderText = "TC";
            dataGridView1.Columns[6].HeaderText = "TELEFON";

        }

        private void Txt_ControlMusteriTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Control_MusteriEkle_MouseMove(object sender, MouseEventArgs e)
        {
            GridYukle();
        }
    }
}
