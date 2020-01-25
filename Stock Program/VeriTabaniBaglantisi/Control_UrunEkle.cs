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
    public partial class Control_UrunEkle : UserControl
    {
        public Control_UrunEkle()
        {
            InitializeComponent();
            GridYukle();
        }

        private void Txt_controlurunadedi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Btn_ControlUrunuEkle_Click(object sender, EventArgs e)
        {
            if(txt_controlurunkodu.Text != "" && txt_controlurunısmı.Text != "" && txt_controlurunadedi.Text != "" && txt_urunkategorisi.Text != "")
            {
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-56EF49F;Initial Catalog=Kullanicilar;Integrated Security=True");
                SqlCommand komut = new SqlCommand();
                SqlCommand komut2 = new SqlCommand();
                komut.Connection = connection;
                komut2.Connection = connection;
                connection.Open();
                komut2.CommandText = "SELECT * FROM Urunler WHERE UrunKodu='"+txt_controlurunkodu.Text+"'";
                int kosulumuz = (int)komut2.ExecuteNonQuery();
                if(kosulumuz == 1)      // Daha Once Bu Koda Sahip Bir Urun Varsa Güncelleme Yapmak İcin Once Olup Olmadıgının Kontrol Etttim    
                {
                    komut.CommandText = "UPDATE Urunler SET UrunKodu='"+ txt_controlurunkodu.Text + "', UrunIsmi='" + txt_controlurunkodu.Text + "', UrunAdedi='"+ Int32.Parse(txt_controlurunadedi.Text) + "',UrunKategorisi='"+ txt_urunkategorisi.Text + " WHERE UrunKodu='" + txt_controlurunkodu.Text + "'";
                    komut.ExecuteNonQuery();
                    MessageBox.Show(txt_controlurunısmı.Text + " İsimli Ürün Başarılı Bir Şekilde Sistemde Güncellenmiştir ..");
                }
                else
                {
                    komut.CommandText = "INSERT INTO Urunler (UrunKodu, UrunIsmi, UrunAdedi,UrunKategorisi) VALUES ('" + txt_controlurunkodu.Text + "','" + txt_controlurunısmı.Text + "','" + Int32.Parse(txt_controlurunadedi.Text) + "','" + txt_urunkategorisi.Text + "')";
                    komut.ExecuteNonQuery();
                    MessageBox.Show(txt_controlurunısmı.Text + " İsimli Ürün Başarılı Bir Şekilde Sisteme Eklenmiştir ..");
                }
                txt_controlurunkodu.Text = "";
                txt_controlurunısmı.Text = "";
                txt_urunkategorisi.Text = "";
                txt_controlurunadedi.Text = "";

                connection.Close();
            }
            else
                MessageBox.Show("Lütfen Tüm Alanları Boş Bırakmadan Doldurunuz ... !");

        }

        public void GridYukle()
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-56EF49F;Initial Catalog=Kullanicilar;Integrated Security=True");
            connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Urunler", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Ürün Kodu";
            dataGridView1.Columns[1].HeaderText = "Ürün Adı";
            dataGridView1.Columns[2].HeaderText = "Ürün Adedi";
            dataGridView1.Columns[3].HeaderText = "Ürün Kategorisi";
        }

        private void Control_UrunEkle_MouseMove(object sender, MouseEventArgs e)
        {
            GridYukle();
        }
    }
}
