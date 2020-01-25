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
    public partial class Control_MusteriSil : UserControl
    {
        public Control_MusteriSil()
        {
            InitializeComponent();
            GridYukle();
        }

        private void Btn_ControlMusteriSil_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-56EF49F;Initial Catalog=Kullanicilar;Integrated Security=True");
            SqlCommand komut = new SqlCommand();
            komut.Connection = connection;
            connection.Open();
            if (txt_ControlSilinecekTc.Text != "")
            {
                komut.CommandText = "DELETE FROM Musteriler WHERE MusteriTc = '" + txt_ControlSilinecekTc.Text + "'";
                int kosul = (int)komut.ExecuteNonQuery(); // eger komut deger dondururse 1 diger durumlarda 0 alıyor
                if(kosul == 1)
                {
                    MessageBox.Show(txt_ControlSilinecekTc.Text + " TC Numaralı Müşterimiz Başarılı Bir Şekilde Sistemden Silinmiştir..");
                    txt_ControlSilinecekTc.Text = "";
                }
                else
                    MessageBox.Show(txt_ControlSilinecekTc.Text + "TC Numaralı Müşterimiz Sistemde Bulunamamıştır...");
            }
            else
            MessageBox.Show("Lütfen Tüm Alanları Boş Bırakmadan Doldurunuz ... !");
            connection.Close();
            GridYukle();

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

        private void Control_MusteriSil_MouseMove(object sender, MouseEventArgs e)
        {
            GridYukle();
        }

        private void Txt_ControlSilinecekTc_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
