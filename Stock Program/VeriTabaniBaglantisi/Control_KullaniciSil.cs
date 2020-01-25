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
    public partial class Control_KullaniciSil : UserControl
    {
        public Control_KullaniciSil()
        {
            InitializeComponent();
            GridYukle();
        }
        private void Btn_kullanicisil_Click(object sender, EventArgs e)
        {
            if(txt_kullanicisilcontrol.Text != "")
            {
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-56EF49F;Initial Catalog=Kullanicilar;Integrated Security=True");
                SqlCommand komut = new SqlCommand();
                komut.Connection = connection;
                connection.Open();
                komut.CommandText = "DELETE FROM UsersTable WHERE Id = '"+txt_kullanicisilcontrol.Text+"'";
               int kosul = (int)komut.ExecuteNonQuery(); // eger komut deger dondururse 1 diger durumlarda 0 alıyor
                if(kosul == 1)
                {
                    MessageBox.Show(txt_kullanicisilcontrol.Text + " Kullanıcısı Başarılı Bir Şekilde Sistemden Silinmiştir..");
                    txt_kullanicisilcontrol.Text = "";
                }
                else
                    MessageBox.Show(txt_kullanicisilcontrol.Text + " Kullanıcısı Sistemde Bulunamamıştır...");
                connection.Close();
                GridYukle();
            }
            else
            MessageBox.Show("Lütfen Tüm Alanları Boş Bırakmadan Doldurunuz ... !");
        }
        public void GridYukle()
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-56EF49F;Initial Catalog=Kullanicilar;Integrated Security=True");
            connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM UsersTable", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Kullanıcı Id";
            dataGridView1.Columns[1].HeaderText = "Kullanıcı Adı";
            dataGridView1.Columns[2].HeaderText = "Kullanıcı Şifresi";
            dataGridView1.Columns[3].HeaderText = "Kullanıcı Rolü";
        }

        private void Control_KullaniciSil_MouseMove(object sender, MouseEventArgs e)
        {
            GridYukle();
        }
    }
}
